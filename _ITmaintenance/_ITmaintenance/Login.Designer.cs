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
            this.SuspendLayout();
            // 
            // bAnmelden
            // 
            this.bAnmelden.Location = new System.Drawing.Point(117, 174);
            this.bAnmelden.Name = "bAnmelden";
            this.bAnmelden.Size = new System.Drawing.Size(75, 23);
            this.bAnmelden.TabIndex = 0;
            this.bAnmelden.Text = "Login";
            this.bAnmelden.UseVisualStyleBackColor = true;
            this.bAnmelden.Click += new System.EventHandler(this.bAnmelden_Click);
            // 
            // bAbbrechenLogin
            // 
            this.bAbbrechenLogin.Location = new System.Drawing.Point(197, 230);
            this.bAbbrechenLogin.Name = "bAbbrechenLogin";
            this.bAbbrechenLogin.Size = new System.Drawing.Size(75, 23);
            this.bAbbrechenLogin.TabIndex = 1;
            this.bAbbrechenLogin.Text = "Abbrechen";
            this.bAbbrechenLogin.UseVisualStyleBackColor = true;
            this.bAbbrechenLogin.Click += new System.EventHandler(this.bAbbrechenLogin_Click);
            // 
            // lBenutzernameLogin
            // 
            this.lBenutzernameLogin.AutoSize = true;
            this.lBenutzernameLogin.Location = new System.Drawing.Point(45, 41);
            this.lBenutzernameLogin.Name = "lBenutzernameLogin";
            this.lBenutzernameLogin.Size = new System.Drawing.Size(75, 13);
            this.lBenutzernameLogin.TabIndex = 2;
            this.lBenutzernameLogin.Text = "Benutzername";
            // 
            // lPasswortLogin
            // 
            this.lPasswortLogin.AutoSize = true;
            this.lPasswortLogin.Location = new System.Drawing.Point(48, 103);
            this.lPasswortLogin.Name = "lPasswortLogin";
            this.lPasswortLogin.Size = new System.Drawing.Size(50, 13);
            this.lPasswortLogin.TabIndex = 3;
            this.lPasswortLogin.Text = "Passwort";
            // 
            // tBBenutzernameLogin
            // 
            this.tBBenutzernameLogin.Location = new System.Drawing.Point(161, 41);
            this.tBBenutzernameLogin.Name = "tBBenutzernameLogin";
            this.tBBenutzernameLogin.Size = new System.Drawing.Size(100, 20);
            this.tBBenutzernameLogin.TabIndex = 4;
            // 
            // tBPasswortLogin
            // 
            this.tBPasswortLogin.Location = new System.Drawing.Point(161, 100);
            this.tBPasswortLogin.Name = "tBPasswortLogin";
            this.tBPasswortLogin.Size = new System.Drawing.Size(100, 20);
            this.tBPasswortLogin.TabIndex = 5;
            // 
            // Login
            // 
            this.ClientSize = new System.Drawing.Size(284, 265);
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
    }
}