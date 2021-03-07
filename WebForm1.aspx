<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="Scripts/jquery-3.4.1.js"></script>
    <link href="Content/Site.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>

            &nbsp;

            <asp:Label ID="Label1" runat="server" Text="donner votre nom"></asp:Label>
            <br />
            
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Clicker ici "  CssClass="c1" OnClick="Button1_Click"/>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Indice"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            
            <asp:Label ID="Label4" runat="server" Text="longueur"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </div>
        <asp:Label ID="Label2" runat="server" CssClass="c1" Font-Bold="True" Font-Italic="True" Font-Overline="False" Font-Underline="True" ForeColor="#FFFFCC"></asp:Label>
    </form>
</body>
</html>
