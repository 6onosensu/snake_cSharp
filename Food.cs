using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_cSharp
{
    class Food
    {
        char sym;
        Random rand = new();
        public Food(char sym)
        {
            this.sym = sym;
        }
        public Point CreateFood() 
        { 
            int x = rand.Next(2, 76);
            int y = rand.Next(2, 22);
            return new Point(x, y, sym);
          
        }    
    }
}
