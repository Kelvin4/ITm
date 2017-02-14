namespace _ITmaintance
{
    partial class ElektrogeraetBenutzeroberfläche
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBElektrogerätBesitzer = new System.Windows.Forms.TextBox();
            this.tBGeraetTyp = new System.Windows.Forms.TextBox();
            this.tBGeraetName = new System.Windows.Forms.TextBox();
            this.tBProduktID = new System.Windows.Forms.TextBox();
            this.bWeiterZum1 = new System.Windows.Forms.Button();
            this.bElektrogeraetBenutzeroberflaecheAbbrechen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Besitzer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gerät Typ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gerät Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Produkt ID";
            // 
            // tBElektrogerätBesitzer
            // 
            this.tBElektrogerätBesitzer.Location = new System.Drawing.Point(150, 25);
            this.tBElektrogerätBesitzer.Name = "tBElektrogerätBesitzer";
            this.tBElektrogerätBesitzer.Size = new System.Drawing.Size(100, 20);
            this.tBElektrogerätBesitzer.TabIndex = 4;
            this.tBElektrogerätBesitzer.TextChanged += new System.EventHandler(this.tBElektrogerätBesitzer_TextChanged);
            // 
            // tBGeraetTyp
            // 
            this.tBGeraetTyp.Location = new System.Drawing.Point(150, 69);
            this.tBGeraetTyp.Name = "tBGeraetTyp";
            this.tBGeraetTyp.Size = new System.Drawing.Size(100, 20);
            this.tBGeraetTyp.TabIndex = 5;
            // 
            // tBGeraetName
            // 
            this.tBGeraetName.Location = new System.Drawing.Point(150, 114);
            this.tBGeraetName.Name = "tBGeraetName";
            this.tBGeraetName.Size = new System.Drawing.Size(100, 20);
            this.tBGeraetName.TabIndex = 6;
            // 
            // tBProduktID
            // 
            this.tBProduktID.Location = new System.Drawing.Point(150, 164);
            this.tBProduktID.Name = "tBProduktID";
            this.tBProduktID.Size = new System.Drawing.Size(100, 20);
            this.tBProduktID.TabIndex = 7;
            // 
            // bWeiterZum1
            // 
            this.bWeiterZum1.Location = new System.Drawing.Point(93, 216);
            this.bWeiterZum1.Name = "bWeiterZum1";
            this.bWeiterZum1.Size = new System.Drawing.Size(75, 23);
            this.bWeiterZum1.TabIndex = 8;
            this.bWeiterZum1.Text = "Weiter";
            this.bWeiterZum1.UseVisualStyleBackColor = true;
            // 
            // bElektrogeraetBenutzeroberflaecheAbbrechen
            // 
            this.bElektrogeraetBenutzeroberflaecheAbbrechen.Location = new System.Drawing.Point(206, 243);
            this.bElektrogeraetBenutzeroberflaecheAbbrechen.Name = "bElektrogeraetBenutzeroberflaecheAbbrechen";
            this.bElektrogeraetBenutzeroberflaecheAbbrechen.Size = new System.Drawing.Size(75, 23);
            this.bElektrogeraetBenutzeroberflaecheAbbrechen.TabIndex = 9;
            this.bElektrogeraetBenutzeroberflaecheAbbrechen.Text = "button2";
            this.bElektrogeraetBenutzeroberflaecheAbbrechen.UseVisualStyleBackColor = true;
            this.bElektrogeraetBenutzeroberflaecheAbbrechen.Click += new System.EventHandler(this.bElektrogeraetBenutzeroberflaecheAbbrechen_Click);
            // 
            // ElektrogeraetBenutzeroberfläche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 265);
            this.Controls.Add(this.bElektrogeraetBenutzeroberflaecheAbbrechen);
            this.Controls.Add(this.bWeiterZum1);
            this.Controls.Add(this.tBProduktID);
            this.Controls.Add(this.tBGeraetName);
            this.Controls.Add(this.tBGeraetTyp);
            this.Controls.Add(this.tBElektrogerätBesitzer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ElektrogeraetBenutzeroberfläche";
            this.Text = "Elektrogerät";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBElektrogerätBesitzer;
        private System.Windows.Forms.TextBox tBGeraetTyp;
        private System.Windows.Forms.TextBox tBGeraetName;
        private System.Windows.Forms.TextBox tBProduktID;
        private System.Windows.Forms.Button bWeiterZum1;
        private System.Windows.Forms.Button bElektrogeraetBenutzeroberflaecheAbbrechen;
    }
}