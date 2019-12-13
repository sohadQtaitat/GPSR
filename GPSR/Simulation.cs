using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSR
{
    public class Simulation
    {
        public int NodeCount { get; set; }
        public int DeadNodesCount { get; set; }
        public bool LiveIterationMinCount { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public float SimulationTime { get; set; }
        public List<Node> Nodes { get; set; }
        public float NodeRange { get; set; }
        public PointF MaxNodeSpeed { get; set; }
        public PointF MinNodeSpeed { get; set; }
        public float BeaconInterval { get; set; } //multiples of DeltaT
        public float DeltaT { get; set; }
        public int Iterations { get; set; }
        public float SimulationEndTime { get; private set; }
        public List<Packet> DroppedPackets { get; set; }
        public List<Packet> Packets { get; set; }
        public List<Packet> RecievedPackets { get; set; }
        public List<BeaconPacket> BeaconPackets { get; set; }
        public Random Random { get; set; }
        public double SentBeaconsCount { get; set; }
        public double RecivedBeaconsCount { get; set; }
        public Graphics g { get; set; }
        public string ResultSummery { get; set; }

        public float Energy { get; set; }//Initial Energy
        public float TotalEnergyConsumtion { get; set; } //Amount of energy consumed.
        public float TransmisionConsumption { get; set; } //Amount of energy consumed to transmit a packet
        public float ReceptionConsumption { get; set; }  //Amount of energy consumed to receive a packet
        public float IdleConsumption { get; set; } //Amount of energy consumed while idle in a simulation tick 
      
        public bool IsInfiniteEnergy { get; set; }


        private static Simulation Instance;
        public static Simulation GetInstance()
        {
            if(Simulation.Instance == null)
            {
                Instance = new GPSR.Simulation();
            }
            return Instance;
        }

        public Simulation()
        {
            Random = new Random(DateTime.Now.Millisecond);
            DroppedPackets = new List<Packet>();
            Packets = new List<Packet>();
            RecievedPackets = new List<Packet>();
            BeaconPackets = new List<BeaconPacket>();
            SentBeaconsCount = 0;
            RecivedBeaconsCount = 0;
        }
        public void SetTimeParameters()
        {
            DeltaT = 0.001f;
            BeaconInterval = DeltaT * 10.0f;
            SimulationEndTime = Iterations * DeltaT;
            SimulationTime = 0;
        }

        public void InitilizeSimulation()
        {            
            Node.Simulation = this;
            Packet.Simulation = this;
            Edge.Simulation = this;
            Nodes = new List<Node>();

            for (int i = 0; i < NodeCount; i++)
            {
                Node node = new Node() { Id = i, Range = NodeRange };
                float x = (float)Random.NextDouble() * Width;
                float y = (float)Random.NextDouble() * Height;
                float xSpeed = (float)(Random.NextDouble() * (MaxNodeSpeed.X - MinNodeSpeed.X) + MinNodeSpeed.X);
                float ySpeed = (float)(Random.NextDouble() * (MaxNodeSpeed.Y - MinNodeSpeed.Y) + MinNodeSpeed.Y);
                //Random direction
                xSpeed = Random.NextDouble() < 0.5 ? -xSpeed : xSpeed;
                ySpeed = Random.NextDouble() < 0.5 ? -xSpeed : ySpeed;
                node.Location = new PointF(x, y);
                node.Speed = new PointF(xSpeed, ySpeed);
                node.BeaconInterval = (float)(0.5 + Random.NextDouble() )*( BeaconInterval);
                node.Energy = Energy;
                node.TransmisionConsumption = TransmisionConsumption;
                node.ReceptionConsumption = ReceptionConsumption;
                node.IdleConsumption = IdleConsumption;
                node.IsInfiniteEnergy = IsInfiniteEnergy;
                Nodes.Add(node);
            }
           

        }
        public void Simulate()
        {
            for (int i = 0; i < Iterations; i++)
            {
                SentBeaconsCount += BeaconPackets.Count();
                BeaconPackets.Clear();
                foreach (Node node in Nodes)
                {
                    node.Iterate();
                }
                drawSimulation();                
                SimulationTime += DeltaT;
                DeadNodesCount = Nodes.Count(n => n.IsDead);
                bool areAllNodesDead = DeadNodesCount == NodeCount;
                if (areAllNodesDead) break;
            }
            TotalEnergyConsumtion = Nodes.Sum(n => n.EnergyConsumtion);
            StringBuilder sb = new StringBuilder(ResultSummery);
            sb.AppendLine();
            sb.AppendFormat("Total Energy Consumtion {0} ", TotalEnergyConsumtion);
            ResultSummery = sb.ToString();

        }
        float scaleX = -1;
        float scaleY = -1;

        public Bitmap drawSimulation()
        {
            if (g == null) return null;
            if (scaleX == -1) {
                scaleX = ((float)g.VisibleClipBounds.Width) / Width ;
                scaleY = ((float)g.VisibleClipBounds.Height) / Height;
            }
            PointF scale = new PointF(scaleX, scaleY);
            //Bitmap b = new Bitmap(1000, (int)(Height*scale));
            Bitmap b = new Bitmap(1000, 1000);
            g = g == null ? Graphics.FromImage(b) : g;
            
            g.Clear(Color.Pink);
            float size = 5f ;
            Font font = new Font("Tahoma",5*scale.X,GraphicsUnit.World);
            Font font2 = new Font("Tahoma", 3 * scale.X, GraphicsUnit.World);
            StringBuilder sb = new StringBuilder();
            
            string info = string.Format("Nodes Alive {0}/{1},Packets: Sent({2}), Received({3}),Dropped({4}),PDR {5}% ",
                NodeCount- DeadNodesCount , NodeCount, Packets.Count(), RecievedPackets.Count(),
                DroppedPackets.Count() ,((float)DroppedPackets.Count()*100)/Packets.Count());
            g.DrawString(info, font, Brushes.Black, 1* scale.X , 1 * scale.Y , StringFormat.GenericDefault);
            sb.AppendLine(info);
            info = string.Format("Beacons Broadcast({0}) and received {1} times", SentBeaconsCount, RecivedBeaconsCount);
            sb.AppendLine(info);
            g.DrawString(info, font, Brushes.Black, 1 * scale.X, 15 * scale.Y, StringFormat.GenericDefault);
            if (RecievedPackets.Count() > 0)
            {
                float E_E_delay = RecievedPackets.Select(p => p.RecivedTime - p.SentTime).Average();
                double hopCount = RecievedPackets.Select(p => p.Hubes.Count()).Average();
                info = string.Format("E-E Delay:({0}),Average hub Count {1})", E_E_delay, hopCount);
                sb.AppendLine(info);
                g.DrawString(info, font, Brushes.Black, 1 * scale.X, 30* scale.Y , StringFormat.GenericDefault);
            }
            ResultSummery = sb.ToString();
            
            
            foreach (Node node in Nodes)
            {
                var speed = Math.Round( Math.Sqrt(Math.Pow(node.Speed.X,2) + Math.Pow(node.Speed.Y, 2)),2);
                if(node.IsDead)
                {
                    speed = 0;
                    g.FillRectangle(Brushes.Red, new RectangleF(node.Location.Scale(scale), new SizeF(size, size)));
                    g.DrawString(node.Id.ToString(), font, Brushes.Red, node.Location.X * scale.X + 2 * scale.Y, node.Location.Y * scale.Y - 2 * scale.Y, StringFormat.GenericDefault);
                    g.DrawString(speed.ToString(), font2, Brushes.Red, node.Location.X * scale.X - 2 * scale.Y, node.Location.Y * scale.Y + 2 * scale.Y, StringFormat.GenericDefault);                    

                }
                else
                {
                    g.FillRectangle(Brushes.Yellow, new RectangleF(node.Location.Scale(scale), new SizeF(size, size)));
                    g.DrawString(node.Id.ToString(), font, Brushes.Black, node.Location.X * scale.X + 2 * scale.Y, node.Location.Y * scale.Y - 2 * scale.Y, StringFormat.GenericDefault);
                    g.DrawString(speed.ToString(), font2, Brushes.Yellow, node.Location.X * scale.X - 2 * scale.Y, node.Location.Y * scale.Y + 2 * scale.Y, StringFormat.GenericDefault);
                    g.DrawString(node.Energy.ToString("0.0000"), font2, Brushes.Red, node.Location.X * scale.X - 6 * scale.Y, node.Location.Y * scale.Y + 6 * scale.Y, StringFormat.GenericDefault);

                }


                foreach (Node ne in node.RNGNeighbors)
                {
                    g.DrawLine(Pens.Yellow, node.Location.Scale(scale), ne.Location.Scale(scale));
                    
                }
                
            }
            foreach (BeaconPacket bp in BeaconPackets)
            {
                var node = bp.Sender;
                RectangleF boundingRectf = new RectangleF(node.Location, new SizeF(node.Range, node.Range));
                boundingRectf.Offset(-node.Range / 2, -node.Range / 2);
                g.DrawEllipse(Pens.YellowGreen, boundingRectf.Scale(scale));
            }
            Pen pen = new Pen(Brushes.Black, 2.5f);
            foreach (Packet p in RecievedPackets.Where(p=>p.SentTime == SimulationTime))
            {
                if (p.Hubes.Count > 0)
                {
                    for (int i = 0; i < p.Hubes.Count - 1; i++)
                    {
                        g.DrawLine(pen, p.Hubes[i].Location.Scale(scale), p.Hubes[i + 1].Location.Scale(scale));
                    }
                } 
            }

            pen.Dispose();
            return b;
        }
        public Bitmap drawSimulationPacket(Packet p)
        {
            float time = p.SentTime;
            if (g == null) return null;
            if (scaleX == -1)
            {
                scaleX = ((float)g.VisibleClipBounds.Width) / Width;
                scaleY = ((float)g.VisibleClipBounds.Height) / Height;
            }
            PointF scale = new PointF(scaleX, scaleY);
            //Bitmap b = new Bitmap(1000, (int)(Height*scale));
            Bitmap b = new Bitmap(1000, 1000, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
           
            g = g == null ? Graphics.FromImage(b) : g;

            //g.FillRectangle(Brushes.Blue, new Rectangle(0,0,b.Width, b.Height));
            g.Clear(Color.Gray);
            float size = 5f;
            Font font = new Font("Tahoma", 5 * scale.X, GraphicsUnit.World);
            string info = string.Format("Packet: Sent Time({0}), Received Time({1}), Status({2})",
             p.SentTime, p.RecivedTime, p.Status.ToString());
            g.DrawString(info, font, Brushes.Black, 1 * scale.X, 1 * scale.Y, StringFormat.GenericDefault);
            var nodeLogs = Nodes.Select(n => n.Log).ToList();

            foreach (NodeLog nodeLog in nodeLogs)
            {
                int index = nodeLog.Time.FindIndex(t => t == time);
                var loc = nodeLog.Location[index];
                g.FillRectangle(Brushes.Yellow, new RectangleF(loc.Scale(scale), new SizeF(size, size)));
                g.DrawString(nodeLog.Node.Id.ToString(), font, Brushes.Black, loc.X * scale.X + 2 * scale.Y, loc.Y * scale.Y - 2 * scale.Y, StringFormat.GenericDefault);
                //foreach (Node ne in node.RNGNeighbors)
                //{
                //    g.DrawLine(Pens.Yellow, node.Location.Scale(scale), ne.Location.Scale(scale));

                //}

            }
            //foreach (BeaconPacket bp in BeaconPackets)
            //{
            //    var node = bp.Sender;
            //    RectangleF boundingRectf = new RectangleF(node.Location, new SizeF(node.Range, node.Range));
            //    boundingRectf.Offset(-node.Range / 2, -node.Range / 2);
            //    g.DrawEllipse(Pens.YellowGreen, boundingRectf.Scale(scale));
            //}
            Pen pen = new Pen(Brushes.Black, 2.5f);
           
                if (p.Hubes.Count > 0)
                {
                    for (int i = 0; i < p.Hubes.Count - 1; i++)
                    {
                    var nodeLog1 = p.Hubes[i].Log;
                    int index1 = nodeLog1.Time.FindIndex(t => t == time);
                    var loc1 = nodeLog1.Location[index1];
                    var nodeLog2 = p.Hubes[i+1].Log;
                    int index2 = nodeLog2.Time.FindIndex(t => t == time);
                    var loc2 = nodeLog2.Location[index1];


                    g.DrawLine(pen, loc1.Scale(scale), loc2.Scale(scale));
                    }
                }
            

            pen.Dispose();
            return b;
        }

    }
}
