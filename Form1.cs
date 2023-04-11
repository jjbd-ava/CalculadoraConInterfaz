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
        private double num1;
        private double num2;
        private int operacion;
        private double resultado;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "9";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(display.Text);
            operacion = 1;
            display.Text = "";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(display.Text);
            operacion = 2;
            display.Text = "";
        }

        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(display.Text);
            operacion = 3;
            display.Text = "";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(display.Text);
            operacion = 4;
            display.Text = "";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + ".";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(display.Text);
            switch (operacion)
            {
                case 1:
                    resultado = num1 + num2;
                    break;
                case 2:
                    resultado = num1 - num2;
                    break;
                case 3:
                    resultado = num1 * num2;
                    break;
                case 4:
                    resultado = num1 / num2;
                    break;
            }
            display.Text = "" + resultado;
            operacion = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            display.Text = "";
        }
    }
}
