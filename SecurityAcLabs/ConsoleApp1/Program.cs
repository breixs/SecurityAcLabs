using MyAPICode;
using VirusTotal;
using System.IO;

var api = new PasswordAPI();
var result = api.GetPasswordAPI(16);
string[] results = result.Split('"');
Console.WriteLine(result);
Console.WriteLine(results[3]);

var api2 = new URLScan();
var result2 = await api2.GetURL();
Console.WriteLine(result2);

string filePath = "analysis.txt";
var apiAnalysis= new URLScanAnalysis();
var analysis = await apiAnalysis.GetAnalysis(result2.Data.Links.Self);
string json = Newtonsoft.Json.JsonConvert.SerializeObject(analysis, Newtonsoft.Json.Formatting.Indented);
Console.WriteLine(json);
