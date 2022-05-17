<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="BandaCad.Index" %>

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
        <asp:GridView ID="gvdBanda" runat="server" AutoGenerateColumns="False" OnRowCancelingEdit="gvdBanda_RowCancelingEdit" OnRowDeleting="gvdBanda_RowDeleting" OnRowEditing="gvdBanda_RowEditing" OnRowUpdating="gvdBanda_RowUpdating" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="5" CellSpacing="2">
            <Columns>
                <asp:TemplateField HeaderText="Cód.">
                    <EditItemTemplate>
                        <asp:Label ID="lblCodBanda" runat="server" Text='<%# Bind("CodBanda") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblCodBanda" runat="server" Text='<%# Bind("CodBanda") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Descrição">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtDescricao" runat="server" Text='<%# Bind("Descricao") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblDescricao" runat="server" Text='<%# Bind("Descricao") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Cidade">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtCidade" runat="server" Text='<%# Bind("Cidade") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblCidade" runat="server" Text='<%# Bind("Cidade") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Uf">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtUf" runat="server" Text='<%# Bind("Uf") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblUf" runat="server" Text='<%# Bind("Uf") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Vocalista">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtVocalista" runat="server" Text='<%# Bind("Vocalista") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblVocalista" runat="server" Text='<%# Bind("Vocalista") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField>
                    <EditItemTemplate>
                        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" CommandName="Update"></asp:Button>
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CommandName="Cancel"></asp:Button>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Button ID="btnEditar" runat="server" Text="Alterar" CommandName="Edit"></asp:Button>
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
                <td><asp:Label ID="lblDescricaoCadastro" Text="Descrição" runat="server"></asp:Label></td>
                <td><asp:Label ID="lblCidadeCadastro" Text="Cidade" runat="server"></asp:Label></td>
                <td><asp:Label ID="lblUfCadastro" Text="Uf" runat="server"></asp:Label></td>
                <td><asp:Label ID="lblVocalistaCadastro" Text="Vocalista" runat="server"></asp:Label></td>
                <td></td>
            </tr>
            <tr>
                <td><asp:TextBox ID="txtDescricaoCadastro" Width="250" runat="server"></asp:TextBox></td>
                <td><asp:TextBox ID="txtCidadeCadastro" Width="100" runat="server"></asp:TextBox></td>
                <td><asp:TextBox ID="txtUfCadastro" Width="20" runat="server"></asp:TextBox></td>
                <td><asp:TextBox ID="txtVocalistaCadastro" Width="80" runat="server"></asp:TextBox></td>
                <td><asp:Button ID="btnInserir" runat="server" Text="Inserir" OnClick="btnInserir_Click"/></td>
            </tr>
            <tr>
                <td colspan="6"><asp:Label ID="lblRetornoOperacao" text="" Font-Bold="true" runat="server"></asp:Label></td>
            </tr>
        </table>
    </form>
</body>
</html>