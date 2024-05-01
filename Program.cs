using System;
using System.Text;
using System.Threading;

namespace snake_cSharp
{
    class Program
    {
        private const int Width = 122;

        static void Main(string[] args)
        {
            ArgumentNullException.ThrowIfNull(args);

            Console.SetBufferSize(width: Width, 30);

            HorizontalLine top = new(0, 120, 0, '+');
            HorizontalLine bottom = new(0, 120, 28, '+');
            VerticalLine left = new(0, 28, 0, '+');
            VerticalLine right = new(0, 28, 120, '+');
            top.Display();
            bottom.Display();
            left.Display();
            right.Display();

            Point food = new(9, 10, '#');
            food.DisplayPoint();

            Point snakeTail = new(2, 3, '*');
            Snake snake = new(snakeTail, 4, Direction.Right);
            snake.Display();
            
            while(true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();

            }
        }
    }
}