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
    public partial class FormRepedir : Form
    {
        ControladoraForms c = new ControladoraForms();
        public FormRepedir()
        {
            InitializeComponent();
            label1.Text = Program.name + " Deseja Fazer Outro Pedido ?";
        }

        private void buttonNao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Obrigado Por Comprar Conosco");
            Program.fechar();
        }

        private void buttonSim_Click(object sender, EventArgs e)
        {
            c.desativarRepitir();
            c.ativarTelaPratos();

        }
    }
}
