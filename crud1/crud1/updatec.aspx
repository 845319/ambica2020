<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="updatec.aspx.cs" Inherits="crud1.updatec" %>


<asp:Content ID="id123" ContentPlaceHolderID="MainContent" runat="server">
    Course Id<asp:TextBox ID="TextBox1"  runat="server"></asp:TextBox>
    
    No of Students<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>

    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </asp:Content>