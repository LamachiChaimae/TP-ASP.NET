<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication3.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lb1" runat="server" Text="Liste de ville"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Afficher ville choissie" />
            
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="afficher tout" />
            <br />
            <asp:Label ID="lblvilleSellectionez" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
        </div>
        <div style="border:1px solid blue; margin-top:50px;">

            <asp:Label ID="Label2" runat="server" Text="donner nom nouvelle ville"></asp:Label>

            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label1" runat="server" Text="combien value"></asp:Label>

            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" Text="Ajouter cet ville a dropdownlist" OnClick="Button3_Click"/>

        </div>
    </form>
</body>
</html>
