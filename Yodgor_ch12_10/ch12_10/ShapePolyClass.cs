using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeHierarchy;
namespace ch12_10
{
    class ShapePolyClass
    {
        public static void ShapePoly(Shape[] shapes)
        {
            // call method ToString on all shapes
            foreach (var currentShape in shapes)
            {
                Console.Write($"{currentShape.Name}: {currentShape}");

                if (currentShape is TwoDimensionalShape)
                {
                    TwoDimensionalShape twoDimensionalShape =
                       (TwoDimensionalShape)currentShape;

                    Console.WriteLine($"{currentShape.Name}'s area is {twoDimensionalShape.Area:F2}");
                } // end if

                if (currentShape is ThreeDimensionalShape)
                {
                    ThreeDimensionalShape threeDimensionalShape =
                       (ThreeDimensionalShape)currentShape;

                    Console.WriteLine($"{currentShape.Name}'s area is {threeDimensionalShape.Area:F2}");
                    Console.WriteLine($"{currentShape.Name}'s volume is {threeDimensionalShape.Volume:F2}");
                } // end if

                Console.WriteLine();

            } // end foreach

            Console.Read();
        }
    }
}
