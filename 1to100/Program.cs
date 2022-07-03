//1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.
using System;

namespace loops
{
    class Program
    {
        static void Main()
        {
            var count = 0;
            for(int i = 0; i <= 100;i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("count of numbers divisible by 3 between 1 to 100 are: {0}",count);
        }
    }
}