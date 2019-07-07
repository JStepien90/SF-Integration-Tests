using SFIntegration.NETFramework.SF;
using System.ServiceModel;
using Task = System.Threading.Tasks.Task;

namespace SFIntegration.NETFramework
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //EndpointAddress endpointAddress = new EndpointAddress("");
            
            SoapClient soapClient = new SoapClient("Soap");

            var r = await soapClient.loginAsync(new LoginScopeHeader(),
                                                            "jakubs.stepien.90@gmail.com",
                                                            "!HalaMadrid@20197uAFwMrL7g23pNrQ6sqrNzMd");

            string sUrl = r.result.serverUrl;
            string sessionIds = r.result.sessionId;

            SoapClient queryClient = new SoapClient("Soap", new EndpointAddress(sUrl));

            SessionHeader sessionHeader = new SessionHeader
            {
                sessionId = sessionIds
            };

            QueryOptions queryOptions = new QueryOptions { };

            var rq = await queryClient.queryAsync(sessionHeader, null, null, null, "SELECT ID, Name FROM Team__c");
        }
    }
}
