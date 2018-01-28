using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverkata
{
    internal interface IRoverInstruction
    {
        Position Do(Position position);
    }
}
