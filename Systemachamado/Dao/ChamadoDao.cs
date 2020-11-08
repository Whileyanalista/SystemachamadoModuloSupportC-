using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Systemachamado.ModellGetSet;
using System.Data;
using System.Drawing;

namespace Systemachamado.Dao
{
    public class ChamadoDao : Conexao
    {
        MySqlCommand comando = null;
        
        //metodo para salvar chamado
        public void salvar(Chamado chamado)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("insert into chamado (ABERTURA, HORAE, PRODUTO, SAIDA, HORAS, SITUAÇAO, ID_ACESSO) " +
                    "values (@ABERTURA, @HORAE, @PRODUTO, @SAIDA, @HORAS, @SITUAÇAO, @ID_ACESSO)", conexao);

                comando.Parameters.AddWithValue("@ABERTURA", chamado.abertura);
                comando.Parameters.AddWithValue("@HORAE", chamado.horaAb);
                comando.Parameters.AddWithValue("@PRODUTO", chamado.produto);
                comando.Parameters.AddWithValue("@SAIDA", chamado.fechamento);
                comando.Parameters.AddWithValue("@HORAS", chamado.horaSa);
                comando.Parameters.AddWithValue("@SITUAÇAO", chamado.situacao);
                comando.Parameters.AddWithValue("@ID_ACESSO", chamado.id_acesso);

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

        //metodo para editar chamado
        public void editar(Chamado chamado)
        {
            FormTelaPrincipal formTelaPrincipal = new FormTelaPrincipal();
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("update chamado set ABERTURA = @ABERTURA, HORAE = @HORAE, PRODUTO = @PRODUTO, " +
                    " SAIDA = @SAIDA, HORAS = @HORAS, SITUAÇAO = @SITUAÇAO, ID_ACESSO = @ID_ACESSO  where ID_CHAMADO = @ID_CHAMADO", conexao);

                comando.Parameters.AddWithValue("@ID_CHAMADO", chamado.id_chamado);
                comando.Parameters.AddWithValue("@ABERTURA", chamado.abertura);
                comando.Parameters.AddWithValue("@HORAE", chamado.horaAb);
                comando.Parameters.AddWithValue("@PRODUTO", chamado.produto);
               
                comando.Parameters.AddWithValue("@SAIDA", chamado.fechamento);
                comando.Parameters.AddWithValue("@HORAS", chamado.horaSa);
                             
                comando.Parameters.AddWithValue("@SITUAÇAO", chamado.situacao);
                comando.Parameters.AddWithValue("@ID_ACESSO", chamado.id_acesso);

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
        

        //metodo para deletar chamados
        public void deletar (Chamado chamado) 
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("delete from chamado where ID_CHAMADO = @ID_CHAMADO", conexao);

                comando.Parameters.AddWithValue("@ID_CHAMADO", chamado.id_chamado);

                comando.ExecuteNonQuery();

            }
            catch (Exception erro )
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
        

        //METODO PARA LISTAR A DATAGRIDVIEW
        public DataTable listarCh()
        {
            try
            {
                AbrirConexao();

                DataTable dataTable = new DataTable();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();

                comando = new MySqlCommand("select acesso.NOME, acesso.SETOR, acesso.ID_ACESSO, chamado.ABERTURA , chamado.HORAE, chamado.PRODUTO , chamado.SAIDA, chamado.HORAS, chamado.SITUAÇAO, chamado.ID_CHAMADO " +
                    "from acesso, chamado where acesso.ID_ACESSO = chamado.ID_ACESSO ; ", conexao);
             
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


        //listas os chamados realizados
        public DataTable listarChUser(Chamado chamado)
        {
            try
            {
                AbrirConexao();

                DataTable dataTable = new DataTable();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();

                comando = new MySqlCommand("select NOME, SETOR, chamado.ID_ACESSO, ABERTURA, HORAE, PRODUTO, SAIDA, HORAS, SITUAÇAO, ID_CHAMADO " +
                    "from acesso inner join chamado on chamado.ID_ACESSO = acesso.ID_ACESSO and acesso.ID_ACESSO = @acesso.ID_ACESSO;", conexao);

                comando.Parameters.AddWithValue("@acesso.ID_ACESSO", chamado.id_acesso);

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


        //listas os chamados realizados
        public DataTable pesquisarNome(Acesso acesso)
        {
            try
            {
                AbrirConexao();

                DataTable dataTable = new DataTable();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();

                comando = new MySqlCommand("select acesso.NOME, acesso.SETOR, acesso.ID_ACESSO, chamado.ABERTURA , chamado.HORAE, chamado.PRODUTO , chamado.SAIDA, chamado.HORAS, chamado.SITUAÇAO, chamado.ID_CHAMADO " +
                    "from acesso, chamado where acesso.ID_ACESSO = chamado.ID_ACESSO and acesso.NOME like @NOME", conexao);

                comando.Parameters.AddWithValue("@NOME", acesso.nome + "%");               

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



        //listas os chamados realizados
        public DataTable pesquisarDatas(Chamado chamado)
        {
            try
            {
                AbrirConexao();

                DataTable dataTable = new DataTable();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();

                comando = new MySqlCommand("SELECT NOME, SETOR, chamado.ID_ACESSO, ABERTURA, HORAE, PRODUTO, SAIDA, HORAS, SITUAÇAO, ID_CHAMADO " +
                    "FROM ACESSO inner join CHAMADO ON chamado.ID_CHAMADO = acesso.ID_ACESSO WHERE ABERTURA AND SAIDA between @ABERTURA AND @SAIDA", conexao);

                comando.Parameters.AddWithValue("@ABERTURA", chamado.abertura);
                comando.Parameters.AddWithValue("@SAIDA", chamado.fechamento);


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

        //listas os chamados realizados
        public DataTable pesquisarPerfil(Chamado chamado)
        {
            try
            {
                AbrirConexao();

                DataTable dataTable = new DataTable();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();

                comando = new MySqlCommand("select acesso.NOME, acesso.SETOR, acesso.ID_ACESSO, chamado.ABERTURA , chamado.HORAE, chamado.PRODUTO , chamado.SAIDA, chamado.HORAS, chamado.SITUAÇAO, chamado.ID_CHAMADO " +
                    "from acesso, chamado where acesso.ID_ACESSO = chamado.ID_ACESSO and chamado.SITUAÇAO = @SITUAÇAO", conexao);

                comando.Parameters.AddWithValue("@SITUAÇAO", chamado.situacao);

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
