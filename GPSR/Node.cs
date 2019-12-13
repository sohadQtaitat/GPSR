using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSR
{
    public class Node
    {
        public int Id { get; set; }
        public PointF Location { get; set; }
        public List<Node> Neighbors { get; set; }
        public List<BeaconPacket> RecivedBeaconPackets { get; set; }
        public List<Node> PlanerNeighbors { get { return RNGNeighbors; } }
        public List<Node> RNGNeighbors { get; set; }
        public List<Node> GGNeighbors { get; set; }
        public float Range { get; set; }
        public PointF Speed { get; set; }
        public float BeaconInterval { get; set; }
        public float LastBeaconSendTime { get; set; }
        public static Simulation Simulation;
        public NodeLog Log { get; set; }
        private float energy;
        public float Energy { get {return energy; } set {energy = value<0?0:value; } }
        public float EnergyConsumtion { get; set; } //Amount of energy consumed by this node
        public float TransmisionConsumption { get; set; } //Amount of energy consumed to transmit a packet
        public float ReceptionConsumption { get; set; }  //Amount of energy consumed to receive a packet
        public float IdleConsumption { get; set; } //Amount of energy consumed while idle in a simulation tick 
        public bool IsDead { get { return IsInfiniteEnergy? false: Energy <= 0; } }
        public bool IsInfiniteEnergy { get; set; }
        
        public Node()
        {
            Neighbors = new List<Node>();
            GGNeighbors = new List<Node>();
            RNGNeighbors = new List<Node>();
            RecivedBeaconPackets = new List<BeaconPacket>();
            Log = new GPSR.NodeLog(this);

        }
        private void consumeEnergy(EnergyConsumtionType consumptionType,float custumConsumtion = 0)
        {
            float tempEnergy = Energy;
            switch (consumptionType)
            {
                case EnergyConsumtionType.Idle:
                    Energy -= IdleConsumption;
                    EnergyConsumtion += IdleConsumption;
                    break;
                case EnergyConsumtionType.Transmision:

                    Energy -= TransmisionConsumption;
                    EnergyConsumtion += TransmisionConsumption;
                    break;
                case EnergyConsumtionType.Reception:
                    Energy -= ReceptionConsumption;
                    EnergyConsumtion += ReceptionConsumption;
                    break;
                default:

                    Energy -= custumConsumtion;
                    EnergyConsumtion += custumConsumtion;
                    break;
            }
            //if node has infinite energy source restor inital energy 
            Energy = IsInfiniteEnergy ? tempEnergy : Energy;
        }
        public void Iterate()
        {
            float t = Simulation.SimulationTime;
            //move around
            Move();
            if (IsDead) return;
          
            //remove outdated BeaconPackets
            RecivedBeaconPackets.RemoveAll(bp => t - bp.SentTime > BeaconInterval * 4.5);
            //Remove older  packets from same sender

            //update neighbors lists
            var tempNeighbors = RecivedBeaconPackets.Select(bp => bp.Sender).ToList();
            Neighbors = tempNeighbors.GroupBy(n => n.Id).Select(g => g.First()).ToList();
            consumeEnergy(EnergyConsumtionType.Idle);
            foreach (Node n in Neighbors)
            {
                var rb = RecivedBeaconPackets.Where(bp => bp.Sender.Id == n.Id).OrderByDescending(bp => bp.SentTime).Skip(1).ToList();
                foreach (var item in rb)
                {
                    RecivedBeaconPackets.Remove(item);

                }

            }
            UpdateRNGNeighbors();
            UpdateGGNeighbors();

            //if Beacon Interval passed
            if (t - LastBeaconSendTime >= BeaconInterval)
            {
                //Broadcast a beacon;
                BroadcastLocation();
                LastBeaconSendTime = t;               
            }

            //see if i want to sent packets;
            bool sendAPacket = Simulation.Random.NextDouble() < 0.1;
            if (sendAPacket )
            {
                var p = Packet.CreateRandomPacket(this.Id);
                Simulation.Packets.Add(p);
                
                    GpsrForward(p, null);
                
            }
           
        }
        public void BroadcastLocation()
        {
            BeaconPacket beaconPacket = new BeaconPacket() { Sender = this, SentTime = Simulation.SimulationTime };
            Simulation.BeaconPackets.Add(beaconPacket);
            consumeEnergy(EnergyConsumtionType.Transmision);
            foreach (Node n in Simulation.Nodes)
            {
                if (Distance(this, n) < Range && n.Id != this.Id)
                {
                    n.ReciveBeaconPacket(beaconPacket);
                   
                }
            }

        }
        public void ReciveBeaconPacket(BeaconPacket beaconPacket)
        {
            if (IsDead) return;
            consumeEnergy(EnergyConsumtionType.Reception);
            RecivedBeaconPackets.Add(beaconPacket);
            Simulation.RecivedBeaconsCount++;
        }
        public void Move()
        {
            Log.Time.Add(Simulation.SimulationTime);
            Log.Location.Add(Location);
            var d = Speed.Scale(Simulation.DeltaT);
            this.Location = new PointF(Location.X + d.X, Location.Y + d.Y);
            //reverse the movement if going out of field
            if (Location.X > Simulation.Width)
            {
                Location = new PointF(Simulation.Width, Location.Y);
                Speed = new PointF(-Speed.X, Speed.Y);
            }
            if (Location.X < 0)
            {
                Location = new PointF(0, Location.Y);
                Speed = new PointF(-Speed.X, Speed.Y);
            }
            if (Location.Y > Simulation.Height)
            {
                Location = new PointF(Location.X, Simulation.Height);
                Speed = new PointF(Speed.X, -Speed.Y);
            }
            if (Location.Y < 0)
            {
                Location = new PointF(Location.X, 0);
                Speed = new PointF(Speed.X, -Speed.Y);
            }

        }
        public static double GetEdgeAngle(Node node1, Node node2)
        {

            double angle1 = Math.Atan2(node1.Location.Y - node2.Location.Y, node1.Location.X - node2.Location.X);
            return angle1 < 0 ? angle1 + 2 * Math.PI : angle1;

        }
        public static float Distance(Node node1, Node node2)
        {
            return Distance(node1.Location, node2.Location);
        }

        public static float Distance(PointF point1, PointF point2)
        {
            return (float)Math.Sqrt(Math.Pow((point1.X - point2.X), 2) + Math.Pow((point1.Y - point2.Y), 2));
        }
        public static PointF MidPoint(Node node1, Node node2)
        {
            return MidPoint(node1.Location, node2.Location);
        }

        public static PointF MidPoint(PointF point1, PointF point2)
        {
            var dx = (point1.X - point2.X) / 2;
            var dy = (point1.Y - point2.Y) / 2;
            var x = dx + point2.X;
            var y = dy + point2.Y;
            return new PointF(x, y);
        }
        public void GpsrForward(Packet p, Node prevNode)
        {
            if (p.Destination.Id == this.Id)
            {
                RecivePacket(p);
                return;
            }
            if (p.Mode == GPSRMode.Greedy)
            {
                if (!GreedyForward(p,prevNode))
                {
                    p.Mode = GPSRMode.Perimeter;
                    p.Lp = p.Lf = this;
                    Node t = PerimeterInitForward(p);
                    p.E0 = new Edge(this, t);
                    ForwardPacketToNode(p, t);
                }
            }
            else //p.Mode == GPSRMode.Perimeter
            {
                if (Distance(this, p.Destination) < Distance(p.Lp, p.Destination))
                {
                    p.Mode = GPSRMode.Greedy;
                    GreedyForward(p,prevNode);
                }
                else
                {
                    Node t = RightHandForward(p, prevNode);
                    if (t == null)
                    {
                        DropPacket(p);
                        return;
                    }
                    Edge e = new Edge(this, t);
                    if (p.E0.Equals(e))
                    {
                        DropPacket(p);
                    }
                    else
                    {
                        t = FaceChange(p, t);
                        ForwardPacketToNode(p, t);
                    }


                }
            }

        }
        public bool GreedyForward(Packet p, Node prevNode)
        {
            Node bestNeighbor = this;
            float bestDistance = Distance(this, p.Destination);
            foreach (Node node in Neighbors)
            {
                float d = Distance(node, p.Destination);
                if (p.Destination == node || d < bestDistance && node != prevNode)
                {
                    bestDistance = d;
                    bestNeighbor = node;
                    if (p.Destination == node) break;
                }

            }

            if (bestNeighbor != this)
            {
                ForwardPacketToNode(p, bestNeighbor);
                return true;
            }
            else
            {
                return false;
            }

        }
        public void RecivePacket(Packet p)
        {
            p.Status = PacketState.Recived;
            Simulation.RecievedPackets.Add(p);
            p.RecivedTime = Simulation.SimulationTime +p.Hubes.Count()*Simulation.DeltaT;
            consumeEnergy(EnergyConsumtionType.Reception);

        }
        public Node PerimeterInitForward(Packet p)
        {
            return RightHandForward(p, p.Destination);
        }
        public Node RightHandForward(Packet p, Node node1)
        {
            double angle1 = GetEdgeAngle(this, node1);
            double minAngleDiff = 3 * Math.PI;
            Node minAngleNode = null;
            foreach (Node node in PlanerNeighbors)
            {
                if (node1 == node) continue;
                double angle = GetEdgeAngle(this, node);
                double angleDiff = angle - angle1;
                angleDiff = angleDiff < 0 ? angleDiff + 2 * Math.PI : angleDiff;
                if (angleDiff < minAngleDiff)
                {
                    minAngleDiff = angleDiff;
                    minAngleNode = node;
                }
            }
            return minAngleNode;
        }
        public Node FaceChange(Packet p, Node t)
        {
            PointF intersectionPoint;
            if (t != null && Intersect(t.Location, Location, p.Lp.Location, p.Destination.Location, out intersectionPoint))
            {
                if (Distance(intersectionPoint, p.Destination.Location) < Distance(p.Lf, p.Destination))
                {
                    t = RightHandForward(p, t);
                    t = FaceChange(p, t);
                    p.E0 = new Edge(this, t);
                }
            }
            return t;
        }
        public void ForwardPacketToNode(Packet p, Node node)
        {

            bool movedAway = node == null || Distance(this, node) > this.Range;//if the node moved away
            if (IsDead || movedAway)
            {
                DropPacket(p);
                return;
            }
            consumeEnergy(EnergyConsumtionType.Transmision);
            
            p.CurrentNode = node;
            p.Modes.Add(p.Mode);
            if(p.Hubes.Count()> Simulation.NodeCount)
            {
                DropPacket(p);
                return;
            }
            node.GpsrForward(p, this);
        }
        public void DropPacket(Packet p)
        {
            Simulation.DroppedPackets.Add(p);
            p.Status = PacketState.Dropped;

        }
        
        public void UpdateRNGNeighbors()
        {
            RNGNeighbors = new List<Node>(Neighbors);
            foreach (Node v in Neighbors)
            {
                foreach (Node w in Neighbors)
                {
                    if (w == v) continue;
                    if (Distance(this, v) > Math.Max(Distance(this, w), Distance(v, w)))
                    {
                        RNGNeighbors.Remove(v);
                    }

                }

            }
        }

        public void UpdateGGNeighbors()
        {
            GGNeighbors = new List<Node>(Neighbors);
            foreach (Node v in Neighbors)
            {
                foreach (Node w in Neighbors)
                {
                    if (w == v) continue;
                    var m = MidPoint(this, v);
                    if (Distance(m, w.Location) < Distance(Location, m))
                    {
                        GGNeighbors.Remove(v);
                    }

                }

            }
        }

        


        public bool Intersect(PointF p1, PointF p2, PointF p3, PointF p4, out PointF intersection)
        {
            intersection = new PointF(-1, -1);

            float A1 = p2.Y - p1.Y;
            float B1 = p1.X - p2.X;
            float C1 = A1 * p1.X + B1 * p1.Y;

            float A2 = p4.Y - p3.Y;
            float B2 = p3.X - p4.X;
            float C2 = A2 * p3.X + B2 * p3.Y;

            float det = A1 * B2 - A2 * B1;
            if (det == 0)
                return false;

            float x = (B2 * C1 - B1 * C2) / det;
            float y = (A1 * C2 - A2 * C1) / det;
            intersection = new PointF(x, y);
            return true;
        }
        public override string ToString()
        {
              return string.Format("Id={0}, RNGNeighbors ={1},  Neighbors = {2} , IsDead = {3}", Id, RNGNeighbors.Count(), Neighbors.Count(),IsDead);
        }

    }
    enum EnergyConsumtionType
    {
        Idle,
        Transmision,
        Reception,
    }
}