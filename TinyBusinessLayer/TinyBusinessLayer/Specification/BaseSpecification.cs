using System;
using System.Linq;
using System.Linq.Expressions;
using TinyBusinessLayer.Interfaces;
using TinyBusinessLayer.Specification.Interfaces;

namespace TinyBusinessLayer.Specification
{
    /// <summary>
    /// A base specification object for callers to use.
    /// </summary>
    /// <typeparam name="TBusinessObjectCollection">The type of the business object collection.</typeparam>
    /// <typeparam name="TBusinessObject">The type of the business object.</typeparam>
    public abstract class BaseSpecification<TBusinessObjectCollection, TBusinessObject>
        : ISpecification<IBusinessObjectCollection<TBusinessObject>, TBusinessObject>
        where TBusinessObjectCollection : IBusinessObjectCollection<TBusinessObject>
        where TBusinessObject : IBusinessObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseSpecification{TBusinessObjectCollection, TBusinessObject}"/> class.
        /// </summary>
        protected BaseSpecification(Expression<Func<TBusinessObject, bool>> predicate)
        {
            this.Predicate = predicate;
        }

        /// <summary>
        /// Gets one item or returns null based on the predicate.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <returns></returns>
        public virtual TBusinessObject SatisfyingFrom(IBusinessObjectCollection<TBusinessObject> query)
        {
            return query.Where(Predicate).SingleOrDefault();
        }

        /// <summary>
        /// Gets the <seealso cref="IBusinessObjectCollection{TBusinessObject}"/> based on the predicate.s
        /// </summary>
        /// <param name="query">The query.</param>
        /// <returns></returns>
        public virtual IBusinessObjectCollection<TBusinessObject> SatisfyingObjectsFrom(IBusinessObjectCollection<TBusinessObject> query)
        {
            return query.Where(Predicate).AsEnumerable() as IBusinessObjectCollection<TBusinessObject>;
        }

        /// <summary>
        /// Gets or sets the predicate.
        /// </summary>
        /// <value>
        /// The predicate.
        /// </value>
        public Expression<Func<TBusinessObject, bool>> Predicate { get; set; }
    }
}
