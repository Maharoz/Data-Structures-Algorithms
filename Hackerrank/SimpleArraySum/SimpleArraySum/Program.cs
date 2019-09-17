using System;

namespace SimpleArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] c = Console.ReadLine().Split(' ');

            int result = 0;
            foreach (var item in c)
            {
                result += Convert.ToInt32(item);
            }

            Console.WriteLine(result);


        }
    }
}
