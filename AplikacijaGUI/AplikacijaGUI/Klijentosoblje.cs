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
    public partial class Klijentosoblje : Form
    {
        public Klijentosoblje()
        {
            InitializeComponent();
        }

        private void Klijentosoblje_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aplikacijaBaseDataSet.Osoblje' table. You can move, or remove it, as needed.
            this.osobljeTableAdapter.Fill(this.aplikacijaBaseDataSet.Osoblje);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to save ??",
                                     "Save?",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                InsertOsoblje();
                // If 'Yes', do something here.
            }
            else
            {
                // If 'No', do something here.
            }
        }
        private void InsertOsoblje()
        {
            DataClasses1DataContext linqklserija = new DataClasses1DataContext(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AplikacijaBase.mdf;Integrated Security=True;Connect Timeout=30");


            int rowindex = dataGridView1.CurrentRow.Index; // here rowindex will get through currentrow property of datagridview.
            Osoblje KS1 = new Osoblje();
            KS1.ID = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[0].Value);
            KS1.Ime = Convert.ToString(dataGridView1.Rows[rowindex].Cells[1].Value);
            KS1.Prezime = Convert.ToString(dataGridView1.Rows[rowindex].Cells[2].Value);
            KS1.Tvrtka = Convert.ToString(dataGridView1.Rows[rowindex].Cells[3].Value);
            linqklserija.Osobljes.InsertOnSubmit(KS1);
            linqklserija.SubmitChanges();
            MessageBox.Show("Spremljeno");
            rowindex = 0;
        }
    }
}
