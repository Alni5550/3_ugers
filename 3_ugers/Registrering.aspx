<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrering.aspx.cs" Inherits="_3_ugers.Registrering" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 140px">
            <h1 style="width: 306px">Opret Bruger</h1>
            <br />
        </div>
        <p>
            &nbsp;</p>
        <p>
            Brugernavn</p>
        <p>
            <asp:TextBox ID="TextBox16" runat="server" OnTextChanged="TextBox15_TextChanged"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox16"></asp:RequiredFieldValidator>
        </p>
        <p>
            Kodeord</p>
        <p>
            <asp:TextBox ID="TextBox15" runat="server" OnTextChanged="TextBox15_TextChanged"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox15"></asp:RequiredFieldValidator>
        </p>
        <p>
            Fornavn</p>
        <p>
            <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox14"></asp:RequiredFieldValidator>
        </p>
        <p>
            Efternavn</p>
        <p>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox3"></asp:RequiredFieldValidator>
        </p>
        <p>
            Email </p>
        <p>
            <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox12"></asp:RequiredFieldValidator>
        </p>
        <p>
            Telefonnummer</p>
        <p>
            <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox13"></asp:RequiredFieldValidator>
        </p>
        <p>
            Vej</p>
        <p>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox4"></asp:RequiredFieldValidator>
        </p>
        <p>
            Bynavn</p>
        <p>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox5"></asp:RequiredFieldValidator>
        </p>
        <p>
            Postnummer</p>
        <p>
            <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox11"></asp:RequiredFieldValidator>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Opret" />
        </p>
    </form>
</body>
</html>
