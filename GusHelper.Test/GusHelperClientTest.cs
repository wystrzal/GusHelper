using FluentAssertions;
using NUnit.Framework;
using System.Threading.Tasks;

namespace GusHelper.Test
{
    public class GusHelperClientTest
    {
        private GusHelperClient gusHelperClient;

        [SetUp]
        public void SetUp()
        {
            gusHelperClient = new GusHelperClient("abcde12345abcde12345", false);
        }

        [Test]
        public async Task SearchEntityByNipResultShouldNotBeNull()
        {
            var result = await gusHelperClient.SearchEntityByNip("6452521870");
            result.Should().NotBeNull();
        }

        [Test]
        public async Task SearchEntityByNipResultShouldBeNull()
        {
            var result = await gusHelperClient.SearchEntityByNip("");
            result.Should().BeNull();
        }
        
        [Test]
        public async Task GetFullReportResultShouldNotBeNull()
        {
            var result = await gusHelperClient.GetFullReport("6452521870");
            result.Should().NotBeNull();
        }

        [Test]
        public async Task GetFullReportResultShouldBeNull()
        {
            var result = await gusHelperClient.GetFullReport("");
            result.Should().BeNull();
        }
    }
}