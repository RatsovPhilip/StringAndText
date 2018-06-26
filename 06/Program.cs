using System;
using System.Text;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            string numOne = Console.ReadLine().TrimStart('0');
            string numTwo = Console.ReadLine().TrimStart('0');

            int longerLength = Math.Max(numOne.Length, numTwo.Length);

            StringBuilder result = new StringBuilder(longerLength + 1);

            numOne = numOne.PadLeft(longerLength, '0');
            numTwo = numTwo.PadLeft(longerLength, '0');
            int remainder = 0;

            for (int i = longerLength - 1; i >= 0; i--)
            {
                int num1 = int.Parse(numOne[i].ToString());
                int num2 = int.Parse(numTwo[i].ToString());
                int currSum = num1 + num2 + remainder;
                int sum = currSum % 10;
                remainder = currSum / 10;

                result.Append(sum);
            }

            if (remainder > 0)
            {
                result.Append(remainder);
            }

            for (int i = result.Length - 1; i >= 0; i--)
            {
                Console.Write(result[i]);
            }

            Console.WriteLine();
        }
    }
}
