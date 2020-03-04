using System;

namespace Shapes.Models
{
    public class Sphere
    {
        public Circle Face { get; set; }
        public Sphere(Circle diameter)
        {
            Face = diameter;
        }

        public double GetVolume()
        {
            int radius = (Face.Diameter / 2);
            return Math.Round((4 * Math.PI * Math.Pow(radius, 3) / 3), 2);
        }

        public double GetSurfaceArea()
        {
            int radius = (Face.Diameter / 2);
            return Math.Round(4 * Math.PI * Math.Pow(radius, 2), 2);
        }
    }
}