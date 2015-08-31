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
    public partial class Modosoblje : Form
    {
        public Modosoblje()
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

        private void button2_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to save ??",
                                    "Save?",
                                    MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                delosoblje();

                // If 'Yes', do something here.
            }
            else
            {
                // If 'No', do something here.
            }
        }
        private void delosoblje()
        {
            DataClasses1DataContext linqglu = new DataClasses1DataContext(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AplikacijaBase.mdf;Integrated Security=True;Connect Timeout=30");
            int rowindex = dataGridView1.CurrentRow.Index; // here rowindex will get through currentrow property of datagridview.
            Osoblje GI2 = new Osoblje();
            int iid = 0;
            iid = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[0].Value);
            var delete = from p in linqglu.Osobljes
                         where p.ID == iid// match the ecords.
                         select p;
            linqglu.Osobljes.DeleteAllOnSubmit(delete);// DeleteAllOnSubmit function will call and queries will automatic call thats the data context class handle it.
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
                updateosoblje();

                // If 'Yes', do something here.
            }
            else
            {
                // If 'No', do something here.
            }
        }
        public void updateosoblje()
        {
            int iid = 0;
            DataClasses1DataContext linqglu = new DataClasses1DataContext(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AplikacijaBase.mdf;Integrated Security=True;Connect Timeout=30");
            Osoblje SI = new Osoblje();
            int rowindex = dataGridView1.CurrentRow.Index; // here rowindex will get through currentrow property of datagridview.
            iid = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[0].Value);
            var update = from s1 in linqglu.Osobljes
                         where s1.ID == iid
                         select s1;
            foreach (var v in update)
            {
                v.ID = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[0].Value);
                v.Ime = Convert.ToString(dataGridView1.Rows[rowindex].Cells[1].Value);
                v.Prezime = Convert.ToString(dataGridView1.Rows[rowindex].Cells[2].Value);
                v.Tvrtka = Convert.ToString(dataGridView1.Rows[rowindex].Cells[3].Value);
                linqglu.SubmitChanges(); // here will submitchanges function call and queries will automatic call.
            }
            MessageBox.Show("Updated");
            Refresh();// refresh the data gridview.
        }

        private void Modosoblje_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aplikacijaBaseDataSet.Osoblje' table. You can move, or remove it, as needed.
            this.osobljeTableAdapter.Fill(this.aplikacijaBaseDataSet.Osoblje);

        }
    }
}
