using TinyBusinessLayer.Interfaces;

namespace TinyBusinessLayer.Specifications.Interfaces
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
        /// <param name="items">The list of business object items.</param>
        /// <returns></returns>
        TBusinessObject ItemMatched(IBusinessObjectCollection<TBusinessObject> items);

        /// <summary>
        /// Gets the list of items that satisfies the query being passed in.
        /// </summary>
        /// <param name="items">The list of business object items.</param>
        /// <returns></returns>
        IBusinessObjectCollection<TBusinessObject> ItemsMatched(IBusinessObjectCollection<TBusinessObject> items);
    }
}
