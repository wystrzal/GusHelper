using GusHelper.Models.DataSearchEntitiesResult;
using GusHelperWSDL;
using NUnit.Framework;
using System;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GusHelper.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public async Task Test1()
        {
            UslugaBIRzewnPublClient client = CreateClient();
            ZalogujResponse loginResult = await Login(client);
            SetSid(client, loginResult.ZalogujResult);

            var res = await client.DaneSzukajPodmiotyAsync(new ParametryWyszukiwania { Nipy = "8992689516,5261040828" });

            StringReader stringReader = new(res.DaneSzukajPodmiotyResult);
            XmlSerializer serializer = new(typeof(SearchEntityRoot));
            SearchEntityRoot dataSearchEntities = serializer.Deserialize(stringReader) as SearchEntityRoot;

            var xx = dataSearchEntities.Results.FirstOrDefault().BusinessEndDate;

            var res2 = await client.DanePobierzPelnyRaportAsync(dataSearchEntities.Results.FirstOrDefault().Regon, "BIR11OsPrawna");

            await Logout(client, loginResult);
        }

        private UslugaBIRzewnPublClient CreateClient()
        {
            var myBinding = new WSHttpBinding();
            myBinding.Security.Mode = SecurityMode.Transport;
            myBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
            myBinding.MessageEncoding = WSMessageEncoding.Mtom;
            var endpotinAddress = new EndpointAddress("https://wyszukiwarkaregontest.stat.gov.pl/wsBIR/UslugaBIRzewnPubl.svc");
            var client = new UslugaBIRzewnPublClient(myBinding, endpotinAddress);
            client.Open();
            return client;
        }

        private static async Task<ZalogujResponse> Login(UslugaBIRzewnPublClient client)
        {
            ZalogujResponse loginResult = await client.ZalogujAsync("abcde12345abcde12345");
            if (loginResult == null || loginResult.ZalogujResult == null)
            {
                throw new Exception("Null SID.");
            }
            return loginResult;
        }

        private static void SetSid(UslugaBIRzewnPublClient client, string sid)
        {
            _ = new OperationContextScope(client.InnerChannel);
            HttpRequestMessageProperty reqProps = new();
            reqProps.Headers.Add("sid", sid);
            OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = reqProps;
        }

        private static async Task Logout(UslugaBIRzewnPublClient client, ZalogujResponse loginResult)
        {
            var logoutResult = await client.WylogujAsync(loginResult.ZalogujResult);
            if (!logoutResult.WylogujResult)
            {
                throw new Exception("Logout failed.");
            }
        }
    }
}