using System;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static int Area(Rectangle rectangle) => rectangle.Width * rectangle.Height; 
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(3, 4);
            Console.WriteLine($"Area of rectangle ({rectangle}) is {Area(rectangle)}");

            Rectangle square = new Square();
            square.Width = 4;
            Console.WriteLine($"Area of square ({square}) is {Area(square)}");
        }
    }
}
