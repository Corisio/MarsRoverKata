using NUnit.Framework;

namespace MarsRoverkata.Tests
{
    [TestFixture]
    class RoverShould
    {
        private Rover rover;

        private const int DEFAULT_STARTING_X = 0;
        private const int DEFAULT_STARTING_Y = 0;
        private const CardinalPoint DEFAULT_STARTING_CARDINAL_POINT= CardinalPoint.North;

        [SetUp]
        public void SetUp()
        {
            rover = new Rover(new BidimensionalCoordinates(DEFAULT_STARTING_X, DEFAULT_STARTING_Y), DEFAULT_STARTING_CARDINAL_POINT);
        }

        [Test]
        public void BeInitialisedWithTheGivenValues()
        {
            var startingX = 1;
            var startingY = 2;
            var startintOrientation = CardinalPoint.West;
            rover = new Rover(new BidimensionalCoordinates(startingX, startingY), startintOrientation);
            CheckPosition(startingX, startingY, startintOrientation, rover);
        }

        [Test]
        public void OnlyIncreaseYInOneWhenFacingNorthAndMovingForward()
        {
            rover.ExecuteCommands(new char[] { Rover.MOVE_FORWARD_COMMAND});
            CheckPosition(DEFAULT_STARTING_X, DEFAULT_STARTING_Y + 1, DEFAULT_STARTING_CARDINAL_POINT, rover);
        }

        [Test]
        public void OnlyDecreaseYInOneWhenFacingNorthAndMovingBackwards()
        {
            rover.ExecuteCommands(new char[] { Rover.MOVE_BACKWARDS_COMMAND });
            CheckPosition(DEFAULT_STARTING_X, DEFAULT_STARTING_Y - 1, DEFAULT_STARTING_CARDINAL_POINT, rover);
        }

        [Test]
        public void OnlyIncreaseXInOneWhenFacingEastAndMovingForward()
        {
            rover.FacingCardinalPoint = CardinalPoint.East;
            rover.ExecuteCommands(new char[] { Rover.MOVE_FORWARD_COMMAND });
            CheckPosition(DEFAULT_STARTING_X + 1, DEFAULT_STARTING_Y, CardinalPoint.East, rover);
        }

        [Test]
        public void OnlyDecreaseXInOneWhenFacingEastAndMovingBackwards()
        {
            rover.FacingCardinalPoint = CardinalPoint.East;
            rover.ExecuteCommands(new char[] { Rover.MOVE_BACKWARDS_COMMAND });
            CheckPosition(DEFAULT_STARTING_X - 1, DEFAULT_STARTING_Y, CardinalPoint.East, rover);
        }

        [Test]
        public void OnlyDecreaseYInOneWhenFacingSouthAndMovingForward()
        {
            rover.FacingCardinalPoint = CardinalPoint.South;
            rover.ExecuteCommands(new char[] { Rover.MOVE_FORWARD_COMMAND });
            CheckPosition(DEFAULT_STARTING_X, DEFAULT_STARTING_Y - 1, CardinalPoint.South, rover);
        }

        [Test]
        public void OnlyIncreaseYInOneWhenFacingSouthAndMovingBackwards()
        {
            rover.FacingCardinalPoint = CardinalPoint.South;
            rover.ExecuteCommands(new char[] { Rover.MOVE_BACKWARDS_COMMAND });
            CheckPosition(DEFAULT_STARTING_X, DEFAULT_STARTING_Y + 1, CardinalPoint.South, rover);
        }

        [Test]
        public void OnlyDecreaseXInOneWhenFacingWestAndMovingForward()
        {
            rover.FacingCardinalPoint = CardinalPoint.West;
            rover.ExecuteCommands(new char[] { Rover.MOVE_FORWARD_COMMAND });
            CheckPosition(DEFAULT_STARTING_X - 1, DEFAULT_STARTING_Y, CardinalPoint.West, rover);
        }

        [Test]
        public void OnlyIncreaseXInOneWhenFacingWestAndMovingBackwards()
        {
            rover.FacingCardinalPoint = CardinalPoint.West;
            rover.ExecuteCommands(new char[] { Rover.MOVE_BACKWARDS_COMMAND });
            CheckPosition(DEFAULT_STARTING_X + 1, DEFAULT_STARTING_Y, CardinalPoint.West, rover);
        }

        private static void CheckPosition(int expectedX, int expectedY, CardinalPoint expectedCardinalPoint, Rover testedRover)
        {
            Assert.AreEqual(expectedX, testedRover.Coordinates.X);
            Assert.AreEqual(expectedY, testedRover.Coordinates.Y);
            Assert.AreEqual(expectedCardinalPoint, testedRover.FacingCardinalPoint);
        }
    }
}
