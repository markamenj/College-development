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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                AdminPass apass = new AdminPass();
                apass.Show();
            }
            catch (InvalidCastException e1)
            {
                Console.WriteLine("Exception,cannot load admin password", e1);
                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ModLogin mlog = new ModLogin();
                mlog.Show();
            }
            catch (InvalidCastException e1)
            {
                Console.WriteLine("Exception,cannot load mod password", e1);
                throw;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Klijentstart klistart = new Klijentstart();
                klistart.Show();
            }
            catch (InvalidCastException e1)
            {
                Console.WriteLine("Exception,cannot load client UI", e1);
                throw;
            }
        }
    }
}
