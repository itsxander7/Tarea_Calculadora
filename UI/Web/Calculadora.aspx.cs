using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web_I_DAL.Calculadora;
using Web_l_BILL.Calculadora;

namespace UI.Web
{
    public partial class Calculadora : System.Web.UI.Page
    {
        cls_Calc_DAL obj1 = new cls_Calc_DAL();
        cls_Calc_BLL Operacion = new cls_Calc_BLL();

        protected void Page_Load(object sender, EventArgs e)
        {
           
          
        }

        protected void btnSuma_Click(object sender, EventArgs e)
        {

            operaciones(Convert.ToChar(btnSuma.Text));

        }

        protected void btnRestar_Click(object sender, EventArgs e)
        {

            operaciones(Convert.ToChar(btnRestar.Text));
        }

        protected void btnIgual_Click(object sender, EventArgs e)
        {

            operaciones(Convert.ToChar(btnIgual.Text));
        }

        protected void btnMultiplicar_Click(object sender, EventArgs e)
        {
            operaciones(Convert.ToChar(btnMultiplicar.Text));


        }

        protected void btnDividir_Click(object sender, EventArgs e)
        {
            operaciones(Convert.ToChar(btnDividir.Text)); 
           
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            txtSumador1.Text = "";
            txtSumador2.Text = "";
            lblresultado.Text = "";
        }
        public void operaciones(char op)
        {
            obj1.bNum_I = Convert.ToByte(txtSumador1.Text);
            obj1.bNum_II = Convert.ToByte(txtSumador1.Text);
            obj1.cSigno = op;

            Operacion.Calculadora_Cool(ref obj1);
            lblresultado.Text = obj1.fResultado.ToString();

            txtSumador1.Text = "";
            txtSumador2.Text = "";
        }
    }
}