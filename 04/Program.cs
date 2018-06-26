using System;
using System.Linq;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            string strOne = input[0];
            string strTwo = input[1];

            double result = SumOfCharacters(strOne, strTwo);
            Console.WriteLine(result);


        }

        static double SumOfCharacters(string one, string two)
        {
            double sum = 0;
            int longerString = Math.Min(one.Length, two.Length);

            for (int i = 0; i < longerString; i++)
            {
                sum += one[i] * two[i];
            }

            int addsOne = one.Skip(longerString).Select(c=>(int)c).Sum();
            int addsTwo = two.Skip(longerString).Select(c=>(int)c).Sum();
            sum += addsOne+addsTwo;

            return sum;
        }
    }
}
