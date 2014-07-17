namespace Exercicio04
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEsquerda = new System.Windows.Forms.TextBox();
            this.txtDireita = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdicao = new System.Windows.Forms.RadioButton();
            this.btnSubtracao = new System.Windows.Forms.RadioButton();
            this.btnMultiplicacao = new System.Windows.Forms.RadioButton();
            this.btnDivisao = new System.Windows.Forms.RadioButton();
            this.btnResto = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExpressao = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operador da esquerda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Operador da direita";
            // 
            // txtEsquerda
            // 
            this.txtEsquerda.Location = new System.Drawing.Point(16, 30);
            this.txtEsquerda.Name = "txtEsquerda";
            this.txtEsquerda.Size = new System.Drawing.Size(100, 20);
            this.txtEsquerda.TabIndex = 2;
            // 
            // txtDireita
            // 
            this.txtDireita.Location = new System.Drawing.Point(238, 30);
            this.txtDireita.Name = "txtDireita";
            this.txtDireita.Size = new System.Drawing.Size(100, 20);
            this.txtDireita.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnResto);
            this.groupBox1.Controls.Add(this.btnDivisao);
            this.groupBox1.Controls.Add(this.btnMultiplicacao);
            this.groupBox1.Controls.Add(this.btnSubtracao);
            this.groupBox1.Controls.Add(this.btnAdicao);
            this.groupBox1.Location = new System.Drawing.Point(122, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 143);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operador";
            // 
            // btnAdicao
            // 
            this.btnAdicao.AutoSize = true;
            this.btnAdicao.Location = new System.Drawing.Point(7, 20);
            this.btnAdicao.Name = "btnAdicao";
            this.btnAdicao.Size = new System.Drawing.Size(67, 17);
            this.btnAdicao.TabIndex = 0;
            this.btnAdicao.TabStop = true;
            this.btnAdicao.Text = "+ Adição";
            this.btnAdicao.UseVisualStyleBackColor = true;
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.AutoSize = true;
            this.btnSubtracao.Location = new System.Drawing.Point(7, 44);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(80, 17);
            this.btnSubtracao.TabIndex = 1;
            this.btnSubtracao.TabStop = true;
            this.btnSubtracao.Text = "- Subtração";
            this.btnSubtracao.UseVisualStyleBackColor = true;
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.AutoSize = true;
            this.btnMultiplicacao.Location = new System.Drawing.Point(7, 68);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(94, 17);
            this.btnMultiplicacao.TabIndex = 2;
            this.btnMultiplicacao.TabStop = true;
            this.btnMultiplicacao.Text = "* Multiplicação";
            this.btnMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // btnDivisao
            // 
            this.btnDivisao.AutoSize = true;
            this.btnDivisao.Location = new System.Drawing.Point(7, 92);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(68, 17);
            this.btnDivisao.TabIndex = 3;
            this.btnDivisao.TabStop = true;
            this.btnDivisao.Text = "/ Divisão";
            this.btnDivisao.UseVisualStyleBackColor = true;
            // 
            // btnResto
            // 
            this.btnResto.AutoSize = true;
            this.btnResto.Location = new System.Drawing.Point(7, 116);
            this.btnResto.Name = "btnResto";
            this.btnResto.Size = new System.Drawing.Size(64, 17);
            this.btnResto.TabIndex = 4;
            this.btnResto.TabStop = true;
            this.btnResto.Text = "% Resto";
            this.btnResto.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Expressão";
            // 
            // txtExpressao
            // 
            this.txtExpressao.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtExpressao.Enabled = false;
            this.txtExpressao.Location = new System.Drawing.Point(125, 197);
            this.txtExpressao.Name = "txtExpressao";
            this.txtExpressao.Size = new System.Drawing.Size(107, 20);
            this.txtExpressao.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(16, 197);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(19, 244);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(213, 20);
            this.txtResultado.TabIndex = 9;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(244, 244);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 10;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 279);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtExpressao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDireita);
            this.Controls.Add(this.txtEsquerda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Operadores matemáticos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEsquerda;
        private System.Windows.Forms.TextBox txtDireita;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btnResto;
        private System.Windows.Forms.RadioButton btnDivisao;
        private System.Windows.Forms.RadioButton btnMultiplicacao;
        private System.Windows.Forms.RadioButton btnSubtracao;
        private System.Windows.Forms.RadioButton btnAdicao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExpressao;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnFechar;
    }
}

