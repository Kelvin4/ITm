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
    public partial class Login : Form
    {
        private Login_SQL_Adapter adapter;
        private string name;
        private char[] password;

        public Login()
        {
            InitializeComponent();
        }

        private void bAnmelden_Click(object sender, EventArgs e)
        {
            if (this.lBenutzernameLogin.Text != "" && this.tBPasswortLogin.Text != "")
            {
                this.name = this.tBBenutzernameLogin.Text;
                this.password = this.tBPasswortLogin.Text.ToCharArray();
                this.adapter = new Login_SQL_Adapter(name, password);
                if (this.adapter.CheckUser())
                {
                    MessageBox.Show("Willkommen im Programm. Ihre Personalnummer ist ID: " + this.adapter.getPersNr() + ".");
                    this.Hide();
                    Hauptmenu menue = new Hauptmenu();
                    menue.ShowDialog(this);
                }
                else
                {
                    MessageBox.Show("Falscher Name oder falsches Passwort. Bitte versuchen Sie es erneut!");
                }        
            }
            else
            {
                MessageBox.Show("Bitte geben Sie Ihren Namen und Ihr Passwort ein!");
            }
        }

        private void bAbbrechenLogin_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Environment.Exit(0);
        }
    }
}
