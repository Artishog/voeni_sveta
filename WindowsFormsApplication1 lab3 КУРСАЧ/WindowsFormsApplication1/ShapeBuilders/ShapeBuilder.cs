using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1;

namespace WindowsFormsApplication1
{
    [Serializable]
    public abstract class ShapeBuilder
    {
        public abstract Shape CreateShape();
        public string namebuilder;
        public string NameBuilder
        {
            get { return namebuilder; }
            set { namebuilder = value; }
        }
    }
}
