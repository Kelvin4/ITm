using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace _ITmaintenance
{
    public partial class LoginDatenAendern : Form
    {

        private Benutzer benutzer;
        /// <summary>
        /// SQL - Verbindung
        /// </summary>
        private SQLiteConnection connection;
        private string dataSource;

        /// <summary>
        /// SQL - Commando
        /// </summary>
        private SQLiteCommand command;

        /// <summary>
        /// 
        /// </summary>
        private SQLiteDataReader reader;

        private Aendern_SQL_Adapter adapter;
        public LoginDatenAendern()
        {
            InitializeComponent();
            this.benutzer = Benutzer.getInstance();
            this.dataSource = "Mitarbeiter.sqlite";
            this.connection = new SQLiteConnection();
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

        private void bAenderungenAusführen_Click(object sender, EventArgs e)
        {
            if(this.tBAltesPasswort.Text.Equals(benutzer.Password) && this.tBNeuesPasswort.Text.Equals(this.tBPasswortBestaetigen.Text))
            {
                this.adapter = new Aendern_SQL_Adapter(benutzer.Name, benutzer.Password, tBNeuesPasswort.Text.ToCharArray());
            }
        }
    }
}
