using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public class ColourSpecification : ISpecification<Product>
    {
        private Colour colour;

        public ColourSpecification(Colour colour)
        {
            this.colour = colour;
        }

        public bool IsSatisfied(Product t)
        {
            return this.colour == t.Colour;
        }
    }
}
