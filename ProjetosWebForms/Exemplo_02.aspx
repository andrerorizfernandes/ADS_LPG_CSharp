<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exemplo_02.aspx.cs" Inherits="ProjetosWebForms.Exemplo_02" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>TESTE</title>
    <style type="text/css">
        .auto-style1 {
            z-index: 1;
            left: 484px;
            top: 97px;
            position: absolute;
            width: 120px;
        }
        .auto-style2 {
            right: 946px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 149px">        
        
        <asp:Label ID="lblInformacao" runat="server" style="z-index: 1; left: 10px; top: 17px; position: absolute; width: 200px; right: 721px; bottom: 316px;"></asp:Label>
        
        <asp:Label ID="lblInfo02" runat="server" style="z-index: 1; left: 10px; top: 86px; position: absolute; width: 376px; right: 570px; bottom: 233px;"></asp:Label>
        <asp:CheckBox ID="chkAceito" runat="server" style="z-index: 1; left: 10px; top: 106px; position: absolute; width: 329px" AutoPostBack="True" Text="Aceito os termos deste contrato" CssClass="auto-style2" OnCheckedChanged="chkAceito_CheckedChanged" />
        
        <asp:CheckBoxList ID="lbiCarros" runat="server" style="z-index: 1; left: 247px; top: 41px; position: absolute; height: 81px; width: 221px">
        </asp:CheckBoxList>
        <asp:Label ID="lblInformacao3" runat="server" style="z-index: 1; left: 485px; top: 70px; position: absolute; width: 200px; right: 271px; bottom: 255px;"></asp:Label>
        
        <asp:Button ID="btnSelecionados" runat="server" Text="Selecionados" CssClass="auto-style1" OnClick="btnSelecionados_Click" />
        
        <asp:DropDownList ID="ddlDados" runat="server" style="z-index: 1; left: 10px; top: 39px; position: absolute; height: 24px; width: 208px" AutoPostBack="True" OnSelectedIndexChanged="ddlDados_SelectedIndexChanged">
        </asp:DropDownList>
        
    </div>
    </form>
</body>
</html>