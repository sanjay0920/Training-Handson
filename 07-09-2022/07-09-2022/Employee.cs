using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_09_2022
{
    class Employee
    {
        
		private int joiningyear;

		public int JoiningYear
		{
			get { return joiningyear; }
			set { joiningyear = value; }
		}

	}
	class Program
	{
		static void Main(string[] args)
		{
			Employee employee = new Employee();
			employee.JoiningYear = 2022;
			Console.WriteLine(employee.JoiningYear);
		}
	}
}

