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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnMais = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnVezes = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.lbresultado = new System.Windows.Forms.Label();
            this.txbnumero1 = new System.Windows.Forms.TextBox();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnSete = new System.Windows.Forms.Button();
            this.btnOito = new System.Windows.Forms.Button();
            this.btnNove = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnUm = new System.Windows.Forms.Button();
            this.btnDois = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnQuatro = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lbtemp = new System.Windows.Forms.Label();
            this.lbop = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMais
            // 
            this.btnMais.Location = new System.Drawing.Point(517, 325);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(125, 40);
            this.btnMais.TabIndex = 0;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = true;
            this.btnMais.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.Location = new System.Drawing.Point(517, 268);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(125, 38);
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
            this.btnVezes.Location = new System.Drawing.Point(517, 215);
            this.btnVezes.Name = "btnVezes";
            this.btnVezes.Size = new System.Drawing.Size(125, 39);
            this.btnVezes.TabIndex = 3;
            this.btnVezes.Text = "x";
            this.btnVezes.UseVisualStyleBackColor = true;
            this.btnVezes.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(517, 164);
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
            this.lbresultado.Location = new System.Drawing.Point(189, 96);
            this.lbresultado.Name = "lbresultado";
            this.lbresultado.Size = new System.Drawing.Size(55, 13);
            this.lbresultado.TabIndex = 5;
            this.lbresultado.Text = "Resultado";
            // 
            // txbnumero1
            // 
            this.txbnumero1.Location = new System.Drawing.Point(234, 125);
            this.txbnumero1.Name = "txbnumero1";
            this.txbnumero1.ReadOnly = true;
            this.txbnumero1.Size = new System.Drawing.Size(145, 20);
            this.txbnumero1.TabIndex = 7;
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(364, 325);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(125, 39);
            this.btnIgual.TabIndex = 9;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            // 
            // btnSete
            // 
            this.btnSete.Location = new System.Drawing.Point(71, 164);
            this.btnSete.Name = "btnSete";
            this.btnSete.Size = new System.Drawing.Size(125, 33);
            this.btnSete.TabIndex = 10;
            this.btnSete.Text = "7";
            this.btnSete.UseVisualStyleBackColor = true;
            this.btnSete.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnOito
            // 
            this.btnOito.Location = new System.Drawing.Point(223, 164);
            this.btnOito.Name = "btnOito";
            this.btnOito.Size = new System.Drawing.Size(125, 33);
            this.btnOito.TabIndex = 11;
            this.btnOito.Text = "8";
            this.btnOito.UseVisualStyleBackColor = true;
            this.btnOito.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnNove
            // 
            this.btnNove.Location = new System.Drawing.Point(364, 164);
            this.btnNove.Name = "btnNove";
            this.btnNove.Size = new System.Drawing.Size(125, 33);
            this.btnNove.TabIndex = 12;
            this.btnNove.Text = "9";
            this.btnNove.UseVisualStyleBackColor = true;
            this.btnNove.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.Location = new System.Drawing.Point(223, 224);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(125, 33);
            this.btnCinco.TabIndex = 14;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = true;
            this.btnCinco.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.Location = new System.Drawing.Point(364, 221);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(125, 33);
            this.btnSeis.TabIndex = 15;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = true;
            this.btnSeis.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnUm
            // 
            this.btnUm.Location = new System.Drawing.Point(71, 273);
            this.btnUm.Name = "btnUm";
            this.btnUm.Size = new System.Drawing.Size(125, 33);
            this.btnUm.TabIndex = 16;
            this.btnUm.Text = "1";
            this.btnUm.UseVisualStyleBackColor = true;
            this.btnUm.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnDois
            // 
            this.btnDois.Location = new System.Drawing.Point(223, 273);
            this.btnDois.Name = "btnDois";
            this.btnDois.Size = new System.Drawing.Size(125, 33);
            this.btnDois.TabIndex = 17;
            this.btnDois.Text = "2";
            this.btnDois.UseVisualStyleBackColor = true;
            this.btnDois.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnTres
            // 
            this.btnTres.Location = new System.Drawing.Point(364, 273);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(125, 33);
            this.btnTres.TabIndex = 18;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = true;
            this.btnTres.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(223, 332);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(125, 33);
            this.btnZero.TabIndex = 19;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnQuatro
            // 
            this.btnQuatro.Location = new System.Drawing.Point(71, 221);
            this.btnQuatro.Name = "btnQuatro";
            this.btnQuatro.Size = new System.Drawing.Size(125, 33);
            this.btnQuatro.TabIndex = 20;
            this.btnQuatro.Text = "4";
            this.btnQuatro.UseVisualStyleBackColor = true;
            this.btnQuatro.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(71, 329);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(125, 33);
            this.btnLimpar.TabIndex = 21;
            this.btnLimpar.Text = "C";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lbtemp
            // 
            this.lbtemp.AutoSize = true;
            this.lbtemp.Location = new System.Drawing.Point(284, 96);
            this.lbtemp.Name = "lbtemp";
            this.lbtemp.Size = new System.Drawing.Size(34, 13);
            this.lbtemp.TabIndex = 22;
            this.lbtemp.Text = "Temp";
            // 
            // lbop
            // 
            this.lbop.AutoSize = true;
            this.lbop.Location = new System.Drawing.Point(360, 96);
            this.lbop.Name = "lbop";
            this.lbop.Size = new System.Drawing.Size(19, 13);
            this.lbop.TabIndex = 23;
            this.lbop.Text = "op";
            this.lbop.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbop);
            this.Controls.Add(this.lbtemp);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnQuatro);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnDois);
            this.Controls.Add(this.btnUm);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnNove);
            this.Controls.Add(this.btnOito);
            this.Controls.Add(this.btnSete);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.txbnumero1);
            this.Controls.Add(this.lbresultado);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnVezes);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMais);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
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
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnSete;
        private System.Windows.Forms.Button btnOito;
        private System.Windows.Forms.Button btnNove;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnUm;
        private System.Windows.Forms.Button btnDois;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnQuatro;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lbtemp;
        private System.Windows.Forms.Label lbop;
    }
}

