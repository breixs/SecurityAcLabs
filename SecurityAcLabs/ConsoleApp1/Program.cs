using MyAPICode;

var api = new PasswordAPI();
var result = api.GetPasswordAPI(10);
string[] results = result.Split('"');
Console.WriteLine(result);
Console.WriteLine(results[3]);

