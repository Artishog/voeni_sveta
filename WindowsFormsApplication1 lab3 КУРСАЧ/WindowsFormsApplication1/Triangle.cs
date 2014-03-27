using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using WindowsFormsApplication1;

namespace WindowsFormsApplication1
{
    [Serializable]
    public class Triangle : Shape
    {
        public override void draw(Graphics grph)
        {
            Point p3 = new Point();
            p3.X = p1.X;
            p3.Y = p2.Y;
            grph.DrawLine(this.pen, p1, p2);
            grph.DrawLine(this.pen, p2, p3);
            grph.DrawLine(this.pen, p3, p1);
        }
    }
}
