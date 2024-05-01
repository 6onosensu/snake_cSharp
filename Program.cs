using System;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading;

namespace snake_cSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            VerticalLine vl = new(0, 10, 5, '%');
            Display(vl);

            Point p = new(4, 5, '*');
            Shape fSnake = new Snake(p, 4, Direction.Right);
            Display(fSnake);
            Snake snake = (Snake)fSnake;

            HorizontalLine hl = new(0, 5, 6, '&');

            List<Shape> shapes = new List<Shape>();
            shapes.Add(fSnake);
            shapes.Add(hl);

            foreach (var s in shapes)
            {
                s.Display();
            }
        }

        static void Display(Shape shape)
        {
            shape.Display();
        }
        /*
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

            Point snakeTail = new(4, 2, '*');
            Snake snake = new(snakeTail, 4, Direction.Right);
            snake.Display();

            Food createFood = new ('*');
            Point food = createFood.CreateFood();
            food.DisplayPoint();
            
            while(true)
            {
                if (snake.Eat(food))
                {
                    food = createFood.CreateFood();
                    food.DisplayPoint();
                }
                else 
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                snake.Move();

            }
        }*/
    }
}