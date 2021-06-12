using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace DAL
{
    public class Connect2DB
    {
        public SqlConnection conn = new SqlConnection();

        public Connect2DB()
        {
            string connectionString = @"Data Source=LEANHVU\SQLEXPRESS;Initial Catalog=QuanLySach;Integrated Security=True";

            try
            {
                this.conn.ConnectionString = connectionString;
                conn.Open();
            } catch(SqlException e)
            {
                throw e;
            }
        }
    }
}
