using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace filehandlingproblem
{
    public class Ps1
    {
        public static void Main(string[] args)
        {
            //adding file............
            FileStream fs = new FileStream(@"c:\temp\test.txt", FileMode.OpenOrCreate, FileAccess.Write);
            
            //editing file..........
            StreamWriter m_streamWriter = new StreamWriter(fs);
            m_streamWriter.BaseStream.Seek(0, SeekOrigin.End);
            m_streamWriter.WriteLine(" edit in the text file. \n ");
            m_streamWriter.Flush();

            //truncating file.........
            fs.SetLength(0);
            Console.WriteLine("Enter text. Type a blank line to exit\r\n");

            fs.Close();
        }
    }
}

