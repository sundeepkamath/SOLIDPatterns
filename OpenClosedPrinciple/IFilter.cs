﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public interface IFilter<T>
    {
        IList<T> Filter(IList<T> items, ISpecification<T> spec);
    }
}
