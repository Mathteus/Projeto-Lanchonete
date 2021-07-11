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
    public partial class FormPizzaConfirma : Form
    {
        public FormPizzaConfirma()
        {
            InitializeComponent();
        }

        public void pedido(string pedido)
        {
            label1.Text = Program.name + " Seu Pedido:\n" + pedido;
        }

        private void FormPizzaConfirma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.fechar();
        }

        private void buttonSim_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MessageBox.Show("Obrigado Por Comprar Conosco");
            Program.fechar();
        }

        private void buttonNao_Click(object sender, EventArgs e)
        {
            FormTelaPizza p = new FormTelaPizza();
            this.Visible = false;
            p.Visible = true;
        }
    }
}
