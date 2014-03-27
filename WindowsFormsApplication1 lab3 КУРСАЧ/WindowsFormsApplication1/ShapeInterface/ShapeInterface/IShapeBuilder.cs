using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeInterface
{
    public interface IShapeBuilder
    {
        IShape CreateShape();
        string NameBuilder{get;set;}
    }
}
