using System;

namespace snake_cSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 1;
            int y1 = 1;
            char sym1 = '*';

            int x2 = 2; 
            int y2 = 2;
            int sym2 = '#';

            Draw(x2, y2, sym2);


            Console.ReadLine();
        }

        static void Draw (int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}