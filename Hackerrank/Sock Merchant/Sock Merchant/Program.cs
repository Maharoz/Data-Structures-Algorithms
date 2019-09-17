using System;
using System.Linq;

namespace Sock_Merchant
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] c = Console.ReadLine().Split(' ');
            int result = 0;
            foreach (string color in c.Distinct())
            {
                result += c.Where(ci => ci == color).Count() / 2;
            }
            Console.WriteLine(result);
        }
    }
}
