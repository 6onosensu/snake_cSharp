using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_cSharp
{
    class Shape
    {
        protected List<Point> shapeList;

        public virtual void Display()
        {
            foreach (Point p in shapeList)
            {
                p.DisplayPoint();
            }
        }
    }
}
