using MathApplication.Models.Interfaces;
using MathApplication.Helpers;
using System.Runtime.CompilerServices;
using System.Drawing;

namespace MathApplication.Models
{
    internal class Triangle : Shape
    {
        public Triangle(double a, double b, double c) : base(nameof(Triangle))
        {
            TriangleType type;
            double baseSide = 0;
            double height = 0;
            this.Perimetr = a + b + c;

            //Equilateral Triangle
            if (a == b && b == c) 
            {
                type = TriangleType.Equilateral;

            }
            else
            //Isosceles Triangle
            if (a == b || b == c || a == c)
            {
                type = TriangleType.Isosceles;
            }
            else
            //Scalene Triangle
            {
                type = TriangleType.Scalene;
              
            }
            switch (type)
            {
                case TriangleType.Equilateral:
                    baseSide = a;
                    height = ((double)Math.Sqrt(3) * a) / 2;
                    break;
                case TriangleType.Isosceles:
                    double side;
                    if (a == b)
                    {
                        baseSide = c;
                        side = a;
                    }
                    else if (a == c)
                    {
                        baseSide = b;
                        side = a;

                    }
                    else
                    {
                        baseSide = a;
                        side = b;
                    }

                    height = (double)Math.Sqrt((double)((side * side) - (baseSide * baseSide) / 4));
                    break;
                case TriangleType.Scalene:
                    baseSide = a;
                    var semiperimetr = this.Perimetr / 2;

                    height = (2 / a) * Math.Sqrt((semiperimetr * (semiperimetr - a) * (semiperimetr - b) * (semiperimetr - c)));
                    break;
            }

            this.Name = $"{Enum.GetName(typeof(TriangleType), type)} {this.Name}";
            this.Area = height * baseSide / 2;
        }
    }
}
