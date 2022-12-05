// See https://aka.ms/new-console-template for more information
using MathApplication.Models;
using MathApplication.Models.Interfaces;
using MathApplication.Services;
using MathApplication.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

class Program
{
    static void Main(string[] args)
    {
        //setup our DI
        var serviceProvider = new ServiceCollection()
            .AddSingleton<IShapesService, ShapesService>()
            .BuildServiceProvider();

        var shapesService = serviceProvider.GetService<IShapesService>();

        //init data
        shapesService.Add(new Circle(1));
        shapesService.Add(new Triangle(5, 5, 5));
        shapesService.Add(new Triangle(12, 12, 5));
        shapesService.Add(new Triangle(6, 4, 8));
        shapesService.Add(new Quadrilateral(2, 4, 2, 4));
        shapesService.Add(new Quadrilateral(4, 4, 4, 4));

        shapesService.Get().ToList().ForEach(shape =>
        {
            Console.WriteLine($"Name: { shape.Name }, Perimeter:{ shape.Perimetr } , Area: {shape.Area}");
        });

        //example get sorted shapes
        var orderedByPerimetr = shapesService.GetOrderedByPerimetr();
        var orderedByArea = shapesService.GetOrderedByArea();
        Console.WriteLine($"Total shape instances:{Shape.GetActiveInstances()}");
        //export
        shapesService.ExportToJson();

    }
}




