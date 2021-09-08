// Cube.cs
// Declaration of class Cube.
namespace ShapeHierarchy
{
    public class Cube : ThreeDimensionalShape
    {
        // three-parameter constructor
        public Cube(int side)
            : base(side, side, side) { }

        // overridden properties
        // read-only property that gets the name
        public override string Name
        {
            get
            {
                return "Cube";
            } // end get
        } // end property Name

        // read-only property that gets the area
        public override double Area
        {
            get
            {
                return (6 * Side * Side);
            } // end get
        } // end property Area

        // read-only property that gets the volume
        public override double Volume
        {
            get
            {
                return (Side * Side * Side);
            } // end get
        } // end property Volume

        // property that gets and sets the side length
        public int Side
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
        } // end property Side

        public override string ToString()
        {
            return string.Format($"side: {Side}\n");
        } // end method ToString
    } // end class Cube
}