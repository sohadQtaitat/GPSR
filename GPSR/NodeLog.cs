using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSR
{
    public class NodeLog
    {
        public Node Node { get; set; }
        public List<float> Time { get; set; }
        public List<PointF> Location { get; set; }
        public NodeLog(Node node)
        {
            Node = node;
            Time = new List<float>();
            Location = new List<PointF>();
        }

    }
}
