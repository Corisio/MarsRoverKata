using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverkata
{
    public class Position
    {
        private const int DEFAULT_POSITION = 0;

        public Position()
        {
            X = Y = DEFAULT_POSITION;
        }

        public Position(Position position)
        {
            X = position.X;
            Y = position.Y;
        }

        public int X { get; set; }
        public int Y { get; set; }
    }
}
