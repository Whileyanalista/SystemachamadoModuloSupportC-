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


namespace Systemachamado
{
    public partial class FormCriarTiket : Form
    {
        public FormCriarTiket(string nome, string id)
        {
            InitializeComponent();
            textBoxNomeChat.Text = nome;
            textBoxIdaAcessoTicket.Text = id;
        }

        public FormCriarTiket()
        {
            InitializeComponent();
        }

        //INSTANCIAS DE FORMES USADAS
        FormTelaPrincipal formTelaPrincipal = new FormTelaPrincipal();
        ChamadoBll chamadoBll = new ChamadoBll();
        ChatBll chatBll = new ChatBll();
        Chamado chamado = new Chamado();
        Chat chat = new Chat();


        private void salvar(Chamado chamado)
        {
            chamado.abertura = maskedTextBoxAberCad.Text;
            chamado.horaAb = textBoxHoraAberCad.Text;
            chamado.produto = textBoxNomeProdCad.Text;
            chamado.fechamento = maskedTextBoxFechCad.Text;
            chamado.horaSa = textBoxHoraEntCad.Text;
            chamado.situacao = textBoxStatusCad.Text;
            chamado.id_acesso = Convert.ToInt32(textBoxIdaAcessoTicket.Text);

            chamadoBll.salvar(chamado);           

            MessageBox.Show("PARA DEIXAR UMA MENSAGEM FAVOR CLICAR NO TICKET QUE FOI GERADO");
        }

        private void editar(Chamado chamado)
        {
            chamado.id_chamado = Convert.ToInt32(textBoxIdCadTicket.Text);

            chamado.abertura = maskedTextBoxAberCad.Text;
            chamado.horaAb = textBoxHoraAberCad.Text;
            chamado.produto = textBoxNomeProdCad.Text;
            chamado.fechamento = maskedTextBoxFechCad.Text;
            chamado.horaSa = textBoxHoraEntCad.Text;
            chamado.situacao = textBoxStatusCad.Text;
            chamado.id_acesso = Convert.ToInt32(textBoxIdaAcessoTicket.Text);

            chamadoBll.editar(chamado);

            MessageBox.Show("TICKET FINALIZADO COM SUCESSO!!!");
        }

        //METODO DELETAR 
        public void deletrar(Chamado chamado)
        {
            chamado.id_chamado = Convert.ToInt32(textBoxIdCadTicket.Text);

            chamadoBll.deletar(chamado);

            MessageBox.Show("DADOS DELETADOS COM SUCESSO!!!");
        }

        public void limparCampo()
        {
            textBoxStatusCad.Text = "";
        }

        public void listar(Chat chat)
        {
           chat.id_chamado = Convert.ToInt32(textBoxIdCadTicket.Text);
            listBoxChat.DataSource = chatBll.listar(chat);
            listBoxChat.ValueMember = "OBSERVAÇAO";
        }

        public void salvar(Chat chat)
        {
            chat.id_chamado = Convert.ToInt32(textBoxIdCadTicket.Text);
            chat.observacao = textBoxNomeChat.Text + ": " + textBoxMensagem.Text;
            chatBll.salvar(chat);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //TORNANDO A TELA DE REGISTRO INVISIVEL
            Close();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (textBoxIdCadTicket.Text == "")
            {
                //CAPTURA DE DATA QUANDO O PRODUTO FOR SOLICITADO
                maskedTextBoxAberCad.Text = DateTime.Now.ToShortDateString();
                //CAPTURANDO HORA QUANDO O PRODUTO FOR SOLICITADO
                textBoxHoraAberCad.Text = DateTime.Now.ToShortTimeString();
            } 
            else if (textBoxStatusCad.Enabled == true)
            {
                //CAPTURANDO DATA QUANDO O PRUDUTO FOR ENTREGUE
                maskedTextBoxFechCad.Text = DateTime.Now.ToShortDateString();
                //CAPTURANDO HORA QUANDO O PRODUTO FOR ENTREGUE
                textBoxHoraEntCad.Text = DateTime.Now.ToShortTimeString();
            }

        }

