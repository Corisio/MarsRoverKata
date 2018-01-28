using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverkata
{
    class Forward : IRoverInstruction
    {
        public Position Do(Position position)
        {
            Position updatedPosition = new Position(position);
            updatedPosition.Y++;

            return updatedPosition;
        }
    }
}
