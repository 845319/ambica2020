<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="getdata.aspx.cs" Inherits="clgt.getdata" %>

<asp:Content ID="cont1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">

        <asp:Label ID="Label1" runat="server" Text="Id"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>

        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        <asp:GridView ID="GridView1" runat="server" ></asp:GridView>
        
            </div>
        </asp:Content>