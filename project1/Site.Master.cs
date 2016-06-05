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

            //call addActiveClass method
            addActiveClass();
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
                case "About":
                    about.Attributes.Add("class", "active");
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

            }
            return Page.Title;
        }//method end
    }
}