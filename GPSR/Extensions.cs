using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSR
{

    public static class Extensions
    {
        public static PointF Shift(this PointF p, float s)
        {
            return new PointF(p.X + s, p.Y + s);
        }
        public static PointF Scale(this PointF p, float s)
        {
            return new PointF(p.X * s, p.Y * s);
        }
        public static PointF Scale(this PointF p, PointF s)
        {
            return new PointF(p.X * s.X, p.Y * s.Y);
        }
        public static RectangleF Scale(this RectangleF r, float s)
        {
            return new RectangleF(r.Location.Scale(s),r.Size.Scale(s));
        }
        public static RectangleF Scale(this RectangleF r, PointF s)
        {
            return new RectangleF(r.Location.Scale(s), r.Size.Scale(s));
        }
        public static SizeF Scale(this SizeF s, float scale)
        {
            return new SizeF(s.Width * scale, s.Height * scale);
        }
        public static SizeF Scale(this SizeF s, PointF scale)
        {
            return new SizeF(s.Width * scale.X, s.Height * scale.Y);
        }
        
    }
}
