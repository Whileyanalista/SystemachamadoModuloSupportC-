using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Systemachamado.ModellGetSet;
using MySql.Data;

namespace Systemachamado.Dao
{
    public class LoginDao : Conexao
    {
        MySqlCommand comando = null;

        public void validar(Login login)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("select ID_ACESSO,LOGIN,SENHA,PERFIL,ID_USUARIO from acesso where login = @LOGIN and senha = @SENHA", conexao);

                comando.Parameters.AddWithValue("@LOGIN", login.login);
                comando.Parameters.AddWithValue("@SENHA", login.senha);
                comando.Parameters.AddWithValue("@PERFIL", login.perfil);

                comando.ExecuteNonQuery();

            }
            catch (Exception erro)
            {
                
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
           
        }

      
    }
}
