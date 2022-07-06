

class IceCreamSeller
{
    private Dictionary<string, int> priceDict = new Dictionary<string, int>()
    {
        ["1"] = 19,
        ["2"] = 25,
        ["3"] = 31,
        ["4"] = 37,
        ["guf"] = 6,
        ["flødebolle"] = 6,
        ["nothing"] = 0
    };

    private int tap = 0;

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

    public void TakeCustomerOrder()
    {
   
        Func<string, bool> scoopCountValidation = userInput =>
        {
            int parsedValue = int.Parse(userInput);
            return parsedValue > 0 && parsedValue < 5;
        };
        
        Console.WriteLine("Hi, and welcome to our icecream shop. \n" +
            "Would you like 1,2,3 or 4 scoops of icecream?");
        string userInput = InputHandler(scoopCountValidation);
        PriceCalculator(userInput);


        Func<string, bool> yesNoValidation = x =>
        {
            x = x.ToLower();
            return x == "y" || x == "n";
        };
        Console.WriteLine("Would you like guf? (y/n)");
        userInput = InputHandler(yesNoValidation);
        if (userInput == "y") PriceCalculator("guf");

        Console.WriteLine("Would you like a cream bun? (y/n)");
        userInput = InputHandler(yesNoValidation);
        if (userInput == "y") PriceCalculator("flødebolle", true); else PriceCalculator("nothing", true);

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
