using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapesLibrary
{
    public class Square : IShape
    {
        public string Name
        {
            get
            {
                return "Square";
            }
        }

        public double SideLength { get; set; }

        public void Draw()
        {
            Console.WriteLine(
                "____\n" +
                "|  |\n" +
                "|__|\n"
            );
        }

        public double CalculateArea()
        {
            //need more information
            return SideLength * SideLength;
        }
    }


    public class Triangle : IShape
    {
        public string Name { get { return "Triangle"; } }

        public double Height { get; set; }
        public double Width { get; set; }

        public double CalculateArea()
        {
            return (Width * Height) / 2;
        }

        public void Draw()
        {
            Console.WriteLine(
                "  /\\ \n" +
                " /  \\ \n" +
                "/____\\ \n"
            );
        }
    }

    public class Circle : IShape
    {        
        public string Name => "Circle";

        public double Radius { get; set; }

        public double Pi => 3.14;
        public double CalculateArea()
        {
            return Pi * Radius * Radius;
        }

        public void Draw()
        {
            Console.WriteLine("( )");
        }
    }
}