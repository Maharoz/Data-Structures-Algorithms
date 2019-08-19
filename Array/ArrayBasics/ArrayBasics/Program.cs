using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring an Array
            string[] names = new string[10];

            //setting values
            names[2] = "Raymond";
            names.SetValue("Maharoz",4);

            //Geting Values
            var myName = names[2];
            var getName = names.GetValue(2);

            Console.WriteLine(getName);
        }
    }
}
