using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheSecretNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            Console.WriteLine("Guess the number");
            var b = Convert.ToInt32(random.Next(1, 10));
            Console.WriteLine(b);
            for(int i = 0; i < 4; i++)
            {
                var a = Convert.ToInt32(Console.ReadLine());
                if (a == b)
                {
                    Console.WriteLine("You Won");
                    break;
                }
                else
                {
                    Console.WriteLine("You Lost");
                }

            }
        }
    }
}
