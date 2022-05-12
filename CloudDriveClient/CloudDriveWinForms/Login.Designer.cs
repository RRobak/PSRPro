namespace CloudDriveWinForms
{
    partial class Login
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginEmail = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.GoRegister = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(984, 561);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20F);
            this.label1.Location = new System.Drawing.Point(440, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Logowanie";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LoginEmail
            // 
            this.LoginEmail.Font = new System.Drawing.Font("Arial Narrow", 15F);
            this.LoginEmail.Location = new System.Drawing.Point(425, 225);
            this.LoginEmail.Name = "LoginEmail";
            this.LoginEmail.Size = new System.Drawing.Size(265, 30);
            this.LoginEmail.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Location = new System.Drawing.Point(250, 150);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(500, 300);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15F);
            this.label2.Location = new System.Drawing.Point(309, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15F);
            this.label3.Location = new System.Drawing.Point(309, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hasło:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // LoginPassword
            // 
            this.LoginPassword.Font = new System.Drawing.Font("Arial Narrow", 15F);
            this.LoginPassword.Location = new System.Drawing.Point(425, 277);
            this.LoginPassword.Name = "LoginPassword";
            this.LoginPassword.Size = new System.Drawing.Size(265, 30);
            this.LoginPassword.TabIndex = 2;
            this.LoginPassword.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 15F);
            this.button1.Location = new System.Drawing.Point(273, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Zapomniałem hasła";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // GoRegister
            // 
            this.GoRegister.Font = new System.Drawing.Font("Arial Narrow", 15F);
            this.GoRegister.Location = new System.Drawing.Point(608, 386);
            this.GoRegister.Name = "GoRegister";
            this.GoRegister.Size = new System.Drawing.Size(107, 44);
            this.GoRegister.TabIndex = 4;
            this.GoRegister.Text = "Rejestracja";
            this.GoRegister.UseVisualStyleBackColor = true;
            this.GoRegister.Click += new System.EventHandler(this.GoRegister_click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 15F);
            this.button3.Location = new System.Drawing.Point(608, 341);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 39);
            this.button3.TabIndex = 4;
            this.button3.Text = "Zaloguj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Arial Narrow", 15F);
            this.InfoLabel.Location = new System.Drawing.Point(300, 314);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(0, 24);
            this.InfoLabel.TabIndex = 5;
            this.InfoLabel.Click += new System.EventHandler(this.InfoLabel_Click);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.GoRegister);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LoginPassword);
            this.Controls.Add(this.LoginEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoginEmail;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LoginPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button GoRegister;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label InfoLabel;
    }
}

