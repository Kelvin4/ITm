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

        private Login_SQL_Adapter adapter;
        private char[] passwort = new char[15];

        public Hauptmenu()
        {
            InitializeComponent();
            passwort =  "Kelvin".ToCharArray();
            this.adapter = new Login_SQL_Adapter("Kelvin Sopnan", this.passwort);
        }

        private void Hauptmenu_Load(object sender, EventArgs e)
        {

        }
    }
}
