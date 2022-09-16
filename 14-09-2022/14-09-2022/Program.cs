using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;
using System.Text;
using System.Threading.Tasks;
using classes;

namespace application
{
    class Program
    {
        public static void binaryserialization(Customer c1)
        {
            c1.Id = 001;
            c1.Password = 001 + "password";
            c1.Validateuser(c1);
            FileStream fs = new FileStream(@"userfile.bin",FileMode.Create,FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, c1);
            fs.Flush();
            fs.Close();
            fs.Dispose();
        }
    }
}