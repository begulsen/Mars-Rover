using System;
using MarsRover.Domain.Enum;
using MarsRover.Domain.Model;

namespace MarsRover.Domain.Service
{
    public interface IPlateauService
    {
        bool CheckIsMoveAvailable(Plateau plateau, Coordinates coordinates, Direction direction);
    }

    public class PlateauService : IPlateauService
    {
        private const int PlaneLowerBound = 0;

        public bool CheckIsMoveAvailable(Plateau plateau, Coordinates coordinates, Direction direction)
        {
            bool xFlag = CheckXCanMoveOneStep(plateau, coordinates, direction);
            bool yFlag = CheckYCanMoveOneStep(plateau, coordinates, direction);
            return xFlag && yFlag;
        }

        private bool CheckXCanMoveOneStep(Plateau plateau, Coordinates coordinates, Direction direction)
        {
            Boolean xFlag = true;
            if (direction == Direction.East)
            {
                xFlag = coordinates.xCoordinate >= PlaneLowerBound && coordinates.xCoordinate < plateau.xPlane;
            }
            else if (direction == Direction.West)
            {
                xFlag = coordinates.xCoordinate > PlaneLowerBound;
            }
            return xFlag;
        }

        private bool CheckYCanMoveOneStep(Plateau plateau, Coordinates coordinates, Direction direction)
        {
            Boolean yFlag = true;
            if (direction == Direction.North)
            {
                yFlag = coordinates.yCoordinate >= PlaneLowerBound && coordinates.yCoordinate < plateau.yPlane;
            }
            else if (direction == Direction.South)
            {
                yFlag = coordinates.yCoordinate > PlaneLowerBound;
            }
            return yFlag;
        }
    }
}
