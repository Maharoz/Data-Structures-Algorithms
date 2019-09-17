using System;

namespace A_Very_Big_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] c = Console.ReadLine().Split(' ');
            long result = 0;
            var ar = Array.ConvertAll(c, long.Parse);

            for(int i = 0; i < ar.Length; i++)
            {
                result += ar[i];
            }
            Console.WriteLine(result);
        }
    }
}
