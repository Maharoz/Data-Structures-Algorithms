using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputNumberOrExit
{
    class Program
    {
        static void Main(string[] args)
        {
            //problem definition : Write a program and continuously ask
            //the user to enter a number or "ok" to exit. Calculate the sum of 
            //all the previously entered numbers and display it on the console.
            bool a = true;
            int number = 0;
            while(a == true){
                Console.WriteLine("Please enter a number");
                var input = Console.ReadLine();
                if (input.ToUpper() != "OK")
                {
                    number = number + Convert.ToInt32(input);
                    
                }
                else
                {
                    a = false;
                }
            }
            Console.WriteLine("Your total entered value is " + number);
        }
    }
}
