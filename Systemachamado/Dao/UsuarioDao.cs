using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Systemachamado.ModellGetSet;
using System.Data;


namespace Systemachamado.Dao
{
    
    public class UsuarioDao : Conexao
    {
        MySqlCommand comando = null;

        public void salvar(Usuario usuario)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("insert into usuario (SETOR, NOME) values (@SETOR, @NOME)", conexao);

                comando.Parameters.AddWithValue("@SETOR", usuario.setor);
                comando.Parameters.AddWithValue("@NOME", usuario.nome);

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

        //METODO PARA LISTAR A DATAGRIDVIEW
        public DataTable listar()
        {
            try
            {
                AbrirConexao();

                DataTable dataTable = new DataTable();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();

                comando = new MySqlCommand("select * from usuario inner join acesso on usuario.id_usuario = acesso.id_acesso", conexao);

                mySqlDataAdapter.SelectCommand = comando;

                mySqlDataAdapter.Fill(dataTable);

                return dataTable;
               
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
