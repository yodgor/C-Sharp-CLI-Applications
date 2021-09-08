using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeHierarchy;
namespace ch12_10
{
    class ShapeTest
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[4];
            shapes[0] = new Circle(4);
            shapes[1] = new Square(10);
            shapes[2] = new Sphere(2);
            shapes[3] = new Cube(8);

            ShapePolyClass.ShapePoly(shapes);
        }
    }
}
