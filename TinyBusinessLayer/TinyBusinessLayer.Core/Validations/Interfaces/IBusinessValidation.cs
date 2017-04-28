using TinyBusinessLayer.Core.Interfaces;

namespace TinyBusinessLayer.Core.Validations.Interfaces
{
    public interface IBusinessValidation<TBusinessObject, TKey>
        where TBusinessObject : IBusinessObject<TKey>
    {
        void Validate(TBusinessObject item);
    }
}
