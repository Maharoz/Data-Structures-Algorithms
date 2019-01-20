using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingTheOccuranceOfElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10] { 65, 43, 23, 67, 87, 49, 98, 13, 52, 60 };
            Console.WriteLine("Enter a number to find whether it exists on a list or not");
            int a = Convert.ToInt32(Console.ReadLine());
            if (numbers.Contains(a))
            {
                Console.WriteLine(a + " Exists in the list");
            }
            else
            {
                Console.WriteLine(a + " Doesnot exists");
            }
            
        }
    }
}
