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
            Point p4 = new Point(p1.X, p2.Y);
            
            //прямоугольный
            //p3.X = p1.X;
            //p3.Y = p2.Y;

            p3.X = p1.X + ((p2.X - p1.X) / 2);
            p3.Y = p1.Y;

            grph.DrawLine(this.pen, p4, p2);
            grph.DrawLine(this.pen, p2, p3);
            grph.DrawLine(this.pen, p3, p4);
        }
    }
}
