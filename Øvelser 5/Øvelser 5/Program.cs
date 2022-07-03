
//Opgave 5.1
//for (int i = 1; i < 11; i++) {
//    Console.WriteLine(i);
//}

//int i = 1;
//while (i < 11)
//{
//    Console.WriteLine(i);
//    i++;
//}


//Opgave 5.2
//for (int i = 10; i > 0; i--)
//{
//    Console.WriteLine(i);  
//}


//Opgave 5.3
//for (int i = 3; i < 31; i += 3)
//{
//    Console.WriteLine(i);
//}


//Opgave 5.4
//string user_input = "";

//while(user_input != "Password")
//{
//    user_input = Console.ReadLine();
//    if (user_input != "Password")
//    {
//        Console.WriteLine("Wrong password! Try again!");
//    }
//}


//Opgave 5.5

//int? user_input = null;

//while (user_input != 3)
//{
//    user_input = int.Parse(Console.ReadLine());
//    if (user_input != 3)
//    {
//        Console.WriteLine("Wrong number! Try again!");
//    }
//}


//Opgave 5.6

//string user_input = "";

//do
//{
//    user_input = Console.ReadLine();
//} while (user_input != "");


//Opgave 5.7

//for(int bottles = 99; bottles > 0; bottles--)
//{
//    Console.WriteLine($"{bottles} bottles of beer on the wall, {bottles} bottles of beer.");
//    Console.WriteLine($"Take one down and pass it around, {bottles - 1} bottles of beer on the wall.");
//    Console.WriteLine();
//}


//Opgave 5.8

//for(int i = 1; i <= 10; i++)
//{
//    for(int j = i; j <= i*10; j += i)
//    {
//        Console.Write($"{j} ");
//    }
//    Console.WriteLine();
//}

//Opgave 5.9

//float user_input = float.Parse(Console.ReadLine());

//for(int i = 1; i < 11; i++)
//{
//    Console.Write($"{user_input * i} ");
//}


//Opgave 5.10

//Without break continue
//Console.WriteLine("Please enter your password");
//string user_input;
//int login_attempts = 0;
//do
//{
//    user_input = Console.ReadLine();
//    login_attempts++;
//} while (user_input != "Password" && login_attempts < 3);

//if (login_attempts == 3 && user_input != "Password")
//{
//    Console.WriteLine("Your account has been blocked");
//}


//With break continue
//Console.WriteLine("Please enter your password");
//string user_input;
//int login_attempts = 0;

//while(true)
//{
//    user_input = Console.ReadLine();
//    if (user_input == "Password") break;
//    login_attempts++;
//    if (login_attempts == 3) break;
//}

//if (login_attempts == 3)
//{
//    Console.WriteLine("Your account has been blocked");
//}




// Programmet skal udskrive tallene fra 0 til 9
// med den detalje at i stedet for tallet 5 skal teksten FEM udskrives
// (så det bliver 0 1 2 3 4 FEM 6 7 8 9)

//for (int i = 0; i < 10; i++)
//{
//    if (i == 5)
//    {
//        Console.Write("FEM ");

//        continue;
//    }
//    Console.Write(i);
//    Console.Write(" ");
//}