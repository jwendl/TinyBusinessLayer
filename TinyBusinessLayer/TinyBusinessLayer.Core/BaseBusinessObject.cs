using TinyBusinessLayer.Core.Interfaces;

namespace TinyBusinessLayer.Core
{
    public abstract class BaseBusinessObject<TBusinessObject, TKey>
        : IBusinessObject<TKey>
        where TBusinessObject : IBusinessObject<TKey>
    {
        public TKey Id { get; set; }
    }
}
