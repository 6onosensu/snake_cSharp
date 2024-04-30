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
            points = new List<Point>();
            for (int i = top; i < bottom; i++)
            {
                for (int x = top; x <= bottom; x++)
                {
                    Point p = new Point(y, x, sym);
                    points.Add(p);
                }

                Console.WriteLine("\n");
            }
        }
    }
}
