using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainbow_Schools
{
    class Person
    {
        private string _name;
        private string _class;
        private string _section;

        public Person(string n, string c, string s)
        {
            this._name = n;
            this._class = c;
            this._section = s;
        }

        public string Name => _name;
        public string Class => _class;

        override
        public string ToString()
        {
            return _name + "," + _class + "," + _section;
        }
    }
}