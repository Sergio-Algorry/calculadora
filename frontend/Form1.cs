using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frontend
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btResultado_Click(object sender, EventArgs e)
        {
            if (txtOperacion.Text == "+")
            {
                //relizar la operacion
                double oper1 = System.Convert.ToDouble(txtOperando1.Text);
                double oper2 = System.Convert.ToDouble(txtOperando2.Text);

                double res = oper1 + oper2;

                //lblResultado.Text = res.ToString();
                lblResultado.Text = System.Convert.ToString(res);
            }
            else if (txtOperacion.Text == "*")
            {
                //relizar la operacion
                double oper1 = System.Convert.ToDouble(txtOperando1.Text);
                double oper2 = System.Convert.ToDouble(txtOperando2.Text);

                double res = oper1 * oper2;

                //lblResultado.Text = res.ToString();
                lblResultado.Text = System.Convert.ToString(res);
            }
            else
            {
                lblResultado.Text = "ERROR";
            }
        }
    }
}
