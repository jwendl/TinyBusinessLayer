using TinyBusinessLayer.Interfaces;

namespace TinyBusinessLayer
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseBusinessObject<TBusinessObject>
        : IBusinessObject
        where TBusinessObject : IBusinessObject
    {
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }
    }
}
