using TinyBusinessLayer.Interfaces;

namespace TinyBusinessLayer.Specification.Interfaces
{
    /// <summary>
    /// Represents a specification.
    /// </summary>
    /// <typeparam name="TBusinessObjectCollection">The type of the business object collection.</typeparam>
    /// <typeparam name="TBusinessObject">The type of the business object.</typeparam>
    public interface ISpecification<TBusinessObjectCollection, TBusinessObject>
        where TBusinessObjectCollection : IBusinessObjectCollection<TBusinessObject>
        where TBusinessObject : IBusinessObject
    {
        /// <summary>
        /// Gets a business object based on the query being passed in.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <returns></returns>
        TBusinessObject SatisfyingFrom(IBusinessObjectCollection<TBusinessObject> query);

        /// <summary>
        /// Gets the list of items that satisfies the query being passed in.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <returns></returns>
        IBusinessObjectCollection<TBusinessObject> SatisfyingObjectsFrom(IBusinessObjectCollection<TBusinessObject> query);
    }
}
