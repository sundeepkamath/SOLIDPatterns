using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public class ProductFilter
    {
        public IList<Product> FilterByColour(IList<Product> products, Colour colour)
        {
            return products.Where(p => p.Colour == colour).ToList<Product>();
        }

        public IList<Product> FilterBySize(IList<Product> products, Size size)
        {
            return products.Where(p => p.Size == size).ToList<Product>();
        }

        public IList<Product> FilterByColourAndSize(IList<Product> products, Colour colour, Size size)
        {
            return products.Where(p => p.Colour == colour && p.Size == size).ToList<Product>();
        }
    }
}
