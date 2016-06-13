<%--  File name: Register.aspx --%>
<%--  Author's name: Pui In Kwok and Mo Zou --%>
<%--  Web site name: Game Tracker --%>
<%--  File description: This is the register page, allow user to register
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
                <p>Already have an account? <a href="Login.aspx">Login</a> here</p>
                <div class="text-right">
                    <asp:Button Text="Cancel" ID="CancelButton" CssClass="btn btn-warning btn-lg" runat="server" UseSubmitBehavior="false" CausesValidation="false" OnClick="CancelButton_Click" />
                    <asp:Button Text="Submit" ID="SubmitButton" CssClass="btn btn-primary btn-lg" runat="server" OnClick="SubmitButton_Click" />
                </div>
                <br />

            </div>
        </div>
    </div>

</asp:Content>
