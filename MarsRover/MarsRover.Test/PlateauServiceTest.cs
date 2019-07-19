using System;
using MarsRover.Domain.Enum;
using MarsRover.Domain.Model;
using MarsRover.Domain.Service;
using NUnit.Framework;

namespace MarsRover.Test
{
    public class PlateauServiceTest
    {
        private Plateau plateau;
        private Coordinates coordinates;
        private IPlateauService plateauService;

        [SetUp]
        public void Setup()
        {
            plateauService = new PlateauService();
        }

        [Test]
        public void TestCheckIsMoveAvailable()
        {
            plateau = new Plateau(5, 5);
            coordinates = new Coordinates(1, 2);
            bool flag = plateauService.CheckIsMoveAvailable(plateau, coordinates, Direction.East);
            Assert.IsTrue(flag);
        }

        [Test]
        public void TestCheckIsMoveNotAvailable()
        {
            plateau = new Plateau(5, 5);
            coordinates = new Coordinates(5, 2);
            bool flag = plateauService.CheckIsMoveAvailable(plateau, coordinates, Direction.East);
            Assert.IsFalse(flag);
        }
    }
}