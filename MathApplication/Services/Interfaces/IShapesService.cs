using MathApplication.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApplication.Services.Interfaces
{
    public interface IShapesService
    {
        void Add(IShape shape);
        ICollection<IShape> Get();
        ICollection<IShape> GetOrderedByPerimetr();
        ICollection<IShape> GetOrderedByArea();
        void ExportToJson();

    }
}
