using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DCFClinica
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)//Caso seja a primeira vez que o comando carregou
            {
                lblUsuarioLogado.Text = Session["UsuarioAutenticado"].ToString();
            }
        }
        public void SetNomePagina(string NomePagina)
        {
            lblPaginaAtual.Text = NomePagina;
        }
    }
}