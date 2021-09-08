// ThreeDimensionalShape.cs
// Declaration of class ThreeDimensionalShape.
namespace ShapeHierarchy
{
    public abstract class ThreeDimensionalShape : Shape
    {
        // auto-implemented property Dimension1
        public int Dimension1 { get; set; }

        // auto-implemented property Dimension2
        public int Dimension2 { get; set; }

        // auto-implemented property Dimension3
        public int Dimension3 { get; set; }

        // five-parameter constructor
        public ThreeDimensionalShape(int d1, int d2, int d3)
        {
            Dimension1 = d1;
            Dimension2 = d2;
            Dimension3 = d3;
        } // end five-parameter ThreeDimensionalShape constructor

        // abstract properties
        public abstract double Area
        {
            get;
        }
        public abstract double Volume
        {
            get;
        }
    } // end class ThreeDimensionalShape
}