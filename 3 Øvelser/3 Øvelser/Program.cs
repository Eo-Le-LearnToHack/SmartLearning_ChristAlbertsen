using System;

//3.1
Console.WriteLine("Hello, World!");

//3.2
//string user_input;
//user_input = Console.ReadLine();
//Console.WriteLine("Hej " + user_input);

//3.3
//string best_pizza;
//best_pizza = Console.ReadLine();
//Console.WriteLine($"Du syntes at {best_pizza} er den bedste pizza i verden");

//3.4
//uint document_pages;
//document_pages = uint.Parse(Console.ReadLine());

//Console.WriteLine($"You can save {document_pages / 2} if you print double paged");


//3.5
//float user_number;
//user_number = float.Parse(Console.ReadLine());
//Console.WriteLine($"The first number was {user_number}");

//user_number = float.Parse(Console.ReadLine());
//Console.WriteLine($"The second number was {user_number}");


//3.6
//Console.WriteLine("Indtast to tal");

//float tal1 = float.Parse(Console.ReadLine());
//float tal2 = float.Parse(Console.ReadLine());

//Console.WriteLine($"De to tal var {tal1} og {tal2}");

//3.7
//Console.WriteLine("Hvor varmt er der?");
//float temperature = float.Parse(Console.ReadLine());

//Console.WriteLine("Hvordan er vejret");
//string vejret = Console.ReadLine();

//Console.WriteLine($"Vejret er {vejret} med {temperature} grader celsius");

//3.8
//Console.WriteLine("hvor varmt er der?");
//float temperature = float.Parse(Console.ReadLine());
//Console.WriteLine($"Temperaturen i morgen bliver {temperature + 2} grader celsius");

//3.9
//Console.WriteLine("Hvor hoej er du?");
//float height = float.Parse(Console.ReadLine());
//Console.WriteLine($"Du er {height} meter hoej");


//3.10
//Console.WriteLine("Hvad koster varen?");
//double price = double.Parse(Console.ReadLine());
//Console.WriteLine($"The price is {price:C}");


//ret fejl
﻿// Programmet her skal indlæse brugerens navn og alder,
// og fortælle, hvor gammel vedkommende bliver til næste år.


Console.WriteLine("Hvad hedder du?");
string navn = Console.ReadLine();

Console.WriteLine("Hvor gammel er du?");
int alder = Convert.ToInt32(Console.ReadLine());

int nyAlder = alder + 1;

Console.WriteLine($"Hej {navn}");
Console.WriteLine($"Til næste år bliver du {nyAlder} år");
