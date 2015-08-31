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
    public partial class Klijentserija : Form
    {
        public Klijentserija()
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
                InsertSerija();
                // If 'Yes', do something here.
            }
            else
            {
                // If 'No', do something here.
            }
        }
        private void InsertSerija()
        {
            DataClasses1DataContext linqklserija = new DataClasses1DataContext(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AplikacijaBase.mdf;Integrated Security=True;Connect Timeout=30");


            int rowindex = dataGridView1.CurrentRow.Index; // here rowindex will get through currentrow property of datagridview.
            Serija KS1 = new Serija();
            KS1.ID = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[0].Value);
            KS1.Ime = Convert.ToString(dataGridView1.Rows[rowindex].Cells[1].Value);
            KS1.Glumci = Convert.ToString(dataGridView1.Rows[rowindex].Cells[2].Value);
            KS1.Osoblje = Convert.ToString(dataGridView1.Rows[rowindex].Cells[3].Value);
            KS1.Opis = Convert.ToString(dataGridView1.Rows[rowindex].Cells[4].Value);
            linqklserija.Serijas.InsertOnSubmit(KS1);
            linqklserija.SubmitChanges();
            MessageBox.Show("Spremljeno");
            rowindex = 0;
        }

        private void Klijentserija_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aplikacijaBaseDataSet.Serija' table. You can move, or remove it, as needed.
            this.serijaTableAdapter.Fill(this.aplikacijaBaseDataSet.Serija);

        }
    }
}
