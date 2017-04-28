using TinyBusinessLayer.Core.Interfaces;

namespace TinyBusinessLayer.Core.Specifications.Interfaces
{
    public interface ISpecification<TBusinessObjectCollection, TBusinessObject, TKey>
        where TBusinessObjectCollection : IBusinessObjectCollection<TBusinessObject, TKey>
        where TBusinessObject : IBusinessObject<TKey>
    {
        TBusinessObject ItemMatched(IBusinessObjectCollection<TBusinessObject, TKey> items);

        IBusinessObjectCollection<TBusinessObject, TKey> ItemsMatched(IBusinessObjectCollection<TBusinessObject, TKey> items);
    }
}
