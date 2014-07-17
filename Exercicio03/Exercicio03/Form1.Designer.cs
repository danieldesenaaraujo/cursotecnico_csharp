namespace Exercicio03
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
            this.lbxTipos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExemplo = new System.Windows.Forms.TextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipos primitivos de dados";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Escolha um tipo de dado";
            // 
            // lbxTipos
            // 
            this.lbxTipos.FormattingEnabled = true;
            this.lbxTipos.Items.AddRange(new object[] {
            "int",
            "long",
            "float",
            "double",
            "decimal",
            "string",
            "char",
            "bool"});
            this.lbxTipos.Location = new System.Drawing.Point(16, 69);
            this.lbxTipos.Name = "lbxTipos";
            this.lbxTipos.Size = new System.Drawing.Size(120, 108);
            this.lbxTipos.TabIndex = 2;
            this.lbxTipos.SelectedIndexChanged += new System.EventHandler(this.lbxTipos_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Exemplo";
            // 
            // txtExemplo
            // 
            this.txtExemplo.Location = new System.Drawing.Point(171, 70);
            this.txtExemplo.Name = "txtExemplo";
            this.txtExemplo.Size = new System.Drawing.Size(100, 20);
            this.txtExemplo.TabIndex = 4;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(171, 153);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 191);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txtExemplo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbxTipos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tipos de dados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbxTipos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExemplo;
        private System.Windows.Forms.Button btnFechar;
    }
}

