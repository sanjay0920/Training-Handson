using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Mydict = new Dictionary<int, string>();
            Mydict.Add(1, "hi");
            Mydict.Add(2, "sanjay");
            Mydict.Add(3, "bharathi");

            foreach (KeyValuePair<int, string> elem in Mydict)
            {
                Console.WriteLine("{0} and {1}", elem.Key, elem.Value);

            }
            SortedDictionary<int, string> Mydict1 = new SortedDictionary<int, string>()
            {
                 {1, "hi"}, {5, "sanjay"},{2, "bharathi"},


             };
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
