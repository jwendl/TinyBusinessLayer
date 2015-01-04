using System.Collections.Generic;
using System.Linq;

namespace TinyBusinessLayer.Interfaces
{
    /// <summary>
    /// Represents a list whose items can be modified by external code.
    /// </summary>
    public interface IEditableBusinessCollection<TBusinessObject>
        : IBusinessObjectCollection<TBusinessObject>, IEnumerable<TBusinessObject>, IQueryable<TBusinessObject>
        where TBusinessObject : IBusinessObject
    {

    }
}
