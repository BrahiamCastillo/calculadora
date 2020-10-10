using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private double valor1, valor2, resultado;
        private string signo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textresultado.Clear();
        }

        private void btnuno_Click(object sender, EventArgs e)
        {
            textresultado.Text = textresultado.Text + 1;
        }

        private void btndos_Click(object sender, EventArgs e)
        {
            textresultado.Text = textresultado.Text + 2;
        }

        private void btncero_Click(object sender, EventArgs e)
        {
            textresultado.Text = textresultado.Text + 0;
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            textresultado.Text = textresultado.Text + ".";
        }

        private void btntres_Click(object sender, EventArgs e)
        {
            textresultado.Text = textresultado.Text + 3;
        }

        private void btncuatro_Click(object sender, EventArgs e)
        {
            textresultado.Text = textresultado.Text + 4;
        }

        private void btncinco_Click(object sender, EventArgs e)
        {
            textresultado.Text = textresultado.Text + 5;
        }

        private void btnseis_Click(object sender, EventArgs e)
        {
            textresultado.Text = textresultado.Text + 6;
        }

        private void btnsiete_Click(object sender, EventArgs e)
        {
            textresultado.Text = textresultado.Text + 7;
        }

        private void btnocho_Click(object sender, EventArgs e)
        {
            textresultado.Text = textresultado.Text + 8;
        }

        private void btnnueve_Click(object sender, EventArgs e)
        {
            textresultado.Text = textresultado.Text + 9;
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            signo = "/";
            valor1 = Double.Parse(textresultado.Text);
            textresultado.Clear();
        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            signo = "+";
            valor1 = Double.Parse(textresultado.Text);
            textresultado.Clear();
        }

        private void btnrestar_Click(object sender, EventArgs e)
        {
            signo = "-";
            valor1 = Double.Parse(textresultado.Text);
            textresultado.Clear();
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            valor2 = Double.Parse(textresultado.Text);
            textresultado.Clear();
            switch(signo)
            {
                case "*":
                    resultado=valor1* valor1;
                    textresultado.Text = resultado.ToString();
                    break;
                case "/":
                    resultado = valor1 / valor2;
                    textresultado.Text = resultado.ToString();
                    break;
                case "+":
                    resultado = valor1 + valor2;
                    textresultado.Text = resultado.ToString();
                    break;
                case "-":
                    resultado = valor1 - valor2;
                    textresultado.Text = resultado.ToString();
                    break;
            }
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            signo = "*";
            valor1 = Double.Parse(textresultado.Text);
            textresultado.Clear();
        }
    }
}
