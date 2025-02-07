﻿using System.Net;

string[] ord = new string[3];

for (int i = 0; i < 3; i++) ord[i] = Console.ReadLine();

// Det er er min kode, som du ikke behøver at rette i
string url = $"https://smartword2vec.azurewebsites.net/api/Top3Similar?positive1={ord[1]}&positive2={ord[2]}&negative={ord[0]}".ToLower();
HttpClient client = new ();   
HttpResponseMessage response = await client.GetAsync(url);
if (!response.IsSuccessStatusCode)
{
    Console.WriteLine("Servicen kom ikke med noget svar for de ord du skrev. Husk, at servicen kun kender engelske ord");
    return;
}
string responseBody = await response.Content.ReadAsStringAsync();
string[] resultater = responseBody.Split(';');
// Min kode slutter her

// Svaret ligger nu i array'et resultater. 
// Lav to udskrifter:
// 1) En udskrift af det mest sandsynlige svar på formen
//    a is to b, as c is to d
//    (det mest sandsynlige ord er først i array'et)
Console.WriteLine("The most plausible word is");
Console.WriteLine(resultater[0]);

// 2) En udskrift af alle de ord, der kom med tilbage som resultater
Console.WriteLine("\n Other words are");
foreach (string word in resultater) Console.WriteLine(word);

