using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_09_2022
{
    public class Department
    {
		public int deptno { get; set; }
		
		public  string deptname { get; set; }
		
		public string location { get; set; }
		
	}

	public class Employee:Department
	{
		public int empid { get; set; }

		public string empname { get; set; }

		public int salary { get; set; }

		public string manager { get; set; }
	}
}
