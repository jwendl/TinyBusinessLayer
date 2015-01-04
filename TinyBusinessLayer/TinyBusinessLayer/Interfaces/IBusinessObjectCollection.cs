using System.Collections.Generic;
using System.Linq;

namespace TinyBusinessLayer.Interfaces
{
    /// <summary>
    /// Represents a collection of business objects.
    /// </summary>
    /// <typeparam name="TBusinessObject">The type of the business object.</typeparam>
    public interface IBusinessObjectCollection<TBusinessObject>
        : IEnumerable<TBusinessObject>, IQueryable<TBusinessObject>
        where TBusinessObject : IBusinessObject
    {

    }
}
