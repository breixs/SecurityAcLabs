using MyAPICode;

var api = new PasswordAPI();
var result = api.GetPasswordAPI(16);
string[] results = result.Split('"');
Console.WriteLine(result);
Console.WriteLine(results[3]);

