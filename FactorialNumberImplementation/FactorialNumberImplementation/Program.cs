using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialNumberImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            //problem definition Write a program and ask the user to enter a number.
            //Compute the factorial of the number and print it on the console. For example,
            //if the user enters 5, the program 
            //should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120
            Console.WriteLine("Please enter a number to calculate factorial");
            var a = Console.ReadLine();
            int factorial = 1;
            for(int i = Convert.ToInt32(a); i>= 1; i--)
            {
                factorial = factorial * i;

            }
            Console.WriteLine("5!= " + factorial);
        }
    }
}
