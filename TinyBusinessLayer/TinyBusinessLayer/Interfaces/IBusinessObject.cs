
namespace TinyBusinessLayer.Interfaces
{
    /// <summary>
    /// Represents a business object in a generic form.
    /// </summary>
    public interface IBusinessObject
    {
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        int Id { get; }
    }
}
