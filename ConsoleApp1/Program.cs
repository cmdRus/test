using System.Text.RegularExpressions;

var reg = new Regex(@"h\d-h(x|х|хв)");
var text = new string[] { "h1-hxв", "h1-hxв", "h1-hх", "h1-hx" };
Console.WriteLine(@"h\d-\(h(x|х)в?\)");
foreach (var t in text)
{
    Console.WriteLine(t + " " + reg.IsMatch(t));
}

//var reg2 = new Regex(@"h\d-h((x|х)|(x|х)в)");
//Console.WriteLine(@"h\d-(h(x|х)|h(x|х)в)");
//foreach (var t in text)
//{
//    Console.WriteLine(t + " " + reg2.IsMatch(t));
//}


Console.ReadKey();