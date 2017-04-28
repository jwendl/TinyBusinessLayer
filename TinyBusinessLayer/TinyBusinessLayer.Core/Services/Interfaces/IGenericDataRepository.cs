using System.Collections.Generic;
using System.Threading.Tasks;

namespace TinyBusinessLayer.Core.Services.Interfaces
{
    public interface IGenericDataRepository<TDataObject, TKey>
    {
        Task<IEnumerable<TDataObject>> FetchAllAsync();

        Task<TDataObject> FindOneAsync(TKey key);
    }
}
