using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinica.DAL;

namespace Clinica.BLL
{
    public class Medicamento
    {
        #region [Propriedades]
        public string Codigo
        {
            get;
            set;
        }
        public string Nome
        {
            get;
            set;
        }
        public string Descricao
        {
            get;
            set;
        }
        public string Posologia
        {
            get;
            set;
        }
        public Fornecedor MedicamentoFornecedor
        {
            get;
            set;
        }
        #endregion        

        #region [Métodos]
        public List<Medicamento> Listar(String parCodigo, String parNome, int parFornecedorID)
        {
            try
            {
                Clinica_AndreEntities db = new Clinica_AndreEntities();

                return (from a in db.tb_Medicamento
                        where (String.IsNullOrEmpty(parCodigo) || a.PK_CODIGO.ToUpper().Contains(parCodigo.ToUpper()))
                        && (String.IsNullOrEmpty(parNome) || a.AT_NOME.ToUpper().Contains(parNome.ToUpper()))
                        && (parFornecedorID == 0 || a.FK_FORNECEDOR_ID == parFornecedorID)
                        select new Medicamento
                        {
                            Codigo = a.PK_CODIGO,
                            Nome = a.AT_NOME,
                            Descricao = a.AT_DESCRICAO,
                            Posologia = a.AT_POSOLOGIA
                        }).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Incluir(Medicamento objIncluir)
        {
            try
            {
                if (objIncluir.Codigo == String.Empty)
                    throw new Exception("O Código deve ser informado!");

                Clinica_AndreEntities db = new Clinica_AndreEntities();

                tb_Medicamento objMedicamento = new tb_Medicamento();

                objMedicamento.PK_CODIGO = objIncluir.Codigo;
                objMedicamento.AT_NOME = objIncluir.Nome;
                objMedicamento.AT_DESCRICAO = objIncluir.Descricao;
                objMedicamento.AT_POSOLOGIA = objIncluir.Posologia;
                objMedicamento.FK_FORNECEDOR_ID = objIncluir.MedicamentoFornecedor.Codigo;

                db.AddTotb_Medicamento(objMedicamento);
                db.SaveChanges();
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        public Medicamento RetornaMedicamento(String CodigoMedicamento)
        {
            try
            {
                Clinica_AndreEntities db = new Clinica_AndreEntities();
                return (from a in db.tb_Medicamento
                        where a.PK_CODIGO == CodigoMedicamento
                        select new Medicamento
                        {
                            Codigo = a.PK_CODIGO,
                            Nome = a.AT_NOME,
                            Descricao = a.AT_DESCRICAO,
                            Posologia = a.AT_POSOLOGIA,
                            MedicamentoFornecedor = new Fornecedor()
                            {
                                Codigo = (int)a.FK_FORNECEDOR_ID
                            }
                        }).FirstOrDefault();//Sempre irá devolver o primeiro registro caso o Banco tenha mais códigos iguais cadastrados
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        public void Salvar(Medicamento objSalvar)
        {
            try
            {
                Clinica_AndreEntities db = new Clinica_AndreEntities();
                tb_Medicamento objMedicamentoBanco = (from a in db.tb_Medicamento
                                                   where a.PK_CODIGO == objSalvar.Codigo
                                                   select a).FirstOrDefault();

                //Sobrepondo os Valores
                objMedicamentoBanco.AT_NOME = objSalvar.Nome;
                objMedicamentoBanco.AT_DESCRICAO = objSalvar.Descricao;
                objMedicamentoBanco.AT_POSOLOGIA = objSalvar.Posologia;
                objMedicamentoBanco.FK_FORNECEDOR_ID = objSalvar.MedicamentoFornecedor.Codigo;

                //Salvando as Informações
                db.SaveChanges();
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        public void Excluir(string CodigoMedicamento)
        {
            try
            {
                Clinica_AndreEntities db = new Clinica_AndreEntities();

                //Recuperando o registro a ser excluído
                tb_Medicamento objMedicamentoBanco = (from a in db.tb_Medicamento
                                                      where a.PK_CODIGO == CodigoMedicamento
                                                      select a).FirstOrDefault();

                db.DeleteObject(objMedicamentoBanco);
                db.SaveChanges();
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        #endregion
    }
}
