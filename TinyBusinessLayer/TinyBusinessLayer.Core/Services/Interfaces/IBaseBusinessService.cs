using System.Collections.Generic;
using System.Threading.Tasks;

namespace TinyBusinessLayer.Core.Services.Interfaces
{
    public interface IBaseBusinessService<TDataAccessRepository, TDataObject, TBusinessObject, TKey>
    {
        Task<IEnumerable<TBusinessObject>> FetchAllAsync();

        Task<TBusinessObject> FindOneAsync(TKey key);
    }
}
