using TinyBusinessLayer.Interfaces;

namespace TinyBusinessLayer.Modifications.Interfaces
{
    /// <summary>
    /// Handles rules that will modify properties on the business object.
    /// </summary>
    /// <typeparam name="TBusinessObject">The type of the business object.</typeparam>
    public interface IBusinessModification<TBusinessObject>
        where TBusinessObject : IBusinessObject
    {
        /// <summary>
        /// Executes the modification on the specified business object.
        /// </summary>
        /// <param name="item">The item.</param>
        void Execute(TBusinessObject item);
    }
}
