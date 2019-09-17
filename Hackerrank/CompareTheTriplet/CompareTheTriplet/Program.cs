using System;
using static System.Console;

namespace CompareTheTriplet
{
    class Program
    {
        static void Main(string[] args)
        {
            var ar_al = ReadLine().Split(' ');
            var ar_bo = ReadLine().Split(' ');
            var ar_alice = Array.ConvertAll(ar_al, int.Parse);
            var ar_bob = Array.ConvertAll(ar_bo, int.Parse);
            int alice_point = 0;
            int bob_point = 0;

            for(int i=0; i<ar_alice.Length; i++)
            {
                if (ar_alice[i] > ar_bob[i])
                {
                    alice_point += 1;
                }
                else if (ar_alice[i] < ar_bob[i])
                {
                    bob_point += 1;
                }
            }

            Console.WriteLine(string.Format("{0} {1}",alice_point,bob_point));
        }
    }
}
