<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="DisplaySQL.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    
    <form id="form1" runat="server">
        <p>
            Username and Email Serch</p>
        <p>
            Enter user&#39;s name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" BackColor="#FF3300" OnClick="Button1_Click" Text="Search" />
        </p>
          
<br />
         <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <table id="result" class="auto-style1" runat="server">
            <tr>
                <td>Username</td>
                <td>
                    <asp:Label ID="lblname" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Level</td>
                <td>
                    <asp:Label ID="lbllevel" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <br />
        <br />
        <br />
    </form>

</body>
</html>
