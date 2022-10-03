using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Disconnected_BLL;

namespace Disconnected_DAL
{
    public class DAL
    {
        DataSet ds = null;
        SqlDataAdapter da = null;
        SqlConnection cn = null;

        public DL()
        {
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["imscnstr"].ConnectionString);
        }
    }
}
