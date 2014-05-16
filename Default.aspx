<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="GlavnaStranica" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>
            Најавен корисник&nbsp
            <asp:Label ForeColor="Blue" Font-Bold="true" ID="lblKorisnik" runat="server" /> <br />
            Вкупно најавени корисници&nbsp
            <asp:Label ID="lblKorisnici" ForeColor="Blue" Font-Bold="true" runat="server" />
        </p>
        <asp:Panel ID="pnlPanela" runat="server">
        <p>
            <asp:DropDownList ID="ddlPozadina" AutoPostBack="true" OnSelectedIndexChanged="ddlPozadina_SelectedIndexChanged" runat="server">
            </asp:DropDownList>
            <asp:DropDownList ID="ddlFont" AutoPostBack="true" OnSelectedIndexChanged="ddlFont_SelectedIndexChanged" runat="server">
            </asp:DropDownList>
            <br />
            <asp:Label ID="lblPoraka" runat="server" />
        </p>
            <p>
                <asp:Button ID="btnZ" OnClick="btnZacuvaj_Click" Text="Зачувај" runat="server" />
                <asp:Button Text="Одјава" OnClick="btnOdjava_Click" runat="server" />
            </p>
        </asp:Panel>
    </div>
    </form>
</body>
</html>
