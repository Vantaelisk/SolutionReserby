namespace ReserbyFormsApp
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Usertxt = new System.Windows.Forms.TextBox();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.recuperarcont = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 63);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Castellar", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(67, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reserby";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("FuturaHandwritten", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(67, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "La cena de tus sueños a un clic";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-9, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-8, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 405);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Usertxt
            // 
            this.Usertxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.Usertxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Usertxt.Font = new System.Drawing.Font("FuturaHandwritten", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usertxt.ForeColor = System.Drawing.SystemColors.Info;
            this.Usertxt.Location = new System.Drawing.Point(379, 151);
            this.Usertxt.Multiline = true;
            this.Usertxt.Name = "Usertxt";
            this.Usertxt.Size = new System.Drawing.Size(343, 31);
            this.Usertxt.TabIndex = 2;
            this.Usertxt.Text = "Correo electrónico";
            this.Usertxt.Enter += new System.EventHandler(this.Usertxt_Enter);
            this.Usertxt.Leave += new System.EventHandler(this.Usertxt_Leave);
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.Passwordtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Passwordtxt.Font = new System.Drawing.Font("FuturaHandwritten", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordtxt.ForeColor = System.Drawing.SystemColors.Info;
            this.Passwordtxt.Location = new System.Drawing.Point(379, 216);
            this.Passwordtxt.Multiline = true;
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.Size = new System.Drawing.Size(343, 34);
            this.Passwordtxt.TabIndex = 3;
            this.Passwordtxt.Text = "Contraseña";
            this.Passwordtxt.Enter += new System.EventHandler(this.Passwordtxt_Enter);
            this.Passwordtxt.Leave += new System.EventHandler(this.Passwordtxt_Leave);
            // 
            // Loginbtn
            // 
            this.Loginbtn.BackColor = System.Drawing.Color.Red;
            this.Loginbtn.FlatAppearance.BorderSize = 0;
            this.Loginbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.Loginbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaShell;
            this.Loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loginbtn.Font = new System.Drawing.Font("FuturaHandwritten", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.ForeColor = System.Drawing.Color.Gold;
            this.Loginbtn.Location = new System.Drawing.Point(379, 302);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(343, 34);
            this.Loginbtn.TabIndex = 6;
            this.Loginbtn.Text = "Acceder";
            this.Loginbtn.UseVisualStyleBackColor = false;
            this.Loginbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(379, 177);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(343, 10);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(379, 240);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(343, 10);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // recuperarcont
            // 
            this.recuperarcont.AutoSize = true;
            this.recuperarcont.Font = new System.Drawing.Font("FuturaHandwritten", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recuperarcont.LinkColor = System.Drawing.Color.Gold;
            this.recuperarcont.Location = new System.Drawing.Point(464, 376);
            this.recuperarcont.Name = "recuperarcont";
            this.recuperarcont.Size = new System.Drawing.Size(191, 18);
            this.recuperarcont.TabIndex = 10;
            this.recuperarcont.TabStop = true;
            this.recuperarcont.Text = "¿Olvidó su contraseña?";
            this.recuperarcont.VisitedLinkColor = System.Drawing.Color.DarkGoldenrod;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.recuperarcont);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.Usertxt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserby - Log In";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Usertxt;
        private System.Windows.Forms.TextBox Passwordtxt;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.LinkLabel recuperarcont;
    }
}

