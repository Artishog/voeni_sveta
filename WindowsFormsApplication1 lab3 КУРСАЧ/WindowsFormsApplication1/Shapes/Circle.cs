using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using WindowsFormsApplication1;

namespace WindowsFormsApplication1
{
    [Serializable]
    public class Circle : Shape
    {
        public override void draw(Graphics grph)
        {
            int x, y;
            if (p2.X < p1.X)
                x = p2.X;
            else
                x = p1.X;
            if (p2.Y < p1.Y)
                y = p2.Y;
            else
                y = p1.Y;

            grph.DrawEllipse(this.pen, x, y, Math.Abs(p2.X - p1.X), Math.Abs(p2.Y - p1.Y));
        }
    }
}
