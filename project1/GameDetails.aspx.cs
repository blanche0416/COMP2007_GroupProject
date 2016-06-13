/* File name: GameDetails.aspx.cs
 * Author's name: Pui In Kwok and Mo Zou
 * Web site name: Game Tracker
 * File description: Here will get the team data from database and bind it with 
                     gridview, then show the data in the page, and allow login user
                     to edit game info.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using project1.Models;
using System.Web.ModelBinding;

namespace project1
{
    public partial class GameDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((!IsPostBack) && (Request.QueryString.Count > 0))
            {
                this.GetGame();
                this.GetTeam();
            }
        }
        protected void GetGame()
        {
            //populate teh form with existing data from the database
            int GameID = Convert.ToInt32(Request.QueryString["GameID"]);

            //connect to the EF DB
            using (DefaultConnection db = new DefaultConnection())
            {
                //populate a student object instance with the StudentID from the URL Parameter
                Game updatedGame = (from game in db.Games
                                    where game.GameID == GameID
                                    select game).FirstOrDefault();

                //map the student properties to the form controls
                if (updatedGame != null)
                {
                    GameNameTextBox.Text = updatedGame.GameName;
                    ShortDescripTextBox.Text = updatedGame.ShortDescription;
                    TotalScoreTextBox.Text = updatedGame.TotalPointsScored.ToString();
                    SpectatorsTextBox.Text = updatedGame.NumberOfSpectators.ToString();
                    DesignatedWinningTeamTextBox.Text = updatedGame.DesignatedWinningTeam;
                }
            }
        }
        protected void GetTeam()
        {
            //populate teh form with existing data from the database
            int GameID = Convert.ToInt32(Request.QueryString["GameID"]);

            using (DefaultConnection db = new DefaultConnection())
            {
                var Teams = (from team in db.Teams
                             where team.GameID == GameID
                             select team);

                TeamsGridView.DataSource = Teams.ToList();
                TeamsGridView.DataBind();
            }
        }
        protected void CancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/GameTracker.aspx");
        }
        protected void SaveButton_Click(object sender, EventArgs e)
        {
            //use EF to connect to the server
            using (DefaultConnection db = new DefaultConnection())
            {
                //populate teh form with existing data from the database
                int GameID = Convert.ToInt32(Request.QueryString["GameID"]);

                //populate a student object instance with the StudentID from the URL Parameter
                Game updatedGame = (from game in db.Games
                                    where game.GameID == GameID
                                    select game).FirstOrDefault();

                //map the student properties to the form controls
                if (updatedGame != null)
                {
                    updatedGame.GameName = GameNameTextBox.Text;
                    updatedGame.ShortDescription = ShortDescripTextBox.Text;
                    updatedGame.TotalPointsScored = Convert.ToInt32(TotalScoreTextBox.Text);
                    updatedGame.NumberOfSpectators = Convert.ToInt32(SpectatorsTextBox.Text);
                    updatedGame.DesignatedWinningTeam = DesignatedWinningTeamTextBox.Text;
                }

                //run an insert command
                db.SaveChanges();
                //redirect back to the students page
                Response.Redirect("~/GameTracker.aspx");
            }
        }
    }
}