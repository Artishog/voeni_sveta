using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class EraseBuilder : ShapeBuilder
    {
        public EraseBuilder()
        {
            namebuilder = "Erase";
        }
        public override Shape CreateShape()
        {
            return new Erase();
        }
    }
}