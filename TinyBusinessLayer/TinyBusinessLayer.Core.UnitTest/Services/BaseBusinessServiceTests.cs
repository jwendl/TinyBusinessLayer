using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Threading.Tasks;
using TinyBusinessLayer.Core.UnitTest.Mocks.Interfaces;
using TinyBusinessLayer.Core.UnitTest.Mocks.Models;

namespace TinyBusinessLayer.Core.UnitTest.Services
{
    [TestClass]
    public class BaseBusinessServiceTests
        : BaseBusinessTest
    {
        [TestMethod]
        public async Task BaseBusinessService_FetchAllAsync_HappyPath()
        {
            var emptyBusinessService = ServiceProvider.GetService<IEmptyBusinessService>();
            var businessResults = await emptyBusinessService.FetchAllAsync();

            Assert.AreEqual(10, businessResults.Count());
            Assert.AreEqual(typeof(EmptyBusinessObject), businessResults.First().GetType());
        }
    }
}
