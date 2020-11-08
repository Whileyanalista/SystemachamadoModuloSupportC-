using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Systemachamado.ModellGetSet;
using System.Windows.Forms;
using Systemachamado.Bll;
using Systemachamado.Relatorio;



namespace Systemachamado
{
    public partial class FormTelaPrincipal : Form
    {
        public FormTelaPrincipal()
        {            
            InitializeComponent();            
        }
        

        //ESTANCIAS SENDO USADAS
        AcessoBll acessoBll = new AcessoBll();
        ChamadoBll chamadoBll = new ChamadoBll();       
        FormTelaLogin formTelaLogin = new FormTelaLogin();
        FormTelaCadastroUser formTelaCadastroUser = new FormTelaCadastroUser();

        
        //METODO PARA LISTAR PESSOAS CADASTRADAS NO BANCO
        private void listar()
        {   
            dataGridViewTabUsuarioTP.DataSource = acessoBll.listar();
        }

        public void listarCh()
        {            
            dataGridViewTabChamadoTP.DataSource = chamadoBll.listarCh();
            dataGridViewTabChamadoTP.Sort(dataGridViewTabChamadoTP.Columns["ID_CHAMADO"], ListSortDirection.Descending);
        }

        private void listarChUser(Chamado chamado)
        {
            chamado.id_acesso = Convert.ToInt32(textBoxIdUserTelaPrin.Text);
            dataGridViewTabChamadoTP.DataSource = chamadoBll.listarChUser(chamado);
            dataGridViewTabChamadoTP.Sort(dataGridViewTabChamadoTP.Columns["ID_CHAMADO"], ListSortDirection.Descending);
        }

        private void pesquisarNome(Acesso acesso)
        {
            acesso.nome = textBoxNomeTP.Text;

            dataGridViewTabChamadoTP.DataSource = chamadoBll.pesquisarNome(acesso);
        }

        private void pesquisarPerfil(Chamado chamado)
        {
            chamado.situacao = comboBoxStatusTP.Text;           

            dataGridViewTabChamadoTP.DataSource = chamadoBll.pesquisarPerfil(chamado);
        }

        private void pesquisarDatas(Chamado chamado)
        {
            chamado.abertura = maskedTextBoxAberturaTP.Text;
            chamado.fechamento = maskedTextBoxFechamentoTP.Text;

            dataGridViewTabChamadoTP.DataSource = chamadoBll.pesquisarDatas(chamado);
        }

        private void buttonSupport_Click(object sender, EventArgs e)
        {
            //SHAMANDO TELA DE CADSTRO
            FormCriarTiket formCriarTiket = new FormCriarTiket();            
            formTelaCadastroUser.ShowDialog();
        }

        private void buttonCriaTicket_Click(object sender, EventArgs e)
        {
            FormCriarTiket formCriarTiket = new FormCriarTiket(textBoxNomeUserTelaPrin.Text, textBoxIdUserTelaPrin.Text);
            formCriarTiket.textBoxNomeCd.Text = textBoxNomeUserTelaPrin.Text;
            formCriarTiket.textBoxSetor.Text = textBoxSetorTP.Text;
            formCriarTiket.textBoxStatusCad.Enabled = false;
            formCriarTiket.buttonApagarCad.Enabled = false;
            formCriarTiket.ShowDialog();
            formCriarTiket.textBoxStatusCad.Text = "PENDENTE";
        }


        private void FormTelaPrincipal_Load(object sender, EventArgs e)
        {         
            
            //DIMENSIONANDO COLUNAS 
            dataGridViewTabUsuarioTP.Columns[0].Width = 50;

            dataGridViewTabChamadoTP.Columns[4].HeaderText = "HORA";
            dataGridViewTabChamadoTP.Columns[4].Width = 50;


            dataGridViewTabChamadoTP.Columns[3].Width = 70;

            dataGridViewTabChamadoTP.Columns[1].Width = 70;

            dataGridViewTabChamadoTP.Columns[6].HeaderText = "ENTREGA";
            dataGridViewTabChamadoTP.Columns[6].Width = 70;

            dataGridViewTabChamadoTP.Columns[7].HeaderText = "HORA";
            dataGridViewTabChamadoTP.Columns[7].Width = 50;

            
            dataGridViewTabChamadoTP.Columns[8].Width = 50;

            dataGridViewTabUsuarioTP.Columns["ID_ACESSO"].Visible = false;
            dataGridViewTabChamadoTP.Columns["ID_ACESSO"].Visible = false;
            dataGridViewTabChamadoTP.Columns["ID_CHAMADO"].Visible = false;

            listar();           
           
            if (buttonCriaTicket.Visible == false)
            {
                listarCh();
            }
            else
            {
                Chamado chamado = new Chamado();
                listarChUser(chamado);
            }
            dataGridViewTabChamadoTP.Sort(dataGridViewTabChamadoTP.Columns["ID_CHAMADO"], ListSortDirection.Descending);

        }        
           
