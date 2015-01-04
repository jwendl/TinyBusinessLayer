using TinyBusinessLayer.Interfaces;

namespace TinyBusinessLayer.Validations.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IBusinessValidation<TBusinessObject>
        where TBusinessObject : IBusinessObject
    {
        /// <summary>
        /// Validates the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        void Validate(TBusinessObject item);
    }
}
