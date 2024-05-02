using RestSharp;

namespace VirusTotal
{
    public class URLScan
    {
        private readonly string _apiURL = "https://www.virustotal.com/api/v3/urls";

        public async Task<UrlResponse> GetURL()
        {
            var options = new RestClientOptions(_apiURL);
            var client = new RestClient(options);
            var request = new RestRequest("");
            request.AddHeader("accept", "application/json");
            request.AddHeader("x-apikey", "c9e2cdaf59ae606c1b77ec6ec92e9bab9e106246a8265a34442e97e4f5f96245");
            request.AddParameter("url", "https://www.youtube.com/watch?v=-jJVcMraY1c");
            var response = await client.PostAsync(request);
            var result = response.Content;
            var mess = Newtonsoft.Json.JsonConvert.DeserializeObject<UrlResponse>(result);
            return mess ?? new UrlResponse();
        }
        
    }
}


