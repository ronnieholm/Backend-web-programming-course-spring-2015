using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise26
{
    class Runner
    {
        public void Run()
        {
            DrawingTool drawer = new DrawingTool();

            // part 2a
            Console.WriteLine("Solution for 2a");
            for (int x = 0; x < 10; x++)
            {
                drawer.DrawOneStar();
            }
            Console.WriteLine();

            // part 2b
            Console.WriteLine("Solution for 2b");
            for (int x = 0; x < 5; x++)
            {
                drawer.DrawOneStar();
                drawer.DrawOneSpace();
            }
            Console.WriteLine();

            // part 2c
            Console.WriteLine("Solution for 2c");
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    drawer.DrawOneStar();
                }
                drawer.StartNewLine();
            }
            Console.WriteLine();

            // part 2d
            Console.WriteLine("Solution for 2d");
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x <= y; x++)
                {
                    drawer.DrawOneStar();
                }
                drawer.StartNewLine();
            }
            Console.WriteLine();

            // part 2e
            Console.WriteLine("Solution for 2e");
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    if ((x == y) || (x + y == 9))
                    {
                        drawer.DrawOneStar();
                    }
                    else
                    {
                        drawer.DrawOneSpace();
                    }
                }
                drawer.StartNewLine();
            }
            Console.WriteLine();
        }
    }
}
