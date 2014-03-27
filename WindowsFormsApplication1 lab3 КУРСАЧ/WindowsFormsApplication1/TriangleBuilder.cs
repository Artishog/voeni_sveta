using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1;

namespace WindowsFormsApplication1
{
    class TriangleBuilder : ShapeBuilder
    {
        public TriangleBuilder()
        {
            namebuilder =  "Triangle";
        }
        public override Shape CreateShape()
        {
            return new Triangle();
        }
    }
}
