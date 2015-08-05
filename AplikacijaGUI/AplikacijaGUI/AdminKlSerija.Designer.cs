namespace AplikacijaGUI
{
    partial class AdminKlSerija
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.klijentserijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDserijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.glumciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.osobljeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pogledanoepizodaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentserijaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.iDserijeDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.glumciDataGridViewTextBoxColumn,
            this.osobljeDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.pogledanoepizodaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.klijentserijaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(462, 250);
            this.dataGridView1.TabIndex = 0;
            // 
            // klijentserijaBindingSource
            // 
            this.klijentserijaBindingSource.DataSource = typeof(AplikacijaGUI.Klijent_serija);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // iDserijeDataGridViewTextBoxColumn
            // 
            this.iDserijeDataGridViewTextBoxColumn.DataPropertyName = "IDserije";
            this.iDserijeDataGridViewTextBoxColumn.HeaderText = "IDserije";
            this.iDserijeDataGridViewTextBoxColumn.Name = "iDserijeDataGridViewTextBoxColumn";
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // glumciDataGridViewTextBoxColumn
            // 
            this.glumciDataGridViewTextBoxColumn.DataPropertyName = "Glumci";
            this.glumciDataGridViewTextBoxColumn.HeaderText = "Glumci";
            this.glumciDataGridViewTextBoxColumn.Name = "glumciDataGridViewTextBoxColumn";
            // 
            // osobljeDataGridViewTextBoxColumn
            // 
            this.osobljeDataGridViewTextBoxColumn.DataPropertyName = "Osoblje";
            this.osobljeDataGridViewTextBoxColumn.HeaderText = "Osoblje";
            this.osobljeDataGridViewTextBoxColumn.Name = "osobljeDataGridViewTextBoxColumn";
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            // 
            // pogledanoepizodaDataGridViewTextBoxColumn
            // 
            this.pogledanoepizodaDataGridViewTextBoxColumn.DataPropertyName = "Pogledano_epizoda";
            this.pogledanoepizodaDataGridViewTextBoxColumn.HeaderText = "Pogledano_epizoda";
            this.pogledanoepizodaDataGridViewTextBoxColumn.Name = "pogledanoepizodaDataGridViewTextBoxColumn";
            // 
            // AdminKlSerija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 262);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminKlSerija";
            this.Text = "AdminKlSerija";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentserijaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDserijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn glumciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn osobljeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pogledanoepizodaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource klijentserijaBindingSource;
    }
}