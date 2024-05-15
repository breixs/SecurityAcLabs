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
            var sb = new StringBuilder();
            sb.AppendLine($"Type: {Data?.Type}");
            sb.AppendLine($"Id: {Data?.Id}");
            sb.AppendLine($"Self: {Data?.Links?.Self}");
            if(Data?.Attributes != null)
            {
                sb.AppendLine($"Status: {Data?.Attributes?.Status}");
                
                sb.AppendLine($"Date: {Data?.Attributes?.Date}");
                sb.AppendLine($"Malicious: {Data?.Attributes?.Stats?.Malicious}");
                sb.AppendLine($"Suspicious: {Data?.Attributes?.Stats?.Suspicious}");
                sb.AppendLine($"Undetected: {Data?.Attributes?.Stats?.Undetected}");
                sb.AppendLine($"Harmless: {Data?.Attributes?.Stats?.Harmless}");
                sb.AppendLine($"Timeout: {Data?.Attributes?.Stats?.Timeout}");
            }
            
            
            return sb.ToString();
        }

    }

    public class Data
    {
        public string Type { get; set; }
        public string Id { get; set; }
        public Links Links { get; set; }
        public Attributes Attributes { get; set; }
    }

    public class Links
    {
        public string Self { get; set; }
        public string Item { get; set; }
    }

    public class Attributes
    {
        public Dictionary<string, EngineResult> Results { get; set; }
        public long Date { get; set; }
        public string Status { get; set; }
        public Stats Stats { get; set; }
    }

    public class EngineResult
    {
        public string Method { get; set; }
        public string Engine_Name { get; set; }
        public string Category { get; set; }
        public string Result { get; set; }

        public EngineResult(string method, string engineName, string category, string result)
        {
            Method = method;
            Engine_Name = engineName;
            Category = category;
            Result = result;
        }
    }

    public class Stats
    {
        public int Malicious { get; set; }
        public int Suspicious { get; set; }
        public int Undetected { get; set; }
        public int Harmless { get; set; }
        public int Timeout { get; set; }
    }

    public class Meta
    {
        public UrlInfo UrlInfo { get; set; }
        public FileInfo FileInfo { get; set; }
    }

    public class UrlInfo
    {
        public string Id { get; set; }
        public string Url { get; set; }
    }

    public class FileInfo
    {
        public string Sha256 { get; set; }
    }

}
