<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="_3_ugers.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="height: 68px; width: 139px; margin-left: 1px; text-align: left;" title="Login">
                Login</h1>
            <p>
                Brugernavn</p>
        </div>
        <p style="margin-top: 16px">
        <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
        </p>
        <p style="margin-top: 16px">
            Kodeord</p>
        <p>
        <asp:TextBox ID="TextBox3" runat="server" ></asp:TextBox>
        </p>
        <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Næste" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
