using System;

namespace _08
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new[] { ' ', '\t'}, StringSplitOptions.RemoveEmptyEntries );
            double result = 0;
            foreach (var word in words)
            {
                char firstLetter = word[0];
                char lastLetter = word[word.Length - 1];

                double numbers = double.Parse(word.Substring(1, word.Length - 2));

                if (char.IsUpper(firstLetter))
                {
                    numbers /= (firstLetter - 64);
                }
                else
                {
                    numbers *= (firstLetter - 96);
                }

                if (char.IsUpper(lastLetter))
                {
                    numbers -= (lastLetter - 64);
                }
                else
                {
                    numbers += (lastLetter - 96);
                }

                result += numbers;
            }

            Console.WriteLine($"{result:f2}");
        }
    }
}
