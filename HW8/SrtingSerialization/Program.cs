string russian = "Привет мир!";
var bytes = System.Text.Encoding.UTF8.GetBytes(russian);
string result = System.Text.Encoding.UTF8.GetString(bytes);
Console.WriteLine(result);

string german = "Hallo Welt!";
bytes = System.Text.Encoding.UTF8.GetBytes(german);
result = System.Text.Encoding.UTF8.GetString(bytes);
Console.WriteLine(result);

string japanese = "こんにちは世界!";
bytes = System.Text.Encoding.UTF8.GetBytes(japanese);
result = System.Text.Encoding.UTF8.GetString(bytes);
Console.WriteLine(result);