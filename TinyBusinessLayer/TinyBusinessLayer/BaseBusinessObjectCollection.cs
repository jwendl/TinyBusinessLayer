using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TinyBusinessLayer.Interfaces;
using TinyBusinessLayer.Specifications.Interfaces;

namespace TinyBusinessLayer
{
    /// <summary>
    /// 
    /// </summary>
    public class BaseBusinessObjectCollection<TBusinessObject>
        : IEnumerable<TBusinessObject>, IQueryable<TBusinessObject>, IBusinessObjectCollection<TBusinessObject>
        where TBusinessObject : IBusinessObject
    {
        /// <summary>
        /// Gets or sets the specifications.
        /// </summary>
        /// <value>
        /// The specifications.
        /// </value>
        protected IEnumerable<ISpecification<BaseBusinessObjectCollection<TBusinessObject>, TBusinessObject>> Specifications { get; set; }

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>
        /// A <see cref="T:IEnumerator&lt;TBusinessObject&gt;" /> that can be used to iterate through the collection.
        /// </returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public IEnumerator<TBusinessObject> GetEnumerator()
        {
            // TODO: finish implementing this
            return new List<TBusinessObject>().GetEnumerator();
        }

        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>
        /// An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.
        /// </returns>
        /// <exception cref="System.NotImplementedException"></exception>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Gets the type of the element(s) that are returned when the expression tree associated with this instance of <see cref="T:System.Linq.IQueryable" /> is executed.
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public Type ElementType
        {
            get { return typeof(TBusinessObject); }
        }

        /// <summary>
        /// Gets the expression tree that is associated with the instance of <see cref="T:System.Linq.IQueryable" />.
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public Expression Expression
        {
            get
            {
                var query = new EnumerableQuery<TBusinessObject>(this);
                return query.AsQueryable().Expression;
            }
        }

        /// <summary>
        /// Gets the query provider that is associated with this data source.
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public IQueryProvider Provider
        {
            get
            {
                var query = new EnumerableQuery<TBusinessObject>(this);
                return query.AsQueryable().Provider;
            }
        }
    }
}
