using System;
using System.ServiceModel;
using SF;

namespace SFIntegration
{
    class Program
    {
        static async void Main(string[] args)
        {
            EndpointAddress endpointAddress = new EndpointAddress("");

            SoapClient soapClient = new SoapClient();

            var loginResponse = await soapClient.loginAsync(new LoginScopeHeader(), 
                                                            "jakubs.stepien.90@gmail.com", 
                                                            "!HalaMadrid@20197uAFwMrL7g23pNrQ6sqrNzMd");


        }
    }
}
