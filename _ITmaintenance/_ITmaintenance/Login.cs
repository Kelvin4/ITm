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

            this.name = this.tBBenutzernameLogin.Text;
            this.password = this.tBPasswortLogin.Text.ToCharArray();
            this.adapter = new Login_SQL_Adapter(name, password);
        }

        private void bAbbrechenLogin_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
