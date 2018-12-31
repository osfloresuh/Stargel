using DisplaySQL.App_Code;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DisplaySQL
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBMaster dbm = new DBMaster();
            SqlDataReader reader = dbm.getReader("SELECT TOP 10 [LoginID] ,[JobTitle] FROM [HumanResources].[Employee]");


            string temp = "";

          
            while (reader.Read())
            {
                temp += reader["LoginID"].ToString();
                temp += reader["JobTitle"].ToString();
                temp += "<br/>";
            }

            dbm.closeConnection();

            lbl_test.Text = temp;

        }
    }
}