using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_cSharp
{
    internal class VerticalLine : Shape
    {
        public VerticalLine(int top, int bottom, int y, char sym)
        {
            shapeList = [];
            for (int i = top; i < bottom; i++)
            {
                for (int x = top; x <= bottom; x++)
                {
                    Point p = new(y, x, sym);
                    shapeList.Add(p);
                }

                Console.WriteLine("\n");
            }
        }
    }
}
