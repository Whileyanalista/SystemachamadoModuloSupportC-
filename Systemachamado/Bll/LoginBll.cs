using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Systemachamado.ModellGetSet;
using Systemachamado.Dao;

namespace Systemachamado.Bll
{
    public class LoginBll
    {
        LoginDao loginDao = new LoginDao();

        public void validar(Login login)
        {
            try
            {
                loginDao.validar(login);
            }

            catch (Exception erro)

            {
                if (erro == erro)
                {
                    System.Windows.Forms.MessageBox.Show("ERRO DE CONEXÃO COM O BANCO DE DADOS");
                }

                throw erro;
            }
        }

    }
}
