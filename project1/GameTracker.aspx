<%--  File name: GameDetails.aspx --%>
<%--  Author's name: Pui In Kwok and Mo Zou --%>
<%--  Web site name: Game Tracker --%>
<%--  File description: This is the main game tracker that show four games information,
    allow user to click detail to detail page --%>

<%@ Page Title="GameTracker" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GameTracker.aspx.cs" Inherits="project1.GameTracker" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Here is the header and contact for the page. -->
     <div class="container">
        <div class="row">
            <div class="col-md-offset-1 col-md-10">
                <h1 class="titleH1">Game Tracker</h1>
                <asp:GridView runat="server" ID="GameTrackersGridView" CssClass="table table-striped table-border table-hover" 
                    AutoGenerateColumns="false">
                    <Columns>
                        <asp:BoundField DataField="GameID" HeaderText="Game ID" Visible="true" />
                        <asp:BoundField DataField="GameName" HeaderText="Game Name" Visible="true" />
                        <asp:BoundField DataField="ShortDescription" HeaderText="Short Description" Visible="true" />
                        <asp:BoundField DataField="TotalPointsScored" HeaderText="Total Points Scored" Visible="true" />
                        <asp:BoundField DataField="NumberOfSpectators" HeaderText="Spectators" Visible="true" />
                        <asp:BoundField DataField="DesignatedWinningTeam" HeaderText="Designated Winning Team" Visible="true" />
                        <asp:HyperLinkField HeaderText="Details" Text="<i class='fa fa-pencil-square-o fa-lg'></i> Details" 
                            NavigateUrl="~/GameDetails.aspx.cs" ControlStyle-CssClass="btn btn-primary btn-sm" runat="server" DataNavigateUrlFields="GameID" DataNavigateUrlFormatString="GameDetails.aspx?GameID={0}" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
