using System;
using System.Linq;
using TinyBusinessLayer.Core.Interfaces;
using TinyBusinessLayer.Core.Specifications.Interfaces;

namespace TinyBusinessLayer.Core.Specification
{
    public abstract class BaseSpecification<TBusinessObjectCollection, TBusinessObject, TKey>
        : ISpecification<IBusinessObjectCollection<TBusinessObject, TKey>, TBusinessObject, TKey>
        where TBusinessObjectCollection : IBusinessObjectCollection<TBusinessObject, TKey>
        where TBusinessObject : IBusinessObject<TKey>
    {
        protected BaseSpecification(Func<TBusinessObject, bool> predicate)
        {
            Predicate = predicate;
        }

        public virtual TBusinessObject ItemMatched(IBusinessObjectCollection<TBusinessObject, TKey> items)
        {
            return items.Where(Predicate).SingleOrDefault();
        }

        public virtual IBusinessObjectCollection<TBusinessObject, TKey> ItemsMatched(IBusinessObjectCollection<TBusinessObject, TKey> items)
        {
            return items.Where(Predicate).AsEnumerable() as IBusinessObjectCollection<TBusinessObject, TKey>;
        }

        public Func<TBusinessObject, bool> Predicate { get; set; }
    }
}
