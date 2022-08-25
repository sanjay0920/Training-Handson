using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace filehandling
{
    public class Ps2
    {
        public static void Main(string[] args)
        {
            //creating file..........
            //string path =  @"c:\temp";
            //Console.WriteLine("Enter the file name");
            //string fname = Console.ReadLine();
            //File.Create(path+fname);
            //fname = string.Concat(path, fname);
            //File.Create(fname);
            //Console.WriteLine("file created successfully...");

            //copying file
            //File.Copy(fname, "copiedFile.txt");
            //Console.WriteLine("file copied successful");
            //Console.ReadLine();

            FileInfo fileInfo = new FileInfo(fname);
            Console.WriteLine(fileInfo.FullName + "  Full Name");
            Console.WriteLine(fileInfo.DirectoryName + " DirectoryName");
            Console.WriteLine(fileInfo.CreationTime);
        }
    }
}