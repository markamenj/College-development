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
            var confirmResult = MessageBox.Show("Are you sure you want to delete ??",
                                     "delete?",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                delklserija();

                // If 'Yes', do something here.
            }
            else
            {
                // If 'No', do something here.
            }
        }
        private void delklserija()
        {
            DataClasses1DataContext linqglu = new DataClasses1DataContext(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AplikacijaBase.mdf;Integrated Security=True;Connect Timeout=30");
            int rowindex = dataGridView1.CurrentRow.Index; // here rowindex will get through currentrow property of datagridview.
            Klijent_serija GI2 = new Klijent_serija();
            int iid = 0;
            iid = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[0].Value);
            var delete = from p in linqglu.Klijent_serijas
                         where p.ID == iid// match the ecords.
                         select p;
            linqglu.Klijent_serijas.DeleteAllOnSubmit(delete);// DeleteAllOnSubmit function will call and queries will automatic call thats the data context class handle it.
            linqglu.SubmitChanges();
            // SI = SDCD1.StudentInfos.Single(c => c.Id == iid);
            rowindex = 0;
            MessageBox.Show("deleted");
            Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to update ??",
                                     "update?",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                updateklserija();

                // If 'Yes', do something here.
            }
            else
            {
                // If 'No', do something here.
            }
        }
        public void updateklserija()
        {
            int iid = 0;
            DataClasses1DataContext linqglu = new DataClasses1DataContext(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AplikacijaBase.mdf;Integrated Security=True;Connect Timeout=30");
            Klijent_serija SI = new Klijent_serija();
            int rowindex = dataGridView1.CurrentRow.Index; // here rowindex will get through currentrow property of datagridview.
            iid = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[0].Value);
            var update = from s1 in linqglu.Klijent_serijas
                         where s1.ID == iid
                         select s1;
            foreach (var v in update)
            {
                v.ID = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[0].Value);
                v.IDserije = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[1].Value);
                v.Ime = Convert.ToString(dataGridView1.Rows[rowindex].Cells[2].Value);
                v.Glumci = Convert.ToString(dataGridView1.Rows[rowindex].Cells[3].Value);
                v.Osoblje = Convert.ToString(dataGridView1.Rows[rowindex].Cells[4].Value);
                v.Opis = Convert.ToString(dataGridView1.Rows[rowindex].Cells[5].Value);
                v.Pogledano_epizoda = Convert.ToString(dataGridView1.Rows[rowindex].Cells[6].Value);
                linqglu.SubmitChanges(); // here will submitchanges function call and queries will automatic call.
            }
            MessageBox.Show("Updated");
            Refresh();// refresh the data gridview.
        }

        private void AdminKlSerija_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aplikacijaBaseDataSet.Klijent_serija' table. You can move, or remove it, as needed.
            this.klijent_serijaTableAdapter.Fill(this.aplikacijaBaseDataSet.Klijent_serija);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
