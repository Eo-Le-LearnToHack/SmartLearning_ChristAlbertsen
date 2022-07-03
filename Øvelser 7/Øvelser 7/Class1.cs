namespace Øvelser_7
{
    class Printer
    {
        public void hello_word()
        {
            Console.WriteLine("Hello world!");
        }
    }

    class NumberPrinter
    {
        public void print_number(float number)
        {
            Console.WriteLine($"The number is {number}");
        }
    }
       
    class SumPrinter
        {
            public void print_sum(float num1, float num2)
            {
                Console.WriteLine($"The sum of the numbers is {num1 + num2}");
            }
        }
    
    class Calculator
    {
        public float diff(float num1, float num2)
        {
            return num1 - num2;
        }
    }

    class Tracker
    {
        private float total;
        
        public void plus(float num)
        {
            total += num;
        }

        public void sum()
        {
            Console.WriteLine(total);
        }
    }

    class Person
    {
        private string navn;
        private string email;

        public Person(string input_navn, string input_email)
        {
            navn = input_navn;
            email = input_email;
        }

        public void udskriv()
        {
            Console.WriteLine($"Navn er {navn}, og email er {email}");
        }
    }

    class Vare
    {
        private float pris;
        private string navn;

        public Vare(float pris_input, string navn_input)
        {
            pris = pris_input;
            navn = navn_input;
        }

        public void udskriv()
        {
            Console.WriteLine($"Navn: {navn}, Pris: {pris}");
        }
    }

    class Kasseaparat
    {
        public void udskriv_bon(Vare[] varer)
        {
            foreach(Vare Vare_obj in varer)
            {
                Vare_obj.udskriv();
            }
        }
    }

    class Lysregulering
    {
        private string farve;

        public Lysregulering()
        {
            farve = "roed";
        }
    }

    class By
    {
        public string Navn;
        public int Indbyggertal;


        public By(string navn)
        {
            Navn = navn;
        }


        public By(string navn, int indbyggertal)
        {
            Navn = navn;
            Indbyggertal = indbyggertal;
        }
    }

    class Regn
    {
        public string dag;
        public float nedboer;
        public Regn(string dag_input, float nedboer_input)
        {
            dag = dag_input;
            nedboer = nedboer_input;
        }
    }

    class RegnCalculator
    {
        public float SamletNedboer(Regn regn1, Regn regn2)
        {
            float total = regn1.nedboer + regn2.nedboer;
            Console.WriteLine(total);
            return total;
        }
    }
}






