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
        private InstructionsParser instructionsParser;

        public Rover()
        {
            Position = new Position();
            Direction = INITIAL_DIRECTION;

            instructionsParser = new InstructionsParser();
        }

        public Position Position { get; set; }

        public char Direction { get; set; }

        public void Execute(List<char> commandsList)
        {
            foreach(var command in commandsList)
            {
                var instruction = instructionsParser.Parse(command);
                Position =  instruction.Do(Position);
            }
        }
    }
}
