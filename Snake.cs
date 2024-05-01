using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
            shapeList = [];
            for (int i = 0; i < length; i++)
            {
                Point p = new(tail);
                p.Move(i, direction);
                shapeList.Add(p);
            }
        }

        public Point GetNextPoint()
        {
            Point head = shapeList.Last();
            Point nextPoint = new(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }
        internal void Move()
        {
            Point tail = shapeList.First();
            shapeList.Remove(tail);
            Point head = GetNextPoint();
            shapeList.Add(head);

            tail.Clear();
            head.DisplayPoint();
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                shapeList.Add(food);
                return true;
            }
            else
            {
                return false;
            }
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
