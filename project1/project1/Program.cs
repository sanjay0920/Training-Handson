using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(data.txt);
            foreach (string s in lines)
            {
                Console.WriteLine(s);
            }

            string text = File.ReadAllText("@ C:\\datas");
            Console.WriteLine(text);
        }
    }
}
