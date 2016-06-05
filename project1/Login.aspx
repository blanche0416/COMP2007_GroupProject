<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="project1.Login" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="titleH1">Login Page</h1>
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
             
                <div class="text-right">
                    <asp:Button CssClass="btn btn-primary btn-lg" ID="SendButton" Text="Send" runat="server" OnClick="SendButton_Click" />
                    <a class="btn btn-default btn-lg" id="CancelButton" href="Default.aspx">Cancel</a>
                </div>             
                <br />
            </div>
        </div>
    <p>Need a new account? <a href="Register.aspx">Register</a> here</p>
    </div>
</asp:Content>
