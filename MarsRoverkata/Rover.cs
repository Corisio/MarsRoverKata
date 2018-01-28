using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverkata
{
    public class Rover
    {
        private const char INITIAL_DIRECTION = 'N';

        private const char FORWARD_COMMAND = 'f';
        private const char BACKWARD_COMMAND = 'b';

        public Rover()
        {
            Position = new Position();
            Direction = INITIAL_DIRECTION;
        }

        public Position Position { get; set; }

        public char Direction { get; set; }

        public void Execute(List<char> list)
        {
            foreach(var command in list)
            {
                switch(command)
                {
                    case FORWARD_COMMAND:
                        MoveForward();
                        break;
                    case BACKWARD_COMMAND:
                        MoveBackwards();
                        break;
                }
            }
        }

        private void MoveBackwards()
        {
            Position.Y--;
        }

        private void MoveForward()
        {
            Position.Y++;
        }
    }
}
