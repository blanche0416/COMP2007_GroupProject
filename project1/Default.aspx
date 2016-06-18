<%--  File name: Default.aspx --%>
<%--  Author's name: Pui In Kwok and Mo Zou --%>
<%--  Web site name: Game Tracker --%>
<%--  File description: This is home page. --%>

<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="project1.Default" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Here is the header and contact for the page. -->
    <div class="container">
        <div class="jumbotron">
            <h1>Hello, there!</h1>
            <br />
            <p>This is our project 1 web site, look around and leave us a message:D</p>
            <p><a class="btn btn-info btn-lg" href="/Contact.aspx" role="button">Give suggestion</a></p>
        </div>
    </div>
</asp:Content>
