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
            try
            {
                AdminSerija aserija = new AdminSerija();
                aserija.Show();
            }
            catch (InvalidCastException e1)
            {
                Console.WriteLine("Exception,cannot form", e1);
                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Adminglumci aglumci = new Adminglumci();
                aglumci.Show();
            }
            catch (InvalidCastException e1)
            {
                Console.WriteLine("Exception,cannot load form", e1);
                throw;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Adminosoblje aosoblje = new Adminosoblje();
                aosoblje.Show();
            }
            catch (InvalidCastException e1)
            {
                Console.WriteLine("Exception,cannot load form", e1);
                throw;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                AdminKlSerija aklserija = new AdminKlSerija();
                aklserija.Show();
            }
            catch (InvalidCastException e1)
            {
                Console.WriteLine("Exception,cannot load form", e1);
                throw;
            }
        }
    }
}
