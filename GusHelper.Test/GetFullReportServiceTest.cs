using FluentAssertions;
using GusHelper.Services;
using NUnit.Framework;
using System.Threading.Tasks;

namespace GusHelper.Test
{
    public class GetFullReportServiceTest : BaseTest
    {
        private GetFullReportService getFullReportService;

        [SetUp]
        public void SetUp()
        {
            getFullReportService = new GetFullReportService("abcde12345abcde12345", false);
        }

        [Test]
        public async Task LegalPersonShouldBeFound()
        {
            var data = await getFullReportService.GetFullReport("6452521870");
            data.Regon9.Should().NotBeNullOrWhiteSpace();
            data.Name.Should().NotBeNullOrWhiteSpace();
            data.PkdList.Count.Should().BeGreaterThan(0);
            data.OrganizationData.Should().NotBeNull();
            data.OrganizationData.BasicLegalForm.Should().NotBeNull();
        }

        [Test]
        public async Task LegalPersonShouldNotBeFound()
        {
            var data = await getFullReportService.GetFullReport("");
            data.Should().BeNull();
        }
    }
}