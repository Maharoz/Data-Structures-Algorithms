using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestElementFinding
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[5] { 88,64,90,76,34};
            var largest = number[0];
            for(int i = 0; i < number.Length; i++)
            {
                if (largest < number[i])
                {
                    largest = number[i];
                }
            }
            Console.WriteLine("Largest number is " + largest);
        }
    }
}
