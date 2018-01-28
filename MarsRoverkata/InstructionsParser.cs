using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverkata
{
    internal class InstructionsParser
    {
        private const char FORWARD_COMMAND = 'f';
        private const char BACKWARD_COMMAND = 'b';

        private Dictionary<char, IRoverInstruction> instructions;

        public InstructionsParser()
        {
            instructions = new Dictionary<char, IRoverInstruction>
            {
                { FORWARD_COMMAND,  new Forward()  },
                { BACKWARD_COMMAND, new Backward() }
            };
        }

        public IRoverInstruction Parse(char instructionCode)
        {
            return instructions[instructionCode];
        }
    }
}
