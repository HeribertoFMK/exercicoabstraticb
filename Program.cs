using System;
using abstraticb.entities.enums;
using abstraticb.entities;
using System.Globalization;
using System.Collections.Generic;



namespace abstraticb
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Shape> list = new List<Shape>();

            System.Console.WriteLine("Enter the number of shapes: ");
            int N = int.Parse(Console.ReadLine());


            for (int i = 1; i <= N; i++)
            {


                System.Console.WriteLine($"Shape #{i} data:");
                System.Console.Write("Rectangle or Circle (r/c)? ");
                char x = char.Parse(Console.ReadLine());
                System.Console.Write("Color (Black/Blue/Red):");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (x == 'r')
                {

                    System.Console.WriteLine("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    System.Console.WriteLine("Height:");
                    double heigth = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Rectangle(color, width, heigth));

                }
                else if (x == 'c')
                {

                    System.Console.WriteLine(" Radius:");
                    double radium = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Circle(color, radium));

                }
            }

            System.Console.WriteLine("SHAPE AREAS:");
            foreach (Shape shape in list)
            {

                System.Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));



            }


        }
    }
}
