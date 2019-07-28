<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="wfCadastroMedicamento.aspx.cs" Inherits="DCFClinica.wfCadastroMedicamento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table class="tabelaGeralPaginas">
        <tr>
            <td style="vertical-align:top">
                <table class="headerPages">
                    <tr>
                        <td style="text-align: center">
                            <asp:Label ID="Label1" runat="server" Text="Cadastro de Medicamento"></asp:Label>
                        </td>
                    </tr>
                </table>
                <br />
                <table>
                    <tr>                        
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="Código"></asp:Label>
                        </td>
                         <td>
                            <asp:TextBox ID="txtCodigo" runat="server" Width="300px"></asp:TextBox>
                             <asp:TextBox ID="txtModo" runat="server" Visible="False" Width="10px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>                        
                        <td>
                            Fornecedor</td>
                         <td>
                             <asp:DropDownList ID="ddlFornecedor" runat="server" Width="300px">
                             </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>                        
                        <td>
                            <asp:Label ID="Label3" runat="server" Text="Nome"></asp:Label>
                        </td>
                         <td>
                            <asp:TextBox ID="txtNome" runat="server" Width="400px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>                        
                        <td>
                            <asp:Label ID="Label5" runat="server" Text="Descrição"></asp:Label>
                        </td>
                         <td>
                            <asp:TextBox ID="txtDescricao" runat="server" Width="400px" TextMode="MultiLine" 
                                 Height="110px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>                        
                        <td>
                            <asp:Label ID="Label6" runat="server" Text="Posologia"></asp:Label>
                        </td>
                         <td>
                            <asp:TextBox ID="txtPosologia" runat="server" Width="400px" Height="110px" TextMode="MultiLine"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" style="text-align: right">
                            <asp:Label ID="lblMensagem" runat="server" ForeColor="Red"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                         <td style="text-align: right">
                             <asp:Button ID="btnSalvar" runat="server" Text="Salvar" 
                                 onclick="btnSalvar_Click" />
                             <asp:Button ID="btnIncluir" runat="server" Text="Incluir" 
                                 onclick="btnIncluir_Click" />
                             <asp:Button ID="btnVoltar" runat="server" Text="Voltar" 
                                 onclick="btnVoltar_Click" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
