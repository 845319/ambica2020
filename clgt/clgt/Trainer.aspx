<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Trainer.aspx.cs" Inherits="clgt.Trainer" %>

<asp:Content ID="cont1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <asp:Label ID="Label1" Text="Id" runat="server"></asp:Label><br />
         <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="number doesnt exceed" ControlToValidate="TextBox1" ForeColor="#666699" MaximumValue="9" MinimumValue="1" ValidationGroup="ag" Type="Integer"></asp:RangeValidator><br />
         <asp:Label ID="Label2" runat="server" Text="name"></asp:Label><br />
         <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="please enter name" ControlToValidate="TextBox2" ForeColor="#00CC66" ValidationGroup="ag"></asp:RequiredFieldValidator><br />
        <asp:Label ID="Label3" runat="server" Text="location"></asp:Label><br />
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="please enter location" ControlToValidate="TextBox3" ForeColor="#0066CC" ValidationGroup="ag"></asp:RequiredFieldValidator><br />
        <asp:Label ID="Label4" runat="server" Text="domain"></asp:Label><br />
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="please enter valid domain" ControlToValidate="TextBox5" ForeColor="#CC00FF" ValidationGroup="ag"></asp:RequiredFieldValidator><br />
         <asp:Label ID="Label5" runat="server" Text="sdate"></asp:Label><br />
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="#FF3300" ValidationGroup="ag" /><br />
        <asp:Button ID="Button1"  runat="server" Text="insert" Height="47px" Width="115px" OnClick="Button1_Click" ValidationGroup="ag" />
       
    </div>
        </asp:Content>
