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
    public partial class Klijentstart : Form
    {
        public Klijentstart()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                        Klijentserijaklijent klisserkli = new Klijentserijaklijent();
                        klisserkli.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Klijentserija klisse = new Klijentserija();
            klisse.Show();
        }
    }
}
