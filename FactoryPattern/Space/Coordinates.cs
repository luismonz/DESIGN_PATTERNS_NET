using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Space
{
    public class Coordinates
    {
        public int Pos_X { get; set; }
        public int Pos_Y { get; set; }

        public Coordinates(int x, int y)
        {
            Pos_X = x;
            Pos_Y = y;
        }
    }
}
