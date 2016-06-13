<%--  File name: TeamDetails.aspx --%>
<%--  Author's name: Pui In Kwok and Mo Zou --%>
<%--  Web site name: Game Tracker --%>
<%--  File description: This is the main game tracker that show four games information,
                        allow user to click detail to detail page --%>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TeamDetails.aspx.cs" Inherits="project1.TeamDetails" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-offset-2 col-md-6">
                <h1 class="titleH1">Team Details</h1>
                <h5>All Fields are Required</h5>
                <br />
                <div class="form-group">
                    <label class="control-label" for="TeamNameTextBox">Team Name</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="TeamNameTextBox" placeholder="Team Name" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="ShortDescripTextBox">Short Description</label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Columns="3" Rows="3" CssClass="form-control" ID="ShortDescripTextBox" placeholder="Short Description" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="TotalScoreTextBox">Total Point Scored</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="TotalScoreTextBox" required="true"></asp:TextBox>
                </div>
                <div class="text-right">
                    <asp:Button Text="Cancel" ID="CancelButton" CssClass="btn btn-warning btn-lg" runat="server" UseSubmitBehavior="false" CausesValidation="false" OnClick="CancelButton_Click" />
                    <asp:Button Text="Save" ID="SaveButton" CssClass="btn btn-primary btn-lg" runat="server" OnClick="SaveButton_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>