        private void buttonCadastrarCad_Click(object sender, EventArgs e)
        {

            if (textBoxNomeProdCad.Text == "")
            {
                labelNomeProCad.ForeColor = Color.Red;
                textBoxNomeProdCad.Focus();
            }            
            else
            {
                if (textBoxIdCadTicket.Text == "")
                {
                    if (DialogResult.Yes == MessageBox.Show("GOSTARIA DE CADASTRAR ESTE TICKET", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    {
                        salvar(chamado);
                        this.Close();
                        formTelaPrincipal.listarCh();
                       
                    }
                }
                else if (DialogResult.Yes == MessageBox.Show("GOSTARIA DE FINALIZAR ESTE TICKET ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    {
                        editar(chamado);
                        this.Close();
                    }
                
            }
        }


        private void buttonCancelarCad_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonApagarCad_Click(object sender, EventArgs e)
        {
            Chamado chamado = new Chamado();
            if (DialogResult.Yes == MessageBox.Show("GOSTARIA DE DELETAR ESTE TICKET", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                deletrar(chamado);
                limparCampo();
                this.Close();
            }
        }

        private void FormCriarTiket_Load(object sender, EventArgs e)
        {
            buttonCancelarCad.Enabled = true;
            buttonCadastrarCad.BackColor = Color.SkyBlue;

            

            Chat chat = new Chat();
            if (textBoxIdCadTicket.Text != "")
            {
                listar(chat);
            }
            else if (textBoxIdCadTicket.Text == "")
            {
                textBoxStatusCad.Text = "PENDENTE";
                buttonCadastrarCad.Enabled = true;
                buttonCadastrarCad.BackColor = Color.Green;


            }
            
            if (textBoxNomeProdCad.Text != "")
            {
                listBoxChat.Enabled = true;
                textBoxMensagem.Enabled = true;
                buttonEnviar.Enabled = true;
            }

            if (textBoxStatusCad.Text == "ENTREGUE" )
            {
                textBoxStatusCad.Enabled = false;
                textBoxMensagem.Enabled = false;
                buttonEnviar.Enabled = false;
                buttonCadastrarCad.Enabled = false;
                buttonApagarCad.Enabled = false;                                
                listBoxChat.Enabled = false;                
            }
        }

        private void textBoxNomeCd_TextChanged(object sender, EventArgs e)
        {
            //LETRAS EM CAIXA ALTA
            textBoxNomeCd.CharacterCasing = CharacterCasing.Upper;
        }

        private void textBoxNomeProdCad_TextChanged_1(object sender, EventArgs e)
        {
            //LETRAS EM CAIXA ALTA
            textBoxNomeProdCad.CharacterCasing = CharacterCasing.Upper;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBoxMensagem.Text == "")
            {
                labelObiservaçaoCad.ForeColor = Color.Red;
                textBoxMensagem.Focus();
            }
            else
            {
                Chat chat = new Chat();
                salvar(chat);
                listar(chat);
                textBoxMensagem.Text = "";
            }            
        }

        
        private void textBoxStatusCad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBoxStatusCad.Text == "ENTREGUE")
            {
                buttonCadastrarCad.Enabled = true;
                buttonCadastrarCad.BackColor = Color.Green;
                buttonCancelarCad.Enabled = false;
                buttonCancelarCad.BackColor = Color.SkyBlue;
            }

            if (textBoxStatusCad.Text == "PENDENTE")
            {
                buttonCadastrarCad.Enabled = false;
                buttonCadastrarCad.BackColor = Color.SkyBlue;
                buttonCancelarCad.Enabled = true;
                buttonCancelarCad.BackColor = Color.Red;
            }

        }

        
    }
}
