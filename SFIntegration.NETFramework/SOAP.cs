using SFIntegration.NETFramework.SF;
using System.ServiceModel;
using Task = System.Threading.Tasks.Task;

namespace SFIntegration.NETFramework
{
    public class SOAP
    {
        public async Task Test()
        {
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

            var rq = await queryClient.queryAsync(sessionHeader, null, null, null, "SELECT ID, Name, Players__r.Name	FROM Team__c");

            Team__c team = (Team__c)rq.result.records[0];

            Team__c newTeam = new Team__c
            {

            };

            var ru = await queryClient.createAsync(sessionHeader, null, new MruHeader { updateMru = true }, null, null, null, null, null, null, null, null, null, new sObject[] { newTeam });
        }
    }
}
