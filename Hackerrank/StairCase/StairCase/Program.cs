using System;
using static System.Console;
namespace StairCase
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(ReadLine());
            for (int i = 1; i <= n; i++)
            {
                var spaces = new String(' ', n - i);
                var hashes = new String('#', i);
                WriteLine(spaces + hashes);

            }

        }
    }
}
