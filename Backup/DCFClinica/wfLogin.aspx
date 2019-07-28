<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfLogin.aspx.cs" Inherits="DCFClinica.wfLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>::: Clínica Dog, Cat and Friends :::</title>
    <link href="css/ClinicaStyle.css" rel="stylesheet" type="text/css" />
    <link rel="shortcut icon" type="image/x-icon" href="Imagens/peixe2.ico" />
   
    
   
    <style type="text/css">
        .style1
        {
            height: 18px;
        }
    </style>
   
   
    
   
</head>
<body>
    <form id="form1" runat="server">
    
    <table width="500px" class="tableForm" align="center">
        <tr>
            <td>
                <asp:Image ID="Image1" runat="server" ImageUrl="~/Imagens/veterinario.jpg" />
            </td>
            <td>

                <table style ="width: 150px">
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text="Usuário"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="txtUsuario" runat="server" Width= "150px"></asp:TextBox>
                        </td>
                    </tr>                  
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="Senha"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="txtSenha" runat="server" Width="150px" 
                                TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style ="text-align:right">
                            <asp:Button ID="btnLogar" runat="server" Text="Entrar" 
                                onclick="btnLogar_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            <asp:Label ID="lblMensagem" runat="server" Text="" ForeColor="Red"></asp:Label>
                        </td>
                    </tr>
                    </tr>
                </table>

            </td>
        </tr>
    </table>
    
    </form>
</body>
</html>
