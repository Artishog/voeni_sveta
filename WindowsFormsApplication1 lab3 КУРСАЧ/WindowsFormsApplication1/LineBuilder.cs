using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class LineBuilder : ShapeBuilder
    {
        public LineBuilder()
        {
            namebuilder = "Line";
        }
        public override Shape CreateShape()
        {
            return new Line();
        }
    }
}
