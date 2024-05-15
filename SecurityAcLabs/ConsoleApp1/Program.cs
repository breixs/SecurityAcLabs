using MyAPICode;
using VirusTotal;
using MockAPI;

var api = new PasswordAPI();
var result = api.GetPasswordAPI(16);
string[] results = result.Split('"');
Console.WriteLine(result);
Console.WriteLine(results[3]);

var api2 = new URLScan();
var result2 = await api2.GetURL();
Console.WriteLine(result2);

var apiAnalysis= new URLScanAnalysis();
var analysis = await apiAnalysis.GetAnalysis(result2.Data.Links.Self);
string json = Newtonsoft.Json.JsonConvert.SerializeObject(analysis, Newtonsoft.Json.Formatting.Indented);
Console.WriteLine(json);

var mockApi = new PasswordMockAPI();
var mockresult = await mockApi.GetPasswordApi();
Console.WriteLine(mockresult);

