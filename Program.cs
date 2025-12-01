using System;

namespace Bloc1Activitat9
{
    public class Program
    {
        public static void Main()
        {
            const string DisplayNumbers = "Els nombres generats són: ";
            const string DisplayReversOrder = "\nEls nombres amb l'ordre invertit:";
            const string DisplaySmollerToBigger = "\nEls nombres ordenats de més petit a més gran:";
            const string Number = " {0} |";
            const string AskNumToSearch = """
                Quin número voldries buscar en la llista?
                -> 
                """;
            const string IncorrectVarType = "No s'ha introduit el tipo de variable correcte";
            const string NumNotFound = "No s'ha trobat el número";
            const string NumFound = "El número {0} s'ha trobat {1} begades";
            const string PressToContinue = "\nPrem qualsevol tecla per continuar...";
            const int Min = 1;
            const int Max = 10; //the max value is 9, but to use it with the random you need the next number, in this case, 10
            const int NumsAmount = 10;

            Random random = new Random();
            int[] nums = new int[NumsAmount];
            int numToSearch;
            int amountOfTimes = 0; //The amount of times that the searched number is found

            Console.WriteLine(DisplayNumbers);
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                nums[i] = random.Next(Min, Max);
                Console.Write(Number, nums[i]);
            }

            Console.WriteLine(DisplayReversOrder);
            foreach (int n in nums)
            {
                Console.Write(Number, n);
            }

            for (int i = 0; i < nums.GetLength(0) - 1; i++)
            {
                for (int j = i + 1; j < nums.GetLength(0); j++)
                {
                    int vector;//used to change the positon of the numbers to order the array
                    if (nums[i] > nums[j])
                    {
                        vector = nums[i];
                        nums[i] = nums[j];
                        nums[j] = vector;
                    }
                }
            }

            Console.WriteLine(DisplaySmollerToBigger);
            foreach (int n in nums)
            {
                Console.Write(Number, n);
            }
            Console.Write(PressToContinue);
            Console.ReadKey();

            Console.Clear();
            Console.Write(AskNumToSearch);
            try
            {
                numToSearch = Int32.Parse(Console.ReadLine());
                if (numToSearch >= Min && numToSearch < Max)
                {
                    foreach (int n in nums)
                    {
                        if (numToSearch == n) amountOfTimes++;
                    }
                    if (amountOfTimes > 0)
                    {
                        Console.WriteLine(NumFound, numToSearch, amountOfTimes);
                    }
                    else
                    {
                        Console.WriteLine(NumNotFound);
                    }
                }
                else
                {
                    Console.WriteLine(NumNotFound);
                }
            }
            catch
            {
                Console.WriteLine(IncorrectVarType);
            }
        }
    }
}