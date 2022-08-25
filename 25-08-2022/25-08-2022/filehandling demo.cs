using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace filehandlingdemo
{
    internal class Filestreamdemo
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("test.txt", FileMode.Create, FileAccess.Write);
            
        }
    }
}
             