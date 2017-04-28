using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using TinyBusinessLayer.Core.Services.Interfaces;

namespace TinyBusinessLayer.Core.Services
{
    public abstract class BaseBusinessService<TDataAccessRepository, TDataObject, TBusinessObject, TKey>
        : IBaseBusinessService<TDataAccessRepository, TDataObject, TBusinessObject, TKey>
        where TDataAccessRepository : IGenericDataRepository<TDataObject, TKey>
    {
        private IMapper Mapper { get; set; }
        private TDataAccessRepository DataRepository { get; set; }

        public BaseBusinessService(IMapper mapper, TDataAccessRepository dataRepository)
        {
            Mapper = mapper;
            DataRepository = dataRepository;
        }

        public virtual async Task<IEnumerable<TBusinessObject>> FetchAllAsync()
        {
            var dataResults = await DataRepository.FetchAllAsync();
            var businessResults = Mapper.Map<IEnumerable<TDataObject>, IEnumerable<TBusinessObject>>(dataResults);
            return businessResults;
        }

        public virtual async Task<TBusinessObject> FindOneAsync(TKey key)
        {
            var dataResults = await DataRepository.FindOneAsync(key);
            var businessResult = Mapper.Map<TDataObject, TBusinessObject>(dataResults);
            return businessResult;
        }
    }
}
