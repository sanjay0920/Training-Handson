using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application
{
    class program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "sanjay");
            dict.Add(2, "bharathi");
            dict.Add(3, "hi");
            Console.WriteLine("Values in Dictionary are: ");
            foreach (KeyValuePair<int, string> item in dict)
            {
                Console.WriteLine(item.Key + "  " + item.Value);

            }
            Console.ReadKey();
        }
    }
}