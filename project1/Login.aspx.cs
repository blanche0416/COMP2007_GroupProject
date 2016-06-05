using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SendButton_Click(object sender, EventArgs e)
        {
            //go to default page if login successfully

            Response.Redirect("Default.aspx");


        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            //cancel button is clicked, everything go empty
            UsernameTextBox.Text = "";
            PasswordTextBox.Text = "";
          
        }

    }
}