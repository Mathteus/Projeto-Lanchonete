using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectLanchoneteCS
{
    public partial class FormPrincipal : Form
    {
        ControladoraForms c = new ControladoraForms();
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button_confirmar_name_Click(object sender, EventArgs e)
        {
            if (txtBox_name.Text.Length < 3)
            {
                MessageBox.Show("Digite Um Nome....");
                txtBox_name.Clear();
                txtBox_name.Focus();
            }
            else if(txtBox_name.Text.Length > 22)
            {
                MessageBox.Show("Digite Nome Mais Curto...");
                txtBox_name.Clear();
                txtBox_name.Focus();
            }
            else
            {
                Program.name = txtBox_name.Text;
                c.ativarTelaPratos();
                this.Visible = false;
                this.Enabled = false;
            }
        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.fechar();
        }
    }
}
