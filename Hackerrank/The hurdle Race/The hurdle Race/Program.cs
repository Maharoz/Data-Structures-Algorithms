using System;

namespace The_hurdle_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split(' ');
            var s_a = Array.ConvertAll(s, int.Parse);

            var v = Console.ReadLine().Split(' ');
            var v_a = Array.ConvertAll(v, int.Parse);

            int max_hurdle_height = 0;

            for (int i = 0; i < v_a.Length; i++)
            {
                if (v_a[i] > max_hurdle_height)
                {
                    max_hurdle_height = v_a[i];
                }
            }

            int result = max_hurdle_height - s_a[1];

            if (result > 0)
            {
                Console.WriteLine(max_hurdle_height - s_a[1]);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
