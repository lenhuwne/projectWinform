using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLBH_SOFTWARE
{
    internal class DBContext
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        private String con;

        public String connection()
        {
            con = @"Data Source=ANXEMER;Initial Catalog=Centrix1;Integrated Security=True";
            
            return con;
        }
        
    }
}
