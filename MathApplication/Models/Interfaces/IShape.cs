using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApplication.Models.Interfaces
{
    public interface IShape
    {
        string Name { get; set; }
        double Area { get; set; }
        double Perimetr { get; set; }

    }
}
