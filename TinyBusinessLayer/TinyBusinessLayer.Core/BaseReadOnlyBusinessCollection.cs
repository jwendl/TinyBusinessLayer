using TinyBusinessLayer.Core.Interfaces;

namespace TinyBusinessLayer.Core
{
    public abstract class BaseReadOnlyBusinessCollection<TBusinessObject, TKey>
        : BaseBusinessObjectCollection<TBusinessObject, TKey>, IReadOnlyBusinessCollection<TBusinessObject, TKey>
        where TBusinessObject : IBusinessObject<TKey>
    {

    }
}