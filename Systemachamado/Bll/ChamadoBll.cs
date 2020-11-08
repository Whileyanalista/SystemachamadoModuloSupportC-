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
    public class ChamadoBll
    {
        ChamadoDao chamadoDao = new ChamadoDao();

        //METODO PARA SALVARO
        public void salvar(Chamado chamado)
        {
            try
            {
                chamadoDao.salvar(chamado);
            }
            catch (Exception erro)
            {               
                System.Windows.Forms.MessageBox.Show("ERRO DE CONEXÃO COM O BANCO DE DADOS");               
                
                throw erro;
            }
        }

        //METODO PARA EDITAR
        public void editar(Chamado chamado)
        {
            //ChamadoDao acessoDao = new AcessoDao();           

            try
            {
                chamadoDao.editar(chamado);
            }
            catch (Exception erro)
            {
                System.Windows.Forms.MessageBox.Show("ERRO DE CONEXÃO COM O BANCO DE DADOS");

                throw erro;
            }
        }

        //METODO PARA DELETAR 
        public void deletar(Chamado chamado)
        {
            try
            {
                chamadoDao.deletar(chamado);
            }
            catch (Exception erro)
            {
                System.Windows.Forms.MessageBox.Show("ERRO DE CONEXÃO COM O BANCO DE DADOS");

                throw erro;
            }
        }

       

        //METODO PARA LISTAR
        public DataTable listarCh()
        {
            try
            {
                DataTable dataTable = new DataTable();

                dataTable = chamadoDao.listarCh();

                return dataTable;
            }
            catch (Exception erro)
            { 
                System.Windows.Forms.MessageBox.Show("ERRO DE CONEXÃO COM O BANCO DE DADOS");               

                throw erro;
            }
        }

        //METODO LISTAR US USUARIOS CADASTRADOS 
        public DataTable listarChUser(Chamado chamado)
        {
            try
            {
                DataTable dataTable = new DataTable();

                dataTable = chamadoDao.listarChUser(chamado);

                return dataTable;
            }
            catch (Exception erro)
            {
                System.Windows.Forms.MessageBox.Show("ERRO DE CONEXÃO COM O BANCO DE DADOS");

                throw erro;
            }
        }

        //METODO QUE PERMITE PESQUIOSA PESQUISAR POR NOME
        public DataTable pesquisarNome(Acesso acesso)
        {
            try
            {
                DataTable dataTable = new DataTable();

                dataTable = chamadoDao.pesquisarNome(acesso);

                return dataTable;
            }
            catch (Exception erro)
            {
                System.Windows.Forms.MessageBox.Show("ERRO DE CONEXÃO COM O BANCO DE DADOS");

                throw erro;
            }
        }

        //METODO QUE PERMITE LISTAR POR PERFIL
        public DataTable pesquisarPerfil(Chamado chamado)
        {
            try
            {
                DataTable dataTable = new DataTable();

                dataTable = chamadoDao.pesquisarPerfil(chamado);

                return dataTable;
            }
            catch (Exception erro)
            {
                System.Windows.Forms.MessageBox.Show("ERRO DE CONEXÃO COM O BANCO DE DADOS");

                throw erro;
            }
        }

        //METODO QUE PERMITE LISTAR POR DATAS
        public DataTable pesquisarDatas(Chamado chamado)
        {
            try
            {
                DataTable dataTable = new DataTable();

                dataTable = chamadoDao.pesquisarDatas(chamado);

                return dataTable;
            }
            catch (Exception erro)
            {
                System.Windows.Forms.MessageBox.Show("ERRO DE CONEXÃO COM O BANCO DE DADOS");

                throw erro;
            }
        }


    }


}
