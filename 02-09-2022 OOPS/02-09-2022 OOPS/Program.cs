using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using categorylibrary;
using productlibrary;


namespace application

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Category c = new Category();
            c.CatID = 121;
            c.CatName = "Laptops";
            c.Description = "Electronic Device";

            Console.WriteLine("Category ID: " + c.CatID);
            Console.WriteLine("Category Name: " + c.CatName);
            Console.WriteLine("Category Description: " + c.Description);

            Products pro1 = new Products();
            pro1.ProductID = 01;
            pro1.ProductName = "TV";
            pro1.QTYSold = 20000;
            pro1.UnitPrice = 50000;
            pro1.UnitOFMeasurement = "44 inch";
            pro1.QtyInHand = 1;
            pro1.ReorderLevel = 0;

            Products pro2 = new Products();
            pro2.ProductID = 02;
            pro2.ProductName = "AC";
            pro2.QTYSold = 30000;
            pro2.UnitPrice = 90000;
            pro2.UnitOFMeasurement = "40 inch";
            pro2.QtyInHand = 02;
            pro2.ReorderLevel = 04;

            Products pro3 = new Products();
            pro3.ProductID = 03;
            pro3.ProductName = "Washing Machine";
            pro3.QTYSold = 40000;
            pro3.UnitPrice = 50000;
            pro3.UnitOFMeasurement = "50 inch";
            pro3.QtyInHand = 230;
            pro3.ReorderLevel = 30;

            List<Products> productlist = new List<Products>();
            productlist.Add(pro1);
            productlist.Add(pro2);
            productlist.Add(pro3);
            c.ProductsList = productlist;

            foreach (var i in c.ProductsList)
            {

                Console.WriteLine("Product ID: " + i.ProductID);
                Console.WriteLine("Product Name: " + i.ProductName);
                Console.WriteLine("QTY to Sold: " + i.QTYSold);
                Console.WriteLine("Unit Price: " + i.UnitPrice);
                Console.WriteLine("Unit of Measurement: " + i.UnitOFMeasurement);
                Console.WriteLine("Qty in Hand: " + i.QtyInHand);
                Console.WriteLine("Reorder Level: " + i.ReorderLevel);
                Console.WriteLine("---------------");
                Category c1 = new Category();
                c1.CountProduct();
                Console.ReadLine();
            }
        }
    }
}