        private void dataGridViewTabChamadoTP_DoubleClick(object sender, EventArgs e)
        {

            FormCriarTiket formCriarTiket = new FormCriarTiket();

            if (buttonCriaTicket.Visible == true)
            {
                formCriarTiket.textBoxStatusCad.Enabled = false;                
                formCriarTiket.textBoxIdCadTicket.Enabled = false;
                formCriarTiket.textBoxNomeProdCad.Enabled = false;
                formCriarTiket.buttonCadastrarCad.Enabled = false;

                
                formCriarTiket.textBoxNomeCd.Text = textBoxNomeUserTelaPrin.Text;

                
            }
            else if (buttonCriaTicket.Visible == false)
            {
                formCriarTiket.textBoxNomeProdCad.Enabled = false;
                formCriarTiket.buttonCadastrarCad.Enabled = false;
                
            }
            formCriarTiket.textBoxNomeCd.Text = dataGridViewTabChamadoTP.CurrentRow.Cells[0].Value.ToString();
            formCriarTiket.textBoxSetor.Text = dataGridViewTabChamadoTP.CurrentRow.Cells[1].Value.ToString();
            formCriarTiket.textBoxIdaAcessoTicket.Text = dataGridViewTabChamadoTP.CurrentRow.Cells[2].Value.ToString();
            formCriarTiket.maskedTextBoxAberCad.Text = dataGridViewTabChamadoTP.CurrentRow.Cells[3].Value.ToString();
            formCriarTiket.textBoxHoraAberCad.Text = dataGridViewTabChamadoTP.CurrentRow.Cells[4].Value.ToString();
            formCriarTiket.textBoxNomeProdCad.Text = dataGridViewTabChamadoTP.CurrentRow.Cells[5].Value.ToString();            
            formCriarTiket.maskedTextBoxFechCad.Text = dataGridViewTabChamadoTP.CurrentRow.Cells[6].Value.ToString();
            formCriarTiket.textBoxHoraEntCad.Text = dataGridViewTabChamadoTP.CurrentRow.Cells[7].Value.ToString();
            formCriarTiket.textBoxStatusCad.Text = dataGridViewTabChamadoTP.CurrentRow.Cells[8].Value.ToString();
            formCriarTiket.textBoxIdCadTicket.Text = dataGridViewTabChamadoTP.CurrentRow.Cells[9].Value.ToString();

            formCriarTiket.buttonCancelarCad.BackColor = Color.Red;           


            formCriarTiket.textBoxNomeChat.Text = textBoxNomeUserTelaPrin.Text;


            Chamado chamado = new Chamado();            
            formCriarTiket.ShowDialog();            
        }

        private void dataGridViewTabUsuarioTP_DoubleClick(object sender, EventArgs e)
        {            
            formTelaCadastroUser.textBoxIdCadUser.Text = dataGridViewTabUsuarioTP.CurrentRow.Cells[0].Value.ToString();
            formTelaCadastroUser.textBoxSetorCad.Text = dataGridViewTabUsuarioTP.CurrentRow.Cells[1].Value.ToString();
            formTelaCadastroUser.textBoxNomeCad.Text = dataGridViewTabUsuarioTP.CurrentRow.Cells[2].Value.ToString();
            formTelaCadastroUser.textBoxLoginCad.Text = dataGridViewTabUsuarioTP.CurrentRow.Cells[3].Value.ToString();
            formTelaCadastroUser.textBoxSenhaCad.Text = dataGridViewTabUsuarioTP.CurrentRow.Cells[4].Value.ToString();
            formTelaCadastroUser.textBoxPerfilCad.Text = dataGridViewTabUsuarioTP.CurrentRow.Cells[5].Value.ToString();
            
            formTelaCadastroUser.ShowDialog();
        }

        private void chamadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelChamado.Visible = true;    
        }

        private void usuariosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            panelUser.Visible = true;
            panelChamado.Visible = false;
        }

        private void FormTelaPrincipal_Activated(object sender, EventArgs e)
        {
            
            listar();
            if (buttonCriaTicket.Visible == false)
            {
                listarCh();
            }
            else
            {
                Chamado chamado = new Chamado();
                listarChUser(chamado);
            }
        }

        private void textBoxNomeTP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxNomeTP.Text == "")
            {
                listarCh();
            }
            else
            {
                Acesso acesso = new Acesso();
                pesquisarNome(acesso);
            }            
        }
               

        private void comboBoxStatusTP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxStatusTP.SelectedItem.ToString()=="All")
            {
                listarCh();
            }
            else
            {
                Chamado chamado = new Chamado();
                pesquisarPerfil(chamado);
            }

        }

        private void dataGridViewTabChamadoTP_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            if (e.Value != null && e.Value.Equals("PENDENTE"))
            {
                dataGridViewTabChamadoTP.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;                                   
            }
        }

        private void maskedTextBoxFechamentoTP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Chamado chamado = new Chamado();

                if (maskedTextBoxAberturaTP.Text == "")
                {
                    labelDataAbertura.ForeColor = Color.Red;
                    maskedTextBoxAberturaTP.Focus();
                }
                else if (maskedTextBoxFechamentoTP.Text == "")
                {
                    labelDataSaida.ForeColor = Color.Red;
                    maskedTextBoxFechamentoTP.Focus();
                }
                else
                {
                    pesquisarDatas(chamado);
                }
            }
        }

        private void buttonRelatorio_Click(object sender, EventArgs e)
        {
            iTexRelatorio iTexRelatorio = new iTexRelatorio();
            iTexRelatorio.exportgridtopdf(dataGridViewTabChamadoTP, "Relatorio_Tichet");
        }

        
    }
}
