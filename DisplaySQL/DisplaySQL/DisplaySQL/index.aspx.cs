using DisplaySQL.App_Code;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;

namespace DisplaySQL
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                result.Visible = false;

            }
            DBMaster dbm = new DBMaster();
            SqlDataReader reader = dbm.getReader("SELECT [name],[email] FROM [dbo].[DWUser]");
            if(!IsPostBack)
            {
               
            }

            string temp = "";

          
            while (reader.Read())
            {
                temp += reader["name"].ToString();
                temp += "<br/>";
                temp += reader["email"].ToString();
                temp += "<br/>";
            }

            dbm.closeConnection();
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = "Server=10.0.0.62;Database=dwlogging;User Id=sa; Password=123456;";
            SqlConnection con = new SqlConnection(connStr);
            con.Open();
            string qr = "SELECT * FROM DWLOG_system1 WHERE CONVERT(VARCHAR(25), loggingDate, 126) LIKE '" + TextBox1.Text + "%' ";
            SqlCommand cmd = new SqlCommand(qr, con);
            SqlDataReader dr = cmd.ExecuteReader();
            bool recordfound = dr.Read();
            if (recordfound)
            {
                result.Visible = true;
                Label1.Text = "Record found ....";
                Label1.ForeColor = System.Drawing.Color.Green;
                lblname.Text = dr["username"].ToString();
                lbllevel.Text = dr["loggingLevel"].ToString();

            }
            else
            {
                result.Visible = false;
                Label1.Text = "Record Not found ....";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}