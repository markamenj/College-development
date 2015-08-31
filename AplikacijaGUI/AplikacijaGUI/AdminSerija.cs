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
    public partial class AdminSerija : Form
    {
        public AdminSerija()
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

        private void button2_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to save ??",
                                     "Save?",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                delSerija();
                // If 'Yes', do something here.
            }
            else
            {
                // If 'No', do something here.
            }
        }
        private void delSerija()
        {
            DataClasses1DataContext linqglu = new DataClasses1DataContext(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AplikacijaBase.mdf;Integrated Security=True;Connect Timeout=30");
            int rowindex = dataGridView1.CurrentRow.Index; // here rowindex will get through currentrow property of datagridview.
            Serija GI2 = new Serija();
            int iid = 0;
            iid = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[0].Value);
            var delete = from p in linqglu.Serijas
                         where p.ID == iid// match the ecords.
                         select p;
            linqglu.Serijas.DeleteAllOnSubmit(delete);// DeleteAllOnSubmit function will call and queries will automatic call thats the data context class handle it.
            linqglu.SubmitChanges();
            // SI = SDCD1.StudentInfos.Single(c => c.Id == iid);
            rowindex = 0;
            MessageBox.Show("deleted");
            Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to save ??",
                                     "Save?",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                updateserija();
                // If 'Yes', do something here.
            }
            else
            {
                // If 'No', do something here.
            }
        }
        public void updateserija()
        {
            int iid = 0;
            DataClasses1DataContext linqglu = new DataClasses1DataContext(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AplikacijaBase.mdf;Integrated Security=True;Connect Timeout=30");
            Serija SI = new Serija();
            int rowindex = dataGridView1.CurrentRow.Index; // here rowindex will get through currentrow property of datagridview.
            iid = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[0].Value);
            var update = from s1 in linqglu.Serijas
                         where s1.ID == iid
                         select s1;
            foreach (var v in update)
            {
                v.ID = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[0].Value);
                v.Ime = Convert.ToString(dataGridView1.Rows[rowindex].Cells[1].Value);
                v.Glumci = Convert.ToString(dataGridView1.Rows[rowindex].Cells[2].Value);
                v.Osoblje = Convert.ToString(dataGridView1.Rows[rowindex].Cells[3].Value);
                v.Opis = Convert.ToString(dataGridView1.Rows[rowindex].Cells[4].Value);
                linqglu.SubmitChanges(); // here will submitchanges function call and queries will automatic call.
            }
            MessageBox.Show("Updated");
            Refresh();// refresh the data gridview.
        }

        private void AdminSerija_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aplikacijaBaseDataSet.Serija' table. You can move, or remove it, as needed.
            this.serijaTableAdapter.Fill(this.aplikacijaBaseDataSet.Serija);

        }

    }
}
