using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenClosedPrinciple
{

    class Program
    {
        static void Main(string[] args)
        {
            Product bicycle = new Product("Raleigh", Colour.Blue, Size.Medium);
            Product motorbike = new Product("Suzuki", Colour.Red, Size.Medium);
            Product car = new Product("Toyota", Colour.Green, Size.Large);

            IList<Product> products = new List<Product>() { bicycle, motorbike, car };

            var filter = new ProductFilter();

            Console.WriteLine("Blue coloured products:");
            foreach (var product in filter.FilterByColour(products, Colour.Blue))
            {
                Console.WriteLine($"- {product.Name}");
            }

            Console.WriteLine("Green coloured Large products:");
            foreach (var product in filter.FilterByColourAndSize(products, Colour.Green, Size.Large))
            {
                Console.WriteLine($"- {product.Name}");
            }

            Console.WriteLine("Green coloured products using improvised filter:");
            var improvised_filter = new ProductFilterImprovised();

            foreach (var product in improvised_filter.Filter(products, new ColourSpecification(Colour.Green)))
            {
                Console.WriteLine($"- {product.Name}");
            }

            Console.WriteLine("Green coloured Large products using improvised filter:");

            foreach (var product in improvised_filter.Filter(products, new AndSpecification<Product>(new ColourSpecification(Colour.Green), new SizeSpecification(Size.Large))))
            {
                Console.WriteLine($"- {product.Name}");
            }
        }
    }
}
