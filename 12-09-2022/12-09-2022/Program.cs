using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double No, result;
            Console.WriteLine("Enter a Number : ");
            No = Convert.ToDouble(Console.ReadLine());
            double SqrtNumber = Math.Sqrt(No);
            No = Convert.ToDouble(Console.ReadLine());
            result = Math.Ceiling(Math.Pow(No, (double)1 / 3));
            Console.WriteLine("Square root of {0} is: {1}", No, SqrtNumber);
            Console.WriteLine("cube root : " + result);
           
            Console.ReadLine();
        }
        
        
            
            
    }
}

