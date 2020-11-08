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
    public class UsuarioBll
    {
        UsuarioDao usuarioDao = new UsuarioDao();

        //METODO PARA SALVAR 

        public void salvar(Usuario usuario)
        {
            try
            {
                usuarioDao.salvar(usuario);
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

        //METODO PARA LISTAR
        public DataTable listar()
        {
            try
            {
                DataTable dataTable = new DataTable();

                dataTable = usuarioDao.listar();

                return dataTable;
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
