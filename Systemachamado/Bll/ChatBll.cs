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
    public class ChatBll
    {
        ChatDao chatDao = new ChatDao();

        //METODO QUE LISTA DADOS NA LISTBOX CHAT
        public DataTable listar(Chat chat)
        {
            try
            {
                DataTable dataTable = new DataTable();

                dataTable = chatDao.listar(chat);

                return dataTable;
            }
            catch (Exception erro)
            {
                System.Windows.Forms.MessageBox.Show("ERRO DE CONEXÃO COM O BANCO DE DADOS");

                throw erro;
            }
        }

        //METODO QUE SALVA DADOS NA LISTBOX CHAT
        public void salvar(Chat chat)
        {
            try
            {
                chatDao.salvar(chat);
            }
            catch (Exception erro)
            {
                System.Windows.Forms.MessageBox.Show("ERRO DE CONEXÃO COM O BANCO DE DADOS");
                throw erro;
            }
        }
        
    }
}
