using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class PencilBuilder : ShapeBuilder
    {
        public PencilBuilder()
        {
            namebuilder = "Pencil";
        }
        public override Shape CreateShape()
        {
            return new Pencil();
        }
    }
}
