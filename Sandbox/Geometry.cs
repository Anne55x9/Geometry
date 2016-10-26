using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    public class Geometry
    {
        public double length { get; set; }
        public double width { get; set; }
        public double perimeter { get; set; }
        public double area { get; set; }
        public double pi { get; private set; }
        public double radius { get; set; }
        public double circleArea { get; set; }
        public Boolean polygon;
        public double angle { get; set; }
        

        public Geometry(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double GetPerimeter()
        {
            perimeter = 2*(length + width);
            return perimeter; 
        }

        public double GetArea()
        {
            area = length * width;
            return area;
        }

        public Geometry(double radius)
        {
            this.pi = 3.14;
            this.radius = radius;
        }


        public double GetCircleArea()
        {
            circleArea = pi * (radius * 2);
            return circleArea;
        }

        public Geometry()
        {
           
        }

        public Boolean GetPolygon(double angle)
        {

            Boolean result = true;
            if (angle != 90)
            {
                result = false;
            }

            return result;
        }


    }
}
