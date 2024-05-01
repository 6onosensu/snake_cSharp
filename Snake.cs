using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace snake_cSharp
{
    class Snake : Shape
    {
        Direction direction;
        public Snake(Point tail, int length, Direction direction)
        {
            this.direction = direction;
            points = [];
            for (int i = 0; i < length; i++)
            {
                Point p = new(tail);
                p.Move(i, direction);
                points.Add(p);
            }
        }
        internal void Move() 
        {
            Point tail = points.First();
            points.Remove(tail);
            Point head = GetNextPoint();
            points.Add(head);

            tail.Clear();
            head.DisplayPoint();
        }
        public Point GetNextPoint()
        {
            Point head = points.Last();
            Point nextPoint = new(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
            {
                direction = Direction.Left;
            }
            else if (key == ConsoleKey.RightArrow)
            {
                direction = Direction.Right;
            }
            else if (key == ConsoleKey.UpArrow)
            {
                direction = Direction.Up;
            }
            else if (key == ConsoleKey.DownArrow)
            {
                direction = Direction.Down;
            }
        }
    }
}
