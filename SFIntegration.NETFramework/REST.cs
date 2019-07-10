using Salesforce.Common;
using Salesforce.Common.Models.Json;
using Salesforce.Common.Models.Xml;
using Salesforce.Force;
using System;
using System.Collections.Generic;
using Task = System.Threading.Tasks.Task;

namespace SFIntegration.NETFramework
{
    public class REST
    {
        public async Task Test()
        {
            using (var auth = new AuthenticationClient())
            {
                await auth.UsernamePasswordAsync("3MVG96_7YM2sI9wQEuGYr2dV41ANxFem_XLDBd5Dn8ixAvm8AslaHNoNMUFJI218vqYQDMdCAMFUg_zzFWQJE",
                                                 "7D4690EC731EF30143F64D3469AA907011256023ADC41241178B87CF899F02F4",
                                                 "giiriu@gmail.com",
                                                 "!HalaMadrid@2019stfEr80kdHLR4Nu21RlXtECl");



                using (var forceClient = new ForceClient(auth.InstanceUrl, auth.AccessToken, auth.ApiVersion))
                {
                    var result = await forceClient.QueryAsync<PurchaseOrder>("SELECT Name FROM Purchase_Order__c");

                    var uploadResult = await forceClient.CreateAsync("Purchase_Order__c", new PurchaseOrder
                    {
                        Id = "a062p00001rJSBLAA4",
                        Name = "UpsertTest"
                    });

                    var uploadBatchResult = await forceClient.CreateAsync("Purchase_Order__c", new CreateRequest
                    {
                        Records = new List<IAttributedObject> {
                        new PurchaseOrder
                        {
                            Name = DateTime.Now.Ticks.ToString()
                        },
                        new PurchaseOrder
                        {
                            Name = DateTime.Now.AddTicks(1).Ticks.ToString()
                        }}
                    });


                        //{
                        //    new PurchaseOrder
                        //    {
                        //        Name = DateTime.Now.Ticks.ToString()
                        //    },
                        //    new PurchaseOrder
                        //    {
                        //        Name = DateTime.Now.AddTicks(1).Ticks.ToString()
                        //    }
                        //});
                }
            }
        }
    }
}
