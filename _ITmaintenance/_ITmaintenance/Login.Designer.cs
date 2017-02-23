namespace _ITmaintenance
{
    partial class Login
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.bAnmelden = new System.Windows.Forms.Button();
            this.bAbbrechenLogin = new System.Windows.Forms.Button();
            this.lBenutzernameLogin = new System.Windows.Forms.Label();
            this.lPasswortLogin = new System.Windows.Forms.Label();
            this.tBBenutzernameLogin = new System.Windows.Forms.TextBox();
            this.tBPasswortLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bAnmelden
            // 
            this.bAnmelden.Location = new System.Drawing.Point(1077, 667);
            this.bAnmelden.Name = "bAnmelden";
            this.bAnmelden.Size = new System.Drawing.Size(216, 75);
            this.bAnmelden.TabIndex = 0;
            this.bAnmelden.Text = "Login";
            this.bAnmelden.UseVisualStyleBackColor = true;
            this.bAnmelden.Click += new System.EventHandler(this.bAnmelden_Click);
            // 
            // bAbbrechenLogin
            // 
            this.bAbbrechenLogin.Location = new System.Drawing.Point(1392, 667);
            this.bAbbrechenLogin.Name = "bAbbrechenLogin";
            this.bAbbrechenLogin.Size = new System.Drawing.Size(190, 75);
            this.bAbbrechenLogin.TabIndex = 1;
            this.bAbbrechenLogin.Text = "Abbrechen";
            this.bAbbrechenLogin.UseVisualStyleBackColor = true;
            this.bAbbrechenLogin.Click += new System.EventHandler(this.bAbbrechenLogin_Click);
            // 
            // lBenutzernameLogin
            // 
            this.lBenutzernameLogin.AutoSize = true;
            this.lBenutzernameLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBenutzernameLogin.Location = new System.Drawing.Point(470, 303);
            this.lBenutzernameLogin.Name = "lBenutzernameLogin";
            this.lBenutzernameLogin.Size = new System.Drawing.Size(273, 42);
            this.lBenutzernameLogin.TabIndex = 2;
            this.lBenutzernameLogin.Text = "Benutzername";
            // 
            // lPasswortLogin
            // 
            this.lPasswortLogin.AutoSize = true;
            this.lPasswortLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPasswortLogin.Location = new System.Drawing.Point(473, 365);
            this.lPasswortLogin.Name = "lPasswortLogin";
            this.lPasswortLogin.Size = new System.Drawing.Size(180, 42);
            this.lPasswortLogin.TabIndex = 3;
            this.lPasswortLogin.Text = "Passwort";
            // 
            // tBBenutzernameLogin
            // 
            this.tBBenutzernameLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBBenutzernameLogin.Location = new System.Drawing.Point(772, 307);
            this.tBBenutzernameLogin.Name = "tBBenutzernameLogin";
            this.tBBenutzernameLogin.Size = new System.Drawing.Size(560, 38);
            this.tBBenutzernameLogin.TabIndex = 4;
            // 
            // tBPasswortLogin
            // 
            this.tBPasswortLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBPasswortLogin.Location = new System.Drawing.Point(772, 383);
            this.tBPasswortLogin.Name = "tBPasswortLogin";
            this.tBPasswortLogin.Size = new System.Drawing.Size(560, 38);
            this.tBPasswortLogin.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(558, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(718, 108);
            this.label3.TabIndex = 6;
            this.label3.Text = "IT Maintenance";
            // 
            // Login
            // 
            this.ClientSize = new System.Drawing.Size(1609, 771);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBPasswortLogin);
            this.Controls.Add(this.tBBenutzernameLogin);
            this.Controls.Add(this.lPasswortLogin);
            this.Controls.Add(this.lBenutzernameLogin);
            this.Controls.Add(this.bAbbrechenLogin);
            this.Controls.Add(this.bAnmelden);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBMitarbeiterName;
        private System.Windows.Forms.TextBox tBPasswort;
        private System.Windows.Forms.Label lMitarbeiterName;
        private System.Windows.Forms.Label lMitarbeiterPasswort;
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.Button bLoginAbbrechen;
        private System.Windows.Forms.Button b;
        private System.Windows.Forms.Button bSchließen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBBenutzername;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button bAnmelden;
        private System.Windows.Forms.Button bAbbrechenLogin;
        private System.Windows.Forms.Label lBenutzernameLogin;
        private System.Windows.Forms.Label lPasswortLogin;
        private System.Windows.Forms.TextBox tBBenutzernameLogin;
        private System.Windows.Forms.TextBox tBPasswortLogin;
        private System.Windows.Forms.Label label3;
    }
}