using System;
using System.Text;
using System.Threading;

namespace snake_cSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            const int width = 122;
            const int height = 30;

            Console.SetBufferSize(width, height);

            HorizontalLine top = new(0, 78, 0, '+');
            HorizontalLine bottom = new(0, 78, 24, '+');
            VerticalLine left = new(0, 24, 0, '+');
            VerticalLine right = new(0, 24, 78, '+');
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