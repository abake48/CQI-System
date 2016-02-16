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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_manage_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("Manager.aspx");
            }
            catch(Exception ex)
            {
                Response.Write("Error:" + ex.ToString());
            }
        }

        protected void button_login_Click(object sender, EventArgs e)
        {
            try {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                conn.Open();
                string checkEmail = "select count(*) from AcctReg where Email = '" + login_email.Text + "' and Password = '"+ login_pwd.Text +"'";
                SqlCommand com = new SqlCommand(checkEmail, conn);
                int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
                if (temp == 1)
                    Response.Write("Login Successful");
                else
                    Response.Write("Email or Password was incorrect");

                conn.Close();
            }
            catch(Exception ex)
            {
                Response.Write("Error:" + ex.ToString());
            }
        }
    }
}