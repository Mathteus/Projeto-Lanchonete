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
    public partial class FormTelaPratos : Form
    {
        string name;
        ControladoraForms c= new ControladoraForms();
        public FormTelaPratos()
        {
            InitializeComponent();
            this.name = Program.name;
        }

        private void FormTelaPratos_Load(object sender, EventArgs e)
        {
            lbl_Titulo.Text = this.name+ " Escolha Seu Prato";
        }

        private void buttonLanche_Click(object sender, EventArgs e)
        {
            c.destivarTelaPratos();
            c.ativarLanche();
        }

        private void FormTelaPratos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.fechar();
        }

        private void buttonPizza_Click(object sender, EventArgs e)
        {
            c.ativarPizza();
            c.destivarTelaPratos();
        }

        private void buttonSalgados_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desculpe Opcão indisponível no momento...");
        }
    }
}
