using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public enum Colour
    {
        Red,
        Green,
        Blue
    }

    public enum Size
    {
        Small,
        Medium,
        Large
    }

    public class Product
    {
        public string Name { get; set; }
        public Colour Colour { get; set; }
        public Size Size { get; set; }

        public Product(string name, Colour colour, Size size)
        {
            this.Name = name;
            this.Colour = colour;
            this.Size = size;
        }
    }
}
