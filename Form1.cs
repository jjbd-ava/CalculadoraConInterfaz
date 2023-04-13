using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraWP
{
    public partial class Calculadora : Form
    {
        private double num=0;
        private double num2 = 0;
        private string operacion ="";
        private double resultado=0;
        bool operacionPulsada = false;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void btn_Num(object sender, EventArgs e)
        {
            if ((display.Text == "0") || operacionPulsada) display.Clear();
            operacionPulsada = false;
            Button b = (Button)sender;
            if ((b.Text == "." && !display.Text.Contains('.')) || (b.Text!="."))
            {
                display.Text = display.Text + b.Text;
            }
        }
        
        private void btn_Operador(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operacion = b.Text;
            num = Double.Parse(display.Text);
            operacionPulsada = true;
            lblEcuacion.Text = num + " " + operacion;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            lblEcuacion.Text="";
            num2 = Convert.ToDouble(display.Text);
            switch (operacion)
            {
                case "+":
                    resultado = num + num2;
                    break;
                case "-":
                    resultado = num - num2;
                    break;
                case "*":
                    resultado = num * num2;
                    break;
                case "/":
                    resultado = num / num2;
                    break;
            }
            display.Text = resultado.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            display.Text="0";
            num = 0;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            display.Text = "0";
        }

        private void btnSigno_Click(object sender, EventArgs e)
        {
            if (display.Text != "0")
            {
                if (display.Text.StartsWith('-'))
                    display.Text = display.Text.Remove(0, 1);
                else display.Text = "-" + display.Text;
            }
        }
    }
}
