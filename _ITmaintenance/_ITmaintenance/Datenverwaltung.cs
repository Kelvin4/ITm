using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _ITmaintenance
{
    public partial class Datenverwaltung : Form
    {
        private bool test = false;
        public Datenverwaltung()
        {
            InitializeComponent();
        }

        private void Datenverwaltung_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hauptmenu menue = new Hauptmenu();
            menue.ShowDialog(this);
            this.Dispose();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
