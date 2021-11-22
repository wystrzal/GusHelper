using FluentAssertions;
using GusHelperWSDL;
using NUnit.Framework;
using System;
using System.IO;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GusHelper.Test
{
    public class BaseTest
    {
        [Test]
        public void ClientShouldNotBeNull()
        {
            var client = CreateClient();
            client.Should().NotBeNull();
        }

        [Test]
        public async Task LoginResponseShouldNotBeNull()
        {
            var client = CreateClient();
            var loginResponse = await Login(client);
            loginResponse.Should().NotBeNull();
        }

        [Test]
        public async Task LogoutShouldPass()
        {
            var client = CreateClient();
            var loginResponse = await Login(client);
            SetSid(client, loginResponse.ZalogujResult);
            await Logout(client, loginResponse);
        }

        protected UslugaBIRzewnPublClient CreateClient()
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

        protected static async Task<ZalogujResponse> Login(UslugaBIRzewnPublClient client)
        {
            ZalogujResponse loginResult = await client.ZalogujAsync("abcde12345abcde12345");
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

        protected object DeserializeResult(string result, Type deserializeTo)
        {
            StringReader stringReader = new(result);
            XmlSerializer serializer = new(deserializeTo);
            return serializer.Deserialize(stringReader);
        }
    }
}
