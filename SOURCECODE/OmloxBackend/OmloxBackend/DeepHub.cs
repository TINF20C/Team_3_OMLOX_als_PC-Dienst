using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using RestSharp;
using Newtonsoft.Json.Linq;

namespace OmloxBackend
{
    public class Geometry
    {
        public string type = "Polygon";
        public double[][][] cooardinates { get; set; }
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
        public string access_token { get; set; }
        public int expires_in { get; set; }
        public int refresh_expires_in { get; set; }
        public string refresh_token { get; set; }
        public string token_type { get; set; }
        public string id_token { get; set; }
        public int not_before_policy { get; set; }
        public string session_state { get; set; }
        public string scope { get; set; }
    }

    public class Trackable
    {
        public string id { get; set; }
        public string type = "omlox";
        public string name { get; set; }
        public Geometry geometry { get; set; }
        public string[] location_providers { get; set; }



    }

    public class DeleteStatus
    {
        public int code { get; set; }
    }

    public class DeepHub
    {



        HttpClient client = new HttpClient();
        Token token;

        //Constructor needs username and Password
        //Creates an auth Object for future request authorization
        public DeepHub()
        {
            CreateTokenAsync();
        }

        public void CreateTokenAsync()
        {
            /*
            var content = new Dictionary<string, string>();
            content.Add("grant_type", "client_credentials");
            content.Add("client_id", "deephub-release-client");
            content.Add("scope", "openid");
            content.Add("client_secret", "bda13a64-7f5a-4d58-9177-d0ddabbc4dbd");

            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Clear();
            var req = new HttpRequestMessage(HttpMethod.Post, "https://api.deephub.io/auth/realms/omlox/protocol/openid-connect/token")
            {
                Content = new FormUrlEncodedContent(content)
            };

            var res = await client.SendAsync(req);
            string ausgabe = await res.Content.ReadAsStringAsync();
            token = JsonConvert.DeserializeObject<Token>(ausgabe);
            GetTrackables();
            */

            //------------------------------------------------------------------
            //RestSharp
            var rsClient = new RestClient("https://api.deephub.io/auth/realms/omlox/protocol/openid-connect/token");
            var request = new RestRequest(Method.POST);
            request.AddParameter("grant_type", "client_credentials");
            request.AddParameter("client_id", "deephub-release-client");
            request.AddParameter("scope", "openid");
            request.AddParameter("client_secret", "bda13a64-7f5a-4d58-9177-d0ddabbc4dbd");
            var response = rsClient.Post(request);
            string tmp = response.Content.ToString();
            token = JsonConvert.DeserializeObject<Token>(tmp);
        }

        public String[] GetTrackables()
        {
            //RestSharp
            var rsClient = new RestClient("https://api.deephub.io/deephub/v1/trackables");
            rsClient.AddDefaultHeader("Authorization", "Bearer " + token.access_token);
            var request = new RestRequest();
            var response = rsClient.Get(request);

            return jsonArrayStringToArray(response.Content.ToString());
        }
        public Trackable[] GetTrackableSummary()
        {
            //RestSharp
            var rsClient = new RestClient("https://api.deephub.io/deephub/v1/trackables/summary");
            rsClient.AddDefaultHeader("Authorization", "Bearer " + token.access_token);
            var request = new RestRequest();
            var response = rsClient.Get(request);

            Trackable[] trackables = JsonConvert.DeserializeObject<Trackable[]>(response.Content.ToString());
            return trackables;
        }

        public bool DeleteTrackable(string trackableID)
        {
            var rsClient = new RestClient("https://api.deephub.io/deephub/v1/trackables/" + trackableID);
            rsClient.AddDefaultHeader("Authorization", "Bearer " + token.access_token);
            var request = new RestRequest();
            var response = rsClient.Delete(request);
            DeleteStatus res = JsonConvert.DeserializeObject<DeleteStatus>(response.Content.ToString());
            return res == null ? true : false;
        }

        public void SetTrackable()
        {
            var rsClient = new RestClient("https://api.deephub.io/deephub/v1/trackables");
            rsClient.AddDefaultHeader("Authorization", "Bearer " + token.access_token);
            var request = new RestRequest(Method.POST);
            request.RequestFormat = DataFormat.Json;
            //request.AddJsonBody(); //Add objekt in the method

            //client.PostAsync("https://api.deephub.io/deephub/v1/trackables", )

            //var req = new HttpRequestMessage(HttpMethod.Post, "https://api.deephub.io/deephub/v1/trackables");
        }

        public String[] jsonArrayStringToArray(String arrayString)
        {
            arrayString = arrayString.Replace("\\", string.Empty);
            arrayString = arrayString.Replace("\"", string.Empty);
            arrayString = arrayString.Replace("[", string.Empty);
            arrayString = arrayString.Replace("]", string.Empty);

            return Regex.Split(arrayString, ",");
        }

    }
}
