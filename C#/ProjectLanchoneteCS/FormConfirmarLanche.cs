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
    public partial class FormConfirmarLanche : Form
    {
        ControladoraForms c = new ControladoraForms();
        public FormConfirmarLanche()
        {
            InitializeComponent();
        }

        public void pedido(string pedido)
        {
            label1.Text = c.lancheAnotado();
        }

        private void buttonNao_Click(object sender, EventArgs e)
        {
            c.desativarConfirmaLanche();
            c.ativarLanche();
        }

        private void buttonSim_Click(object sender, EventArgs e)
        {
            c.desativarConfirmaLanche();
            c.ativarRepitir();

        }

        private void FormConfirmarLanche_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.fechar();
        }
    }
}
