﻿using System.Text;

string name = "Nadir";

name += " Zamanov";

Console.WriteLine(name);

StringBuilder stringBuilder = new StringBuilder("a");
for (int i = 0;i < 100; i++)
{
    stringBuilder.Append("a");
    Console.WriteLine($"Capacity: {stringBuilder.Capacity}");
    Console.WriteLine($"Length: {stringBuilder.Length}");
    Console.WriteLine();
}

string myStr = stringBuilder.ToString();
Console.WriteLine(myStr);


// """ """
//string code = """ 

//""";
// работает на 7 версии дот нет


string lorem = "Lorem ipsum dolor sit amet, " +
"consectetur adipiscing elit. " +
"Donec aliquam varius leo, " +
"vel porta lorem.";

// @ - verbatim - как бы отменяет форматирование

string lorem_new = @$"Lorem ipsum dolor sit amet,
consectetur adipiscing elit. 
Donec aliquam varius {name} leo, 
vel porta lorem.";

Console.WriteLine(lorem_new);

string path = @"C:\Users\zamanov\Download";