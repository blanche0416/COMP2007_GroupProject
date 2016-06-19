/* File name: Site.Master.aspx.cs
 * Author's name: Pui In Kwok and Mo Zou
 * Web site name: Game Tracker
 * File description: This is the site master.cs for all the pages
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project1
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                // check if a user is logged in
                if (HttpContext.Current.User.Identity.IsAuthenticated)
                {

                    // show the game tracker area
                    DetailsPlaceHolder.Visible = true;
                    AdminPlaceHolder.Visible = false;
                }
                else
                {
                    // only show login and register
                    DetailsPlaceHolder.Visible = false;
                    AdminPlaceHolder.Visible = true;
                    
                }
                addActiveClass();
            }
        }


        /**
         *method adds the active class to each li in navbar, master page 
         * according to the page title
         */
        private string addActiveClass()
        {
            //switch pages
            switch (Page.Title)
            {
                case "Home Page":
                    home.Attributes.Add("class", "active");
                    break;
                case "GameTracker":
                    gametracker.Attributes.Add("class", "active");
                    break;
                case "Contact":
                    contact.Attributes.Add("class", "active");
                    break;
                case "Register":
                    register.Attributes.Add("class", "active");
                    break;
                case "Login":
                    login.Attributes.Add("class", "active");
                    break;
				case "Logout":
                    logout.Attributes.Add("class", "active");
                    break;

            }
            return Page.Title;
        }//method end
    }
}