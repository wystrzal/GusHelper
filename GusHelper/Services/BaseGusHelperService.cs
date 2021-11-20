using GusHelperWSDL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace GusHelper.Services
{
    public abstract class BaseGusHelperService
    {
        private readonly string key;
        private readonly bool production;

        public BaseGusHelperService(string key, bool production = true)
        {
            this.key = key;
            this.production = production;
        }

        protected UslugaBIRzewnPublClient CreateClient()
        {
            var myBinding = new WSHttpBinding();
            myBinding.Security.Mode = SecurityMode.Transport;
            myBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
            myBinding.MessageEncoding = WSMessageEncoding.Mtom;
            EndpointAddress endpointAddress;
            if (production)
            {
                endpointAddress = new EndpointAddress("https://wyszukiwarkaregon.stat.gov.pl/wsBIR/UslugaBIRzewnPubl.svc");
            }
            else
            {
                endpointAddress = new EndpointAddress("https://wyszukiwarkaregontest.stat.gov.pl/wsBIR/UslugaBIRzewnPubl.svc");
            }
            var client = new UslugaBIRzewnPublClient(myBinding, endpointAddress);
            client.Open();
            return client;
        }

        protected async Task<ZalogujResponse> Login(UslugaBIRzewnPublClient client)
        {
            ZalogujResponse loginResult = await client.ZalogujAsync(key);
            if (loginResult == null || loginResult.ZalogujResult == null)
            {
                throw new Exception("Null SID.");
            }
            return loginResult;
        }

        protected static void SetSid(UslugaBIRzewnPublClient client, string sid)
        {
            _ = new OperationContextScope(client.InnerChannel);
            HttpRequestMessageProperty reqProps = new();
            reqProps.Headers.Add("sid", sid);
            OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = reqProps;
        }

        protected static async Task Logout(UslugaBIRzewnPublClient client, ZalogujResponse loginResult)
        {
            var logoutResult = await client.WylogujAsync(loginResult.ZalogujResult);
            if (!logoutResult.WylogujResult)
            {
                throw new Exception("Logout failed.");
            }
        }
    }
}
