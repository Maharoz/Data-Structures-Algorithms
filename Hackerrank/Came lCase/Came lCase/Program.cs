using System;

namespace Came_lCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int word = 1;
            foreach (char item in s)
            {
                if (item < 91 && item > 64)
                {
                    word += 1;
                }
            }
            Console.WriteLine(word);
        }
    }
}
