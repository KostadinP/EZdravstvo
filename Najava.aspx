<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Najava.aspx.cs" Inherits="Najava" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form style="margin-left:auto; margin-right:auto; width:40%" id="form1" runat="server">
    <div>
        Корисничко име
        <asp:TextBox ID="tbKorisnik" runat="server"></asp:TextBox> <br/>
        <asp:Label ID="Label2" Width="120px"  runat="server" Text="Лозинка"></asp:Label>
        <asp:TextBox ID="tbLozinka" runat="server"></asp:TextBox>
        <br/><br />
        <asp:Button ID="btnPodnesi" OnClick="ptnPodnesi_Click" runat="server" Text="Поднеси" />
        <br/>
        <br />
        Број на обиди <br />
        <asp:Label Font-Bold="true" ForeColor="Red" ID="lblObidi" runat="server" Text="0"></asp:Label>
    </div>
    </form>
</body>
</html>
