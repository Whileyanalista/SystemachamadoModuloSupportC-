using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Systemachamado.ModellGetSet;
using Systemachamado.Dao;
using System.Data;


namespace Systemachamado.Bll
{
    //CLASSE BLL A CLASE DE COMUNICAÇAO ENTRE CLASSES 
    public class AcessoBll
    {
        AcessoDao acessoDao = new AcessoDao();

        public void salvar(Acesso acesso)
        {
            try
            {
                acessoDao.salvar(acesso);
            }
            catch (Exception erro)
            {               
             System.Windows.Forms.MessageBox.Show("ERRO DE CONEXÃO COM O BANCO DE DADOS");                

             throw erro;
            }
        }

        public void deletar(Acesso acesso)
        {
            try
            {
                acessoDao.deletar(acesso);
            }
            catch (Exception erro)
            {
                System.Windows.Forms.MessageBox.Show("ERRO DE CONEXÃO COM O BANCO DE DADOS");

                throw erro;
            }
        }

        public void editar(Acesso acesso)
        {
            try
            {
                acessoDao.editar(acesso);
            }
            catch (Exception erro)
            {
                System.Windows.Forms.MessageBox.Show("ERRO DE CONEXÃO COM O BANCO DE DADOS");

                throw erro;
            }
        }


        //METODO PARA LISTAR
        public DataTable listar()
        {
            try
            {
                DataTable dataTable = new DataTable();

                dataTable = acessoDao.listar();

                return dataTable;
            }
            catch (Exception erro)
            {                
                System.Windows.Forms.MessageBox.Show("ERRO DE CONEXÃO COM O BANCO DE DADOS");               

                throw erro;
            }
        }

        //METODO BLL COGAR
        public bool tem;
        public bool logar(Acesso acesso)
        {
            try
            {
                acessoDao.logar(acesso);
                return tem;
            }
            catch (Exception erro)
            {
                System.Windows.Forms.MessageBox.Show("ERRO DE CONEXÃO COM O BANCO DE DADOS");
                throw erro;
            }
        }


    }
}
