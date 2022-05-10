<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exemplo_06.aspx.cs" Inherits="ProjetosWebForms.Exemplo_06" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            z-index: 1;
            left: 10px;
            top: 56px;
            position: absolute;
            height: 226px;
            width: 936px;
        }
    </style>
</head>
<body style="height: 195px">
    <form id="form1" runat="server">               
        <asp:GridView ID="gvdAlunos" runat="server" AutoGenerateColumns="False" OnRowCancelingEdit="gvdAlunos_RowCancelingEdit" OnRowDeleting="gvdAlunos_RowDeleting" OnRowEditing="gvdAlunos_RowEditing" OnRowUpdating="gvdAlunos_RowUpdating" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="5" CellSpacing="2">
            <Columns>
                <asp:TemplateField HeaderText="Id">
                    <EditItemTemplate>
                        <asp:Label ID="lblId" runat="server" Text='<%# Bind("id") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblId" runat="server" Text='<%# Bind("id") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Matrícula">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtMatricula" runat="server" Text='<%# Bind("matricula") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblMatricula" runat="server" Text='<%# Bind("matricula") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Nome">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtNome" runat="server" Text='<%# Bind("nome") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblNome" runat="server" Text='<%# Bind("nome") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Curso">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtCurso" runat="server" Text='<%# Bind("curso") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblCurso" runat="server" Text='<%# Bind("curso") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField>
                    <EditItemTemplate>
                        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" CommandName="Update"></asp:Button>
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CommandName="Cancel"></asp:Button>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Button ID="btnEditar" runat="server" Text="Editar" CommandName="Edit"></asp:Button>
                        <asp:Button ID="btnExcluir" runat="server" Text="Excluir" CommandName="Delete"></asp:Button>
                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>         
        
        <table>
            <tr>
                <td><asp:Label ID="Label1" Text="Nome" runat="server"></asp:Label></td>
                <td><asp:Label ID="Label2" Text="Matrícula" runat="server"></asp:Label></td>
                <td><asp:Label ID="Label3" Text="Curso" runat="server"></asp:Label></td>
                <td></td>
            </tr>
            <tr>
                <td><asp:TextBox ID="txtNome_Add" Width="350" runat="server"></asp:TextBox></td>
                <td><asp:TextBox ID="txtMatricula_Add" Width="60" runat="server"></asp:TextBox></td>
                <td><asp:TextBox ID="txtCurso_Add" Width="100" runat="server"></asp:TextBox></td>
                <td><asp:Button ID="btnAdicionar" runat="server" Text="Adicionar Aluno" OnClick="btnAdicionar_Click"/></td>
            </tr>
            <tr>
                <td colspan="6"><asp:Label ID="lblRetornoOperacao" text="" Font-Bold="true" runat="server"></asp:Label></td>
            </tr>
        </table>
    </form>
</body>
</html>

