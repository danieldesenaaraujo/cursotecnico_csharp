using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exercicio04
{
    public partial class Form1 : Form
    {
        double esquerda;
        double direita;
        double resultado;

        public Form1()
        {
            InitializeComponent();
        }

        protected void Somar()
        {
            txtExpressao.Text = txtEsquerda.Text + " + " + txtDireita.Text;
            resultado = esquerda + direita;
        }

        protected void Subtrair()
        {
            txtExpressao.Text = txtEsquerda.Text + " - " + txtDireita.Text;
            resultado = esquerda - direita;
        }

        protected void Multiplicar()
        {
            txtExpressao.Text = txtEsquerda.Text + " * " + txtDireita.Text;
            resultado = esquerda * direita;
        }

        protected void Dividir()
        {
            txtExpressao.Text = txtEsquerda.Text + " / " + txtDireita.Text;
            resultado = esquerda / direita;
        }

        protected void Resto()
        {
            txtExpressao.Text = txtEsquerda.Text + " % " + txtDireita.Text;
            resultado = esquerda % direita;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            direita = Convert.ToDouble(txtDireita.Text);
            esquerda = Convert.ToDouble(txtEsquerda.Text);

            if (btnAdicao.Checked)
            {
                Somar();
            }
            else if (btnSubtracao.Checked)
            {
                Subtrair();
            }
            else if (btnMultiplicacao.Checked)
            {
                Multiplicar();
            }
            else if (btnDivisao.Checked)
            {
                Dividir();
            }
            else if (btnResto.Checked)
            {
                Resto();
            }

            txtResultado.Text = resultado.ToString();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
