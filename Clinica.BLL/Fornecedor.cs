using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinica.DAL;

namespace Clinica.BLL
{  
    public class Fornecedor
    {
        #region [Propriedades]
        public int Codigo
        {
            get;
            set;
        }
        public string Nome
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
        public List<Fornecedor> Listar()
        {
            try
            {
                Clinica_AndreEntities db = new Clinica_AndreEntities();
                return (from a in db.tb_Fornecedor
                        orderby a.AT_NOME
                        select new Fornecedor 
                        { 
                            Codigo = a.PK_CODIGO,
                            Nome = a.AT_NOME
                        }
                        ).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Fornecedor> ListarParacombo()
        {
            try
            {
                //Criando um array do tipo fornecedor (vazio até o momento)
                List<Fornecedor> objRetorno = new List<Fornecedor>();
                objRetorno.Add(new Fornecedor()
                {
                    Codigo = 0,
                    Nome = "Todos"
                }
                    );

                Clinica_AndreEntities db = new Clinica_AndreEntities();
                List<Fornecedor> objListaBanco = (from a in db.tb_Fornecedor
                        orderby a.AT_NOME
                        select new Fornecedor
                        {
                            Codigo = a.PK_CODIGO,
                            Nome = a.AT_NOME
                        }
                        ).ToList();
                objRetorno.AddRange(objListaBanco);
                return objRetorno;

            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }   
    
    
}
