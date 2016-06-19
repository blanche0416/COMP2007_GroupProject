/* File name: GameTracker.aspx.cs
 * Author's name: Pui In Kwok and Mo Zou
 * Web site name: Game Tracker
 * File description: Here will get the game data from database and bind it with 
                     gridview, then show the data in the page.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using project1.Models;
using System.Web.ModelBinding;
using System.Linq.Dynamic;

namespace project1
{
    public partial class GameTracker : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //set students from EF db
                this.GetGames();

                //if (HttpContext.Current.User.Identity.IsAuthenticated)
                //{
                    // show everything              
                //}
                //else
                //{
                    // page before login
                    //GameTrackersGridView.Columns[6].Visible = false;

                //}
            }
        }
        protected void GetGames()
        {
            using (ContosoConnection db = new ContosoConnection())
            {
                    var Games = (from allGames in db.Games
                                 select allGames);

                    GameTrackersGridView.DataSource = Games.ToList();
                    GameTrackersGridView.DataBind();
            }
        }
    }
}