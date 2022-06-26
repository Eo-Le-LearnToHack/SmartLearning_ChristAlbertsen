

//Opgave 4.1
//string user_name = "Chris";

//string input_name = Console.ReadLine();
//if (input_name == user_name) Console.WriteLine("Det er et flot navn!");

//Opgave 4.2 
//double temperature = double.Parse(Console.ReadLine());

//if (temperature >= 20) Console.WriteLine("Det er dejligt varmt");


//Opgave 4.3

//string user_input = Console.ReadLine().ToLower();
//if (user_input == "yes") Console.WriteLine("Det faar du saa");
//else if (user_input == "nej") Console.WriteLine("okay du bliver fri");
//else Console.WriteLine("Jeg ikke forstaa din sprog");


//Opgave 4.4

//double price = double.Parse(Console.ReadLine());
//switch(price)
//{
//    case < 10:
//        Console.WriteLine("Det var billigt");
//        break;

//    case > 100:
//        Console.WriteLine("Det var dyrt");
//        break;

//    default:
//        Console.WriteLine("Prisen er iorden");
//        break;
//}

//Opgave 4.5

//string weather = Console.ReadLine().ToLower();
//double temperature = double.Parse(Console.ReadLine());

//if (weather == "sne" || temperature < 0) Console.WriteLine("Jeg tror, det er vinter");


//Opgave 4.6
//string gender = Console.ReadLine().ToLower();
//int age = int.Parse(Console.ReadLine());

//string team = gender == "mand" ? "herreholdet" : "dameholdet";
//string junior_senior = age < 18 ? "junior" : "senior";

//Console.WriteLine($"Du skal spille paa {junior_senior} {team}");


//Opgave 4.7
//string identification = Console.ReadLine().ToLower();

//switch (identification)
//{
//    case "l":
//        Console.WriteLine("Lesbian");
//        break;

//    case "g":
//        Console.WriteLine("Gay");
//        break;

//    case "b":
//        Console.WriteLine("Bisexsual");
//        break;

//    case "t":
//        Console.WriteLine("Transexual");
//        break;

//    case "q":
//        Console.WriteLine("Queer");
//        break;
//}

//Opgave 4.8

//int identification = int.Parse(Console.ReadLine());

//switch (identification)
//{
//    case 1:
//        Console.WriteLine("Es");
//        break;

//    case 11:
//        Console.WriteLine("Knight");
//        break;

//    case 12:
//        Console.WriteLine("Queen");
//        break;

//    case 13:
//        Console.WriteLine("King");
//        break;

//    default:
//        Console.WriteLine(identification);
//        break;
//}

//Opave 4.9
//string user_input = Console.ReadLine().ToLower();

//if (user_input == "kaffe") Console.WriteLine("Det var et godt valg");
//else Console.WriteLine("Det er da ogsaa okay");



//Opgave 4.10

//string gender = Console.ReadLine().ToLower();
//int age = int.Parse(Console.ReadLine());

//switch(gender, age)
//{
//    case ("m", > 50):
//        Console.WriteLine("Du boer blive screenet");
//        break;

//    case ("m", <= 50):
//        Console.WriteLine("Du boer blive screenet, naar du er over 50");
//        break;

//    case ("k",int):
//        Console.WriteLine("Du er ikke i risikogruppen");
//        break;

//    default:
//        Console.WriteLine("Du har skrevt noget forkert");
//        break;
//}



// Dette program skal fortælle hvad en gruppe med et bestemt antal
// medlemmer hedder.
// Programmet er korrekt, når det udskriver den korrekte beskrivelse,
// uanset om du indtaster 1, 2 eller 3.



Console.WriteLine("Hvor mange er I i gruppen? (1-3 personer)");
int antal = Convert.ToInt32(Console.ReadLine());

if (antal == 1)
{
    Console.WriteLine("Du er solist");
}
else if (antal == 2)
{
    Console.WriteLine("I er en duo");
}
else if (antal == 3)
{
    Console.WriteLine("I er en trio");
}