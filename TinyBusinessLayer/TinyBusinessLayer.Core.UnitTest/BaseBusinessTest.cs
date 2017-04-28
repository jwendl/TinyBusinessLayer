using AutoMapper;
using Bogus;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System;
using TinyBusinessLayer.Core.Services.Interfaces;
using TinyBusinessLayer.Core.UnitTest.Mocks.Interfaces;
using TinyBusinessLayer.Core.UnitTest.Mocks.Models;
using TinyBusinessLayer.Core.UnitTest.Mocks.Services;

namespace TinyBusinessLayer.Core.UnitTest
{
    [TestClass]
    public class BaseBusinessTest
    {
        protected IServiceProvider ServiceProvider { get; set; }

        [TestInitialize]
        public void TestInitialize()
        {
            var serviceCollection = new ServiceCollection();

            var results = new Faker<EmptyDataObject>()
                .RuleFor(edo => edo.Id, f => f.IndexVariable)
                .Generate(10);

            var mockDataRepository = Substitute.For<IGenericDataRepository<EmptyDataObject, int>>();
            mockDataRepository.FetchAllAsync().Returns(results);

            serviceCollection.AddSingleton(mockDataRepository);
            serviceCollection.AddSingleton<IEmptyBusinessService, EmptyBusinessService>();

            // Automapper DI implementation
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EmptyDataObject, EmptyBusinessObject>();
            });

            var mapper = config.CreateMapper();
            serviceCollection.AddSingleton(mapper);
            serviceCollection.AddSingleton(s => config.CreateMapper());

            ServiceProvider = serviceCollection.BuildServiceProvider();
        }
    }
}
