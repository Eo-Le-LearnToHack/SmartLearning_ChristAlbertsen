using System;

Console.WriteLine("Hello World!");
Console.WriteLine("Its a wonderful world!");

var antalIngredienser = Convert.ToInt32(Console.ReadLine());

for (var i = 0; i < antalIngredienser; i++)
{
    var x = Console.ReadLine();
    Console.WriteLine("Du kan lide: " + x);
}