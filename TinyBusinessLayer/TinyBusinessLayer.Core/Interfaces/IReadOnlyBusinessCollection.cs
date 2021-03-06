﻿using System.Collections.Generic;
using System.Linq;

namespace TinyBusinessLayer.Core.Interfaces
{
    public interface IReadOnlyBusinessCollection<TBusinessObject, TKey>
        : IBusinessObjectCollection<TBusinessObject, TKey>, IEnumerable<TBusinessObject>, IQueryable<TBusinessObject>
        where TBusinessObject : IBusinessObject<TKey>
    {

    }
}
