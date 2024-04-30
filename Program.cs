using System;

namespace snake_cSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(122, 30);

            HorizontalLine top = new HorizontalLine(0, 120, 0, '+');
            HorizontalLine bottom = new HorizontalLine(0, 120, 28, '+');
            VerticalLine left = new VerticalLine(0, 28, 0, '+');
            VerticalLine right = new VerticalLine(0, 28, 120, '+');

            top.DrawLine();
            bottom.DrawLine();
            left.DrawLine();
            right.DrawLine();



            Point p2 = new Point(9, 10, '#');
            p2.Draw();

            Point p = new Point(2, 3, '*');
            Snake snake = new Snake(p, 2, Direction.RIGHT);
            snake.DrawLine();
            
            for (int i = 0; i < 10; i++)
            {
                snake.Move();
                Thread.Sleep(300);
            }
        }
    }
}