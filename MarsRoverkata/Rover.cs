using System;

namespace MarsRoverkata
{
    public class Rover : ICommandable
    {
        public GridPosition Position { get; set; }

        public Rover(BidimensionalCoordinates startingPositionInGrid, CardinalPoint orientation)
        {
            Position = new GridPosition(startingPositionInGrid, orientation);
        }

        public void ExecuteCommands(char[] commands)
        {
            foreach (var command in commands)
            {
                Position.Move(command);
            }
        }
    }
}
