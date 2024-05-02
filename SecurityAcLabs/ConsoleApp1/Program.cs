using MyAPICode;
using VirusTotal;

var api = new PasswordAPI();
var result = api.GetPasswordAPI(10);
string[] results = result.Split('"');
Console.WriteLine(result);
Console.WriteLine(results[3]);

var api2 = new URLScan();
var result2 = await api2.GetURL();
Console.WriteLine(result2);