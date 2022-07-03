
//Opgave 6.1

//string[] arr = new string[] {"leverpostej","salami","tartar" };


//foreach(string mad in arr)
//{
//    Console.WriteLine(mad);

//}


//Opgave 6.2

//int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

//foreach(int lotto_nummer in arr)
//{
//    Console.WriteLine(lotto_nummer);
//}


// Opgave 6.3
//string[] arr = new string[3];

//for(int i = 0; i < 6; i++)
//{
//    if (i < 3) arr[i] = Console.ReadLine();
//    else Console.WriteLine($"{i - 2}. {arr[i - 3]}");
//}


// Opgave 6.4

//string[] arr = new string[3];

//for (int i = 0; i < 3; i++)
//{
//    arr[i] = Console.ReadLine();
//}

//for (int i = 3; i > 0; i--)
//{
//    Console.WriteLine($"{i}. {arr[i-1]}");
//}


// Opgave 6.5

//string[] arr = new string[3];

//for (int i=0; i<3; i++)
//{
//    arr[i] = Console.ReadLine();
//}

//foreach (string ven in arr)
//{
//    if (ven == "Kristian") Console.WriteLine("Godt du huskede mig");
//}


// Opgave 6.6

//string[] varer = new string[3];
//float[] pris = new float[3];

//for (int i = 0; i < 3; i++)
//{
//    varer[i] = Console.ReadLine();
//    pris[i] = float.Parse(Console.ReadLine());
//}

//for (int i = 0; i < 3; i++)
//{
//    Console.WriteLine($"{varer[i]} koster {pris[i]} kr.");
//}


// Opgave 6.7

//float[] arr = new float[5];
//for(int i = 0; i<5; i++)
//{
//    arr[i] = float.Parse(Console.ReadLine());
//}

//foreach(float num in arr)
//{
//    if (num > 10) Console.WriteLine(num);
//}

// Opgave 6.8

//int arr_length = int.Parse(Console.ReadLine());

//string[] arr = new string[arr_length];

//for (int i = 0; i < arr_length; i++)
//{
//    arr[i] = Console.ReadLine();
//}

//for (int i = 0; i < arr_length; i++)
//{
//    Console.WriteLine(arr[i]); 
//}


// Opgave 6.9

//float[] arr = new float[5];
//for (int i = 0; i < 5; i++)
//{
//    arr[i] = float.Parse(Console.ReadLine());
//}

//int counter = 0;

//foreach (float num in arr)
//{
//    if (num < 5) counter++;
//}

//Console.WriteLine(counter);


// Opgave 6.10

//string[] arr = new string[5];
//for (int i = 0; i < 5; i++)
//{
//    arr[i] = Console.ReadLine();
//}


//foreach (string word in arr)
//{
//    if (word.Length == 4) Console.WriteLine(word);
//}


// Programmet skal bede brugeren indtaste hvor mange tal, han vil have
// i sit array. Derefter fyldes arrayet med tal fra 0 og op, indtil det
// ønskede antal er opnået.

// Herefter skal programmet udskrive tallene i arrayet i baglæns rækkefølge

//Console.WriteLine("Hvor mange tal vil du have?");
//int antal = Convert.ToInt32(Console.ReadLine());

//int[] tal = new int[antal];
//for (int i = 0; i < tal.Length; i++)
//{
//    tal[i] = i;
//}

//for (int i = tal.Length - 1; i >= 0; i--)
//{
//    Console.WriteLine(tal[i]);
//}


double? input = null;
double? tempSvar;
string? svar = Console.ReadLine();

do
{
    double.TryParse(svar, out tempSvar);
    if (tempSvar == null) Console.Write("Input invalid. Indtast venligst et tal:\t");
} while (tempSvar == null);

Console.Write($"Input of value {tempSvar} was successfull!");