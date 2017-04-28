using TinyBusinessLayer.Core.Services.Interfaces;
using TinyBusinessLayer.Core.UnitTest.Mocks.Models;

namespace TinyBusinessLayer.Core.UnitTest.Mocks.Interfaces
{
    public interface IEmptyBusinessService
        : IBaseBusinessService<IGenericDataRepository<EmptyDataObject, int>, EmptyDataObject, EmptyBusinessObject, int>
    {
    }
}
