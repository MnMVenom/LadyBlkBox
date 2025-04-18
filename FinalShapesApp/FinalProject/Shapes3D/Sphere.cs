using System;

namespace Shapes3D
{
    public class Sphere : Shape
    {
        private double surfaceArea, volume;

        public Sphere(double radius)
        {
            surfaceArea = 4 * Math.PI * radius * radius;
            volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        }

        public override double SurfaceArea => surfaceArea;
        public override double Volume => volume;
    }
}