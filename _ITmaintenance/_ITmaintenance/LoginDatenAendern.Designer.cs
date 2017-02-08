namespace _ITmaintenance
{
    partial class LoginDatenAendern
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
            this.lBenutzernameBeiPasswortAendern = new System.Windows.Forms.Label();
            this.lAltesPasswort = new System.Windows.Forms.Label();
            this.lNeuesPasswort = new System.Windows.Forms.Label();
            this.lPasswortBestaetigen = new System.Windows.Forms.Label();
            this.tBAltesPasswort = new System.Windows.Forms.TextBox();
            this.tBNeuesPasswort = new System.Windows.Forms.TextBox();
            this.tBPasswortBestaetigen = new System.Windows.Forms.TextBox();
            this.bAenderungenAusführen = new System.Windows.Forms.Button();
            this.bAenderungenAbbrechen = new System.Windows.Forms.Button();
            this.tBBenutzernameBeiPasswortAendern = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lBenutzernameBeiPasswortAendern
            // 
            this.lBenutzernameBeiPasswortAendern.AutoSize = true;
            this.lBenutzernameBeiPasswortAendern.Location = new System.Drawing.Point(33, 27);
            this.lBenutzernameBeiPasswortAendern.Name = "lBenutzernameBeiPasswortAendern";
            this.lBenutzernameBeiPasswortAendern.Size = new System.Drawing.Size(75, 13);
            this.lBenutzernameBeiPasswortAendern.TabIndex = 0;
            this.lBenutzernameBeiPasswortAendern.Text = "Benutzername";
            this.lBenutzernameBeiPasswortAendern.Click += new System.EventHandler(this.lAktuellerBenutzernameAendern_Click);
            // 
            // lAltesPasswort
            // 
            this.lAltesPasswort.AutoSize = true;
            this.lAltesPasswort.Location = new System.Drawing.Point(33, 76);
            this.lAltesPasswort.Name = "lAltesPasswort";
            this.lAltesPasswort.Size = new System.Drawing.Size(76, 13);
            this.lAltesPasswort.TabIndex = 4;
            this.lAltesPasswort.Text = "Altes Passwort";
            // 
            // lNeuesPasswort
            // 
            this.lNeuesPasswort.AutoSize = true;
            this.lNeuesPasswort.Location = new System.Drawing.Point(36, 121);
            this.lNeuesPasswort.Name = "lNeuesPasswort";
            this.lNeuesPasswort.Size = new System.Drawing.Size(84, 13);
            this.lNeuesPasswort.TabIndex = 5;
            this.lNeuesPasswort.Text = "Neues Passwort";
            // 
            // lPasswortBestaetigen
            // 
            this.lPasswortBestaetigen.AutoSize = true;
            this.lPasswortBestaetigen.Location = new System.Drawing.Point(33, 166);
            this.lPasswortBestaetigen.Name = "lPasswortBestaetigen";
            this.lPasswortBestaetigen.Size = new System.Drawing.Size(103, 13);
            this.lPasswortBestaetigen.TabIndex = 6;
            this.lPasswortBestaetigen.Text = "Passwort Bestätigen";
            // 
            // tBAltesPasswort
            // 
            this.tBAltesPasswort.Location = new System.Drawing.Point(172, 69);
            this.tBAltesPasswort.Name = "tBAltesPasswort";
            this.tBAltesPasswort.Size = new System.Drawing.Size(100, 20);
            this.tBAltesPasswort.TabIndex = 7;
            // 
            // tBNeuesPasswort
            // 
            this.tBNeuesPasswort.Location = new System.Drawing.Point(172, 114);
            this.tBNeuesPasswort.Name = "tBNeuesPasswort";
            this.tBNeuesPasswort.Size = new System.Drawing.Size(100, 20);
            this.tBNeuesPasswort.TabIndex = 8;
            // 
            // tBPasswortBestaetigen
            // 
            this.tBPasswortBestaetigen.Location = new System.Drawing.Point(172, 159);
            this.tBPasswortBestaetigen.Name = "tBPasswortBestaetigen";
            this.tBPasswortBestaetigen.Size = new System.Drawing.Size(100, 20);
            this.tBPasswortBestaetigen.TabIndex = 9;
            // 
            // bAenderungenAusführen
            // 
            this.bAenderungenAusführen.Location = new System.Drawing.Point(91, 198);
            this.bAenderungenAusführen.Name = "bAenderungenAusführen";
            this.bAenderungenAusführen.Size = new System.Drawing.Size(149, 23);
            this.bAenderungenAusführen.TabIndex = 10;
            this.bAenderungenAusführen.Text = "Änderungen ausführen";
            this.bAenderungenAusführen.UseVisualStyleBackColor = true;
            this.bAenderungenAusführen.Click += new System.EventHandler(this.bAenderungenAusführen_Click);
            // 
            // bAenderungenAbbrechen
            // 
            this.bAenderungenAbbrechen.Location = new System.Drawing.Point(120, 240);
            this.bAenderungenAbbrechen.Name = "bAenderungenAbbrechen";
            this.bAenderungenAbbrechen.Size = new System.Drawing.Size(75, 23);
            this.bAenderungenAbbrechen.TabIndex = 11;
            this.bAenderungenAbbrechen.Text = "Abbrechen";
            this.bAenderungenAbbrechen.UseVisualStyleBackColor = true;
            this.bAenderungenAbbrechen.Click += new System.EventHandler(this.bAenderungenAbbrechen_Click);
            // 
            // tBBenutzernameBeiPasswortAendern
            // 
            this.tBBenutzernameBeiPasswortAendern.Location = new System.Drawing.Point(172, 20);
            this.tBBenutzernameBeiPasswortAendern.Name = "tBBenutzernameBeiPasswortAendern";
            this.tBBenutzernameBeiPasswortAendern.Size = new System.Drawing.Size(100, 20);
            this.tBBenutzernameBeiPasswortAendern.TabIndex = 2;
            // 
            // LoginDatenAendern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 265);
            this.Controls.Add(this.bAenderungenAbbrechen);
            this.Controls.Add(this.bAenderungenAusführen);
            this.Controls.Add(this.tBPasswortBestaetigen);
            this.Controls.Add(this.tBNeuesPasswort);
            this.Controls.Add(this.tBAltesPasswort);
            this.Controls.Add(this.lPasswortBestaetigen);
            this.Controls.Add(this.lNeuesPasswort);
            this.Controls.Add(this.lAltesPasswort);
            this.Controls.Add(this.tBBenutzernameBeiPasswortAendern);
            this.Controls.Add(this.lBenutzernameBeiPasswortAendern);
            this.Name = "LoginDatenAendern";
            this.Text = "LoginDatenAendern";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lBenutzernameBeiPasswortAendern;
        private System.Windows.Forms.Label lAltesPasswort;
        private System.Windows.Forms.Label lNeuesPasswort;
        private System.Windows.Forms.Label lPasswortBestaetigen;
        private System.Windows.Forms.TextBox tBAltesPasswort;
        private System.Windows.Forms.TextBox tBNeuesPasswort;
        private System.Windows.Forms.TextBox tBPasswortBestaetigen;
        private System.Windows.Forms.Button bAenderungenAusführen;
        private System.Windows.Forms.Button bAenderungenAbbrechen;
        private System.Windows.Forms.TextBox tBBenutzernameBeiPasswortAendern;
    }
}