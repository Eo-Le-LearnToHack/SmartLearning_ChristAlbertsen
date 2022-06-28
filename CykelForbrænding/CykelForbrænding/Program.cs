
class BikingMetrics
{
    //default value for calories burned
    static private double calories_per_kg = 0.33;


    static public void calc_cal_burn(double km_biked, double body_weight)
    {//calculate calories burned
        Console.WriteLine($"Biking {km_biked}km with a body weight of {body_weight} kg means burning " +
            $"{calories_per_kg * km_biked * body_weight} kcal \n");
    }


    static private void method_repeater(double[] repeated_items, double arg, Action<double, double> method)
    {//repeats the method argument keeping arg fixed while iterating over repeated_items
        foreach (double item in repeated_items)
        {
            method(item, arg);
        }
    }


    static private double ReadLine_validated()
    {//validate the user input.

        string temp_input;
        double user_input;
        bool conversion_result = true;

        do
        {
            temp_input = Console.ReadLine();
            
            //-1 is the exit-code for the parent method
            if (temp_input == "exit") return -1;

            conversion_result = !double.TryParse(temp_input, out user_input);
            if (conversion_result) Console.WriteLine("The input value wasn't a double value, please try again.");
        } while (conversion_result);

        return user_input;
    }


    static void Main()
    {
        //define default biking length
        double[] default_length = new double[] { 12, 202, 182 };
        Console.WriteLine("Calculate your calories burned biking! \n" +
                          "Here's examples of three calculations \n ");

        //calculate calories burned for each person and varying trip lengths
        Console.WriteLine($"Person 1:");
        method_repeater(default_length, 84, calc_cal_burn);

        Console.WriteLine($"Person 2:");
        method_repeater(default_length, 69, calc_cal_burn);

        Console.WriteLine($"Person 3:");
        method_repeater(default_length, 97, calc_cal_burn);


        double user_input_weight;
        double user_input_length;
        
        do
        {
            Console.WriteLine("\nDo you want to try it for yourself (write `exit` to cancel)?");

            //get user weight
            Console.WriteLine("\nWhats your weight (in kg)?");
            user_input_weight = ReadLine_validated();
            if (user_input_weight == -1) break;

            //get length of bike trip
            Console.WriteLine("\nWhats the length of your bike trip (in km)?");
            user_input_length = ReadLine_validated();
            if (user_input_length == -1) break;
            
            Console.WriteLine("\n");
            calc_cal_burn(user_input_length, user_input_weight);

        } while (true);

        Console.WriteLine("\n\nThanks for trying out! \n\n");
    }
}