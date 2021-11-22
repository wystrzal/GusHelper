using FluentAssertions;
using GusHelper.Services;
using NUnit.Framework;
using System.Threading.Tasks;

namespace GusHelper.Test
{
    public class SearchEntityServiceTest : BaseTest
    {
        private SearchEntityService searchEntityService;

        [SetUp]
        public void Setup()
        {
            searchEntityService = new SearchEntityService("abcde12345abcde12345", false);
        }

        [Test]
        public async Task SearchEntityResultShouldNotBeNull()
        {
            var result = await searchEntityService.SearchEntityByNip("6452521870");
            result.Should().NotBeNull();
        }

        [Test]
        public async Task SearchEntityResultShouldBeNull()
        {
            var result = await searchEntityService.SearchEntityByNip("");
            result.Should().BeNull();
        }

        [Test]
        public async Task SearchEntityWithClientResultShouldNotBeNull()
        {
            var client = CreateClient();
            var login = await Login(client);
            SetSid(client, login.ZalogujResult);
            var result = await searchEntityService.SearchEntityByNip("6452521870", client);
            result.Should().NotBeNull();
        }
    }
}