namespace ØvelserClasses
{
    class Algorithms
    {
        public int factorize(int num)
        {
            
            if (num > 1)
            {
                num = num * factorize(num - 1);
            }
            return num;
        }

        public void bottles_of_beer(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"{num} bottles of beer on the wall, {num} bottles of beer. \n " +
                    $"Take one down and pass it around, {num - 1} bottles of beer on the wall.");

                bottles_of_beer(num - 1);
            }
        }

        public void print_sorted(float[] numbers, bool descending = false)
        {
            Array.Sort(numbers);
            if (descending) Array.Reverse(numbers);
            foreach(float value in numbers)
            {
                Console.Write(value + " ");
            }
        }

        public void print_sorted_string(string[] arr)
        {
            Array.Sort<string>(arr, new Comparison<string>((s1,s2) => s1.Length.CompareTo(s2.Length)));
            foreach(string sentence in arr) Console.WriteLine(sentence);
        }
        
        public void shuffle_and_print(int[] arr)
        {
            Random random = new();
            arr = arr.OrderBy(x => random.Next()).ToArray();

            foreach (int value in arr) Console.WriteLine(value);
        }

        public void shuffle_and_print_strings(string[] arr)
        {
            int[] indexes = new int[arr.Length];
            for(int i=0; i<arr.Length; i++) indexes[i] = i;

            Random random = new();
            indexes = indexes.OrderBy(x => random.Next()).ToArray();

            foreach(int index in indexes)
            {
                Console.WriteLine(arr[index]);
            }
        }

        static public string[] size = new string[] { "tiny", "small", "large", "gigantic" };
        static public string[] color = new string[] { "red", "blue", "green" };
        static public string[] type = new string[] { "box", "ball", "backpack", "car", "playground" };
        
        public string[] random_draw(string[] arr, int number_of_draws)
        {
            string[] descriptions = new string[number_of_draws];
            Random rnd = new Random();
            for (uint i = 0; i < number_of_draws; i++)
            {
                descriptions[i] = arr[rnd.Next(0,arr.Length - 1)];
            }

            return descriptions;
        }
        
        public void create_descriptions(int number_of_descriptions)
        {
            string[] sizes = random_draw(size, number_of_descriptions);
            string[] colors = random_draw(color, number_of_descriptions);
            string[] types = random_draw(type, number_of_descriptions);

            for(int i = 0; i < number_of_descriptions; i++)
            {
                Console.WriteLine(sizes[i] + " " + colors[i] + " " + types[i]);
            }
        }

        public void number_reperater()
        {
            float[] numbers = new float[10];
            for(int i = 0; i < 10; i++)
            {
                numbers[i] = float.Parse(Console.ReadLine());
                for (int j = 0; j <= i; j++) Console.WriteLine(numbers[j]);
            }
        }

        public void number_shuffler(int[] numbers)
        {

        }
    }
}


