using System;
using MarsRover.Domain.Model;
using MarsRover.Domain.Service;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            IRoverService roverService = new RoverService();
            Plateau plateau = new Plateau(5, 5);
            Coordinates coordinates = new Coordinates(2, 0);

            Rover rover = new Rover(plateau, Domain.Enum.Direction.South , coordinates);
            roverService.ApplyCommand(rover, "MLLM");
            Console.WriteLine(rover.coordinates.xCoordinate + " " + rover.coordinates.yCoordinate + " " + rover.direction);

            coordinates = new Coordinates(3, 3);
            rover = new Rover(plateau, Domain.Enum.Direction.East, coordinates);
            roverService.ApplyCommand(rover, "MMRMMRMRRM");
            Console.WriteLine(rover.coordinates.xCoordinate + " " + rover.coordinates.yCoordinate + " " + rover.direction);
        }
    }
}
