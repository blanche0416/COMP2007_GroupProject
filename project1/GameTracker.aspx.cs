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
            }
        }
        protected void GetGames()
        {
            using (DefaultConnection db = new DefaultConnection())
            {
                    var Games = (from allGames in db.Games
                                 select allGames);

                    GameTrackersGridView.DataSource = Games.ToList();
                    GameTrackersGridView.DataBind();
            }
        }
    }
}