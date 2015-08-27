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
    public partial class AdminKlSerija : Form
    {
        public AdminKlSerija()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to save ??",
                                     "Save?",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                saveklserija();
                // If 'Yes', do something here.
            }
            else
            {
                // If 'No', do something here.
            }
        }
        private void saveklserija()
        {
            DataClasses1DataContext linqklserija = new DataClasses1DataContext(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AplikacijaBase.mdf;Integrated Security=True;Connect Timeout=30");


            int rowindex = dataGridView1.CurrentRow.Index; // here rowindex will get through currentrow property of datagridview.
            Klijent_serija KS1 = new Klijent_serija();
            KS1.ID = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[0].Value);
            KS1.IDserije = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[1].Value);
            KS1.Ime = Convert.ToString(dataGridView1.Rows[rowindex].Cells[2].Value);
            KS1.Glumci = Convert.ToString(dataGridView1.Rows[rowindex].Cells[3].Value);
            KS1.Osoblje = Convert.ToString(dataGridView1.Rows[rowindex].Cells[4].Value);
            KS1.Opis = Convert.ToString(dataGridView1.Rows[rowindex].Cells[5].Value);
            KS1.Pogledano_epizoda = Convert.ToString(dataGridView1.Rows[rowindex].Cells[6].Value);
            linqklserija.Klijent_serijas.InsertOnSubmit(KS1);
            linqklserija.SubmitChanges();
            MessageBox.Show("Spremljeno");
            rowindex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DelForm dform = new DelForm();
            dform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InsertGUIKlijentserija iserija = new InsertGUIKlijentserija();
            iserija.Show();
        }
    }
}
