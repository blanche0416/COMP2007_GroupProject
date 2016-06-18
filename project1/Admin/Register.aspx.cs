/* File name: Register.aspx.cs
 * Author's name: Pui In Kwok and Mo Zou
 * Web site name: Game Tracker
 * File description: This page will get the data in the textbox and
                     all it to db if user is not exist
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// required for Identity and OWIN Security
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;

namespace project1
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //cancel button is clicked, everything empty
        protected void CancelButton_Click(object sender, EventArgs e)
        {
             //back to the Default page
            Response.Redirect("~/Default.aspx");
        }

		//submit button is clicked
        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            // create new userStore and userManager objects
            var userStore = new UserStore<IdentityUser>();
            var userManager = new UserManager<IdentityUser>(userStore);

            // create a new user object
            var user = new IdentityUser()
            {
                UserName = UserNameTextBox.Text,
                Email = EmailTextBox.Text
            };

            // create a new user in the db and store the result 
            IdentityResult result = userManager.Create(user, PasswordTextBox.Text);

            // check if successfully registered
            if(result.Succeeded)
            {
                // authenticate and login our new user
                var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
                var userIdentity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);

                // sign in 
                authenticationManager.SignIn(new AuthenticationProperties() { }, userIdentity);

                // Redirect to the Main Menu page
                Response.Redirect("~/Details/GameTracker.aspx");
            }
            else
            {
                // display error in the AlertFlash div
                StatusLabel.Text = result.Errors.FirstOrDefault();
                AlertFlash.Visible = true;
            }
        }
    }
}