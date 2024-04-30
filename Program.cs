using System;

namespace snake_cSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            point.x = 1;
            point.y = 2;
            point.sym = '*';
            point.Draw();

            Point point2 = new Point();
            point2.x = 4;
            point2.y = 5;
            point2.sym = '#';
            point2.Draw();


            Console.ReadLine();
        }
    }
}