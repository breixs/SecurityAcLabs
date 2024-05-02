using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirusTotal
{
        public class UrlResponse
        {
            public Data Data { get; set; }

        public override string ToString()
        {
            return $"Type: {Data.Type}\n" +
                $"Id: {Data.Id}\n" +
                $"Self: {Data.Links.Self}";
        }
    }
    
    public class Data
        {
            public string Type { get; set; }
            public string Id { get; set; }
            public Links Links { get; set; }
        }

        public class Links
        {
            public string Self { get; set; }
        }
}
