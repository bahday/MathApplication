using MathApplication.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApplication.Models
{
    internal class Shape: IShape
    {
        public string Name { get; set; }
        public double Area { get; set; }
        public double Perimetr { get; set; }

        private static int counter = 0;

        public Shape(string name)
        {
            this.Name = name;
            Interlocked.Increment(ref counter);

        }

        ~Shape()
        {
            Interlocked.Decrement(ref counter);
        }

        public static int GetActiveInstances()
        {
            return counter;
        }
    }
}
