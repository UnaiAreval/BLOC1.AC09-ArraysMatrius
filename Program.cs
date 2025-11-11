using System;

namespace Bloc1Activitat9
{
    public class Program
    {
        public static void Main()
        {
            const string DisplayNumbers = "\nEls nombres generats són: ";
            const string DisplayReversOrder = "\nEls nombres amb l'ordre invertit:";
            const string Number = " {0} |";
            const int Min = 1;
            const int Max = 10; //the max value is 9, but to use it with the random you need the next number, in this case, 10
            const int NumsAmount = 20;
            Random random = new Random();
            int[] nums = new int[NumsAmount];

            Console.WriteLine(DisplayNumbers);
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                nums[i] = random.Next(Min, Max);
                Console.Write(Number, nums[i]);
            }

            Console.WriteLine(DisplayReversOrder);
            for (int i = nums.GetLength(0) - 1; i >= 0; i--)
            {
                Console.Write(Number, nums[i]);
            }

        }
    }
}