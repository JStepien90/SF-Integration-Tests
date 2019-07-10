using Salesforce.Common;
using Task = System.Threading.Tasks.Task;

namespace SFIntegration.NETFramework
{
    public class BulkAPI
    {
        public async Task Test()
        {
            using (var auth = new AuthenticationClient())
            {
                await auth.UsernamePasswordAsync("3MVG96_7YM2sI9wQEuGYr2dV41ANxFem_XLDBd5Dn8ixAvm8AslaHNoNMUFJI218vqYQDMdCAMFUg_zzFWQJE",
                                                 "7D4690EC731EF30143F64D3469AA907011256023ADC41241178B87CF899F02F4",
                                                 "giiriu@gmail.com",
                                                 "!HalaMadrid@2019stfEr80kdHLR4Nu21RlXtECl");


            }
        }
    }
}
