using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1;

namespace WindowsFormsApplication1
{
    public class CircleBuilder : ShapeBuilder
    {
        public CircleBuilder()
        {
            namebuilder =  "Ellipse";
        }
        public override Shape CreateShape()
        {
            return new Circle();
        }
    }
}
