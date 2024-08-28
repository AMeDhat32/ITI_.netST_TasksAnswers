using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    public class _3Dpoint
    {
        int x, y, z;

        public _3Dpoint() : this(0, 0, 0)
        {

        }

        public _3Dpoint(int value) : this(value, value, value)
        {

        }

        public _3Dpoint(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
       
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Z { get => z; set => z = value; }


       
        public override string ToString()
        {
            return $"Point Coordinates: ({x}, {y}, {z})";
        }

        
        public static implicit operator string(_3Dpoint p)
        {
            return p.ToString();
        }
    }
}
