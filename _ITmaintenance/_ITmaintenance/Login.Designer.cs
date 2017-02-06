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
            this.tBMitarbeiterName = new System.Windows.Forms.TextBox();
            this.tBPasswort = new System.Windows.Forms.TextBox();
            this.lMitarbeiterName = new System.Windows.Forms.Label();
            this.lMitarbeiterPasswort = new System.Windows.Forms.Label();
            this.bLogin = new System.Windows.Forms.Button();
            this.bSchliessen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBMitarbeiterName
            // 
            this.tBMitarbeiterName.Location = new System.Drawing.Point(121, 56);
            this.tBMitarbeiterName.Name = "tBMitarbeiterName";
            this.tBMitarbeiterName.Size = new System.Drawing.Size(100, 20);
            this.tBMitarbeiterName.TabIndex = 0;
            // 
            // tBPasswort
            // 
            this.tBPasswort.Location = new System.Drawing.Point(121, 138);
            this.tBPasswort.Name = "tBPasswort";
            this.tBPasswort.Size = new System.Drawing.Size(100, 20);
            this.tBPasswort.TabIndex = 1;
            // 
            // lMitarbeiterName
            // 
            this.lMitarbeiterName.AutoSize = true;
            this.lMitarbeiterName.Location = new System.Drawing.Point(26, 56);
            this.lMitarbeiterName.Name = "lMitarbeiterName";
            this.lMitarbeiterName.Size = new System.Drawing.Size(82, 13);
            this.lMitarbeiterName.TabIndex = 2;
            this.lMitarbeiterName.Text = "Mitarbeitername";
            this.lMitarbeiterName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lMitarbeiterPasswort
            // 
            this.lMitarbeiterPasswort.AutoSize = true;
            this.lMitarbeiterPasswort.Location = new System.Drawing.Point(29, 144);
            this.lMitarbeiterPasswort.Name = "lMitarbeiterPasswort";
            this.lMitarbeiterPasswort.Size = new System.Drawing.Size(50, 13);
            this.lMitarbeiterPasswort.TabIndex = 3;
            this.lMitarbeiterPasswort.Text = "Passwort";
            // 
            // bLogin
            // 
            this.bLogin.Location = new System.Drawing.Point(130, 183);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(75, 23);
            this.bLogin.TabIndex = 4;
            this.bLogin.Text = "Login";
            this.bLogin.UseVisualStyleBackColor = true;
            // 
            // bSchliessen
            // 
            this.bSchliessen.Location = new System.Drawing.Point(197, 230);
            this.bSchliessen.Name = "bSchliessen";
            this.bSchliessen.Size = new System.Drawing.Size(75, 23);
            this.bSchliessen.TabIndex = 5;
            this.bSchliessen.Text = "Schliessen";
            this.bSchliessen.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 265);
            this.Controls.Add(this.bSchliessen);
            this.Controls.Add(this.bLogin);
            this.Controls.Add(this.lMitarbeiterPasswort);
            this.Controls.Add(this.lMitarbeiterName);
            this.Controls.Add(this.tBPasswort);
            this.Controls.Add(this.tBMitarbeiterName);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBMitarbeiterName;
        private System.Windows.Forms.TextBox tBPasswort;
        private System.Windows.Forms.Label lMitarbeiterName;
        private System.Windows.Forms.Label lMitarbeiterPasswort;
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.Button bSchliessen;
    }
}