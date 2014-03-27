using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ShapeInterface
{
    [Serializable]
    public class MementoShape
    {
        private IShape shapeState;
        private Point p1 = new Point(), p2 = new Point();

        public MementoShape() { }

        public MementoShape(IShape state)
        {
            shapeState = state;
            p1.X = state.P1.X; p1.Y = state.P1.Y;
            p2.X = state.P2.X; p2.Y = state.P2.Y;
        }

        public IShape ShapeState
        {
            get
            {
                shapeState.P1 = p1;
                shapeState.P2 = p2;
                return shapeState;
            }
            set
            {
                shapeState = value;
                p1 = shapeState.P1;
                p2 = shapeState.P2;
            }
        }
    }
}
