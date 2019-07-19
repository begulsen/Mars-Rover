using System;
using MarsRover.Domain.Enum;
using MarsRover.Domain.Model;

namespace MarsRover.Domain.Service
{
    public interface IRoverService
    {
        void ApplyCommand(Rover rover, string command);
    }

    public class RoverService : IRoverService
    {
        IPlateauService plateauService = new PlateauService();
        public void ApplyCommand(Rover rover, string command)
        {
            for (int i = 0; i < command.Length; i++)
            {
                Run(rover, command[i]);
            }
        }

        private void Run(Rover rover, char commandChr)
        {
            if ((commandChr == 'L') || (commandChr == 'R'))
            {
                ApplyDirectionCommand(rover, commandChr);
            }
            else if (commandChr == 'M')
                ApplyMoveCommand(rover);
            else
                throw new Exception("Invalid Instruction Processed.");
        }

        private void ApplyDirectionCommand(Rover rover, char commandChr)
        {
            if (commandChr == 'L')
            {
                TurnLeftCommand(rover);
            }
            else if (commandChr == 'R')
            {
                TurnRightCommand(rover);
            }
        }

        private void ApplyMoveCommand(Rover rover)
        {
            if (plateauService.CheckIsMoveAvailable(rover.plateau, rover.coordinates , rover.direction))
            {
                switch (rover.direction)
                {
                    case Direction.North:
                        rover.coordinates.yCoordinate = rover.coordinates.yCoordinate + 1;
                        break;
                    case Direction.West:
                        rover.coordinates.xCoordinate = rover.coordinates.xCoordinate - 1;
                        break;
                    case Direction.South:
                        rover.coordinates.yCoordinate = rover.coordinates.yCoordinate - 1;
                        break;
                    default:
                        rover.coordinates.xCoordinate = rover.coordinates.xCoordinate + 1;
                        break;
                }
                return;
            }
            return;
        }

        private void TurnLeftCommand(Rover rover)
        {
            switch (rover.direction)
            {
                case Direction.North:
                    rover.direction = Direction.West;
                    break;
                case Direction.West:
                    rover.direction = Direction.South;
                    break;
                case Direction.South:
                    rover.direction = Direction.East;
                    break;
                default:
                    rover.direction = Direction.North;
                    break;
            }
            return;
        }

        private void TurnRightCommand(Rover rover)
        {
            switch (rover.direction)
            {
                case Direction.North:
                    rover.direction = Direction.East;
                    break;
                case Direction.East:
                    rover.direction = Direction.South;
                    break;
                case Direction.South:
                    rover.direction = Direction.West;
                    break;
                default:
                    rover.direction = Direction.North;
                    break;
            }

            return;
        }
    }
}
