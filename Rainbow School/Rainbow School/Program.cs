using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using models;

namespace Rainbow_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();

            if (menu.CanOpenMenu())
            {
                string option = "";

                do
                {
                    option = menu.ShowMenu();
                } while (!option.Equals("0"));
            }
            else
            {
                Console.WriteLine("Something wrong with datas, this program will close in 5 seconds");
                System.Threading.Thread.Sleep(5000);
            }

        }
    }
}
