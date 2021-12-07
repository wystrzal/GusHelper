using GusHelperWSDL;
using System;
using System.IO;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using System.Xml.Serialization;

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
            myBinding.MaxReceivedMessageSize = 64000000;
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
            if (client == null) throw new NullReferenceException();
            ZalogujResponse loginResult = await client.ZalogujAsync(key);
            if (loginResult == null || loginResult.ZalogujResult == null)
            {
                throw new Exception("Login failed.");
            }
            return loginResult;
        }

        protected static void SetSid(UslugaBIRzewnPublClient client, string sid)
        {
            if (client == null || string.IsNullOrWhiteSpace(sid)) throw new NullReferenceException();
            _ = new OperationContextScope(client.InnerChannel);
            HttpRequestMessageProperty reqProps = new();
            reqProps.Headers.Add("sid", sid);
            OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = reqProps;
        }

        protected static async Task Logout(UslugaBIRzewnPublClient client, ZalogujResponse loginResult)
        {
            if (client == null || loginResult == null) throw new NullReferenceException();
            var logoutResult = await client.WylogujAsync(loginResult.ZalogujResult);
            if (!logoutResult.WylogujResult)
            {
                throw new Exception("Logout failed.");
            }
        }

        protected object DeserializeResult(string result, Type deserializeTo)
        {
            if (string.IsNullOrWhiteSpace(result) || deserializeTo == null) return null;
            StringReader stringReader = new(result);
            XmlSerializer serializer = new(deserializeTo);
            return serializer.Deserialize(stringReader);
        }
    }
}