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
            this.bHauptmenuSchliessen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bNeuesGeraet
            // 
            this.bNeuesGeraet.Location = new System.Drawing.Point(833, 246);
            this.bNeuesGeraet.Name = "bNeuesGeraet";
            this.bNeuesGeraet.Size = new System.Drawing.Size(300, 100);
            this.bNeuesGeraet.TabIndex = 1;
            this.bNeuesGeraet.Text = "neues geraet";
            this.bNeuesGeraet.UseVisualStyleBackColor = true;
            this.bNeuesGeraet.Click += new System.EventHandler(this.bNeuesGeraet_Click);
            // 
            // bDatenverwaltung
            // 
            this.bDatenverwaltung.Location = new System.Drawing.Point(833, 366);
            this.bDatenverwaltung.Name = "bDatenverwaltung";
            this.bDatenverwaltung.Size = new System.Drawing.Size(300, 100);
            this.bDatenverwaltung.TabIndex = 2;
            this.bDatenverwaltung.Text = "Datenverwaltung";
            this.bDatenverwaltung.UseVisualStyleBackColor = true;
            this.bDatenverwaltung.Click += new System.EventHandler(this.bDatenverwaltung_Click);
            // 
            // bNeuerMitarbeiter
            // 
            this.bNeuerMitarbeiter.Location = new System.Drawing.Point(833, 496);
            this.bNeuerMitarbeiter.Name = "bNeuerMitarbeiter";
            this.bNeuerMitarbeiter.Size = new System.Drawing.Size(300, 100);
            this.bNeuerMitarbeiter.TabIndex = 3;
            this.bNeuerMitarbeiter.Text = "Neuer Mitarbeiter";
            this.bNeuerMitarbeiter.UseVisualStyleBackColor = true;
            // 
            // bMitarbeiterDatenAender
            // 
            this.bMitarbeiterDatenAender.Location = new System.Drawing.Point(833, 628);
            this.bMitarbeiterDatenAender.Name = "bMitarbeiterDatenAender";
            this.bMitarbeiterDatenAender.Size = new System.Drawing.Size(300, 100);
            this.bMitarbeiterDatenAender.TabIndex = 4;
            this.bMitarbeiterDatenAender.Text = "Mitarbeiter Daten aendern";
            this.bMitarbeiterDatenAender.UseVisualStyleBackColor = true;
            this.bMitarbeiterDatenAender.Click += new System.EventHandler(this.bMitarbeiterDatenAender_Click);
            // 
            // lMenu
            // 
            this.lMenu.AutoSize = true;
            this.lMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMenu.Location = new System.Drawing.Point(883, 51);
            this.lMenu.Name = "lMenu";
            this.lMenu.Size = new System.Drawing.Size(288, 108);
            this.lMenu.TabIndex = 5;
            this.lMenu.Text = "Menu";
            // 
            // bHauptmenuSchliessen
            // 
            this.bHauptmenuSchliessen.Location = new System.Drawing.Point(1425, 784);
            this.bHauptmenuSchliessen.Name = "bHauptmenuSchliessen";
            this.bHauptmenuSchliessen.Size = new System.Drawing.Size(300, 100);
            this.bHauptmenuSchliessen.TabIndex = 6;
            this.bHauptmenuSchliessen.Text = "Schliessen";
            this.bHauptmenuSchliessen.UseVisualStyleBackColor = true;
            this.bHauptmenuSchliessen.Click += new System.EventHandler(this.bHauptmenuSchliessen_Click);
            // 
            // Hauptmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1768, 917);
            this.Controls.Add(this.bHauptmenuSchliessen);
            this.Controls.Add(this.lMenu);
            this.Controls.Add(this.bMitarbeiterDatenAender);
            this.Controls.Add(this.bNeuerMitarbeiter);
            this.Controls.Add(this.bDatenverwaltung);
            this.Controls.Add(this.bNeuesGeraet);
            this.Name = "Hauptmenu";
            this.Text = "Hauptmenu";
            this.Load += new System.EventHandler(this.Hauptmenu_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bNeuesGeraet;
        private System.Windows.Forms.Button bDatenverwaltung;
        private System.Windows.Forms.Button bNeuerMitarbeiter;
        private System.Windows.Forms.Button bMitarbeiterDatenAender;
        private System.Windows.Forms.Label lMenu;
        private System.Windows.Forms.Button bHauptmenuSchliessen;
    }
}