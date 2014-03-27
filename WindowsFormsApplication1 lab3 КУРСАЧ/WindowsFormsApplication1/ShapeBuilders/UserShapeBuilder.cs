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
    public class UserShapeBuilder :ShapeBuilder
    {
        private List<Shape> listofShapes = new List<Shape>();
        private int endX, endY;

        public List<Shape> Content
        {
            get { return listofShapes; }
            set { listofShapes = value; }
        }

        public int EndX
        {
            get { return endX; }
            set { endX = value; }
        }
        public int EndY
        {
            get { return endY; }
            set { endY = value; }
        }
        
        public void SaveNameandList(string s, List<Shape> tmplst)
        {
            Point p = new Point();
            int startX, startY;
            startX = 32000;
            startY = 32000;
            endX = 0;
            endY = 0;
            foreach (var item in tmplst)
            {
                if (startX > item.P1.X)
                    startX = item.P1.X;
                if (startX > item.P2.X)
                    startX = item.P2.X;
                if (startY > item.P1.Y)
                    startY = item.P1.Y;
                if (startY > item.P2.Y)
                    startY = item.P2.Y;
            }
            foreach (var item in tmplst)
            {
                p.X = item.P1.X - startX; p.Y = item.P1.Y - startY;
                item.P1 = p;
                p.X = item.P2.X - startX; p.Y = item.P2.Y - startY;
                item.P2 = p;
            }
            foreach (var item in tmplst)
            {
                if (endX < item.P1.X)
                    endX = item.P1.X;
                if (endX < item.P2.X)
                    endX = item.P2.X;
                if (endY < item.P1.Y)
                    endY = item.P1.Y;
                if (endY < item.P2.Y)
                    endY = item.P2.Y;
            }
            listofShapes = tmplst;
            namebuilder = s;
        }

        public override Shape CreateShape()
        {
            return new UserShape(listofShapes,endX,endY);
        }
    }
}
