using System;

namespace Shapes3D
{
    public class Prism : Shape
    {
        private double surfaceArea, volume;

        public Prism(double sideLength, int faces, double height)
        {
            double apothem = sideLength / (2 * Math.Tan(Math.PI / faces));
            double baseArea = 0.5 * faces * sideLength * apothem;
            double perimeter = faces * sideLength;

            volume = baseArea * height;
            surfaceArea = 2 * baseArea + perimeter * height;
        }

        public override double SurfaceArea => surfaceArea;
        public override double Volume => volume;
    }
}