using System;
using System.Collections.Generic;

class IceCreamSeller
{

    public static Dictionary<string, int> priceDict = new()
    {
        ["1"] = 19, //First entry = ["1"]
        ["2"] = 25,
        ["3"] = 31,
        ["4"] = 37,
        ["guf/flødebolle"] = 6, //Fifth ["guf/flødebolle"]. Udvidet fra ["guf"]
        ["nothing"] = 0 //Sixth entry = ["nothing"]. Nødvendigt til sidst når der vælges nej til flødebolle.

    };

    public static Dictionary< string, Predicate<string> > validationFunctions = new()   //Why necessary with Predicate?
    {                                                                                   //The predicate using the userInput to return true/false?
        //First entry = ["scoopCountValidation"]
        ["scoopCountValidation"] = userInput =>     //The string "scoopCountValidation" must be between 1-4.
        {
            int parsedValue = int.Parse(userInput); 
            return parsedValue > 0 && parsedValue < 5;
        },

        //Second entry = ["yesNoValidation"]
        ["yesNoValidation"] = userInput =>          // The string "yesNoValidation" must be y or n.
        {
            userInput = userInput.ToLower();
            return userInput == "y" || userInput == "n";
        }
    };

    private int tap = 0;

    public void TakeCustomerOrder()
    {
        Console.WriteLine("Hi, and welcome to our icecream shop. \n" +
            "Would you like 1,2,3 or 4 scoops of icecream?");
        string userInput = InputHandler(validationFunctions["scoopCountValidation"]);
        PriceCalculator(userInput);
        //userInput takes in the dictionary validationFunctions from the entry "scoopCountValidation"
        //The userInput must be between 1-4 as defined in the dictionary validationFunctions, entry "scoopCountValidation".
        //Next, the method PriceCalculator is reading the price from the priceDict.

        Console.WriteLine("Would you like guf? (y/n)");
        userInput = InputHandler(validationFunctions["yesNoValidation"]);
        if (userInput == "y") PriceCalculator("guf/flødebolle");
        //userInput takes in the dictionary validationFunctions from the entry "scoopCountValidation"
        //The userInput must be between 1-4 as defined in the dictionary validationFunctions, entry "scoopCountValidation".
        //Next, the method PriceCalculator is reading the price from the priceDict.

        Console.WriteLine("Would you like a cream bun? (y/n)");
        userInput = InputHandler(validationFunctions["yesNoValidation"]);
        if (userInput == "y") PriceCalculator("guf/flødebolle", true); else PriceCalculator("nothing", true);
    } //userInput takes in the dictionary validationFunctions from the entry "yesNoValidation".
      //The userInput must be y or n as defined in the dictionary validationFunctions, entry "yesNoValidation".
      //Next, the method PriceCalculator is reading the price from the priceDict.


    private string InputHandler(Predicate<string> InputCriteria)
    {
        string userInput;
        bool criteriaEvaluation = false;

        do
        {
            userInput = Console.ReadLine(); 
            criteriaEvaluation = InputCriteria(userInput);

        } while (criteriaEvaluation == false);

        return userInput;
    }   

    private void PriceCalculator(string customerOrder, bool printTotal = false)
    {
        this.tap += priceDict[customerOrder];
        if (printTotal) Console.WriteLine("prisen er " + tap + " kr.");
    }
}

class program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            IceCreamSeller iceCreamSeller = new IceCreamSeller();
            iceCreamSeller.TakeCustomerOrder();
            Console.ReadLine();
        }
        
        //IceCreamSeller class inderholder følgende:
        //  private Dictionary
        //                  priceDict with 5 entries
        //                  validationFunctions with 2 entries
        //  int tap = 0;
        //  metoden TakeCustomerOrder()
        //  pmetoden InputHandler(Predicate<string>)
        //  metoden PriceCalculator(string customerOrder, bool printTotal = false), printer kun til konsollen hvis printTotal = true
       

        //foreach (KeyValuePair<string, Predicate<string>> kvp in IceCreamSeller.validationFunctions)
        //{
        //    Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
        //}

        //Console.WriteLine("scoopCountValidation Value = {0} \nyesNoValidation Value = {1}", IceCreamSeller.validationFunctions["scoopCountValidation"], IceCreamSeller.validationFunctions["yesNoValidation"]);
    }
}
