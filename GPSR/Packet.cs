using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSR
{
    public class Packet
    {
        
        public Node Source { get; set; }
        public Node Destination { get; set; }
        private Node _currentNode;
        public PacketState Status { get; set; }
        public float SentTime { get; set; }
        public float RecivedTime { get; set; }
        public bool HasUsedPerimeter { get; set; }
        public Node CurrentNode
        {
            get { return _currentNode; }
            set
            {               
                _currentNode = value;                
                Hubes.Add(_currentNode);
            }
        }
        
        
        private GPSRMode _Mode;
        public GPSRMode Mode
        {
            get { return _Mode; }
            set
            {                
                    _Mode = value;
                if (_Mode == GPSRMode.Perimeter)
                    HasUsedPerimeter = true;                 
                
            }
        }
        public Node Lp { get; set; } //Location Packet Entered Perimeter Mode
        public Node Lf { get; set; } //Point on xV Packet Entered Current Face
        public Edge E0 { get; set; } //First Edge Traversed on Current Face
        public List<GPSRMode> Modes = new List<GPSRMode>();
        public List<Node> Hubes = new List<Node>();
        public static Simulation Simulation;
        private static  Random random = new Random(DateTime.Now.Millisecond);
        public Packet()
        {
            Mode = GPSRMode.Greedy;
            Status = PacketState.Bending;
            SentTime = Simulation.SimulationTime;
            
        }
        public Bitmap DrawPacketPath(Bitmap b)
        {

            float scale = 1000f / Simulation.Width;
            float w = 15f * scale;
            Graphics g = Graphics.FromImage(b);
            RectangleF boundingRect = new RectangleF( Source.Location,new SizeF(w,w));
            boundingRect.Offset(-w/2,-w/2);
            g.DrawEllipse(Pens.Black, boundingRect.Scale(scale));

            boundingRect = new RectangleF(Destination.Location, new SizeF(w, w));
            boundingRect.Offset(-w / 2, -w / 2);
            g.DrawEllipse(Pens.Green, boundingRect.Scale(scale));
            if (Hubes.Count > 0)
            {
                for (int i = 0; i < this.Hubes.Count-1; i++)
                {
                    g.DrawLine(Pens.White, Hubes[i].Location.Scale(scale), Hubes[i + 1].Location.Scale(scale));
                }
            }
            g.Dispose();
            return b;
        }
        public void DrawPacketPath(Graphics g,Bitmap img)
        {
            g.DrawImage(img, new Point(0, 0));
            float scale = 1000f / Simulation.Width;
            float w = 15f * scale;            
            RectangleF boundingRect = new RectangleF(Source.Location, new SizeF(w, w));
            boundingRect.Offset(-w / 2, -w / 2);
            g.DrawEllipse(Pens.Black, boundingRect.Scale(scale));

            boundingRect = new RectangleF(Destination.Location, new SizeF(w, w));
            boundingRect.Offset(-w / 2, -w / 2);
            g.DrawEllipse(Pens.Green, boundingRect.Scale(scale));
            if (Hubes.Count > 0)
            {
                for (int i = 0; i < this.Hubes.Count - 1; i++)
                {
                    g.DrawLine(Pens.White, Hubes[i].Location.Scale(scale), Hubes[i + 1].Location.Scale(scale));
                }
            }           
            
        }
        public static Packet CreateRandomPacket(int sourceNodeId=-1)
        {
            
            int source =sourceNodeId==-1? random.Next(0, Simulation.NodeCount):sourceNodeId;
            int dest = random.Next(0, Simulation.NodeCount);
            while (source == dest)
            {
                dest = random.Next(0, Simulation.NodeCount);
            }
            Packet p = new Packet();
            p.Source = Simulation.Nodes[source];
            p.Destination = Simulation.Nodes[dest];
            
            p.CurrentNode = p.Source;
            return p;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Status.ToString());
            sb.AppendFormat("  Source: {0},Destination {1}", Source.Id, Destination.Id);
            sb.Append(Environment.NewLine);
            sb.AppendLine("Path:");
            foreach (Node n in Hubes)
            {
                sb.Append(n.Id);
                sb.Append(" ,");
                
            }
            sb.Append(Environment.NewLine);
            sb.AppendLine("Modes:");
            foreach (GPSRMode m in Modes)
            {
                sb.Append(m.ToString());
                sb.Append(" ,");

            }
            sb.Remove(sb.Length - 2, 1);
            return  sb.ToString();
            
            
        }

    }
    public enum GPSRMode
    {
        Greedy,
        Perimeter

    }
    public enum PacketState
    {
        Bending,
        Recived,
        Dropped,
        
    }
}
