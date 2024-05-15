using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockAPI
{
    public class PasswordMockAPI
    {
        public async Task<string> GetPasswordApi()
        {
            var client = new HttpClient();
            var response = await client.GetAsync("https://my.api.mockaroo.com/passwords.json?key=ce7efee0");
            return await response.Content.ReadAsStringAsync();
        }
    }
}