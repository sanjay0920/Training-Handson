using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productlibrary
{
    internal class Product
    {
        private int _Pid;

        public int PID
        {
            get { return _Pid; }
            set { _Pid = value; }
        }


        private string _Pname;

        public string PName
        {
            get { return _Pname; }
            set { _Pname = value; }
        }
    }
}
