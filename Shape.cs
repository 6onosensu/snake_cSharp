using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_cSharp
{
    internal class Shape
    {
        protected List<Point> points;

        public void Display()
        {
            foreach (Point p in points)
            {
                p.DisplayPoint();
            }
        }
    }
}
