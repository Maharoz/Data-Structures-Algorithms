using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            CArray nums = new CArray(5);
            Random rnd = new Random(100);
            for (int i = 0; i < 5; i++)
                nums.Insert((int)(rnd.NextDouble() * 100));
            Console.WriteLine("Before sorting: ");
            nums.DisplayElements();
            Console.WriteLine("During sorting: ");
            nums.BubbleSort();
            Console.WriteLine("After sorting: ");
            nums.DisplayElements();
        }
    }
}
