<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TestProject.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 301px;
        }
        .auto-style3 {
            width: 406px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3" align ="center">Log in below:</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2" align="right">Email:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="login_email" runat="server" Width="400px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="login_email" Display="Dynamic" ErrorMessage="Email is required."></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" align="right">Password:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="login_pwd" runat="server" Width="401px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="login_pwd" Display="Dynamic" ErrorMessage="Password is required."></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3" align="center">
                    <asp:Button ID="button_login" runat="server" Text="Log In" OnClick="button_login_Click"/>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="Button_manage" runat="server" Text="Database View" BackColor="Black" BorderColor="#0066FF" BorderStyle="Outset" CausesValidation="False" ForeColor="#CCCCCC" OnClick="Button_manage_Click" />
                </td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
