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
    
    public partial class Adminglumci : Form
    {
        public Adminglumci()
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
            //GI1.ID = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[0].Value);
            GI1.ime = Convert.ToString(dataGridView1.Rows[rowindex].Cells[1].Value);
            GI1.prezime = Convert.ToString(dataGridView1.Rows[rowindex].Cells[2].Value);
            linqglu.Glumcis.InsertOnSubmit(GI1);
            linqglu.SubmitChanges();
            MessageBox.Show("Saved");
            rowindex = 0;
        }
        private void delglumac()
        {
            DataClasses1DataContext linqglu = new DataClasses1DataContext(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AplikacijaBase.mdf;Integrated Security=True;Connect Timeout=30");
            int rowindex = dataGridView1.CurrentRow.Index; // here rowindex will get through currentrow property of datagridview.
            Glumci GI2 = new Glumci();
            int iid = 0;
            iid = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[0].Value);
            var delete = from p in linqglu.Glumcis
                         where p.ID == iid// match the ecords.
                         select p;
            linqglu.Glumcis.DeleteAllOnSubmit(delete);// DeleteAllOnSubmit function will call and queries will automatic call thats the data context class handle it.
            linqglu.SubmitChanges();
            // SI = SDCD1.StudentInfos.Single(c => c.Id == iid);
            rowindex = 0;
            MessageBox.Show("deleted");
            Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete ??",
                                     "delete?",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                delglumac();

                // If 'Yes', do something here.
            }
            else
            {
                // If 'No', do something here.
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to update ??",
                                     "update?",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                updateglumci();

                // If 'Yes', do something here.
            }
            else
            {
                // If 'No', do something here.
            }
        }
        public void updateglumci()
        {
            int iid = 0;
            DataClasses1DataContext linqglu = new DataClasses1DataContext(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AplikacijaBase.mdf;Integrated Security=True;Connect Timeout=30");
            Glumci SI = new Glumci();
            int rowindex = dataGridView1.CurrentRow.Index; // here rowindex will get through currentrow property of datagridview.
            iid = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[0].Value);
            var update = from s1 in linqglu.Glumcis
                         where s1.ID == iid
                         select s1;
            foreach (var v in update)
            {
                v.ID = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[0].Value);
                v.ime = Convert.ToString(dataGridView1.Rows[rowindex].Cells[1].Value);
                v.prezime = Convert.ToString(dataGridView1.Rows[rowindex].Cells[2].Value);
                linqglu.SubmitChanges(); // here will submitchanges function call and queries will automatic call.
            }
            MessageBox.Show("Updated");
            Refresh();// refresh the data gridview.
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Adminglumci_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aplikacijaBaseDataSet.Glumci' table. You can move, or remove it, as needed.
            this.glumciTableAdapter.Fill(this.aplikacijaBaseDataSet.Glumci);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
