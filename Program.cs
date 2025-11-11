using System;

namespace Bloc1Activitat9
{
    public class Program
    {
        public static void Main()
        {
            const int NumsAmount = 20;

            Random rnd = new Random();
            int odd_amount = 0;
            int even_amount = 0;
            int[] nums = new int[NumsAmount];
            int[] even;//array where the even numbers will be saved
            int[] odd;//array where the odd numbers will be saved
            int last_num_founded_position = 0;//save the position of the last value saved as odd or even to start from that point and don't repeat nums already saved

            Console.Write("\nNumbers generated: ");
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                nums[i] = rnd.Next(-99, 100);
                Console.Write(i == 0 ? $"{nums[0]}" : $", {nums[i]}");
                if (nums[i] % 2 == 0)
                {
                    even_amount++;//to know the amount of even nums that we will need to save in the even array
                }
                else
                {
                    odd_amount++;//to know the amount of odd nums that we will need to save in the odd array
                }
            }

            even = new int[even_amount];
            odd = new int[odd_amount];

            Console.Write("\n   -> Even ones: ");
            for (int i = 0; i < even.GetLength(0); i++)
            {
                bool even_num_found = false;
                for (int j = last_num_founded_position; j < nums.GetLength(0) && !even_num_found; j++)
                {
                    if (nums[j] % 2 == 0)
                    {
                        even[i] = nums[j];
                        even_num_found = true;
                        last_num_founded_position = j + 1;
                    }
                }
                Console.Write(i == 0 ? $"{even[0]}" : $", {even[i]}");
            }

            Console.Write("\n   -> Odd ones: ");
            last_num_founded_position = 0;
            for (int i = 0; i < odd.GetLength(0); i++)
            {
                bool odd_num_found = false;
                for (int j = last_num_founded_position; j < nums.GetLength(0) && !odd_num_found; j++)
                {
                    if (nums[j] % 2 != 0)
                    {
                        odd[i] = nums[j];
                        odd_num_found = true;
                        last_num_founded_position = j + 1;
                    }
                }
                Console.Write(i == 0 ? $"{odd[0]}" : $", {odd[i]}");
            }
        }
    }
}