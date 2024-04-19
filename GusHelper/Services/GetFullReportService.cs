using GusHelper.Models.FullReport;
using GusHelper.Utils;
using GusHelper.ViewModels;
using GusHelperWSDL;
using System.Threading.Tasks;

namespace GusHelper.Services
{
    public sealed class GetFullReportService(string key, bool production = true) : BaseGusHelperService(key, production)
    {
        private readonly SearchEntityService searchEntityService = new(key, production);
        private UslugaBIRzewnPublClient client;

		public async Task<DataOfPersonBusiness> GetFullReport(string searchParameter)
        {
            client = CreateClient();
            var loginResult = await Login(client);
            SetSid(client, loginResult.ZalogujResult);

            var searchEntity = await searchEntityService.SearchEntity(searchParameter, client);
            if (searchEntity == null || string.IsNullOrWhiteSpace(searchEntity.Type)) return null;

            var data = new DataOfPersonBusiness();
            if (searchEntity.Type == "P") await GetLegalPersonData(data, searchEntity.Regon);
            if (searchEntity.Type == "F") await GetNaturalPersonData(data, searchEntity.Regon, searchEntity.SilosID);

            await Logout(client, loginResult);
            return data;
        }

        private async Task GetNaturalPersonData(DataOfPersonBusiness data, string regon, int silosId)
        {
            if (silosId > 4 || silosId < 1) return;

            switch (silosId)
            {
                case 1:
                    await GetNaturalPersonEconomicBusiness(data, regon);
                    break;
                case 2:
                    await GetNaturalPersonAgriculturalBusiness(data, regon);
                    break;
                case 3:
                    await GetNaturalPersonOtherBusiness(data, regon);
                    break;
                case 4:
                    await GetNaturalPersonDeletedBusinessTo20141108(data, regon);
                    break;
                default:
                    break;
            }

            if (silosId != 4)
            {
                await GetNaturalPersonAll(data, regon);
                await GetNaturalPersonPkd(data, regon);
            }
        }

        private async Task GetNaturalPersonEconomicBusiness(DataOfPersonBusiness data, string regon)
        {
            var naturalPersonData = await DeserializeResult<NaturalPersonEconomicBusinessRoot>(regon, "BIR11OsFizycznaDzialalnoscCeidg");
            if (naturalPersonData.Result == null) return;
            data.DateOfEntryToRegisterOfRecords = naturalPersonData.Result.DateOfEntryToRegisterOfRecords.DateTime;
            data.NumberInRegisterOfRecords = naturalPersonData.Result.NumberInRegisterOfRecords;
            data.BusinessTerminationDate = naturalPersonData.Result.BusinessTerminationDate.DateTime;
            NaturalPersonMapper.MapOrganizationData(data, naturalPersonData.Result);
            BasePersonMapper.MapBaseData(data, naturalPersonData.Result);
            BasePersonMapper.MapAddress(data, naturalPersonData.Result);
        }

        private async Task GetNaturalPersonAgriculturalBusiness(DataOfPersonBusiness data, string regon)
        {
            var naturalPersonData = await DeserializeResult<NaturalPersonAgriculturalBusinessRoot>(regon, "BIR11OsFizycznaDzialalnoscRolnicza");
            if (naturalPersonData.Result == null) return;
            data.BusinessTerminationDate = naturalPersonData.Result.BusinessTerminationDate.DateTime;
            BasePersonMapper.MapBaseData(data, naturalPersonData.Result);
            BasePersonMapper.MapAddress(data, naturalPersonData.Result);
        }

        private async Task GetNaturalPersonOtherBusiness(DataOfPersonBusiness data, string regon)
        {
            var naturalPersonData = await DeserializeResult<NaturalPersonOtherBusinessRoot>(regon, "BIR11OsFizycznaDzialalnoscPozostala");
            if (naturalPersonData.Result == null) return;
            data.DateOfEntryToRegisterOfRecords = naturalPersonData.Result.DateOfEntryToRegisterOfRecords.DateTime;
            data.NumberInRegisterOfRecords = naturalPersonData.Result.NumberInRegisterOfRecords;
            data.BusinessTerminationDate = naturalPersonData.Result.BusinessTerminationDate.DateTime;
            NaturalPersonMapper.MapOrganizationData(data, naturalPersonData.Result);
            BasePersonMapper.MapBaseData(data, naturalPersonData.Result);
            BasePersonMapper.MapAddress(data, naturalPersonData.Result);
        }

        private async Task GetNaturalPersonDeletedBusinessTo20141108(DataOfPersonBusiness data, string regon)
        {
            var naturalPersonData = await DeserializeResult<NaturalPersonDeletedBusinessTo20141108Root>(regon, "BIR11OsFizycznaDzialalnoscSkreslonaDo20141108");
            if (naturalPersonData.Result == null) return;
            data.BusinessTerminationDate = naturalPersonData.Result.BusinessTerminationDate.DateTime;
            BasePersonMapper.MapBaseData(data, naturalPersonData.Result);
            BasePersonMapper.MapAddress(data, naturalPersonData.Result);
        }

        private async Task GetNaturalPersonAll(DataOfPersonBusiness data, string regon)
        {
            var naturalPersonData = await DeserializeResult<NaturalPersonAllRoot>(regon, "BIR11OsFizycznaDaneOgolne");
            if (naturalPersonData.Result == null) return;
            NaturalPersonMapper.MapOrganizationData(data, naturalPersonData.Result);
        }

        private async Task GetNaturalPersonPkd(DataOfPersonBusiness data, string regon)
        {
            var pkdResult = await DeserializeResult<NaturalPersonPkdRoot>(regon, "BIR11OsFizycznaPkd");
            if (pkdResult.Results.Count <= 0) return;
            foreach (var pkd in pkdResult.Results)
            {
                data.PkdList.Add(new Pkd { Code = pkd.Code, Name = pkd.Name });
            }
        }

        private async Task GetLegalPersonData(DataOfPersonBusiness data, string regon)
        {
            var legalPersonData = await DeserializeResult<LegalPersonRoot>(regon, "BIR11OsPrawna");
            if (legalPersonData.Result == null) return;
            data.DateOfEntryToRegisterOfRecords = legalPersonData.Result.DateOfEntryToRegisterOfRecords.DateTime;
            data.NumberInRegisterOfRecords = legalPersonData.Result.NumberInRegisterOfRecords;
            data.BusinessTerminationDate = legalPersonData.Result.BusinessTerminationDate.DateTime;
            LegalPersonMapper.MapOrganizationData(data, legalPersonData.Result);
            BasePersonMapper.MapBaseData(data, legalPersonData.Result);
            BasePersonMapper.MapAddress(data, legalPersonData.Result);

            var pkdResult = await DeserializeResult<LegalPersonPkdRoot>(regon, "BIR11OsPrawnaPkd");
            if (pkdResult.Results.Count <= 0) return;
            foreach (var pkd in pkdResult.Results)
            {
                data.PkdList.Add(new Pkd { Code = pkd.Code, Name = pkd.Name });
            }
        }

        private async Task<T> DeserializeResult<T>(string regon, string reportType) where T : class
        {
            var result = await client.DanePobierzPelnyRaportAsync(regon, reportType);
            if (string.IsNullOrWhiteSpace(result.DanePobierzPelnyRaportResult)) return null;
            if (DeserializeResult(result.DanePobierzPelnyRaportResult, typeof(T)) is not T deserializedResult) return null;
            return deserializedResult;
        }
    }
}