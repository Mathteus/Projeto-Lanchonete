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
    public partial class FormLanche : Form
    {
        int hamburguer = 0, tomate = 0, alface = 0, cebola = 0, bacon = 0, queijo = 0, presunto = 0, ovo = 0, frango = 0;
        bool ketchup=false, maionese=false, batata=false, pasta=false, pimenta=false;
        string pao = ""; string name="";
        ControladoraForms c = new ControladoraForms();

        private void buttonSubHamburguer_Click(object sender, EventArgs e)
        {
            if (hamburguer > 0) {
                hamburguer--;
                labelQntdHamburguer.Text = hamburguer.ToString();
            }
        }

        private void buttonAddTomate_Click(object sender, EventArgs e)
        {
            if (tomate >= 0)
            {
                tomate++;
                labelQntdTomate.Text = tomate.ToString();
            }
        }

        private void buttonSubTomate_Click(object sender, EventArgs e)
        {
            if (tomate > 0)
            {
                tomate--;
                labelQntdTomate.Text = tomate.ToString();
            }
        }

        private void buttonAddAlface_Click(object sender, EventArgs e)
        {
            if (alface >= 0)
            {
                alface++;
                labelQntdAlface.Text = alface.ToString();
            }
        }

        private void buttonSubAlface_Click(object sender, EventArgs e)
        {
            if (alface > 0)
            {
                alface--;
                labelQntdAlface.Text = alface.ToString();
            }
        }

        private void buttonAddCebola_Click(object sender, EventArgs e)
        {
            if (cebola >= 0)
            {
                cebola++;
                labelQntdCebola.Text = cebola.ToString();
            }
        }

        private void buttonSubCebola_Click(object sender, EventArgs e)
        {
            if (cebola > 0)
            {
                cebola--;
                labelQntdCebola.Text = cebola.ToString();
            }
        }

        private void buttonAddBacon_Click(object sender, EventArgs e)
        {
            if (bacon >= 0)
            {
                bacon++;
                labelQntdBacon.Text = bacon.ToString();
            }
        }

        private void buttonSubBacon_Click(object sender, EventArgs e)
        {
            if (bacon > 0)
            {
                bacon--;
                labelQntdBacon.Text = bacon.ToString();
            }
        }

        private void buttonAddQueijo_Click(object sender, EventArgs e)
        {
            if (queijo >= 0)
            {
                queijo++;
                labelQntdQueijo.Text = queijo.ToString();
            }
        }

        private void buttonSubQueijo_Click(object sender, EventArgs e)
        {
            if (queijo > 0)
            {
                queijo--;
                labelQntdQueijo.Text = queijo.ToString();
            }
        }

        private void buttonAddPresunto_Click(object sender, EventArgs e)
        {
            if (presunto >= 0)
            {
                presunto++;
                labelQntdPresunto.Text = presunto.ToString();
            }
        }

        private void buttonSubPresunto_Click(object sender, EventArgs e)
        {
            if (presunto > 0)
            {
                presunto--;
                labelQntdPresunto.Text = presunto.ToString();
            }
        }

        private void buttonAddOvo_Click(object sender, EventArgs e)
        {
            if (ovo >= 0)
            {
                ovo++;
                labelQntdOvo.Text = ovo.ToString();
            }
        }

        private void buttonSubOvo_Click(object sender, EventArgs e)
        {
            if (ovo > 0)
            {
                ovo--;
                labelQntdOvo.Text = ovo.ToString();
            }
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            string pd = entrega();
            c.desativarLanche();
            c.ativarConfirmaLanche();
            c.anotarLanche(pd);
        }

        private void FormLanche_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddFrango_Click(object sender, EventArgs e)
        {
            if (frango >= 0)
            {
                frango++;
                labelQntdFrango.Text = frango.ToString();
            }
        }

        private void checkBoxPimenta_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPimenta.Checked)
            {
                pimenta = true;
            }
            else
            {
                pimenta = false;
            }
        }

        private void FormLanche_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.fechar();
        }

        private void buttonAddHamburguer_Click(object sender, EventArgs e)
        {
            if (hamburguer>=0)
            {
                hamburguer++;
                labelQntdHamburguer.Text = hamburguer.ToString();
            }
        }

        private void buttonSubFrango_Click(object sender, EventArgs e)
        {
            if(frango > 0)
            {
                frango--;
                labelQntdFrango.Text = frango.ToString();
            }
        }

        private void checkBoxBatata_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBatata.Checked)
            {
                batata = true;
            }
            else
            {
                batata = false;
            }
        }

        private void checkBoxMaionese_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMaionese.Checked)
            {
                maionese = true;
            }
            else
            {
                maionese = false;
            }
        }

        private void checkBoxPasta_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPasta.Checked)
            {
                pasta = true;
            }
            else
            {
                pasta = false;
            }
        }

        private void checkBoxKetchup_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxKetchup.Checked)
            {
                ketchup = true;
            }
            else
            {
                ketchup = false;
            }
        }

        private void radioButtonPaoHamburguer_CheckedChanged(object sender, EventArgs e)
        {
            bool paoHamburguer = radioButtonPaoHamburguer.Checked;
            paoStado(paoHamburguer, "Pao De Hamburguer");
        }

        private void radioButtonPaoFrances_CheckedChanged(object sender, EventArgs e)
        {
            bool paoFrances = radioButtonPaoFrances.Checked;
            paoStado(paoFrances, "Pao Frances");
        }
        public FormLanche()
        {
            InitializeComponent();
            this.name = Program.name;
            label1.Text = name + " Monte Seu Combo a Sua Preferência";
        }

        private void paoStado(bool statado, string tipo)
        {
            if (statado & tipo.Equals("Pao Frances"))
            {
                pao = tipo+"\n";
            }
            else if(statado & tipo.Equals("Pao De Hamburguer"))
            {
                pao = tipo + "\n";
            }

        }

        private string entrega()
        {
            string retorno=pao;
            if(ketchup)
                retorno += "ketchup\n";
            if (pasta)
                retorno += "Pasta de Alho\n";
            if (maionese)
                retorno += "Maionese\n";
            if (batata)
                retorno += "Batata Palha\n";
            if (pimenta)
                retorno += "Pimenta\n";

            if (hamburguer > 0)
                retorno += "Camadas de Hamburguer: " + hamburguer + "\n";
            if (tomate>0)
                retorno += "Camadas de Tomate: " + tomate + "\n";
            if(alface>0)
                retorno += "Camadas de Alface: " + alface + "\n";
            if(cebola>0)
                retorno += "Camadas de cebola: " + cebola + "\n";
            if(bacon>0)
                retorno += "Camadas de Bacon: " + bacon + "\n";
            if(queijo>0)
                retorno += "Camadas de Queijo: " + queijo + "\n";
            if(presunto>0)
                retorno += "Camadas de Presunto: " + presunto + "\n";
            if(ovo>0)
                retorno += "Camadas de Ovo: " + ovo + "\n";
            if(frango>0)
                retorno += "Camadas de Frango: " + frango + "\n";

            return  retorno;
        }
    }
}
