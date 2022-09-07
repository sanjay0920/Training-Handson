using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_09_2022
{
     class product
    {
        
		private int prodid;

		public int ProdId
		{
			get { return prodid; }
			set { prodid = value; }
		}
		
		private string prodname;

		public string ProdName
		{
			get { return prodname; }
			set { prodname = value; }
		}

	}
	class program
	{
		static void Main(string[] args)
		{
			product product = new product();
			product.ProdId = 001;
			product.ProdName = "Laptop";
			Console.WriteLine(product.ProdId);
			Console.WriteLine(product.ProdName);
		}
	}
}
