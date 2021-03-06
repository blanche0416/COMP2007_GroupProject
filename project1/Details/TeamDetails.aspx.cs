﻿/* File name: GameDetails.aspx.cs
 * Author's name: Pui In Kwok and Mo Zou
 * Web site name: Game Tracker
 * File description: Here will allow login user to edit team info.
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
    public partial class TeamDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((!IsPostBack) && (Request.QueryString.Count > 0))
            {
                this.GetTeam();

                if (HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    // show everything      
                    BackButton.Visible = false;
                }
                else
                {
                    // page before login
                    CancelButton.Visible = false;
                    SaveButton.Visible = false;

                    TeamNameTextBox.ReadOnly = true;
                    ShortDescripTextBox.ReadOnly = true;
                    TotalScoreTextBox.ReadOnly = true;

                }


            }
        }
        protected void GetTeam()
        {
            //populate teh form with existing data from the database
            int TeamID = Convert.ToInt32(Request.QueryString["TeamID"]);

            //connect to the EF DB
            using (ContosoConnection db = new ContosoConnection())
            {
                //populate a student object instance with the StudentID from the URL Parameter
                Team updatedTeam = (from team in db.Teams
                                    where team.TeamID == TeamID
                                    select team).FirstOrDefault();

                //map the student properties to the form controls
                if (updatedTeam != null)
                {
                    TeamNameTextBox.Text = updatedTeam.TeamName;
                    ShortDescripTextBox.Text = updatedTeam.ShortDescription;
                    TotalScoreTextBox.Text = updatedTeam.TotalPointsScored.ToString();
                }
            }
        }
        protected void CancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Details/GameTracker.aspx");
        }
        //update team's informations
        //update game's total point scored and designated winning team
        protected void SaveButton_Click(object sender, EventArgs e)
        {
            //use EF to connect to the server
            using (ContosoConnection db = new ContosoConnection())
            {
                //populate teh form with existing data from the database
                int TeamID = Convert.ToInt32(Request.QueryString["TeamID"]);

                //populate a student object instance with the StudentID from the URL Parameter
                Team updatedTeam = (from team in db.Teams
                                    where team.TeamID == TeamID
                                    select team).FirstOrDefault();
                //map the student properties to the form controls
                if (updatedTeam != null)
                {
                    int GameID = updatedTeam.GameID;
                    int teamScore = Convert.ToInt32(TotalScoreTextBox.Text);
                    Team anotherTeamScore = (from team in db.Teams
                                            where team.GameID == GameID && team.TeamID != TeamID
                                             select team).FirstOrDefault();
                    
                    Game updatedGame = (from game in db.Games
                                        where game.GameID == GameID
                                        select game).FirstOrDefault();
                    if(updatedTeam.TotalPointsScored > anotherTeamScore.TotalPointsScored)
                    {
                        updatedGame.DesignatedWinningTeam = TeamNameTextBox.Text;
                    }
                    else if(updatedTeam.TotalPointsScored < anotherTeamScore.TotalPointsScored)
                    {
                        updatedGame.DesignatedWinningTeam = anotherTeamScore.TeamName;
                    }
                    else
                    {
                        updatedGame.DesignatedWinningTeam = "Draw";
                    }

                    updatedGame.TotalPointsScored = (teamScore + anotherTeamScore.TotalPointsScored);

                    updatedTeam.TeamName = TeamNameTextBox.Text;
                    updatedTeam.ShortDescription = ShortDescripTextBox.Text;
                    updatedTeam.TotalPointsScored = Convert.ToInt32(TotalScoreTextBox.Text);
                }

                //run an insert command
                db.SaveChanges();
                //redirect back to the students page
                Response.Redirect("~/Details/GameTracker.aspx");
            }
        }

        protected void BackButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Details/GameTracker.aspx");
        }
    }
}