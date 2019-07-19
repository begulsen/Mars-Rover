using System;
using MarsRover.Domain.Enum;

namespace MarsRover.Domain.Model
{
    interface IRover
    {
        Plateau plateau
        {
            get;
            set;
        }

        Direction direction
        {
            get;
            set;
        }

        Coordinates coordinates
        {
            get;
            set;
        }
    }

    public class Rover : IRover
    {
        private Plateau _plateau;
        private Direction _direction;
        private Coordinates _coordinates;

        public Rover(Plateau plateau, Direction direction, Coordinates coordinates)
        {
            _plateau = plateau;
            _direction = direction;
            _coordinates = coordinates;
        }

        public Plateau plateau
        {
            get { return _plateau; }

            set { _plateau = value; }
        }

        public Coordinates coordinates
        {
            get { return _coordinates; }

            set { _coordinates = value; }
        }

        public Direction direction
        {
            get { return _direction; }

            set { _direction = value; }
        }
    }
}
