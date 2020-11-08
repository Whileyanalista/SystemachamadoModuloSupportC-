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
    public partial class FormTelaCadastroUser : Form
    {
        
        public FormTelaCadastroUser()
        {
            InitializeComponent();    
        }

        //ESTANCIAS DE FORMES USADAS 
        AcessoBll acessoBll = new AcessoBll();
        Acesso acesso = new Acesso();

        //METODO SALVAR
        private void salvar(Acesso acesso)
        {
            AcessoBll acessoBll = new AcessoBll();

            acesso.setor = textBoxSetorCad.Text;
            acesso.nome = textBoxNomeCad.Text;
            acesso.login = textBoxLoginCad.Text;
            acesso.senha = textBoxSenhaCad.Text;
            acesso.perfil = textBoxPerfilCad.Text;            
            
            acessoBll.salvar(acesso);

            MessageBox.Show("DADOS SALVOS COM SUCESSO !!!");
        }


        // METODO EDITAR
        private void editar(Acesso acesso)
        {
            AcessoBll acessoBll = new AcessoBll();

            acesso.id_acesso = Convert.ToInt32(textBoxIdCadUser.Text);

            acesso.setor = textBoxSetorCad.Text;
            acesso.nome = textBoxNomeCad.Text;
            acesso.login = textBoxLoginCad.Text;
            acesso.senha = textBoxSenhaCad.Text;
            acesso.perfil = textBoxPerfilCad.Text;

            acessoBll.editar(acesso);

            MessageBox.Show("DADOS ALTERADOS COM SUCESSO!!!");
        }

        //METODO EDITAR
        private void deletar(Acesso acesso)
        {
            acesso.id_acesso = Convert.ToInt32(textBoxIdCadUser.Text);

            if (acesso.id_acesso == Convert.ToInt32(textBoxIdCadUser.Text))
            {
                acessoBll.deletar(acesso);
                MessageBox.Show("DADOS DELETADOS COM SUCESSO !!!");
            }
            acessoBll.deletar(acesso);
        }

        //METODO LIMPAR CAMPO
        public void Limpar_Campo()
        {
            textBoxSetorCad.Text = "";
            textBoxNomeCad.Text = "";
            textBoxLoginCad.Text = "";
            textBoxSenhaCad.Text = "";
            textBoxPerfilCad.Text = "";
            textBoxIdCadUser.Text = "";
        }


        private void buttonCadastroCadLogin_Click(object sender, EventArgs e)
        {
            //AÇAO QUE PERMITE ORIENTACAO A CAMPOS EM BRANCO OBRIGATORIOS
            if (textBoxNomeCad.Text == ""  )
            {
                labelNome.ForeColor = Color.Red;
                textBoxNomeCad.Focus();
            }
            else if (textBoxSetorCad.Text == "")
            {
                labelSetor.ForeColor = Color.Red;
                textBoxSetorCad.Focus();
            }
            else if (textBoxLoginCad.Text == "")
            {
                labelLogin.ForeColor = Color.Red;
                textBoxLoginCad.Focus();
            }
            else if (textBoxSenhaCad.Text == "")
            {
                labelSenha.ForeColor = Color.Red;
                textBoxSenhaCad.Focus();
            }
            else
            {
                if (textBoxIdCadUser.Text == "")
                {
                    if (DialogResult.Yes == MessageBox.Show("GOSTARIA DE CADASTRAR ESTE USUARIO", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    {
                        salvar(acesso);
                        Limpar_Campo();

                    }
                }
                else if (DialogResult.Yes == MessageBox.Show("GOSTARIA DE ALTERAR ESTE USUARIO", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    editar(acesso);
                    Limpar_Campo();
                }
                Close();
            }
        }

        private void buttonCancelarCadLogin_Click(object sender, EventArgs e)
        {
            Close();

            Limpar_Campo();
        }

        private void buttonDeletarCadLogin_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("GOSTARIA DE DELETAR ESTE USUARIO", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                deletar(acesso);
                Limpar_Campo();

                Close();
            }
        }

        private void textBoxNomeCad_TextChanged(object sender, EventArgs e)
        {
            //LETRAS EM CAIXA ALTA
            textBoxNomeCad.CharacterCasing = CharacterCasing.Upper;
        }

        private void textBoxSetorCad_TextChanged(object sender, EventArgs e)
        {
            //LETRAS EM CAIXA ALTA
            textBoxSetorCad.CharacterCasing = CharacterCasing.Upper;
        }

        private void textBoxLoginCad_TextChanged(object sender, EventArgs e)
        {
            //LETRAS EM CAIXA ALTA
            textBoxLoginCad.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
