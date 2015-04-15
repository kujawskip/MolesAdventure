using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Game_Engine.Objects
{
    public struct Point
    {
       

        public Point(int x,int y=0)
        {
            this.x = x;
            this.y = y;
        }
        int x;
        int y;
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }
    }
}
