using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _ITmaintenance
{
    public partial class Hauptmenu : Form
    {
        public Hauptmenu()
        {
            InitializeComponent();
        }

        private void bHauptmenuSchliessen_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
            Application.Exit();
        }

        private void bNeuesGeraet_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
            ElektrogeraetBenutzeroberfläche neuesGeraet = new _ITmaintenance.ElektrogeraetBenutzeroberfläche();
            neuesGeraet.ShowDialog();
        }

        private void bMitarbeiterDatenAender_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
            LoginDatenAendern datenAendern = new _ITmaintenance.LoginDatenAendern();
            datenAendern.ShowDialog(this);
        }

        private void Hauptmenu_Load_1(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void bDatenverwaltung_Click(object sender, EventArgs e)
        {
            Datenverwaltung verwaltung = new Datenverwaltung();
            verwaltung.ShowDialog(this);
            this.Dispose();
        }
    }
}
