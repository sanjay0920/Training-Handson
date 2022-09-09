using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ClassLibrary1;
namespace application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] cs = new Book[2];
            for (int i = 0; i < cs.Length; i++)
            {
                Book B = new Book();
                Console.WriteLine("Enter book ID");
                B.ID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter book name");
                B.Name = Console.ReadLine();
                Console.WriteLine("Enter price");
                B.price = Convert.ToInt32(Console.ReadLine());
                cs[i] = B;
            }
            for (int i = 0; i < 2; i++)
            {


                cs[i].Display();
            }
            Console.WriteLine("details");
            Console.ReadLine();
        }
    }
}