using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DisplaySQL.App_Code
{
    public class DBMaster
    {
        private SqlConnection conn;

        public SqlConnection getConnection()
        {
            //CONNECT TO DB
            //Use thrusted connection for production
            string connStr = "Server=10.0.0.62;Database=dwsystem;User Id=sa; Password=123456;";
             conn = new SqlConnection(connStr);
            conn.Open();
            return conn;
     
        }
        
        public SqlDataReader getReader(string query)
        {
            // CREATE A COMMAND
            // Use stored procedure in production
            SqlCommand cmd = new SqlCommand(query);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = this.getConnection();

            //READ FROM DB
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
        public void closeConnection()
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                this.conn.Close();
            }
        }
    }
}