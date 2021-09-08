namespace ShapeHierarchy
{
    public class Square : TwoDimensionalShape
    {
        public Square(int side) : 
            base(side, side) {}

        public override double Area
        {
            get
            {
                return Side * Side;
            }
        }

        public override string Name
        {
            get
            {
                return "Square";
            }
        }

        public int Side
        {
            get
            {
                return Dimension1;
            }
            set
            {
                Dimension1 = value;
                Dimension2 = value;
            }
        }

        public override string ToString()
        {
            return string.Format($"side: {Side}\n");
        }
    }
}