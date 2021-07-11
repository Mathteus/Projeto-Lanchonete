using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLanchoneteCS
{
    class ControladoraForms
    {
        public static FormTelaPratos telaPratos = new FormTelaPratos(); 
        public static FormLanche lanche = new FormLanche();
        public static FormConfirmarLanche confirmaLanche = new FormConfirmarLanche();
        public static FormTelaPizza Pizza = new FormTelaPizza();
        public static FormPizzaConfirma confirmaPizza = new FormPizzaConfirma();
        public static FormRepedir repetir = new FormRepedir();
        public static FormTelaSalgados salgados = new FormTelaSalgados();
        public static string pedidoLanche="";
        public static string pedidoPizza = "";
        public static string pedidoSalgado = "";

        public void ativarTelaPratos()
        {
            telaPratos.Show();
            telaPratos.Enabled = true;
            telaPratos.Visible = true;
        }
        public void destivarTelaPratos()
        {
            telaPratos.Enabled = false;
            telaPratos.Visible = false;
        }

        public void ativarLanche()
        {
            lanche.Show();
            lanche.Enabled = true;
            lanche.Visible = true;
        }
        public void desativarLanche()
        {
            lanche.Enabled = false;
            lanche.Visible = false;
        }

        public void ativarConfirmaLanche()
        {
            confirmaLanche.Show();
            confirmaLanche.Enabled = true;
            confirmaLanche.Visible = true;
        }
        public void desativarConfirmaLanche()
        {
            confirmaLanche.Enabled = false;
            confirmaLanche.Visible = false;
        }

        public void ativarPizza()
        {
            Pizza.Show();
            Pizza.Enabled = true;
            Pizza.Visible = true;
        }
        public void desativarPizza()
        {
            Pizza.Enabled = false;
            Pizza.Visible = false;
        }

        public void ativarConfirmaPizza()
        {
            confirmaPizza.Show();
            confirmaPizza.Enabled = true;
            confirmaPizza.Visible = true;
        }

        public void ativarSalgados()
        {
            salgados.Show();
            salgados.Enabled = true;
            salgados.Visible = true;
        }
        public void desativarSalgados()
        {
            salgados.Enabled = false;
            salgados.Visible = false;
        }

        public void ativarRepitir()
        {
            repetir.Show();
            repetir.Enabled = true;
            repetir.Visible = true;
        }
        public void desativarRepitir()
        {
            repetir.Enabled = false;
            repetir.Visible = false;
        }

        public void anotarLanche(string p)
        {
            pedidoLanche = p;
        }
        public string lancheAnotado()
        {
            return pedidoLanche;
        }

        public void anotarPizza(string p)
        {
            pedidoPizza = p;
        }
        public string pizzaAnotada()
        {
            return pedidoPizza;
        }

        public void anotarSalgados(string p)
        {
            pedidoSalgado = p;
        }
        public string salgadosAnotados()
        {
            return pedidoSalgado;
        }
    }
}
