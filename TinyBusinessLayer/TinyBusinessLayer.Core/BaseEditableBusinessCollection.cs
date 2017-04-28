using TinyBusinessLayer.Core.Interfaces;

namespace TinyBusinessLayer.Core
{
    public abstract class BaseEditableBusinessCollection<TBusinessObject, TKey>
        : BaseBusinessObjectCollection<TBusinessObject, TKey>, IEditableBusinessCollection<TBusinessObject, TKey>
        where TBusinessObject : IBusinessObject<TKey>
    {

    }
}