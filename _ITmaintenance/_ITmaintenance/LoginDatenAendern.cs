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
    public partial class LoginDatenAendern : Form
    {
        public LoginDatenAendern()
        {
            InitializeComponent();
        }

        private void lAktuellerBenutzernameAendern_Click(object sender, EventArgs e)
        {

        }

        private void bAenderungenAusführen_Click(object sender, EventArgs e)
        {
            Benutzer benutzer = Benutzer.getInstance();
            if(tBNeuesPasswort.Text.Equals(tBPasswortBestaetigen.Text) && !(tBAltesPasswort.Equals(benutzer.Password)))
            {
                MessageBox.Show("Die Passwörter beziehungsweise ihr altes Passwort stimmen nicht überein", "Warnung");
            }
            else
            {

            }
            
        }

        /// <summary>
        /// Login Daten ändern" schließen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bAenderungenAbbrechen_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
            Hauptmenu menu = new Hauptmenu();
            menu.ShowDialog(this);
        }
    }
}
