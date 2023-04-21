var s = Console.ReadLine();

var s1 = s.Split("://");
var protocol = s1.Length > 1 ? s1[0] : "";
var rest = s1.Length > 1 ? s1[1] : s;
var s2 = rest.Split("/");
var server = s2.Length > 1 ? s2[0] : rest;
var resource = s2.Length > 1 ? s2[1] : "";

Console.WriteLine($"[protocol] = \"{protocol}\"");
Console.WriteLine($"[server] = \"{server}\"");
Console.WriteLine($"[resource] = \"{resource}\"");