﻿using System;
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
    public partial class ModSerija : Form
    {
        public ModSerija()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to save ??",
                                     "Save?",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // If 'Yes', do something here.
            }
            else
            {
                // If 'No', do something here.
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DelForm dform = new DelForm();
            dform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InsertSerija iserija = new InsertSerija();
            iserija.Show();
        }
    }
}
