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
    public partial class FormTelaPizza : Form
    {
        string retornado = "";
        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            ingredientes();
            FormPizzaConfirma pizzaConfirma = new FormPizzaConfirma();
            this.Visible = false;
            pizzaConfirma.Show();
        }

        public FormTelaPizza()
        {
            InitializeComponent();
        }

        private void FormTelaPizza_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.fechar();
        }

        private void FormTelaPizza_Load(object sender, EventArgs e)
        {

        }

        private string selectionBorda(string p,bool v)
        {
            string retorno="";
            switch (p)
            {
                case "Sem Borda":
                    if (v) retorno = p;
                    break;
                case "Cheddar":
                    if (v) retorno = p;
                    break;
                case "Catupiry":
                    if (v) retorno = p;
                    break;
            }
            return retorno;
        }

        private void radioButtonSemBorda_CheckedChanged(object sender, EventArgs e)
        {
            string sb = "Sem Borda";
            bool vsb = true;
            string n = selectionBorda(sb, vsb);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string cd = "Cheddar";
            bool vcd = true;
            string n1 = selectionBorda(cd, vcd);
        }

        private void radioButtonCatupiry_CheckedChanged(object sender, EventArgs e)
        {
            string c = "Catupiry";
            bool vc = true;
            string n2 = selectionBorda(c, vc);
        }

        private void ingredientes()
        {
            if(checkBoxMussarela.Checked)
            {
                retornado += "\nMussarela";
            }
            if (checkBoxAzeitona.Checked)
            {
                retornado += "\nAzeitona";
            }
            if (checkBoxBacon.Checked)
            {
                retornado += "\nBacon";
            }
            if (checkBoxBrocolis.Checked)
            {
                retornado += "\nBrócolis";
            }
            if (checkBoxCalabresa.Checked)
            {
                retornado += "\nCalabresa";
            }
            if (checkBoxCebola.Checked)
            {
                retornado += "\nCebola";
            }
            if (checkBoxFrango.Checked)
            {
                retornado += "\nFrango";
            }
            if (checkBoxManjericao.Checked)
            {
                retornado += "\nManjericão";
            }
            if (checkBoxOvo.Checked)
            {
                retornado += "\nOvo";
            }
            if (checkBoxPalmito.Checked)
            {
                retornado += "\nPalmito";
            }
            if (checkBoxPresunto.Checked)
            {
                retornado += "\nPresunto";
            }
            if (checkBoxTomate.Checked)
            {
                retornado += "\nTomate";
            }
        }
    }
}
