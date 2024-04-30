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
            points = new List<Point>();
            for (int x = xLeft; x < xRight; x++) 
            {
                Point point = new Point(x, y, sym);
                points.Add(point);
            }
        }

    } 
}
