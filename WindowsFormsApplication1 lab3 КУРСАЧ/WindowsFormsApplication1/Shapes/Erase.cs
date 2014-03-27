using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using WindowsFormsApplication1;

namespace WindowsFormsApplication1
{
    [Serializable]
    public class Erase : Shape
    {
        public override void draw(Graphics grph)
        {
            grph.FillRectangle(Brushes.White, p2.X, p2.Y, 25, 25);
        }
        public override void PickOutMe(Graphics grph)
        {
        }
    }
}
