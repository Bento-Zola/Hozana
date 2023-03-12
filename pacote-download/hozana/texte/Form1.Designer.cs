namespace texte
{
    partial class HOZANA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HOZANA));
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BTNENTRAR = new System.Windows.Forms.Button();
            this.TXTUSUARIO = new System.Windows.Forms.TextBox();
            this.TXTSENHA = new System.Windows.Forms.TextBox();
            this.BTNSAIR = new System.Windows.Forms.Button();
            this.cbcargos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(142, 514);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Versão 1.1.1 \"By: CenasReaisSoft";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(57, 61);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(300, 158);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // BTNENTRAR
            // 
            this.BTNENTRAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.BTNENTRAR.Location = new System.Drawing.Point(65, 355);
            this.BTNENTRAR.Name = "BTNENTRAR";
            this.BTNENTRAR.Size = new System.Drawing.Size(138, 23);
            this.BTNENTRAR.TabIndex = 10;
            this.BTNENTRAR.Text = "ENTRAR";
            this.BTNENTRAR.UseVisualStyleBackColor = true;
            this.BTNENTRAR.Click += new System.EventHandler(this.button3_Click);
            // 
            // TXTUSUARIO
            // 
            this.TXTUSUARIO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTUSUARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTUSUARIO.Location = new System.Drawing.Point(65, 225);
            this.TXTUSUARIO.Name = "TXTUSUARIO";
            this.TXTUSUARIO.Size = new System.Drawing.Size(292, 21);
            this.TXTUSUARIO.TabIndex = 11;
            this.TXTUSUARIO.Text = "Usuario";
            this.TXTUSUARIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTUSUARIO.TextChanged += new System.EventHandler(this.TXTUSUARIO_TextChanged);
            // 
            // TXTSENHA
            // 
            this.TXTSENHA.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.TXTSENHA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.TXTSENHA.Location = new System.Drawing.Point(65, 271);
            this.TXTSENHA.Name = "TXTSENHA";
            this.TXTSENHA.Size = new System.Drawing.Size(292, 21);
            this.TXTSENHA.TabIndex = 13;
            this.TXTSENHA.Text = "Senha";
            this.TXTSENHA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTSENHA.UseSystemPasswordChar = true;
            this.TXTSENHA.TextChanged += new System.EventHandler(this.TXTSENHA_TextChanged);
            // 
            // BTNSAIR
            // 
            this.BTNSAIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.BTNSAIR.Location = new System.Drawing.Point(219, 355);
            this.BTNSAIR.Name = "BTNSAIR";
            this.BTNSAIR.Size = new System.Drawing.Size(138, 23);
            this.BTNSAIR.TabIndex = 14;
            this.BTNSAIR.Text = "SAIR";
            this.BTNSAIR.UseVisualStyleBackColor = true;
            this.BTNSAIR.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbcargos
            // 
            this.cbcargos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.cbcargos.FormattingEnabled = true;
            this.cbcargos.Items.AddRange(new object[] {
            "Pastor Titular",
            "Secretario",
            "Contabilista"});
            this.cbcargos.Location = new System.Drawing.Point(65, 314);
            this.cbcargos.Name = "cbcargos";
            this.cbcargos.Size = new System.Drawing.Size(292, 23);
            this.cbcargos.TabIndex = 15;
            this.cbcargos.Text = "Cargo";
            // 
            // HOZANA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 548);
            this.Controls.Add(this.cbcargos);
            this.Controls.Add(this.BTNSAIR);
            this.Controls.Add(this.TXTSENHA);
            this.Controls.Add(this.TXTUSUARIO);
            this.Controls.Add(this.BTNENTRAR);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HOZANA";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOZANA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button BTNENTRAR;
        private System.Windows.Forms.TextBox TXTUSUARIO;
        private System.Windows.Forms.TextBox TXTSENHA;
        private System.Windows.Forms.Button BTNSAIR;
        private System.Windows.Forms.ComboBox cbcargos;
    }
}

