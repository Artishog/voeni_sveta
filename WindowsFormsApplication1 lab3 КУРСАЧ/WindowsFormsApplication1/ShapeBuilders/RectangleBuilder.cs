using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1;

namespace WindowsFormsApplication1
{
    public class RectangleBuilder :ShapeBuilder
    {
        public RectangleBuilder()
        {
            namebuilder =  "Rectangle";
        }
        public override Shape CreateShape()
        {
            return new Rectangle();
        }
    }
}
