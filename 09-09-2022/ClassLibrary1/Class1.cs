using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace ClassLibrary1
{
    public class Threading
    {
        static void M1()
        {
            Thread.Sleep(1000);
            Console.WriteLine("sleep state =" + Thread.CurrentThread.ThreadState);
        }
    }
}