using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using WindowsFormsApplication1;

namespace WindowsFormsApplication1
{
    public class UserShape :Shape
    {
        private List<Shape> listofShapes = new List<Shape>();
        private int length, width;

        public UserShape(List<Shape> tmplist, int x, int y)
        {
            listofShapes = tmplist;
            length = x;
            width = y;
        }

        public override void draw(Graphics grph)
        {
            int x1, y1, x2, y2;
            Point p = new Point();
            foreach (var item in listofShapes)
            {
                item.SetPenColor(this.pen);
                item.SetPenWidth(this.pen);
            }
            foreach (var item in listofShapes)
            {
                x1 = item.P1.X; 
                y1 = item.P1.Y; 
                x2 = item.P2.X; 
                y2 = item.P2.Y;
                //item.SetPoint1(item.P1().X + p1.X, item.P1().Y + p1.Y);
                //item.SetPoint2(item.P2().X + p2.X, item.P2().Y + p2.Y);
                p.X = item.P1.X * (p2.X - p1.X) / length + p1.X; 
                p.Y = item.P1.Y * (p2.Y - p1.Y)/width + p1.Y;
                item.P1 = p;
                p.X = item.P2.X * (p2.X - p1.X) / length + p1.X; 
                p.Y = item.P2.Y * (p2.Y - p1.Y)/width + p1.Y;
                item.P2 = p;
                item.draw(grph);
                p.X = x1; p.Y = y1;
                item.P1 = p;
                p.X = x2; p.Y = y2;
                item.P2 = p;
            }
        }
    }
}
