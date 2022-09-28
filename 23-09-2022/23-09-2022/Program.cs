using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel.Design;

namespace _23_09_2022
{
     class Program
    {
        static void Main(string[] args)
        {
            string connectionstring = "Data Source=LAPTOP-4OFMFRFR\\SQLEXPRESS;Initial Catalog=LibrarySystem;Integrated Security=True";
            SqlConnection cn = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand("select * from products", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            cn.Close();

        }
    }
}
