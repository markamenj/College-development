using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacijaGUI
{
    public partial class Adminstart : Form
    {
        public Adminstart()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminSerija aserija = new AdminSerija();
            aserija.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Adminglumci aglumci = new Adminglumci();
            aglumci.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Adminosoblje aosoblje = new Adminosoblje();
            aosoblje.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminKlSerija aklserija = new AdminKlSerija();
            aklserija.Show();
        }
    }
}
