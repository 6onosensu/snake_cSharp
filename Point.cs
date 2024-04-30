using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_cSharp
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        public Point(Point p)
        {
            this.x = p.x;
            this.y = p.y;
            this.sym = p.sym;
        }

        public void Move (int offset, Direction direction)
        {
            if (direction == Direction.RIGHT) { this.x += offset; } 
            else if (direction == Direction.LEFT) { this.x -= offset; }
            else if (direction == Direction.UP) { this.y += offset; }
            else if (direction == Direction.DOWN) { this.y -= offset; }
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void Clear() 
        {
            sym = ' ';
            Draw();
        }


        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }
    }
}
