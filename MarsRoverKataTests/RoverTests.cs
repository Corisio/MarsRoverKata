using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MarsRoverkata;

namespace MarsRoverKataTests
{
    class RoverShould
    {
        private const char INITIAL_DIRECTION = 'N';

        private const int INITIAL_POSITION_X = 0;
        private const int INITIAL_POSITION_Y = 0;

        private const char FORWARD_COMMAND = 'f';
        private const char BACKWARD_COMMAND = 'b';

        private Rover rover;

        [SetUp]
        public void SetUp()
        {
            rover = new Rover();
        }

        [Test]
        public void has_an_initial_position()
        {
            Assert.AreEqual(INITIAL_POSITION_X, rover.Position.X);
            Assert.AreEqual(INITIAL_POSITION_Y, rover.Position.Y);
        }

        [Test]
        public void has_an_initial_direction()
        {
            Assert.AreEqual(INITIAL_DIRECTION, rover.Direction);
        }

        [Test]
        public void moves_forward_when_receives_forward_command()
        {
            rover.Execute(new List<char> { FORWARD_COMMAND });

            Assert.AreEqual(1, rover.Position.Y);
        }

        [Test]
        public void moves_backwards_when_receives_backward_command()
        {
            rover.Execute(new List<char> { BACKWARD_COMMAND });

            Assert.AreEqual(-1, rover.Position.Y);
        }
    }
}
