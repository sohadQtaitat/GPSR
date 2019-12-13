using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSR
{
    public class Edge
    {
        public Node Node1 { get; set; }
        public Node Node2 { get; set; }
        public Edge(Node n1,Node n2)
        {
            Node1 = n1;
            Node2 = n2;
        }
        public static List<Edge> fullGraph = new List<Edge>();
        public static List<Edge> GGGraph = new List<Edge>();
        public static List<Edge> RNGraph = new List<Edge>();
        public static Simulation Simulation;
        public static List<Edge> getFullGraph()
        {            
            foreach (Node node1 in Simulation.Nodes)
            {
                foreach (Node node2 in Simulation.Nodes)
                {
                    if (node1 == node2) continue;
                    if (Node.Distance(node1,node2) < Simulation.NodeRange)
                    {
                        Edge newEdge = new Edge(node1, node2);
                        if (fullGraph.Exists(e => e.Equals(newEdge))) continue;
                        fullGraph.Add(newEdge);                            
                    }
                        
                }
                
            }
            return fullGraph;
        }
        public static Bitmap DrawFullGraph(Bitmap b)
        {

            float scale = 1000f / Simulation.Width;
            float w = 15f * scale;
            Graphics g = Graphics.FromImage(b);
            foreach (Edge e in getFullGraph())
            {
                g.DrawLine(Pens.White, e.Node1.Location.Scale(scale), e.Node2.Location.Scale(scale));
                
            }
            g.Dispose();
            return b;
        }
        public static Bitmap DrawRngGraph(Bitmap b)
        {

            float scale = 1000f / Simulation.Width;
            float w = 15f * scale;
            Graphics g = Graphics.FromImage(b);
            foreach (Edge e in RNGraph)
            {
                g.DrawLine(Pens.White, e.Node1.Location.Scale(scale), e.Node2.Location.Scale(scale));

            }
            g.Dispose();
            return b;
        }
        public static Bitmap DrawGGraph(Bitmap b)
        {

            float scale = 1000f / Simulation.Width;
            float w = 15f * scale;
            Graphics g = Graphics.FromImage(b);
            foreach (Edge e in GGGraph)
            {
                g.DrawLine(Pens.White, e.Node1.Location.Scale(scale), e.Node2.Location.Scale(scale));

            }
            g.Dispose();
            return b;
        }
        
    public override bool Equals (object obj)
    {
        if (obj == null || GetType() != obj.GetType()) 
        {
            return false;
        }        
         Edge edge2 = obj as Edge;
         if (edge2 == null || edge2.Node1==null || edge2.Node2==null || Node1==null || Node2 ==null) return false;

            bool b1 = Node1.Id == edge2.Node1.Id && Node2.Id == edge2.Node2.Id;
            bool b2 = Node1.Id == edge2.Node2.Id && Node2.Id == edge2.Node1.Id;
            return b1 || b2;
            
    }
    
    

    }
}
