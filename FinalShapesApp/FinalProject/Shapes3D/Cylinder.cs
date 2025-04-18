using System;

namespace Shapes3D
{
    public class Cylinder : Shape
    {
        private double surfaceArea, volume;

        public Cylinder(double radius, double height)
        {
            surfaceArea = 2 * Math.PI * radius * (radius + height);
            volume = Math.PI * radius * radius * height;
        }

        public override double SurfaceArea => surfaceArea;
        public override double Volume => volume;
    }
}