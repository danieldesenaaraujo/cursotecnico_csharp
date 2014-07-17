using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exercicio03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected void ExibirInt()
        {
            int var;
            var = 10;
            txtExemplo.Text = var.ToString();
        }

        protected void ExibirLong()
        {
            long var;
            var = 10L;
            txtExemplo.Text = var.ToString();
        }

        protected void ExibirFloat()
        {
            float var;
            var = 10.0F;
            txtExemplo.Text = var.ToString();
        }

        protected void ExibirDouble()
        {
            double var;
            var = 10.0;
            txtExemplo.Text = var.ToString();
        }

        protected void ExibirDecimal()
        {
            decimal var;
            var = 10.0M;
            txtExemplo.Text = var.ToString();
        }

        protected void ExibirString()
        {
            string var;
            var = "Daniel";
            txtExemplo.Text = var.ToString();
        }

        protected void ExibirChar()
        {
            char var;
            var = 'F';
            txtExemplo.Text = var.ToString();
        }

        protected void ExibirBool()
        {
            bool var;
            var = false;
            txtExemplo.Text = var.ToString();
        }

        private void lbxTipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lbxTipos.SelectedIndex)
            {
                case 0:
                    ExibirInt();
                    break;
                case 1:
                    ExibirLong();
                    break;
                case 2:
                    ExibirFloat();
                    break;
                case 3:
                    ExibirDouble();
                    break;
                case 4:
                    ExibirDecimal();
                    break;
                case 5:
                    ExibirString();
                    break;
                case 6:
                    ExibirChar();
                    break;
                case 7:
                    ExibirBool();
                    break;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
