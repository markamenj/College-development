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
    public partial class Glumciklijent : Form
    {
        public Glumciklijent()
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
                saveglumac();

                // If 'Yes', do something here.
            }
            else
            {
                // If 'No', do something here.
            }

        }
        private void saveglumac()
        {
            DataClasses1DataContext linqglu = new DataClasses1DataContext(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AplikacijaBase.mdf;Integrated Security=True;Connect Timeout=30");
            int rowindex = dataGridView1.CurrentRow.Index; // here rowindex will get through currentrow property of datagridview.
            Glumci GI1 = new Glumci();
            GI1.ID = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[0].Value);
            GI1.ime = Convert.ToString(dataGridView1.Rows[rowindex].Cells[1].Value);
            GI1.prezime = Convert.ToString(dataGridView1.Rows[rowindex].Cells[2].Value);
            linqglu.Glumcis.InsertOnSubmit(GI1);
            linqglu.SubmitChanges();
            MessageBox.Show("Spremljeno");
            rowindex = 0;
        }


        private void Glumciklijent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aplikacijaBaseDataSet.Glumci' table. You can move, or remove it, as needed.
            this.glumciTableAdapter.Fill(this.aplikacijaBaseDataSet.Glumci);

        }
    }
}
