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
    public partial class ModLogin : Form
    {
        public ModLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (password.Text == "admin")
            {
                Modstart astart = new Modstart();
                astart.Show();
            }
            else
            {
                password.Clear();
                MessageBox.Show("Are you trying to brute force me :(");
                password.Focus();
            }
        }
    }
}
