using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_SOFTWARE
{
    internal class KetNoi
    {
        public string connectString = @"Data Source=LAPTOP-DRPTOLNJ\LENHU;Initial Catalog=Centrix;Integrated Security=True";
        public SqlConnection getConnect()
        {
            SqlConnection sqlConn = new SqlConnection(connectString);
            sqlConn.Open();
            return sqlConn;
        }
    }
}
