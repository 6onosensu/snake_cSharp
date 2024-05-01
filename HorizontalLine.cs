using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_cSharp
{
    internal class HorizontalLine : Shape
    {
        public HorizontalLine(int xLeft, int xRight, int y, char sym) 
        { 
            shapeList = [];
            for (int x = xLeft; x < xRight; x++) 
            {
                Point p = new(x, y, sym);
                shapeList.Add(p);
            }
        }

        public override void Display()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            base.Display();

            Console.ForegroundColor = ConsoleColor.White;
        }

    } 
}
