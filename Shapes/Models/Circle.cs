namespace Shapes.Models
{
    public class Circle
    {
        public int Diameter { get; set; }

        public Circle(int diameter)
        {
            Diameter = diameter;
        }

        public double GetCircumference()
        {
            return Diameter * 3.14;
        }

        public double GetArea()
        {
            return Diameter * Diameter * 3.14;
        }

    }
}