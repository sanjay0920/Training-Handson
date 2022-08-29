using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using productlibrary;

namespace listapplication
{
    class Ps3
    {
        static void Main(string[] args)
        {
            List<int> PIdlist = new List<int>();
            List<string> PNamelist = new List<string>();

            PIdlist.Add(01);
            PIdlist.Add(02);
            PIdlist.Add(03);
            PIdlist.Add(04);
            PIdlist.Add(05);

            PNamelist.Add("pen");
            PNamelist.Add("pencil");
            PNamelist.Add("paper");
            PNamelist.Add("book");
            PNamelist.Add("eraser");

            foreach (var item in PIdlist)
            {
                Console.WriteLine(item);

            }

            foreach (var item in PNamelist)
            {
                Console.WriteLine(item);

            }

            int indexToRemove = 01;

            PIdlist.RemoveAt(indexToRemove);
            foreach (var item in PIdlist)
            {
                Console.WriteLine(item);

            }

            Console.ReadKey();




        }
    }
}