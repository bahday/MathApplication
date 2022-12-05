using MathApplication.Models.Interfaces;
using MathApplication.Services.Interfaces;
using System.Collections.ObjectModel;
using System.Text.Json;

namespace MathApplication.Services
{
    public class ShapesService : IShapesService
    {
        Collection<IShape> shapes = new Collection<IShape>();
        public void Add(IShape shape)
        {
            shapes.Add(shape);
        }

        public void ExportToJson()
        {
            //return JsonSerializer.Serialize(shapes);
            Console.WriteLine("Please enter export destination folder");
            var destinationFolder = Console.ReadLine();

            if (!Directory.Exists(destinationFolder))
            {
                Console.WriteLine("Destination folder " + destinationFolder + " doesn't exist");
                return; // or you could loop back and prompt the user again
            }

            var data = JsonSerializer.Serialize(shapes); // put your logic to create the data here

            var destinationPath = Path.Combine(destinationFolder, "shapes_export.json");
            File.WriteAllText(destinationPath, data);
            Console.WriteLine($"Success!Data Exported to Json File {destinationPath}");

        }

        public ICollection<IShape> GetOrderedByPerimetr()
        {
            return shapes.OrderBy(s => s.Perimetr).ToList();
        }
        public ICollection<IShape> GetOrderedByArea()
        {
            return shapes.OrderBy(s => s.Area).ToList();
        }

        public ICollection<IShape> Get()
        {
            return shapes.ToList();
        }
    }
}
