using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Geometry rectangle = new Geometry(3.5,6.4);

            Console.WriteLine($"The perimeter of the rectangle is: {rectangle.GetPerimeter()}");

            Console.WriteLine($"The area of the rectangle is: {rectangle.GetArea()}");

            Geometry circle = new Geometry(5.8);

            Console.WriteLine($"The area of the circle is: {circle.GetCircleArea()}");

            Geometry polygonR = new Geometry();

            Console.WriteLine($"The polygon is a rectagle: {polygonR.GetPolygon(60)}");

            // The LAST line of code should be ABOVE this line
        }
    }
}
