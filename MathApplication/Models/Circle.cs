using MathApplication.Models.Interfaces;
using MathApplication.Helpers;
using System.Diagnostics;

namespace MathApplication.Models
{
    internal class Circle: Shape
    {
        public Circle(double radius):base(nameof(Circle))
        {
            this.Area = Constants.Pi * radius * radius;
            this.Perimetr = 2 * Constants.Pi * radius;
        }
        
    }
}
