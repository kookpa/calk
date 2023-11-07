namespace cak
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMais = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnVezes = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.lbresultado = new System.Windows.Forms.Label();
            this.txbnumero1 = new System.Windows.Forms.TextBox();
            this.txbnumero2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMais
            // 
            this.btnMais.Location = new System.Drawing.Point(66, 166);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(174, 28);
            this.btnMais.TabIndex = 0;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = true;
            this.btnMais.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.Location = new System.Drawing.Point(277, 165);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(139, 29);
            this.btnMenos.TabIndex = 1;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(454, 45);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(9, 8);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnVezes
            // 
            this.btnVezes.Location = new System.Drawing.Point(71, 210);
            this.btnVezes.Name = "btnVezes";
            this.btnVezes.Size = new System.Drawing.Size(168, 37);
            this.btnVezes.TabIndex = 3;
            this.btnVezes.Text = "x";
            this.btnVezes.UseVisualStyleBackColor = true;
            this.btnVezes.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(290, 213);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(125, 33);
            this.btnDividir.TabIndex = 4;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.button5_Click);
            // 
            // lbresultado
            // 
            this.lbresultado.AutoSize = true;
            this.lbresultado.Location = new System.Drawing.Point(411, 100);
            this.lbresultado.Name = "lbresultado";
            this.lbresultado.Size = new System.Drawing.Size(55, 13);
            this.lbresultado.TabIndex = 5;
            this.lbresultado.Text = "Resultado";
            // 
            // txbnumero1
            // 
            this.txbnumero1.Location = new System.Drawing.Point(71, 93);
            this.txbnumero1.Name = "txbnumero1";
            this.txbnumero1.Size = new System.Drawing.Size(144, 20);
            this.txbnumero1.TabIndex = 7;
            // 
            // txbnumero2
            // 
            this.txbnumero2.Location = new System.Drawing.Point(250, 93);
            this.txbnumero2.Name = "txbnumero2";
            this.txbnumero2.Size = new System.Drawing.Size(121, 20);
            this.txbnumero2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbnumero2);
            this.Controls.Add(this.txbnumero1);
            this.Controls.Add(this.lbresultado);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnVezes);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMais);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnVezes;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Label lbresultado;
        private System.Windows.Forms.TextBox txbnumero1;
        private System.Windows.Forms.TextBox txbnumero2;
    }
}

