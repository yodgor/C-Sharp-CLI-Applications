// Sphere.cs
// Declaration of class Sphere.
using System;

namespace ShapeHierarchy
{
    public class Sphere : ThreeDimensionalShape
    {
        // three-parameter constructor
        public Sphere(int radius)
            : base(radius, radius, radius) { }

        // overridden properties
        // read-only property that gets the name
        public override string Name
        {
            get
            {
                return "Sphere";
            } // end get
        } // end property Name

        // read-only property that gets the area
        public override double Area
        {
            get
            {
                return (4 * Math.PI * Radius * Radius);
            } // end get
        } // end property Area

        // read-only property that gets the volume
        public override double Volume
        {
            get
            {
                return (4.0 / 3.0 * Math.PI *
                   Radius * Radius * Radius);
            } // end get
        } // end property Volume

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
                Dimension3 = value;
            } // end set
        } // end property Radius

        public override string ToString()
        {
            return string.Format($"radius: {Radius}\n");
              
        } // end method ToString
    } // end class Sphere
}