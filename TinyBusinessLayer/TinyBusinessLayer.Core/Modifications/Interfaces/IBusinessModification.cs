using TinyBusinessLayer.Core.Interfaces;

namespace TinyBusinessLayer.Core.Modifications.Interfaces
{
    public interface IBusinessModification<TBusinessObject, TKey>
        where TBusinessObject : IBusinessObject<TKey>
    {
        void Execute(TBusinessObject item);
    }
}
