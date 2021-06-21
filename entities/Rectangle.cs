using abstraticb.entities.enums;
using abstraticb.entities;

namespace abstraticb.entities

{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Heigth { get; set; }

        public Rectangle(Color color, double width, double heigth) : base(color)
        {



            Width = width;
            Heigth = heigth;


        }

        public override double Area()
        {
            return Width * Heigth;

        }








    }
}
