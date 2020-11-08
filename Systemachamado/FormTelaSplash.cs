using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Systemachamado
{
    public partial class FormTelaSplash : Form
    {
        public FormTelaSplash()
        {
            //InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBarTelaSplah.Value < 100)
            {
                progressBarTelaSplah.Value = progressBarTelaSplah.Value + 2;
            }
            else
            {
                timer1.Enabled = false;
                FormTelaLogin formTelaLogin = new FormTelaLogin();
                formTelaLogin.Show();
                this.Visible = false;                
            }
        }

        private void pictureBoxTelaSplash_Click(object sender, EventArgs e)
        {

        }
    }
}
