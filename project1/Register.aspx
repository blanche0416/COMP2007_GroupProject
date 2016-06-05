<%--  File name: Register.aspx --%>
<%--  Author's name: Pui In Kwok and Mo Zou --%>
<%--  Web site name: Game Tracker --%>
<%--  File description: This page the register page, allow user to register
                        an account. --%>

<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="project1.Register" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">  
    <!-- Here is the header and contact for the page. -->
    <h1 class="titleH1">Register Page</h1>
    <div class="container">
         <div class="row">
            <div class="col-md-offset-3 col-md-6">
                <br />
                <!-- textboxes -->
                <div class="form-group">
                    <label class="control-label" for="Username">Username</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="UsernameTextBox" placeholder="Username" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="Password">Password</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="PasswordTextBox" placeholder="Password" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="Email">Email</label>
                    <asp:TextBox runat="server" TextMode="Email" CssClass="form-control" ID="EmailTextBox" placeholder="Email" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="ContactNumber">Contact Number</label>
                    <asp:TextBox runat="server" TextMode="Phone" CssClass="form-control" ID="ContactNumberTextBox" placeholder="Contact Number" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="Introduction">Introduction</label>
                    <asp:TextBox runat="server" TextMode="MultiLine" Columns="5" Rows="5" CssClass="form-control" ID="IntroductionTextBox" placeholder="brief introduction about youself" required="true"></asp:TextBox>
                </div>
                <div class="text-right">
                    <asp:Button CssClass="btn btn-primary btn-lg" ID="SendButton" Text="Send" runat="server" OnClick="SendButton_Click" />
                    <a class="btn btn-default btn-lg" id="CancelButton" href="Default.aspx">Cancel</a>
                </div>
                <br />
                
            </div>
        </div>
        <a href="Login.aspx">Already have an account? Login here</a>
    </div>

</asp:Content>
