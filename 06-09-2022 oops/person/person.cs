using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person
{
    public abstract class person
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public abstract void work();
    }
    public class Employee : person
    {
        public override void work()
        {
            base.Description = "employee";
            Console.WriteLine("employee");
        }
    }
}