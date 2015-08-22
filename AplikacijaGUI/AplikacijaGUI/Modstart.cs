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
    public partial class Modstart : Form
    {
        public Modstart()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModSerija modse = new ModSerija();
            modse.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modosoblje modos = new Modosoblje();
            modos.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MOdglumci modgl = new MOdglumci();
            modgl.Show();
        }
    }
}
