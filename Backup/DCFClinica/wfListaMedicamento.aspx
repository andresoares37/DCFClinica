<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site1.Master" CodeBehind="wfListaMedicamento.aspx.cs" Inherits="DCFClinica.wfListaMedicamentos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table class="tabelaGeralPaginas">
        <tr>
            <td style="height:120px">
                <table class="tabelaPesquisa">
                    <tr>
                        <td >
                            <asp:Label ID="Label1" runat="server" Text="Código"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtCodigoPesquisa" runat="server" Width="300px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="Nome"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtNomePesquisa" runat="server" Width="300px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label3" runat="server" Text="Fornecedor"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlFornecedorPesquisa" runat="server" Width="300px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                        </td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td>
                        </td>
                        <td style="text-align: right">
                            <asp:Button ID="btnPesquisa" runat="server" Text="Pesquisar" 
                                onclick="btnPesquisa_Click" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td style="vertical-align:top">
                <asp:GridView ID="gvwMedicamento" runat="server" AutoGenerateColumns="False" 
                    onrowdatabound="gvwMedicamento_RowDataBound">
                    <Columns>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                <asp:ImageButton ID="btnAdicionar" runat="server" Height="16px" 
                                    ImageUrl="~/Imagens/ap_AddNew.gif" ToolTip="Incluir Novo Medicamento" 
                                    onclick="btnAdicionar_Click" />
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:ImageButton ID="btn_Editar" runat="server" ImageUrl="~/Imagens/Editar.gif" 
                                    ToolTip="Editar Registro do Medicamento" onclick="btn_Editar_Click" 
                                    style="width: 20px" />
                            </ItemTemplate>
                            <HeaderStyle Width="20px" />
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:ImageButton ID="btnExcluir" runat="server" 
                                    ImageUrl="~/Imagens/ap_Remove.gif" ToolTip="Excluir Medicamento" 
                                    onclick="btnExcluir_Click" />
                            </ItemTemplate>
                            <HeaderStyle Width="20px" />
                        </asp:TemplateField>
                        <asp:BoundField DataField="CODIGO" HeaderText="CODIGO"></asp:BoundField>
                        <asp:BoundField DataField="NOME" HeaderText="NOME"></asp:BoundField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
