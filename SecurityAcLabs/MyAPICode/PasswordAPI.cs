using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;

namespace MyAPICode
{
    public class PasswordAPI
    {
        //private string apiURL="url";
        private HttpClient _client;
        public PasswordAPI()
        {
            _client = new HttpClient();
        }

        public string GetPasswordAPI(int length)
        {
            var response = _client.GetAsync($"https://api.genratr.com/?length={length}&uppercase&lowercase&special&numbers").Result;
            var result = response.Content.ReadAsStringAsync().Result;
            return result;
        }
    }
}
