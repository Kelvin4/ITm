using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _ITmaintance
{
    public partial class ElektrogeraetBenutzeroberfläche : Form
    {
        public ElektrogeraetBenutzeroberfläche()
        {
            InitializeComponent();
        }

        private void tBElektrogerätBesitzer_TextChanged(object sender, EventArgs e)
        {

        }

        private void bElektrogeraetBenutzeroberflaecheAbbrechen_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
