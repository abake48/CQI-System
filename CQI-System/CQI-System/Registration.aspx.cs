using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace TestProject
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack)
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UserInfoConnectionString1"].ConnectionString);
                conn.Open();
                string checkuser = "select count(*) from UserInfo where UserName = '"+ TextBoxUser.Text +"'";
                SqlCommand com = new SqlCommand(checkuser, conn);
                int temp = Convert.ToInt32(com.ExecuteScalar().ToString());

                if (temp < 0)
                    Response.Write("User already exists");

                conn.Close();

            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection nect = new SqlConnection(ConfigurationManager.ConnectionStrings["UserInfoConnectionString1"].ConnectionString);
                nect.Open();

                string insertQuery = "insert into UserInfo(FirstName,LastName,UserName,Password,Email) values (@first, @last, @user, @pword, @email)";
                SqlCommand com = new SqlCommand(insertQuery, nect);

                com.Parameters.AddWithValue("@first", TextBoxFirst.Text);
                com.Parameters.AddWithValue("@last", TextBoxLast.Text);
                com.Parameters.AddWithValue("@user", TextBoxUser.Text);
                com.Parameters.AddWithValue("@pword", TextBoxPWD.Text);
                com.Parameters.AddWithValue("@email", TextBoxEmail.Text);

                com.ExecuteNonQuery();
                Response.Redirect("Manager.aspx");   
                Response.Write("Registration was successful");

                nect.Close();
            }
            catch(Exception ex)
            {
                Response.Write("Error:" + ex.ToString());
            }
        }

    }
}