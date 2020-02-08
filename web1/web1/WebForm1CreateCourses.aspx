<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1CreateCourses.aspx.cs" Inherits="web1.WebForm1CreateCourses" %>

<asp:Content ID="cont1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <asp:Label ID="Label1" Text="courseid" runat="server"></asp:Label>
         <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
         <asp:Label ID="Label2" runat="server" Text="coursename"></asp:Label>
         <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Startdate"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="fee"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1"  runat="server" Text="insert" Height="47px" Width="115px" OnClick="Button1_Click" />
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </div>
        </asp:Content>
    
   
