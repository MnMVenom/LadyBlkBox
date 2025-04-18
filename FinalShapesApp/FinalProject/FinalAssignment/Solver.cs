using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Shapes3D;

namespace FinalAssignment
{
    public static class Solver
    {
        public static double ProcessFile(string filePath)
        {
            List<Shape> shapes = new List<Shape>();
            double total = 0.0;

            foreach (var line in File.ReadLines(filePath))
            {
                var parts = line.Split(',');

                switch (parts[0].ToLower())
                {
                    case "cube":
                        shapes.Add(new Cube(Parse(parts[1])));
                        break;
                    case "cuboid":
                        shapes.Add(new Cuboid(Parse(parts[1]), Parse(parts[2]), Parse(parts[3])));
                        break;
                    case "cylinder":
                        shapes.Add(new Cylinder(Parse(parts[1]), Parse(parts[2])));
                        break;
                    case "sphere":
                        shapes.Add(new Sphere(Parse(parts[1])));
                        break;
                    case "prism":
                        shapes.Add(new Prism(Parse(parts[1]), int.Parse(parts[2]), Parse(parts[3])));
                        break;
                    case "area":
                    case "volume":
                        double scale = Parse(parts[1]);
                        double sum = 0;

                        foreach (var shape in shapes)
                            sum += (parts[0].ToLower() == "area") ? shape.SurfaceArea : shape.Volume;

                        total += sum * scale;
                        shapes.Clear();
                        break;
                }
            }

            return total;
        }

        private static double Parse(string input)
        {
            return double.Parse(input, CultureInfo.InvariantCulture);
        }
    }
}