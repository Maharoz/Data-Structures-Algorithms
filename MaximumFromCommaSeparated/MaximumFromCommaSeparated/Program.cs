using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumFromCommaSeparated
{
    class Program
    {
        static void Main(string[] args)
        {

            //problem definition Write a program and ask the user to enter a series of 
            //numbers separated by comma. Find the maximum of the numbers and display it 
            //on the console. For example, if the user enters “5, 3, 8, 1, 4", the program should display 8
            var result = 0;
            Console.WriteLine("Please enter numbers in comma separated format");
            var content = Console.ReadLine();
            int[] numbers = content.Split(',').Select(int.Parse).ToList().ToArray();            
            result = numbers[0];
            for (int i = 0; i< numbers.Count(); i++)
            {
               
                if(numbers[i]> result)
                {
                    result = numbers[i];

                }
            }
            Console.WriteLine(result);
        }
    }
}
