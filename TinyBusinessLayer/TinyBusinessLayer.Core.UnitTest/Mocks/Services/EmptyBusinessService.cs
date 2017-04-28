using AutoMapper;
using TinyBusinessLayer.Core.Services;
using TinyBusinessLayer.Core.Services.Interfaces;
using TinyBusinessLayer.Core.UnitTest.Mocks.Interfaces;
using TinyBusinessLayer.Core.UnitTest.Mocks.Models;

namespace TinyBusinessLayer.Core.UnitTest.Mocks.Services
{
    public class EmptyBusinessService
        : BaseBusinessService<IGenericDataRepository<EmptyDataObject, int>, EmptyDataObject, EmptyBusinessObject, int>, IEmptyBusinessService
    {
        public EmptyBusinessService(IMapper mapper, IGenericDataRepository<EmptyDataObject, int> dataRepository) 
            : base(mapper, dataRepository)
        {

        }
    }
}
