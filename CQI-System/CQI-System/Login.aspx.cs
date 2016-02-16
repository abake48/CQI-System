using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
    }
}