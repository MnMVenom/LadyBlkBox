namespace Shapes3D
{
    public class Cuboid : Shape
    {
        protected double width, height, depth;
        private double surfaceArea, volume;

        public Cuboid(double width, double height, double depth)
        {
            this.width = width;
            this.height = height;
            this.depth = depth;

            surfaceArea = 2 * (width * height + width * depth + height * depth);
            volume = width * height * depth;
        }

        public override double SurfaceArea => surfaceArea;
        public override double Volume => volume;
    }
}