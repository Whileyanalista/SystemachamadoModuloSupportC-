using MySql.Data.MySqlClient;
using System;

namespace Systemachamado.Dao
{
    public class Conexao
    {
        string conecta = "DATABASE = sistematicket; SERVER = SERVIDOR;Port=3307; UID = admin; PWD = admin";
        protected MySqlConnection conexao = null;       

        //METODO PARA CONECXAO DO BANCO
        public void AbrirConexao()
        {
            try
            {
                conexao = new MySqlConnection(conecta);
                conexao.Open();
            }
            catch ( Exception erro)
            {
                throw erro;                
               
            }
            
        }

        //METO PARA DESCONECTAR DO BANCO APOS AS ACOES SEREM FEITAS
        public void FecharConexao()
        {
            try
            {
                conexao = new MySqlConnection(conecta);
                conexao.Close();
            }
            catch(Exception erro)
            {
                throw erro; 
            }
            
        }
        
    }
}
