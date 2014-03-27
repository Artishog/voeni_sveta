using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ShapeInterface
{
    public interface IShape
    {
         void draw(System.Drawing.Graphics grph);
         Point P1{get;set;}
         Point P2{get;set;}
         void Setpencolor(Pen tmppen);
         void PickOutMe(Graphics grph);
         MementoShape CreateMementoShape();
    }
}
