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
            try
            {
                Klijentserijaklijent klisserkli = new Klijentserijaklijent();
                klisserkli.Show();
            }
            catch (InvalidCastException e1)
            {
                Console.WriteLine("Exception,cannot load form", e1);
                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Klijentserija klisse = new Klijentserija();
                klisse.Show();
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
                Glumciklijent glukli = new Glumciklijent();
                glukli.Show();
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
                Klijentosoblje klios = new Klijentosoblje();
                klios.Show();
            }
            catch (InvalidCastException e1)
            {
                Console.WriteLine("Exception,cannot load form", e1);
                throw;
            }
        }
    }
}
