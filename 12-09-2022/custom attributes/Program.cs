using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Song
{
    [System.AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    sealed class DeveloperAttribute : Attribute
    {
        public DeveloperAttribute(string name)
        {

        }
        public string SongName { get; set; }
        public string Language { get; set; }
        public string Lyrics { get; set; }

    }
}