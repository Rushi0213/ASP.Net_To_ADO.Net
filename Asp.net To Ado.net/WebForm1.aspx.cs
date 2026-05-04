using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace Connection_Ado_NET
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // connection on sql sever

            string path = " Data source=hp\\SQLEXPRESS; Initial Catalog=student; Integrated Security=true";
             SqlConnection conn = new SqlConnection(path);
             conn.Open();
             Response.Write("connection succesfull!");
            

            // connection on mysql server

            //string path = "Server=localhost;Database=Collage;Uid=root;password=;";

            //MySqlConnection conn = new MySqlConnection(path);
            //conn.Open();
            //Response.Write("connection succesfull!");
        }
    }
}