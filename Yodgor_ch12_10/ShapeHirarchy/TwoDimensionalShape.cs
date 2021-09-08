using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeHierarchy
{
    public abstract class TwoDimensionalShape : Shape
    {
        public TwoDimensionalShape(int d1, int d2)             
        {
            Dimension1 = d1;
            Dimension2 = d2;
        }

        public int Dimension1 { get; set; }
        public int Dimension2 { get; set; }

        public abstract double Area { get; }

    }
}