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
            AdminPass apass = new AdminPass();
            apass.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModLogin mlog = new ModLogin();
            mlog.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Klijentstart klistart = new Klijentstart();
            klistart.Show();
        }
    }
}
