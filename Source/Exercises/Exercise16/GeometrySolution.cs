using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise16
{
    class MyCode
    {
        public void MyMain()
        {
            GeometrySolution g = new GeometrySolution();

            double perimeter = g.CalculateRectanglePerimeter(5, 10);
            Console.WriteLine(perimeter);

            double area = g.CalculateRectangleArea(5, 10);
            Console.WriteLine(area);

            double area1 = g.CalculateCircleArea(5);
            Console.WriteLine(area1);

            bool isRectangle1 = g.IsPolygonARectangle(90, 90, 90, 90);
            bool isRectangle2 = g.IsPolygonARectangle(12, 90, 90, 90);
            Console.WriteLine(isRectangle1);
            Console.WriteLine(isRectangle2);

            int thirdAngle = g.CalculateThirdAngleOfTriangle(45, 90);
            Console.WriteLine(thirdAngle);
        }
    }

    class GeometrySolution
    {
        // this class does not need any instance fields. Why is that?
        // why do we not need a constructor?

        public double CalculateRectanglePerimeter(double sideA, double sideB)
        {
            double perimeter = 2 * sideA + 2 * sideB;
            return perimeter;
        }

        public double CalculateRectangleArea(double sideA, double sideB)
        {
            double area = sideA * sideB;
            return area;
        }

        public double CalculateCircleArea(double radius)
        {
            // PI is assumed to be 3.1416
            double area = 3.1416 * radius * radius;
            return area;
        }

        public bool IsPolygonARectangle(int angleA, int angleB, int angleC, int angleD)
        {
            bool isRectangle = (angleA == 90) && (angleB == 90) && (angleC == 90) && (angleD == 90);
            return isRectangle;
        }

        // given two angles of a triangle, calculate the last angle.
        // Use the fact that the sum of the angles in a triangle is always 180 degrees.
        public int CalculateThirdAngleOfTriangle(int angleA, int angleB)
        {
            int angleC = 180 - angleA - angleB;
            return angleC;
        }
    }
}
