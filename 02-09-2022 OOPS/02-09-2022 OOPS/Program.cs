using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using categorylibrary;
using productlibrary;

namespace demo
{
    class program
    {


        static void Main(string[] args)
        {
            category cat = new category();
            cat.CATID = 01;
            cat.CATNAME = "dairy";
            cat.DESCRIPTION = "p";

            product prod = new product();
            prod.PRODUCTID = 001;
            prod.PRODUCTNAME = "milk";
            prod.QUANTITYSOLD = 20;
            prod.UNITPRICE = 25;
            prod.UNITOFMEASUREMENT = "litre";
            prod.QUANTITYINHAND = 5;

            Console.WriteLine(cat.DESCRIPTION);
            Console.ReadKey();
        }
    }
}