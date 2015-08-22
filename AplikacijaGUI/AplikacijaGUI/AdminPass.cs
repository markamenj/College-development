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
    public partial class AdminPass : Form
    {
        public AdminPass()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void OKbutton1_Click(object sender, EventArgs e)
        {
            if(password1.Text=="admin")
            {
                Adminstart astart = new Adminstart();
                astart.Show();
            }
            else
            {
                password1.Clear();
                MessageBox.Show("Are you trying to brute force me :(");
                password1.Focus();
            }
        }
    }
}
