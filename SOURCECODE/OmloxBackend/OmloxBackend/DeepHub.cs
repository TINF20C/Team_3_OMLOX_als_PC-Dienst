using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace OmloxBackend
{
    public class Geometry
    {
        public string type { get; set; }
        public double[][] cooardinates { get; set; }
    }

    public class Answer
    {
        public string id { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public Geometry geometry { get; set; }
        public int extrusion { get; set; }
        public string[] location_providers { get; set; }
        public int exit_tolerance { get; set; }
        public int tolerance_timeout { get; set; }
        public int exit_delay { get; set; }
        public int radius { get; set; }
    }

    public class Token
    {
        private string access_token { get; set; }
        private int expires_in { get; set; }
        private int refresh_expires_in { get; set; }
        private string refresh_token { get; set; }
        private string token_type { get; set; }
        private string id_token { get; set; }
        private int not_before_policy { get; set; }
        private string session_state { get; set; }
        private string scope { get; set; }
    }
    internal class DeepHub
    {



        HttpClient client = new HttpClient();
        private string _username;
        private string _password;

        //Constructor needs username and Password
        //Creates an auth Object for future request authorization
        public DeepHub(string usernmae, string password)
        {
            CreateTokenAsync(usernmae, password);
        }

        public async void CreateTokenAsync(string username, string password)
        {
            var content = new Dictionary<string, string>();
            content.Add("grant_type", "client_credentials");
            content.Add("client_id", "deephub-release-client");
            content.Add("username", username);
            content.Add("password", password);
            content.Add("scope", "openid");
            content.Add("client_secret", "bda13a64-7f5a-4d58-9177-d0ddabbc4dbd");

            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Clear();
            var req = new HttpRequestMessage(HttpMethod.Post, "https://api.deephub.io/auth/realms/omlox/protocol/openid-connect/token")
            {
                Content = new FormUrlEncodedContent(content)
            };

            var res = await client.SendAsync(req);
            Console.WriteLine(res.ToString());
        }


        public void function()
        {
            //https://stackoverflow.com/questions/9620278/how-do-i-make-calls-to-a-rest-api-using-c
            //https://docs.microsoft.com/de-de/aspnet/web-api/overview/advanced/calling-a-web-api-from-a-net-client

        }

    }
}
