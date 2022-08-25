using System;
using System.IO;
namespace filehandling
{ 
    public class Ps4
    {
        public static void Main(string[] args)
        {
            DriveInfo[] driverslist = DriveInfo.GetDrives();
            foreach (DriveInfo d in driverslist)
            {
                Console.WriteLine("Drive {0}", d.Name);
                Console.WriteLine("  File type: {0}", d.DriveType);
                if (d.IsReady == true)
                {
                    Console.WriteLine(" Total size of drive:{0, 15} bytes ", d.TotalSize);
                    Console.Read();
                }
            }
        }
    }
}