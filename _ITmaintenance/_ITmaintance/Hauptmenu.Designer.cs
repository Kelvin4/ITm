namespace _ITmaintenance
{
    partial class Hauptmenu
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
            this.bNeuesGeraet = new System.Windows.Forms.Button();
            this.bDatenverwaltung = new System.Windows.Forms.Button();
            this.bNeuerMitarbeiter = new System.Windows.Forms.Button();
            this.bMitarbeiterDatenAender = new System.Windows.Forms.Button();
            this.lMenu = new System.Windows.Forms.Label();
            this.bSchliessen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bNeuesGeraet
            // 
            this.bNeuesGeraet.Location = new System.Drawing.Point(73, 51);
            this.bNeuesGeraet.Name = "bNeuesGeraet";
            this.bNeuesGeraet.Size = new System.Drawing.Size(164, 23);
            this.bNeuesGeraet.TabIndex = 1;
            this.bNeuesGeraet.Text = "neues geraet";
            this.bNeuesGeraet.UseVisualStyleBackColor = true;
            // 
            // bDatenverwaltung
            // 
            this.bDatenverwaltung.Location = new System.Drawing.Point(73, 80);
            this.bDatenverwaltung.Name = "bDatenverwaltung";
            this.bDatenverwaltung.Size = new System.Drawing.Size(164, 23);
            this.bDatenverwaltung.TabIndex = 2;
            this.bDatenverwaltung.Text = "Datenverwaltung";
            this.bDatenverwaltung.UseVisualStyleBackColor = true;
            // 
            // bNeuerMitarbeiter
            // 
            this.bNeuerMitarbeiter.Location = new System.Drawing.Point(73, 109);
            this.bNeuerMitarbeiter.Name = "bNeuerMitarbeiter";
            this.bNeuerMitarbeiter.Size = new System.Drawing.Size(164, 23);
            this.bNeuerMitarbeiter.TabIndex = 3;
            this.bNeuerMitarbeiter.Text = "Neuer Mitarbeiter";
            this.bNeuerMitarbeiter.UseVisualStyleBackColor = true;
            // 
            // bMitarbeiterDatenAender
            // 
            this.bMitarbeiterDatenAender.Location = new System.Drawing.Point(73, 138);
            this.bMitarbeiterDatenAender.Name = "bMitarbeiterDatenAender";
            this.bMitarbeiterDatenAender.Size = new System.Drawing.Size(164, 23);
            this.bMitarbeiterDatenAender.TabIndex = 4;
            this.bMitarbeiterDatenAender.Text = "Mitarbeiter Daten aendern";
            this.bMitarbeiterDatenAender.UseVisualStyleBackColor = true;
            // 
            // lMenu
            // 
            this.lMenu.AutoSize = true;
            this.lMenu.Location = new System.Drawing.Point(124, 9);
            this.lMenu.Name = "lMenu";
            this.lMenu.Size = new System.Drawing.Size(34, 13);
            this.lMenu.TabIndex = 5;
            this.lMenu.Text = "Menu";
            // 
            // bSchliessen
            // 
            this.bSchliessen.Location = new System.Drawing.Point(73, 167);
            this.bSchliessen.Name = "bSchliessen";
            this.bSchliessen.Size = new System.Drawing.Size(164, 23);
            this.bSchliessen.TabIndex = 6;
            this.bSchliessen.Text = "Schliessen";
            this.bSchliessen.UseVisualStyleBackColor = true;
            // 
            // Hauptmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 265);
            this.Controls.Add(this.bSchliessen);
            this.Controls.Add(this.lMenu);
            this.Controls.Add(this.bMitarbeiterDatenAender);
            this.Controls.Add(this.bNeuerMitarbeiter);
            this.Controls.Add(this.bDatenverwaltung);
            this.Controls.Add(this.bNeuesGeraet);
            this.Name = "Hauptmenu";
            this.Text = "Hauptmenu";
            this.Load += new System.EventHandler(this.Hauptmenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bNeuesGeraet;
        private System.Windows.Forms.Button bDatenverwaltung;
        private System.Windows.Forms.Button bNeuerMitarbeiter;
        private System.Windows.Forms.Button bMitarbeiterDatenAender;
        private System.Windows.Forms.Label lMenu;
        private System.Windows.Forms.Button bSchliessen;
    }
}