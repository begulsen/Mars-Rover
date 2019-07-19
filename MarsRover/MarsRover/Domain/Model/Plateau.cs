using System;
namespace MarsRover.Domain.Model
{
    interface IPlateau
    {
        int xPlane { get; set; }

        int yPlane { get; set; }
    }

    public class Plateau : IPlateau
    {
        private int _xPlane;
        private int _yPlane;

        public Plateau(int xPlaneParam, int yPlaneParam)
        {
            _xPlane = xPlaneParam;
            _yPlane = yPlaneParam;
        }

        public int xPlane
        {
            get { return _xPlane; }

            set { _yPlane = value; }
        }

        public int yPlane
        {
            get { return _yPlane; }

            set { _yPlane = value; }
        }
    }
}
