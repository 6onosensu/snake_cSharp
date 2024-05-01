using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_cSharp
{
    class Point
    {
        private int x;
        private int y;
        private char sym;

        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move (int offset, Direction direction)
        {
            if (direction == Direction.Right) 
            {
                x += offset;
            } 
            else if (direction == Direction.Left) 
            {
                x -= offset;
            }
            else if (direction == Direction.Up) 
            {
                y -= offset;
            }
            else if (direction == Direction.Down) 
            { 
                y += offset;
            }
        }
        public void DisplayPoint()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void Clear() 
        {
            sym = ' ';
            DisplayPoint();
        }
    }
}
