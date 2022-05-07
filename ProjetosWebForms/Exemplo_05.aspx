<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exemplo_05.aspx.cs" Inherits="ProjetosWebForms.Exemplo_05" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="lblResultado" runat="server" BackColor="#FFFF99" Font-Bold="True" ForeColor="Red"></asp:Label>
        <asp:GridView ID="gvDados" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
        <p>
        <table>
            <tr>
                <td><asp:Label ID="lblID" Text="ID" runat="server"></asp:Label></td>
                <td><asp:Label ID="Label1" Text="Nome Aluno" runat="server"></asp:Label></td>
                <td><asp:Label ID="Label2" Text="Matricula" runat="server"></asp:Label></td>
                <td><asp:Label ID="Label3" Text="Curso" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td><asp:TextBox ID="txtID" Width="20" runat="server"></asp:TextBox></td>
                <td><asp:TextBox ID="txtNome" Width="350" runat="server"></asp:TextBox></td>
                <td><asp:TextBox ID="txtMatricula" Width="60" runat="server"></asp:TextBox></td>
                <td><asp:TextBox ID="txtCurso" Width="100" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Button ID="btnInserir" text="Inserir" runat="server" OnClick="btnInserir_Click"></asp:Button></td>
                <td><asp:Button ID="btnEditar" text="Editar" runat="server" OnClick="btnEditar_Click"></asp:Button></td>
                <td><asp:Button ID="btnExcluir" text="Excluir" runat="server" OnClick="btnExcluir_Click"></asp:Button></td>
                <td><asp:Button ID="btnAtualizar" text="Atualizar" runat="server" OnClick="btnAtualizar_Click"></asp:Button></td>
            </tr>
            <tr>
                <td colspan="4"><asp:Label ID="lblRetornoOperacao" text="" Font-Bold="true" runat="server"></asp:Label></td>
            </tr>
        </table>
    </form>
</body>
</html>
