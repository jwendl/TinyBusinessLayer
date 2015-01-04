using System.Collections.Generic;
using System.Linq;

namespace TinyBusinessLayer.Interfaces
{
    /// <summary>
    /// Represents a list of business objects whose items cannot be editable by outside code.
    /// </summary>
    public interface IReadOnlyBusinessCollection<TBusinessObject>
        : IBusinessObjectCollection<TBusinessObject>, IEnumerable<TBusinessObject>, IQueryable<TBusinessObject>
        where TBusinessObject : IBusinessObject
    {

    }
}
