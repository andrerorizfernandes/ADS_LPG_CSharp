<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exemplo_01.aspx.cs" Inherits="ProjetosWebForms.Exemplo_01" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 63px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblResultado" runat="server" BackColor="Yellow" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
        </div>
        <asp:TextBox ID="txtCliente" runat="server" style="position: relative; top: 10px; left: 0px; width: 358px"></asp:TextBox>
        <asp:Button ID="btnProcessar" runat="server" style="position: relative; top: 11px; left: 8px; width: 87px" Text="Processar" OnClick="btnProcessar_Click" />
    </form>
</body>
</html>
