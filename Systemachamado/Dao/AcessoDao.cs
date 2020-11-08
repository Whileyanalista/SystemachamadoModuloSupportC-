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
    //METODO DE INCERÇAO DE DADOS 
    public class AcessoDao : Conexao
    {
        MySqlCommand comando = null; 

        //METODO SALVAR NO BANCO
        public void salvar(Acesso acesso)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("insert into acesso (SETOR, NOME, LOGIN, SENHA, PERFIL)" +
                    "values (@SETOR, @NOME, @LOGIN, @SENHA, @PERFIL)", conexao);

                comando.Parameters.AddWithValue("@SETOR", acesso.setor);
                comando.Parameters.AddWithValue("@NOME", acesso.nome);
                comando.Parameters.AddWithValue("@LOGIN", acesso.login);
                comando.Parameters.AddWithValue("@SENHA", acesso.senha);
                comando.Parameters.AddWithValue("@PERFIL", acesso.perfil);

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
        


        //METODO QUE PERMITE LOGAR NO SISTEMA APOS ALTENTICAÇAO
        public bool tem = false;
        public bool logar(Acesso acesso)
        {
            //ESTANCIAS DAS CLASSES USADAS 
            FormTelaPrincipal formTelaPrincipal = new FormTelaPrincipal();
            FormCriarTiket formCriarTiket = new FormCriarTiket();
            FormTelaLogin formTelaLogin = new FormTelaLogin();
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("select * from acesso where LOGIN = @LOGIN and SENHA = @SENHA", conexao);

                comando.Parameters.AddWithValue("@LOGIN", acesso.login);
                comando.Parameters.AddWithValue("@SENHA", acesso.senha);

                MySqlDataReader drloga;

                drloga = comando.ExecuteReader();

                if (drloga.Read())//VERIFICA SE EXISTE INFORMAÇAO DIGITADA
                {
                    tem = true;
                    
                    //ATRIBUI INFORMAÇAO A UMA VARIAVEL
                    string nome = drloga.GetString("NOME");
                    string setor = drloga.GetString("SETOR");
                    string id = drloga.GetString("ID_ACESSO");
                    string perfil = drloga.GetString("PERFIL");

                    //VARIAVEL ATRIBUI A INFORMAÇAO CONTIDA NO TEXTBOX
                    formTelaPrincipal.textBoxNomeUserTelaPrin.Text = nome;
                    formTelaPrincipal.textBoxIdUserTelaPrin.Text = id;
                    formTelaPrincipal.textBoxSetorTP.Text = setor;
                     
                    //RESTRIÇAO DE CAMPO PARA SE O USUARIO FOR ADIM
                    if (perfil.Equals("ADMIN"))
                    {
                        formTelaPrincipal.buttonCriaTicket.Visible = false;
                        formTelaPrincipal.ShowDialog();
                    }
                    //RESTRIÇAO SE O USUARIO NAO FOR ADMIN
                    else
                    {
                        formCriarTiket.textBoxStatusCad.Enabled = false;
                        formTelaPrincipal.dataGridViewTabChamadoTP.Enabled = true;
                        formTelaPrincipal.usuariosToolStripMenuItem.Enabled = false;
                        formTelaPrincipal.buttonCadastro.Visible = false;
                        formTelaPrincipal.panelPainel.Visible = false;
                        formTelaPrincipal.buttonRelatorio.Visible = false;
                        formTelaPrincipal.ShowDialog();
                    }
                    drloga.Close();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("LOGIN OU SENHA INCORRETO");
                }
                return tem;
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


        //METODO PARA EDITAR CAMPO
        public void editar(Acesso acesso)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("update acesso set SETOR = @SETOR, NOME = @NOME, LOGIN = @LOGIN, SENHA = @SENHA," +
                    " PERFIL = @PERFIL WHERE ID_ACESSO = @ID_ACESSO", conexao);

                comando.Parameters.AddWithValue("@ID_ACESSO", acesso.id_acesso);
                comando.Parameters.AddWithValue("@SETOR", acesso.setor);
                comando.Parameters.AddWithValue("@NOME", acesso.nome);
                comando.Parameters.AddWithValue("@LOGIN", acesso.login);
                comando.Parameters.AddWithValue("@SENHA", acesso.senha);
                comando.Parameters.AddWithValue("@PERFIL", acesso.perfil);

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


        //METODOPARA DELETAR DADOS DO BANCO
        public void deletar(Acesso acesso)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("delete from acesso where ID_ACESSO = @ID_ACESSO", conexao);

                comando.Parameters.AddWithValue("@ID_ACESSO", acesso.id_acesso);

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


        //METODO PARA LISTAR DATAGRIDVIW
        public DataTable listar()
        {
            try
            {
                AbrirConexao();

                DataTable dataTable = new DataTable();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
                comando = new MySqlCommand("select * from acesso", conexao);

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