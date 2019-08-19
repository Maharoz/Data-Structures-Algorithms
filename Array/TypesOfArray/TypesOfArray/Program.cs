using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers;
            numbers = new int[]{0,1,2,3,4};
            Type arrType = numbers.GetType();
            if (arrType.IsArray)
            {
                Console.WriteLine("The array type is : {0}",arrType);
            }
            else
            {
                Console.WriteLine("Not an array");
            }

            Console.Read();
        }
    }
}
