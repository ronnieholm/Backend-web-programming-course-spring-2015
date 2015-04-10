using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture09
{
    class ConstantsExample
    {
        // example 1 begin
        const double PI = 3.14;

        public double ComputeCircumference(double radius)
        {
            // don't want someone accidentally or intentionally changing PI
            //PI = 3;
            return 2 * PI * radius;
        }

        // example 1 end

        // example 2 begin
        const int RowMin = 1;
        const int RowMax = 10;
        const int ColumnMin = 1;
        const int ColumnMax = 15;

        public void PrintMultiplicationTable()
        {
            Console.WriteLine(
                "Prints multiplication table from {0} to {1} and {2} to {3}",
                RowMin, RowMax, ColumnMin, ColumnMax);

            // we wouldn't want the values to change between printing the header
            // and the multiplication table

            for (int y = ColumnMin; y <= ColumnMax; y++)
            {
                for (int x = RowMin; x <= RowMax; x++)
                {
                    Console.Write("{0} ", x * y);
                }
                Console.WriteLine();
            }
        }
        // example 2 end

        // example 3 begin
        const int DirectionNorth = 1;
        const int DirectionSouth = 2;
        const int DirectionEast = 3;
        const int DirectionWest = 4;

        const int GenderMale = 1;
        const int GenderFemale = 2;

        // use directions above in code

        // example 3 end
    }

    enum Direction
    {
        None = 0,
        North,
        South,
        East,
        West
    }

    class EnumsExample
    {
        Direction _direction;

        public void SetDirectionFromEnumType(Direction d)
        {
            if (Direction.None == d)
            {
                throw new ArgumentException("Invalid direction");
            }

            _direction = d;
        }

        public void SetDirectionFromUnderlyingValueType(int direction)
        {
            _direction = (Direction)direction;
        }

        public void SetDirectionFromString(string direction)
        {
            _direction = (Direction)Enum.Parse(typeof(Direction), direction);
        }

        public void PrintDirection()
        {
            Console.WriteLine("Textual representation: " + _direction.ToString());
            Console.WriteLine("Underlying type value: " + (int)_direction);
        }
    }

    static class StaticExample
    {
        static int _methodCallCount;

        public static int Add(int op1, int op2)
        {
            _methodCallCount++;
            return op1 + op2;
        }

        public static int FlipSign(int op)
        {
            _methodCallCount++;
            return -op;
        }

        public static int GetMethodCallCount()
        {
            return _methodCallCount;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //ConstantsExample ex = new ConstantsExample();
            //Console.WriteLine(ex.ComputeCircumference(5));
            //ex.PrintMultiplicationTable();

            //EnumsExample ex1 = new EnumsExample();
            //ex1.SetDirectionFromEnumType(Direction.North);
            //ex1.PrintDirection();
            //ex1.SetDirectionFromUnderlyingValueType(3);
            //ex1.PrintDirection();
            //ex1.SetDirectionFromString("West");
            //ex1.PrintDirection();
            // todo: set to invalid string and invalid underlying value

            //StaticExample ex2 = new StaticExample(); // cannot create instance of static class
            //Console.WriteLine(StaticExample.Add(1, 2));
            //Console.WriteLine(StaticExample.FlipSign(-4));
            //Console.WriteLine(StaticExample.GetMethodCallCount());
        }
    }
}
