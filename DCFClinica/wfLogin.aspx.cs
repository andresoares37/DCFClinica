using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace DCFClinica
{
    public partial class wfLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogar_Click(object sender, EventArgs e)
        {
            try
            {
                Clinica.BLL.Login objLogin = new Clinica.BLL.Login();
                objLogin.ID = txtUsuario.Text;
                objLogin.Senha = txtSenha.Text;

                if (objLogin.AutenticaUsuario(out objLogin))
                {
                    //Comando que garante a autenticação do usuário
                    FormsAuthentication.RedirectFromLoginPage(txtUsuario.Text, false);
                    Session["UsuarioAutenticado"] = objLogin.Nome;
                    Response.Redirect("wfMenuPrincipal.aspx");
                }
                else
                {
                    lblMensagem.Text = "Usuário ou senha inválido";
                }
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
            
            
        }
    }
}