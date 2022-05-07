<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exemplo_03.aspx.cs" Inherits="ProjetosWebForms.Exemplo_03" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            z-index: 1;
            left: 10px;
            top: 190px;
            position: absolute;
            width: 121px;
        }
        .auto-style2 {
            z-index: 1;
            left: 152px;
            top: 225px;
            position: absolute;
            width: 324px;
        }
        .auto-style3 {
            z-index: 1;
            left: 10px;
            top: 224px;
            position: absolute;
            width: 121px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 10px; top: 41px; position: absolute; right: 809px" Text="Informe o sexo:"></asp:Label>
        <asp:DropDownList ID="cboSexo" runat="server" style="z-index: 1; left: 120px; top: 37px; position: absolute; height: 24px; width: 118px" required="required">
            <asp:ListItem Value="F">Feminino</asp:ListItem>
            <asp:ListItem Value="M">Masculino</asp:ListItem>
        </asp:DropDownList>                    
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 10px; top: 145px; position: absolute; " Text="Informe a quantidade de espetinhos:"></asp:Label>
        <asp:TextBox ID="txtQtdCervejas" runat="server" style="z-index: 1; left: 267px; top: 69px; position: absolute; " MaxLength="3" required="required">0</asp:TextBox>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 10px; top: 109px; position: absolute; " Text="Informe a quantidade de refrigerantes:"></asp:Label>
        <asp:TextBox ID="txtQtdRefrigerantes" runat="server" style="z-index: 1; left: 267px; top: 107px; position: absolute" MaxLength="3" required="required">0</asp:TextBox>            
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 10px; top: 70px; position: absolute; " Text="Informe a quantidade de cervejas:"></asp:Label>        
        <asp:TextBox ID="txtQtdEspetinhos" runat="server" style="z-index: 1; left: 267px; top: 143px; position: absolute" MaxLength="3" required="required">0</asp:TextBox>
        <asp:Button ID="btnCalcular" runat="server" Text="Calcular" OnClick="btnCalcular_Click" CssClass="auto-style3" />
        <p>
        <asp:Label ID="lblTotalGeral" runat="server" Text="Total Geral Recebido: 0" BackColor="#FFFF66" Font-Bold="True" ForeColor="Red" CssClass="auto-style2"></asp:Label>
        </p>
        <p>
        <asp:Label ID="lblTotalAtual" runat="server" style="z-index: 1; left: 152px; top: 193px; position: absolute; width: 324px;" Text="Total a Pagar: 0" BackColor="#FFFF66" Font-Bold="True" ForeColor="Red"></asp:Label>
        <asp:Button ID="btnLimpar" runat="server" Text="Limpar" CssClass="auto-style1" OnClick="btnLimpar_Click" />
        </p>
    </form>
</body>
</html>
