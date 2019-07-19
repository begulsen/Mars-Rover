using System;
using MarsRover.Domain.Enum;
using MarsRover.Domain.Model;
using MarsRover.Domain.Service;
using NUnit.Framework;

namespace MarsRover.Test
{
    public class RoverServiceTest
    {
        private Rover rover;
        private Plateau plateau;
        private Coordinates coordinates;
        private IRoverService roverService;
        private Direction direction;

        [SetUp]
        public void Setup()
        {
            roverService = new RoverService();
            plateau = new Plateau(5, 5);
            coordinates = new Coordinates(1, 2);
            rover = new Rover(plateau, Domain.Enum.Direction.North, coordinates);
        }

        [Test]
        public void TestApplyCommand()
        {
            string commands = "LMLMLMLMM";
            roverService.ApplyCommand(rover,commands);
            int xCoordinate = rover.coordinates.xCoordinate;
            int yCoordinate = rover.coordinates.yCoordinate;
            direction = rover.direction;

            Assert.That(xCoordinate, Is.EqualTo(1));
            Assert.That(yCoordinate, Is.EqualTo(3));
            Assert.That(Direction.North, Is.EqualTo(direction));
        }
    }
}
