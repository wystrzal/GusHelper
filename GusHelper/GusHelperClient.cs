using GusHelper.Models.DataSearchEntitiesResult;
using GusHelper.Services;
using GusHelper.ViewModels;
using System.Threading.Tasks;

namespace GusHelper
{
    public sealed class GusHelperClient
    {
        private readonly GetFullReportService getFullReportService;
        private readonly SearchEntityService searchEntityService;

        public GusHelperClient(string key, bool production = true)
        {
            getFullReportService = new GetFullReportService(key, production);
            searchEntityService = new SearchEntityService(key, production);
        }

        public async Task<DataOfPersonBusiness> GetFullReport(string nip)
        {
            return await getFullReportService.GetFullReport(nip);
        }

        public async Task<SearchEntity> SearchEntityByNip(string nip)
        {
            return await searchEntityService.SearchEntityByNip(nip);
        }
    }
}