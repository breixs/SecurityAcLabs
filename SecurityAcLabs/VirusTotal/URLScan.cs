using Microsoft.Extensions.Configuration;
using RestSharp;

namespace VirusTotal
{
    public class URLScan
    {
        private readonly string _apiURL = "https://www.virustotal.com/api/v3/urls";

        public async Task<UrlResponse> GetURL()
        {
            var builder = new ConfigurationBuilder().AddUserSecrets<URLScan>();
            var configuration = builder.Build();
            string apiKey = configuration["API_KEY"];

            var options = new RestClientOptions(_apiURL);
            var client = new RestClient(options);
            var request = new RestRequest("");
            request.AddHeader("accept", "application/json");
            request.AddHeader("X-Apikey", apiKey);
            request.AddParameter("url", "https://www.youtube.com/watch?v=-jJVcMraY1c");
            var response = await client.PostAsync(request);
            var result = response.Content;
            var mess = Newtonsoft.Json.JsonConvert.DeserializeObject<UrlResponse>(result);
            return mess ?? new UrlResponse();
        }
    }
    public class URLScanAnalysis
    {
        public async Task<UrlResponse> GetAnalysis(string analysisURL)
        {
            var builder = new ConfigurationBuilder().AddUserSecrets<URLScan>();
            var configuration = builder.Build();
            string apiKey = configuration["API_KEY"];

            var options = new RestClientOptions(analysisURL);
            var client = new RestClient(options);
            var request = new RestRequest("");
            request.AddHeader("accept", "application/json");
            request.AddHeader("X-Apikey", apiKey);
            var response = await client.GetAsync(request);
            var result = response.Content;
            var analysis = Newtonsoft.Json.JsonConvert.DeserializeObject<UrlResponse>(result);
            return analysis ?? new UrlResponse();
        }

    }
}


