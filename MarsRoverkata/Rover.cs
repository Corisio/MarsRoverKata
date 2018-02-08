using System;

namespace MarsRoverkata
{
    public class Rover : ICommandable
    {
        public BidimensionalCoordinates Coordinates { get; set; }
        public CardinalPoint FacingCardinalPoint { get; set; }

        public const char MOVE_FORWARD_COMMAND = 'f';
        public const char MOVE_BACKWARDS_COMMAND = 'b';

        delegate void MovingMethod(int units);

        public Rover(BidimensionalCoordinates startingPositionInGrid, CardinalPoint orientation)
        {
            Coordinates = startingPositionInGrid;
            FacingCardinalPoint = orientation;
        }

        public void ExecuteCommands(char[] commands)
        {
            foreach (var command in commands)
            {
                Move(command);
            }
        }

        internal void Move(char command)
        {
            if (!IsValidMove(command))
            {
                return;
            }

            MovingMethod movingMethod = GetMovingMethod();

            int unitsToMove = GetUnitsToMove(command);

            movingMethod(unitsToMove);
        }

        private MovingMethod GetMovingMethod()
        {
            MovingMethod movingMethod = Coordinates.ModifyX;

            if (FacingCardinalPoint.IsIn(CardinalPoint.North, CardinalPoint.South))
            {
                movingMethod = Coordinates.ModifyY;
            }

            return movingMethod;
        }

        private int GetUnitsToMove(char command)
        {
            int unitsToMove = 1;

            if (command == MOVE_BACKWARDS_COMMAND)
            {
                unitsToMove *= -1;
            }

            if (FacingCardinalPoint.IsIn(CardinalPoint.South, CardinalPoint.West))
            {
                unitsToMove *= -1;
            }

            return unitsToMove;
        }

        private bool IsValidMove(char command)
        {
            if (command == MOVE_FORWARD_COMMAND)
            {
                return true;
            }

            if (command == MOVE_BACKWARDS_COMMAND)
            {
                return true;
            }

            return false;
        }
    }
}
