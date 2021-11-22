using GusHelper.Models.DataSearchEntitiesResult;
using GusHelperWSDL;
using System.Linq;
using System.Threading.Tasks;

namespace GusHelper.Services
{
    public sealed class SearchEntityService : BaseGusHelperService
    {
        public SearchEntityService(string key, bool production = true) : base(key, production) { }

        public async Task<SearchEntity> SearchEntityByNip(string nip)
        {
            UslugaBIRzewnPublClient client = CreateClient();
            ZalogujResponse loginResult = await Login(client);
            SetSid(client, loginResult.ZalogujResult);
            var result = await client.DaneSzukajPodmiotyAsync(new ParametryWyszukiwania { Nip = nip });
            if (string.IsNullOrEmpty(result.DaneSzukajPodmiotyResult)) return null;
            var searchEntityRoot = DeserializeResult(result.DaneSzukajPodmiotyResult, typeof(SearchEntityRoot)) as SearchEntityRoot;
            await Logout(client, loginResult);
            return searchEntityRoot?.Results.FirstOrDefault();
        }

        public async Task<SearchEntity> SearchEntityByNip(string nip, UslugaBIRzewnPublClient client)
        {
            var result = await client.DaneSzukajPodmiotyAsync(new ParametryWyszukiwania { Nip = nip });
            if (string.IsNullOrEmpty(result.DaneSzukajPodmiotyResult)) return null;
            var searchEntityRoot = DeserializeResult(result.DaneSzukajPodmiotyResult, typeof(SearchEntityRoot)) as SearchEntityRoot;
            return searchEntityRoot?.Results.FirstOrDefault();
        }
    }
}