<%--  File name: GameDetails.aspx --%>
<%--  Author's name: Pui In Kwok and Mo Zou --%>
<%--  Web site name: Game Tracker --%>
<%--  File description: This is the main game tracker that show four games information,
                        allow user to click detail to detail page --%>

<%@ Page Title="GameDetails" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GameDetails.aspx.cs" Inherits="project1.GameDetails" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-offset-2 col-md-8">
                <h1 class="titleH1">Game Details</h1>
                <h5>All Fields are Required</h5>
                <br />
                <div class="form-group">
                    <label class="control-label" for="GameNameTextBox">Game Name</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="GameNameTextBox" placeholder="Game Name" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="ShortDescripTextBox">Short Description</label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Columns="3" Rows="3" CssClass="form-control" ID="ShortDescripTextBox" placeholder="Short Description" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="TotalScoreTextBox">Total Point Scored</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="TotalScoreTextBox" ReadOnly="true" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="SpectatorsTextBox">Spectators</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="SpectatorsTextBox" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="DesignatedWinningTeamTextBox">Designated Winning Team</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="DesignatedWinningTeamTextBox" ReadOnly="true" required="true"></asp:TextBox>
                </div>
                <div class="text-right">
                    <asp:Button Text="Cancel" ID="CancelButton" CssClass="btn btn-warning btn-lg" runat="server" UseSubmitBehavior="false" CausesValidation="false" OnClick="CancelButton_Click" />
                    <asp:Button Text="Save" ID="SaveButton" CssClass="btn btn-primary btn-lg" runat="server" OnClick="SaveButton_Click" />
                </div>
                <br />
                <h1 class="titleH1">Teams</h1>
                <asp:GridView runat="server" ID="TeamsGridView" CssClass="table table-striped table-border table-hover"
                    AutoGenerateColumns="false">
                    <Columns>
                        <asp:BoundField DataField="TeamID" HeaderText="Team ID" Visible="true" />
                        <asp:BoundField DataField="TeamName" HeaderText="Game Name" Visible="true" />
                        <asp:BoundField DataField="ShortDescription" HeaderText="Short Description" Visible="true" />
                        <asp:BoundField DataField="TotalPointsScored" HeaderText="Total Points Scored" Visible="true" />
                        <asp:HyperLinkField HeaderText="Details" Text="<i class='fa fa-pencil-square-o fa-lg'></i> Details"
                            NavigateUrl="~/Details/TeamDetails.aspx.cs" ControlStyle-CssClass="btn btn-primary btn-sm" runat="server" DataNavigateUrlFields="TeamID" DataNavigateUrlFormatString="TeamDetails.aspx?TeamID={0}" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
