using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using WindowsFormsApplication1;
using System.Xml.Serialization;

namespace WindowsFormsApplication1
{
    [Serializable]
    [XmlInclude(typeof(Rectangle)), XmlInclude(typeof(Circle)), XmlInclude(typeof(Triangle)), XmlInclude(typeof(Line)), XmlInclude(typeof(Pencil))]
    public abstract class Shape
    {
        protected Point p1 = new Point(), p2 = new Point();
        protected Pen pen = new Pen(Color.Black);

        public abstract void draw(System.Drawing.Graphics grph);

        public Point P1
        {
            get { return p1;}
            set { p1 = value;}
        }
        public Point P2
        {
            get { return p2; }
            set { p2 = value; }
        }
        public void SetPenColor(Pen tmppen)
        {
            pen.Color = tmppen.Color;
        }
        public void SetPenWidth(Pen tmppen)
        {
            pen.Width = tmppen.Width;
            
        }
        public void SetLineStyle()
        {
            pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
        }
        public virtual void PickOutMe(Graphics grph)
        {
            Pen blackpen = new Pen(Color.Black,2);
            int x1, x2, y1, y2;
            if (P1.X < P2.X)
            {
                x1 = P1.X;
                x2 = P2.X;
            }
            else
            {
                x2 = P1.X;
                x1 = P2.X;
            }
            if (P1.Y < P2.Y)
            {
                y1 = P1.Y;
                y2 = P2.Y;
            }
            else
            {
                y2 = P1.Y;
                y1 = P2.Y;
            }
            grph.DrawRectangle(blackpen, p2.X-4, p2.Y-4, 8, 8);
            grph.DrawRectangle(blackpen, x1+(x2-x1)/2-4, y1-4+(y2-y1)/2, 8, 8);
            blackpen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            blackpen.Width = 1;
            grph.DrawRectangle(blackpen, x1-6, y1-6, x2 - x1+12, y2 - y1+12);
        }

        public MementoShape CreateMementoShape()
        {
            return (new MementoShape(this));
        }

        /*public void SetMementoShape(MementoShape mementoShape)
        {
            this = mementoShape.ShapeState;
        }*/
    }
}
