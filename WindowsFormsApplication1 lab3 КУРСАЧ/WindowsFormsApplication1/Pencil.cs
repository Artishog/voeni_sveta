﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using WindowsFormsApplication1;

namespace WindowsFormsApplication1
{
    [Serializable]
    public class Pencil: Shape
    {
        public override void draw(Graphics grph)
        {
            grph.DrawLine(this.pen, p1, p2);
        }
        public override void PickOutMe(Graphics grph)
        {
        }
    }
}
