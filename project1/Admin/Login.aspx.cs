/* File name: Login.aspx.cs
 * Author's name: Pui In Kwok and Mo Zou
 * Web site name: Game Tracker
 * File description: This page will check if the username and password
                     user enter is correct, if yes direct to default page.
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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

		//login button click
        protected void LoginButton_Click(object sender, EventArgs e)
        {
            // create new userStore and userManager objects
            var userStore = new UserStore<IdentityUser>();
            var userManager = new UserManager<IdentityUser>(userStore);

            // search for and create a new user object
            var user = userManager.Find(UserNameTextBox.Text, PasswordTextBox.Text);


            // if a match is found for the user
            if(user != null)
            {
                // authenticate and login our new user
                var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
                var userIdentity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);

                // Sign the user
                authenticationManager.SignIn(new AuthenticationProperties() { IsPersistent = false }, userIdentity);

                // Redirect to Main Menu
                Response.Redirect("~/Details/GameTracker.aspx");
            }
            else
            {
                // throw an error to the AlertFlash div
                StatusLabel.Text = "Invalid Username or Password";
                AlertFlash.Visible = true;
            }

        }
        
    }
}