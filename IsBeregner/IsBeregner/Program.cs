

class IceCreamSeller
{

    private Dictionary<string, int> priceDict = new()
    {
        ["1"] = 19,
        ["2"] = 25,
        ["3"] = 31,
        ["4"] = 37,
        ["guf"] = 6,
        ["flødebolle"] = 6,
        ["nothing"] = 0
    };

    private Dictionary<string, Func<string, bool>> validationFunctions = new() {
        ["scoopCountValidation"] = userInput =>
        {
            int parsedValue = int.Parse(userInput);
            return parsedValue > 0 && parsedValue < 5;
        },
        ["yesNoValidation"] = userInput =>
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

        Console.WriteLine("Would you like guf? (y/n)");
        userInput = InputHandler(validationFunctions["yesNoValidation"]);
        if (userInput == "y") PriceCalculator("guf");

        Console.WriteLine("Would you like a cream bun? (y/n)");
        userInput = InputHandler(validationFunctions["yesNoValidation"]);
        if (userInput == "y") PriceCalculator("flødebolle", true); else PriceCalculator("nothing", true);
    }

    private string InputHandler(Func<string, bool> InputCriteria)
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
        IceCreamSeller iceCreamSeller = new IceCreamSeller();
        iceCreamSeller.TakeCustomerOrder();
    }
}
