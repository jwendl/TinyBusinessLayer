using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TinyBusinessLayer.Core.Interfaces;
using TinyBusinessLayer.Core.Specifications.Interfaces;

namespace TinyBusinessLayer.Core
{
    public class BaseBusinessObjectCollection<TBusinessObject, TKey>
        : IEnumerable<TBusinessObject>, IQueryable<TBusinessObject>, IBusinessObjectCollection<TBusinessObject, TKey>
        where TBusinessObject : IBusinessObject<TKey>
    {
        protected IEnumerable<ISpecification<BaseBusinessObjectCollection<TBusinessObject, TKey>, TBusinessObject, TKey>> Specifications { get; set; }

        public IEnumerator<TBusinessObject> GetEnumerator()
        {
            // TODO: finish implementing this
            return new List<TBusinessObject>().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Type ElementType
        {
            get { return typeof(TBusinessObject); }
        }

        public Expression Expression
        {
            get
            {
                var queryable = this as IQueryable<TBusinessObject>;
                return queryable.Expression;
            }
        }

        public IQueryProvider Provider
        {
            get
            {
                var queryable = this as IQueryable<TBusinessObject>;
                return queryable.Provider;
            }
        }
    }
}
