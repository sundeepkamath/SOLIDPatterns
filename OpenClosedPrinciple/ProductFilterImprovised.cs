using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public class ProductFilterImprovised : IFilter<Product>
    {
        public IList<Product> Filter(IList<Product> items, ISpecification<Product> spec)
        {
            return items.Where<Product>(p => spec.IsSatisfied(p)).ToList<Product>();
        }
    }
}
