//string str = "Hello";
//string str2 = new string('_', 9);
//Console.WriteLine(str2);
//char[] chr = new char[]{ 'S', 'a', 'l', 'a', 'm' };
//string str3 = new string(chr);
//Console.WriteLine(str3);

//string newStr = str;
//string othStr = "Hello";
//Console.WriteLine(newStr == str); // тру
//Console.WriteLine(othStr == str); // должно быть фолс но тру т.к. стринг ведет себя как валюе тайп а не референс, так удобнее
//Console.WriteLine(othStr.Equals(str));



string name = "Nadir";

Console.WriteLine(name[0]);
// indices 
var a = name.IndexOf('i');
Console.WriteLine(a);
Console.WriteLine(name[^1]);  // показывает первый элемент с конца

// ranges
Console.WriteLine(name[1..4]);
Console.WriteLine(name[1..]);
Console.WriteLine(name[..4]);