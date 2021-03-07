<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Content/Site.css" rel="stylesheet" />
    <style type="text/css">
        .c3 {
            height: 54px;
            margin-top: 3px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="c2">
        <div>
            formulaire des radiobutton en asp.net
         <div class="c3">
             <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" GroupName="g1" Text="rouge" />
             <asp:RadioButton ID="RadioButton2" runat="server" GroupName="g1" Text="bleu" />
             <asp:RadioButton ID="RadioButton3" runat="server" GroupName="g1" Text="vert" />
             <br />
             <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="afficher" />
        </div>
         </div>
        <asp:Panel ID="Panel1" runat="server" BackColor="Yellow" Height="302px">
        </asp:Panel>
    </form>
</body>
</html>
