using MathApplication.Models.Interfaces;
using MathApplication.Helpers;

namespace MathApplication.Models
{
    internal class Quadrilateral: Shape
    {        
        public Quadrilateral(double a, double b, double c, double d):base(nameof(Quadrilateral))
        {
            if (a == b && b==c && c == d)
            {
                this.Name = "Square";
                this.Area = a * a;
                this.Perimetr = a * 4;
            }
            else if(a == c && b == d)
            {
                this.Name = "Rectangle";
                this.Area = a * b;
                this.Perimetr = (a + b) * 2;
            }
        }
    }
}
