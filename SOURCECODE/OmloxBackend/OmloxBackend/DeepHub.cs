using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace OmloxBackend
{
    internal class DeepHub
    {
        HttpClient httpClient = new HttpClient();
        public void function()
        {
            //https://stackoverflow.com/questions/9620278/how-do-i-make-calls-to-a-rest-api-using-c
            httpClient.BaseAddress = new Uri("https://api.deephub.io/deephub/v1/");
            APIReq req = new APIReq(httpClient);
            Console.WriteLine(req.GetAllTrackableIdsAsync().GetAwaiter().GetResult());
        }

    }
}
