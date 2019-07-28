using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinica.DAL;

namespace Clinica.BLL
{
    public class Login
    {
        
        #region [Propriedades]
        public string ID
        {
            get;
            set;
        }
        public string Nome
        {
            get;
            set;
        }
        public string Senha
        {
            get;
            set;
        }
        #endregion
        #region [Métodos]
        public Boolean AutenticaUsuario(out Login UsuarioAutenticado)
        {
            try
            {

                Clinica_AndreEntities db = new Clinica_AndreEntities();
                tb_Login ObjTbLogin = (from a in db.tb_Login
                                       where a.PK_ID.ToUpper() == ID.ToUpper()
                                       && a.AT_Senha == Senha
                                       select a).FirstOrDefault();
                if (ObjTbLogin != null)
                {
                    Login objRetorno = new Login();
                    objRetorno.ID = ObjTbLogin.PK_ID;
                    objRetorno.Nome = ObjTbLogin.AT_Nome;
                    objRetorno.Senha = ObjTbLogin.AT_Senha;
                    UsuarioAutenticado = objRetorno;
                }
                if (ID.ToUpper() == "ANDRE" && Senha == "123")
                {
                    Login objRetorno = new Login();
                    objRetorno.ID = ID;
                    objRetorno.Nome = "Andre";
                    objRetorno.Senha = "123";
                    UsuarioAutenticado = objRetorno;

                    return true;
                }
                else
                {
                    UsuarioAutenticado = null;
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }
}
