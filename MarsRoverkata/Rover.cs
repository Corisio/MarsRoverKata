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

        private Dictionary<char, Action> actions; 

        public Rover()
        {
            Position = new Position();
            Direction = INITIAL_DIRECTION;

            actions = new Dictionary<char, Action>
            {
                { FORWARD_COMMAND,  MoveForward },
                { BACKWARD_COMMAND, MoveBackwards }
            };
        }

        public Position Position { get; set; }

        public char Direction { get; set; }

        public void Execute(List<char> list)
        {
            foreach(var command in list)
            {
                actions[command]();
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
