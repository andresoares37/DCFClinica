using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clinica.BLL;

namespace DCFClinica
{
    public partial class wfCadastroMedicamento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtModo.Text = HttpContext.Current.Items["Modo"].ToString();

                PopulaComboFornecedores();

                CarregarPagina();
            }

        }
        private void CarregarPagina()
        {
            switch (txtModo.Text)
            {
                case "N": //N = Novo Registro
                    btnSalvar.Visible = false;
                    break;

                case "E": //E = Editar registros existente
                    
                    btnIncluir.Visible = false;
                    txtCodigo.Enabled = false; // indica ao usuário que o comando não está habilitado
                    
                    Medicamento objMedicamento = new Medicamento().RetornaMedicamento(HttpContext.Current.Items["CodigoMedicamento"].ToString());

                    txtCodigo.Text = objMedicamento.Codigo;
                    txtNome.Text = objMedicamento.Nome;
                    txtDescricao.Text = objMedicamento.Descricao;
                    txtPosologia.Text = objMedicamento.Posologia;
                    ddlFornecedor.SelectedValue = objMedicamento.MedicamentoFornecedor.Codigo.ToString();
                    break;
            }
        }

        private void PopulaComboFornecedores()
        {
            //Definindo o Valor de Exibição
            ddlFornecedor.DataTextField = "Nome"; //Nome do Campo que será exibido

            //Definidindo o Valor de Seleção
            ddlFornecedor.DataValueField = "Codigo";//Codigo do Campo que será exibido

            ddlFornecedor.DataSource = new Clinica.BLL.Fornecedor().Listar();
            ddlFornecedor.DataBind();

        }

        protected void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                new Medicamento().Incluir(RecuperaCampos());
                LimpaCampos();

                lblMensagem.Text = "Registro Incluído com Sucesso!";
            }
            catch (Exception ex)
            {
                
                lblMensagem.Text = ex.Message;
            }
        }
        private Medicamento RecuperaCampos()
        {
            return new Medicamento()
            {
                Codigo = txtCodigo.Text,
                Nome = txtNome.Text,
                Descricao = txtDescricao.Text,
                Posologia = txtPosologia.Text,
                MedicamentoFornecedor = new Fornecedor()
                {
                    Codigo = int.Parse(ddlFornecedor.SelectedValue)
                }
            };
        }

        private void LimpaCampos()
        {
            txtCodigo.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtPosologia.Text = string.Empty;
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Server.Transfer("wfListaMedicamento.aspx");
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                new Medicamento().Salvar(RecuperaCampos());
                lblMensagem.Text = "Dados atualizados com sucesso!";
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }
    }
}