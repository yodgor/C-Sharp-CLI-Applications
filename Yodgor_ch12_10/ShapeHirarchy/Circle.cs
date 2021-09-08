// Circle.cs
// Declaration of class Circle.
using System;

namespace ShapeHierarchy
{
    public class Circle : TwoDimensionalShape
    {
        // three-parameter constructor
        public Circle(int radius)
            : base(radius, radius) {}

        // overridden properties
        // read-only property that gets the name
        public override string Name
        {
            get
            {
                return "Circle";
            } // end get
        } // end property Name

        // read-only property that gets the area
        public override double Area
        {
            get
            {
                return (Math.PI * Radius * Radius);
            } // end get
        } // end property Area

        // property that gets and sets the radius
        public int Radius
        {
            get
            {
                return Dimension1;
            } // end get
            set
            {
                Dimension1 = value;
                Dimension2 = value;
            } // end set
        } // end property Radius

        public override string ToString()
        {
            return string.Format($"radius: {Radius}\n");
        } // end method ToString
    } // end class Circle

}