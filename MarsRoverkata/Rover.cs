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

        private Dictionary<char, IRoverInstruction> instructions; 

        public Rover()
        {
            Position = new Position();
            Direction = INITIAL_DIRECTION;

            instructions = new Dictionary<char, IRoverInstruction>
            {
                { FORWARD_COMMAND,  new Forward()  },
                { BACKWARD_COMMAND, new Backward() }
            };
        }

        public Position Position { get; set; }

        public char Direction { get; set; }

        public void Execute(List<char> list)
        {
            foreach(var command in list)
            {
                Position =  instructions[command].Do(Position);
            }
        }
    }
}
