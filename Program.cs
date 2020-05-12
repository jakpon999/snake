using System;
using System.Threading;

namespace Snake
{
    class Program
    {
        static int x = 0;
        static int y = 0;

        static int xVelocity = 1;
        static int yVelocity = 0;

        static void Main(string[] args)
        {
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(false);
                    switch (key.Key)
                    {
                        case ConsoleKey.RightArrow:
                            xVelocity = 1;
                            yVelocity = 0;
                            break;

                        case ConsoleKey.LeftArrow:
                            xVelocity = -1;
                            yVelocity = 0;
                            break;

                        case ConsoleKey.UpArrow:
                            xVelocity = 0;
                            yVelocity = -1;
                            break;

                        case ConsoleKey.DownArrow:
                            xVelocity = 0;
                            yVelocity = 1;
                            break;
                    }
                }

                x += xVelocity;
                y += yVelocity;

                if (x < 0)
                    x = 0;
                if (y < 0)
                    y = 0;
                if (x > Console.WindowWidth - 1)
                    x = Console.WindowWidth - 1;
                if (y > Console.WindowHeight - 1)
                    y = Console.WindowHeight - 1;

                Console.SetCursorPosition(x, y);
                Console.Write('#');

                Thread.Sleep(50);
            }
        }
    }
}
