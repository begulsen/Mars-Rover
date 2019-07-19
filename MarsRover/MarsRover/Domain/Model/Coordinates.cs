using System;
namespace MarsRover.Domain.Model
{
    interface ICoordinates
    {
        int xCoordinate
        {
            get;
            set;
        }

        int yCoordinate
        {
            get;
            set;
        }
    }

    public class Coordinates : ICoordinates
    {
        private int _x;
        private int _y;

        public Coordinates(int xCoordinate , int yCoordinate)
        {
            _x = xCoordinate;
            _y = yCoordinate;
        }

        public int xCoordinate
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }

        public int yCoordinate
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }
    }
}
