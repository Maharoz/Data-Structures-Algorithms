using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingDivisibleByThree
{
    class Program
    {
        //Problem description
        //Write a program to count how many numbers between 1 and 100
        //are divisible by 3 with no remainder. Display the count on the console.
        static void Main(string[] args)
        {
            var a = 0;
            for(int i=1; i<=100; i++)
            {
                if (i % 3 == 0)
                {
                    a = a + 1;
                }

            }
            Console.WriteLine("Total between 1 and 100 are divisible by 3 with no remainder is : " + a);
        }
    }
}
