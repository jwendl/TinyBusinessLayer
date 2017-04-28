
namespace TinyBusinessLayer.Core.Interfaces
{
    public interface IBusinessObject<TKey>
    {
        TKey Id { get; }
    }
}
