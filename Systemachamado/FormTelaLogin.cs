using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Systemachamado.ModellGetSet;
using Systemachamado.Bll;
using Systemachamado.Dao;

namespace Systemachamado
{
    public partial class FormTelaLogin : Form
    {
        public FormTelaLogin()
        {
            InitializeComponent();
        }

        //METODO PARA LOGAR NO SISTEMA 
        private void logar(Acesso acesso)
        {
            AcessoBll acessoBll = new AcessoBll();

            acesso.login = textBoxLogin.Text;
            acesso.senha = textBoxSenha.Text;

            acessoBll.logar(acesso);

            
            if (acessoBll.tem)
            {
                logar(acesso);
            }
        }

        private void buttonAcessar_Click(object sender, EventArgs e)
        {
            //METODOS USADOS NA APLICAÇAO
            Acesso acesso = new Acesso();
            AcessoDao acessoDao = new AcessoDao();
            FormTelaPrincipal formTelaPrincipal = new FormTelaPrincipal();

            //ORIENTAÇAO DE CAMPOS EM BRANCO
            if (textBoxLogin.Text == "")
            {
                labelLogin.ForeColor = Color.Red;
                textBoxLogin.Focus();
            }
            if (textBoxSenha.Text == "")
            {
                labelSenha.ForeColor = Color.Red;
                textBoxSenha.Focus();
            }
            else
            {
                logar(acesso);
            }
   

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FINALIZANDO APLICAÇAO
            Application.Exit();
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            textBoxLogin.CharacterCasing = CharacterCasing.Upper;
        }

        //PRECIONAR ENTER PARA LOGAR
        private void textBoxSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                
                Acesso acesso = new Acesso();
                AcessoDao acessoDao = new AcessoDao();
                if (textBoxLogin.Text == "")
                {
                    labelLogin.ForeColor = Color.Red;
                    textBoxLogin.Focus();
                }
                else if (textBoxSenha.Text == "")
                {
                    labelSenha.ForeColor = Color.Red;
                    textBoxSenha.Focus();
                }
                else
                {
                    this.Visible = false;
                    logar(acesso);                    
                }
            }
        }

        //PRECIONAR ENTER PARA LOGAR
        private void textBoxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Acesso acesso = new Acesso();

                if (textBoxLogin.Text == "")
                {
                    labelLogin.ForeColor = Color.Red;
                    textBoxLogin.Focus();
                }
                else if (textBoxSenha.Text == "")
                {
                    labelSenha.ForeColor = Color.Red;
                    textBoxSenha.Focus();
                }
                else
                {
                    logar(acesso);
                }
            }
        }

        
    }
}
