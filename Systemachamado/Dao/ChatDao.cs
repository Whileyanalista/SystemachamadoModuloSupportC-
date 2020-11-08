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
    public class ChatDao: Conexao
    {       
        
        MySqlCommand comando = null;

        //METODO PARA LISTAR LISTBOX
        public DataTable listar(Chat chat)
        {
            try
            {
                AbrirConexao();

                DataTable dataTable = new DataTable();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();

                comando = new MySqlCommand("select * from chat where ID_CHAMADO = @ID_CHAMADO ", conexao);

                comando.Parameters.AddWithValue("@ID_CHAMADO", chat.id_chamado);

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

        //SALVAR LISTBOX
        public void salvar(Chat chat)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("insert into chat (OBSERVAÇAO, ID_CHAMADO) values (@OBSERVAÇAO, @ID_CHAMADO)", conexao);

                comando.Parameters.AddWithValue("@OBSERVAÇAO", chat.observacao);
                comando.Parameters.AddWithValue("@ID_CHAMADO", chat.id_chamado);

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
