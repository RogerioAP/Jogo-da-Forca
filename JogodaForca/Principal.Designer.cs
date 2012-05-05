namespace JogodaForca
{
    partial class frmJogodaforca
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
            this.components = new System.ComponentModel.Container();
            this.btnFechar = new System.Windows.Forms.Button();
            this.ttpPrimeiro = new System.Windows.Forms.ToolTip(this.components);
            this.btnTentar = new System.Windows.Forms.Button();
            this.lblPalavra = new System.Windows.Forms.Label();
            this.txtPalavra = new System.Windows.Forms.TextBox();
            this.lblLetras = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLetrastentadas = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbxPalavrastentadas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxPernaDireita = new System.Windows.Forms.PictureBox();
            this.pbxPernaEsquerda = new System.Windows.Forms.PictureBox();
            this.pbxBracoDireito = new System.Windows.Forms.PictureBox();
            this.pbxBracoEsquerdo = new System.Windows.Forms.PictureBox();
            this.pbxCorpo = new System.Windows.Forms.PictureBox();
            this.pbxCabeca = new System.Windows.Forms.PictureBox();
            this.pbxPricipal = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPernaDireita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPernaEsquerda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBracoDireito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBracoEsquerdo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCorpo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCabeca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPricipal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFechar.Location = new System.Drawing.Point(516, 446);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(87, 25);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "Desistir";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // ttpPrimeiro
            // 
            this.ttpPrimeiro.ShowAlways = true;
            // 
            // btnTentar
            // 
            this.btnTentar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTentar.Location = new System.Drawing.Point(53, 81);
            this.btnTentar.Name = "btnTentar";
            this.btnTentar.Size = new System.Drawing.Size(87, 25);
            this.btnTentar.TabIndex = 5;
            this.btnTentar.Text = "Tentar";
            this.btnTentar.UseVisualStyleBackColor = false;
            this.btnTentar.Click += new System.EventHandler(this.btnTentar_Click);
            // 
            // lblPalavra
            // 
            this.lblPalavra.AutoSize = true;
            this.lblPalavra.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalavra.Location = new System.Drawing.Point(126, 65);
            this.lblPalavra.Name = "lblPalavra";
            this.lblPalavra.Size = new System.Drawing.Size(0, 24);
            this.lblPalavra.TabIndex = 4;
            // 
            // txtPalavra
            // 
            this.txtPalavra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPalavra.Location = new System.Drawing.Point(7, 49);
            this.txtPalavra.Name = "txtPalavra";
            this.txtPalavra.Size = new System.Drawing.Size(179, 20);
            this.txtPalavra.TabIndex = 6;
            // 
            // lblLetras
            // 
            this.lblLetras.AutoSize = true;
            this.lblLetras.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLetras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetras.Location = new System.Drawing.Point(72, 121);
            this.lblLetras.Name = "lblLetras";
            this.lblLetras.Size = new System.Drawing.Size(60, 24);
            this.lblLetras.TabIndex = 8;
            this.lblLetras.Text = "Letras";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.lblLetras);
            this.groupBox1.Controls.Add(this.txtPalavra);
            this.groupBox1.Controls.Add(this.btnTentar);
            this.groupBox1.Location = new System.Drawing.Point(411, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 117);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tentativas (letras ou palavras)";
            // 
            // txtLetrastentadas
            // 
            this.txtLetrastentadas.Enabled = false;
            this.txtLetrastentadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetrastentadas.Location = new System.Drawing.Point(6, 18);
            this.txtLetrastentadas.Multiline = true;
            this.txtLetrastentadas.Name = "txtLetrastentadas";
            this.txtLetrastentadas.Size = new System.Drawing.Size(180, 92);
            this.txtLetrastentadas.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.txtLetrastentadas);
            this.groupBox2.Location = new System.Drawing.Point(411, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 117);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Letras já tentadas";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Controls.Add(this.lbxPalavrastentadas);
            this.groupBox3.Location = new System.Drawing.Point(411, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(192, 117);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Palavras já tentadas";
            // 
            // lbxPalavrastentadas
            // 
            this.lbxPalavrastentadas.FormattingEnabled = true;
            this.lbxPalavrastentadas.Location = new System.Drawing.Point(7, 16);
            this.lbxPalavrastentadas.Name = "lbxPalavrastentadas";
            this.lbxPalavrastentadas.Size = new System.Drawing.Size(179, 95);
            this.lbxPalavrastentadas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "Jogo da Forca";
            // 
            // pbxPernaDireita
            // 
            this.pbxPernaDireita.Image = global::JogodaForca.Properties.Resources.PernaDireita;
            this.pbxPernaDireita.Location = new System.Drawing.Point(268, 264);
            this.pbxPernaDireita.Name = "pbxPernaDireita";
            this.pbxPernaDireita.Size = new System.Drawing.Size(16, 50);
            this.pbxPernaDireita.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPernaDireita.TabIndex = 20;
            this.pbxPernaDireita.TabStop = false;
            this.pbxPernaDireita.Visible = false;
            // 
            // pbxPernaEsquerda
            // 
            this.pbxPernaEsquerda.Image = global::JogodaForca.Properties.Resources.PernaEsquerda;
            this.pbxPernaEsquerda.Location = new System.Drawing.Point(233, 263);
            this.pbxPernaEsquerda.Name = "pbxPernaEsquerda";
            this.pbxPernaEsquerda.Size = new System.Drawing.Size(20, 51);
            this.pbxPernaEsquerda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPernaEsquerda.TabIndex = 19;
            this.pbxPernaEsquerda.TabStop = false;
            this.pbxPernaEsquerda.Visible = false;
            // 
            // pbxBracoDireito
            // 
            this.pbxBracoDireito.Image = global::JogodaForca.Properties.Resources.BracoDireito;
            this.pbxBracoDireito.Location = new System.Drawing.Point(283, 158);
            this.pbxBracoDireito.Name = "pbxBracoDireito";
            this.pbxBracoDireito.Size = new System.Drawing.Size(58, 156);
            this.pbxBracoDireito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBracoDireito.TabIndex = 18;
            this.pbxBracoDireito.TabStop = false;
            this.pbxBracoDireito.Visible = false;
            // 
            // pbxBracoEsquerdo
            // 
            this.pbxBracoEsquerdo.Image = global::JogodaForca.Properties.Resources.BracoEsquerdo;
            this.pbxBracoEsquerdo.Location = new System.Drawing.Point(176, 158);
            this.pbxBracoEsquerdo.Name = "pbxBracoEsquerdo";
            this.pbxBracoEsquerdo.Size = new System.Drawing.Size(58, 156);
            this.pbxBracoEsquerdo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBracoEsquerdo.TabIndex = 17;
            this.pbxBracoEsquerdo.TabStop = false;
            this.pbxBracoEsquerdo.Visible = false;
            // 
            // pbxCorpo
            // 
            this.pbxCorpo.Image = global::JogodaForca.Properties.Resources.Corpo;
            this.pbxCorpo.Location = new System.Drawing.Point(233, 207);
            this.pbxCorpo.Name = "pbxCorpo";
            this.pbxCorpo.Size = new System.Drawing.Size(51, 51);
            this.pbxCorpo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCorpo.TabIndex = 16;
            this.pbxCorpo.TabStop = false;
            this.pbxCorpo.Visible = false;
            // 
            // pbxCabeca
            // 
            this.pbxCabeca.Image = global::JogodaForca.Properties.Resources.Cabeca;
            this.pbxCabeca.Location = new System.Drawing.Point(233, 161);
            this.pbxCabeca.Name = "pbxCabeca";
            this.pbxCabeca.Size = new System.Drawing.Size(51, 45);
            this.pbxCabeca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCabeca.TabIndex = 15;
            this.pbxCabeca.TabStop = false;
            this.pbxCabeca.Visible = false;
            // 
            // pbxPricipal
            // 
            this.pbxPricipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxPricipal.Image = global::JogodaForca.Properties.Resources.Forca2;
            this.pbxPricipal.Location = new System.Drawing.Point(0, 0);
            this.pbxPricipal.Name = "pbxPricipal";
            this.pbxPricipal.Size = new System.Drawing.Size(615, 483);
            this.pbxPricipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPricipal.TabIndex = 11;
            this.pbxPricipal.TabStop = false;
            // 
            // frmJogodaforca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 483);
            this.Controls.Add(this.pbxPernaDireita);
            this.Controls.Add(this.pbxPernaEsquerda);
            this.Controls.Add(this.pbxBracoDireito);
            this.Controls.Add(this.pbxBracoEsquerdo);
            this.Controls.Add(this.pbxCorpo);
            this.Controls.Add(this.pbxCabeca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPalavra);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pbxPricipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmJogodaforca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Forca";
            this.Load += new System.EventHandler(this.frmJogodaforca_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPernaDireita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPernaEsquerda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBracoDireito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBracoEsquerdo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCorpo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCabeca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPricipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ToolTip ttpPrimeiro;
        private System.Windows.Forms.Label lblPalavra;
        private System.Windows.Forms.Button btnTentar;
        private System.Windows.Forms.TextBox txtPalavra;
        private System.Windows.Forms.Label lblLetras;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbxPricipal;
        private System.Windows.Forms.TextBox txtLetrastentadas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbxPalavrastentadas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxCabeca;
        private System.Windows.Forms.PictureBox pbxCorpo;
        private System.Windows.Forms.PictureBox pbxBracoEsquerdo;
        private System.Windows.Forms.PictureBox pbxBracoDireito;
        private System.Windows.Forms.PictureBox pbxPernaEsquerda;
        private System.Windows.Forms.PictureBox pbxPernaDireita;



    }
}

