<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Najava.aspx.cs" Inherits="Najava" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .klasa {
            color:#b70005;
             text-align:center;
              font-family:Calibri; 
              font-weight:bold;
              clear:both
        }


    </style>
</head>
<body>
    <form id="form1" runat="server">
     <div style="width:600px; margin: 0 auto; background-color:#f8f8f8;" >
        <div id="Header" style="font-size:large; font-weight:bold; font-family:Calibri; background-color:gray; align-content:center; color:white">
            ПРЕЗЕМАЊЕ ИНФОРМАЦИИ ЗА ЗДРАСТВЕНОТО ОСИГУРУВАЊЕ
        </div>
     
             
              

         <table class="auto-style1" style="margin:0 auto; width:300px;">
             <tr>
                 <td><span class="klasa" >ЕЗБО ИЛИ БЗЛ</span></td>
             </tr>
             <tr>
                 <td><asp:TextBox ID="EzboTxt" runat="server"></asp:TextBox></td>
             </tr>
             
             <tr>
                 <td><span class="klasa" >ЕМБГ</span></td>
             </tr>
             <tr>
                 <td><asp:TextBox ID="EMBGTxt" runat="server"></asp:TextBox></td>
             </tr>
             <tr>
                 <td><span class="klasa" >КОНТРОЛЕН КОД</span></td>
             </tr>
             <tr>
                 
                 <td><asp:Image ID="CaptchaImage" ImageUrl="~/CImage.aspx" runat="server" /></td>
             </tr>
             <tr>
                 <td><asp:TextBox ID="CodeTxt" runat="server"></asp:TextBox></td>
             </tr>
             <tr>
                 <td><asp:Button ID="Submit" runat="server" Text="Поднеси" OnClick="Submit_Click" /></td>
                 
             </tr>
         </table>
              

    </div>
    </form>
</body>
</html>
