using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application
{
    class Program
    {
        public static void M1()
        {
            Console.WriteLine("function called using Thread");
        
        }
         public static void M2(object data)
        {
            Console.WriteLine("function called using parameterizedthreadstart Delegate :" + data);
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(M1);
            Thread t2 = new Thread(M2);
        }
    }
}
   