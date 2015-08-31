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
            try
            {
                ModSerija modse = new ModSerija();
                modse.Show();
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
                Modosoblje modos = new Modosoblje();
                modos.Show();
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
                MOdglumci modgl = new MOdglumci();
                modgl.Show();
            }
            catch (InvalidCastException e1)
            {
                Console.WriteLine("Exception,cannot load form", e1);
                throw;
            }
        }
    }
}
