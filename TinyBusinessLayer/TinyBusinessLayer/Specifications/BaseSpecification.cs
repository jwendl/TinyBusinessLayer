using System;
using System.Linq;
using System.Linq.Expressions;
using TinyBusinessLayer.Interfaces;
using TinyBusinessLayer.Specifications.Interfaces;

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
        /// Gets a business object based on the query being passed in.
        /// </summary>
        /// <param name="items">The list of business object items.</param>
        /// <returns></returns>
        public virtual TBusinessObject ItemMatched(IBusinessObjectCollection<TBusinessObject> items)
        {
            return items.Where(Predicate).SingleOrDefault();
        }

        /// <summary>
        /// Gets the list of items that satisfies the query being passed in.
        /// </summary>
        /// <param name="items">The list of business object items.</param>
        /// <returns></returns>
        public virtual IBusinessObjectCollection<TBusinessObject> ItemsMatched(IBusinessObjectCollection<TBusinessObject> items)
        {
            return items.Where(Predicate).AsEnumerable() as IBusinessObjectCollection<TBusinessObject>;
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
