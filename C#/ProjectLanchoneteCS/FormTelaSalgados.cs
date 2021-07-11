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
    public partial class FormTelaSalgados : Form
    {

        bool fim = true;
        public FormTelaSalgados()
        {
            InitializeComponent();
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            decimal valorBolinha = numericBolinha.Value; 
            decimal valorCoxinha = numericCoxinha.Value; 
            decimal valorCroquete = numericCroquete.Value; 
            decimal valorEmpada = numericEmpada.Value; 
            decimal valorPizza = numericPizza.Value; 
            decimal valorRisoles = numericRisoles.Value;
        }

        private void FormTelaSalgados_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(fim){Program.fechar();}
        }

        private void checkBoxCoxinha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCoxinha.Checked) { numericCoxinha.Enabled = true; } else { numericCoxinha.Enabled = false; }
        }

        private void checkBoxBolinha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBolinha.Checked) { numericBolinha.Enabled = true; } else { numericBolinha.Enabled = false; }
        }

        private void checkBoxEmpada_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxEmpada.Checked) { numericEmpada.Enabled = true; } else { numericEmpada.Enabled = false; }
        }

        private void checkBoxCroquete_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCroquete.Checked) { numericCroquete.Enabled = true; } else { numericCroquete.Enabled = false; }
        }

        private void checkBoxPizza_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPizza.Checked) { numericPizza.Enabled = true; } else { numericPizza.Enabled = false; }
        }

        private void checkBoxRiseles_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRiseles.Checked) { numericRisoles.Enabled = true; } else { numericRisoles.Enabled = false; }
        }
    }
}
