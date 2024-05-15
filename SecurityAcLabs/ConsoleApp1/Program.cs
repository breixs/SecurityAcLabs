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

var mockapi = new PasswordMockAPI();
var mockresult = await mockapi.GetPasswordApi();
Console.WriteLine("MockResults: ");
Console.WriteLine(mockresult);