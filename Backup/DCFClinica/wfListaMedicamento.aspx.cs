using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clinica.BLL;

namespace DCFClinica
{
    public partial class wfListaMedicamentos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopulaComboFornecedores();
                PopularGrid();//Carregar os dados, preenche o Grid com as Informações que estão no banco
            }
        }

        private void PopularGrid()
        {
            gvwMedicamento.DataSource = new Medicamento().Listar(txtCodigoPesquisa.Text, txtNomePesquisa.Text, int.Parse(ddlFornecedorPesquisa.SelectedValue));
            gvwMedicamento.DataBind();
        }

        protected void gvwMedicamento_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                ImageButton btnEditar = (ImageButton)e.Row.FindControl("btn_Editar");

                btnEditar.CommandArgument = e.Row.RowIndex.ToString();

                ImageButton btnExcluir = (ImageButton)e.Row.FindControl("btnExcluir");

                btnExcluir.CommandArgument = e.Row.RowIndex.ToString();

                //Adicionar um JavaScript de confirmação de exclusão

                btnExcluir.Attributes.Add("OnClick", "return confirm('Confirma Exclusão?');");

            }
        }

        protected void btnAdicionar_Click(object sender, ImageClickEventArgs e)
        {
            HttpContext.Current.Items["Modo"] = "N";
            Server.Transfer("wfCadastroMedicamento.aspx");
        }

        protected void btnPesquisa_Click(object sender, EventArgs e)
        {
            PopularGrid();
        }

        private void PopulaComboFornecedores()
        {
            //Definindo o Valor de Exibição
            ddlFornecedorPesquisa.DataTextField = "Nome"; //Nome do Campo que será exibido

            //Definidindo o Valor de Seleção
            ddlFornecedorPesquisa.DataValueField = "Codigo";//Codigo do Campo que será exibido

            ddlFornecedorPesquisa.DataSource = new Clinica.BLL.Fornecedor().ListarParacombo();
            ddlFornecedorPesquisa.DataBind();

        }

        protected void btn_Editar_Click(object sender, ImageClickEventArgs e)
        {
            HttpContext.Current.Items["Modo"] = "E"; // E- Editar Registro

            //Acessando o objeto clicado
            ImageButton btnEditar = (ImageButton)sender;

            //Recuperando o indice que foi adicionado na propriedade commandargument
            int index = int.Parse(btnEditar.CommandArgument);

            //Recuperando a linha completa do botão clicando
            GridViewRow row = gvwMedicamento.Rows[index];

            //Criando o parametro para o Código do Medicamento
            HttpContext.Current.Items["CodigoMedicamento"] = row.Cells[2].Text;

            //Navegando para pagina de cadastro
            Server.Transfer("wfCadastroMedicamento.aspx");
        }

        protected void btnExcluir_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton btnExcluir = (ImageButton)sender;

            //Recuperando o indice que foi adicionado na propriedade commandargument
            int index = int.Parse(btnExcluir.CommandArgument);

            //Recuperando a linha completa do botão clicando
            GridViewRow row = gvwMedicamento.Rows[index];

            new Medicamento().Excluir(row.Cells[2].Text);

            PopularGrid();
        }
    }
}