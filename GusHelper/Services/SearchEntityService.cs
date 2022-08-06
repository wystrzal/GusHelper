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

        public async Task<SearchEntity> SearchEntity(string searchParameter, UslugaBIRzewnPublClient client)
        {
            if (string.IsNullOrEmpty(searchParameter)) return null;
	
            var parametryWyszukiwania = new ParametryWyszukiwania();
            if (searchParameter.Length == 9) parametryWyszukiwania.Regony9zn = searchParameter;
            else if (searchParameter.Length == 14) parametryWyszukiwania.Regony14zn = searchParameter;
            else if (searchParameter.Length == 10) parametryWyszukiwania.Nip = searchParameter;

            var result = await client.DaneSzukajPodmiotyAsync(parametryWyszukiwania);
            if (string.IsNullOrEmpty(result.DaneSzukajPodmiotyResult)) return null;
            var searchEntityRoot = DeserializeResult(result.DaneSzukajPodmiotyResult, typeof(SearchEntityRoot)) as SearchEntityRoot;
            return searchEntityRoot?.Results.FirstOrDefault();
        }
    }
}