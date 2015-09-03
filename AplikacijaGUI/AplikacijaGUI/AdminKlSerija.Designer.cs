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
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDserijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.osobljeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pogledanoepizodaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klijentserijaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aplikacijaBaseDataSet = new AplikacijaGUI.AplikacijaBaseDataSet();
            this.klijentserijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.klijent_serijaTableAdapter = new AplikacijaGUI.AplikacijaBaseDataSetTableAdapters.Klijent_serijaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentserijaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplikacijaBaseDataSet)).BeginInit();
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
            this.osobljeDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.pogledanoepizodaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.klijentserijaBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(646, 169);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
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
            // klijentserijaBindingSource1
            // 
            this.klijentserijaBindingSource1.DataMember = "Klijent_serija";
            this.klijentserijaBindingSource1.DataSource = this.aplikacijaBaseDataSet;
            // 
            // aplikacijaBaseDataSet
            // 
            this.aplikacijaBaseDataSet.DataSetName = "AplikacijaBaseDataSet";
            this.aplikacijaBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // klijentserijaBindingSource
            // 
            this.klijentserijaBindingSource.DataSource = typeof(AplikacijaGUI.Klijent_serija);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(399, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Insert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(318, 227);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.button1_Click);
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(237, 227);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(75, 23);
            this.Insert.TabIndex = 4;
            this.Insert.Text = "Update";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.button3_Click);
            // 
            // klijent_serijaTableAdapter
            // 
            this.klijent_serijaTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Unesite sve podatke osim ID. Za glumce i osoblje unesite ID glumca tj. osoblja.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AdminKlSerija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminKlSerija";
            this.Text = "AdminKlSerija";
            this.Load += new System.EventHandler(this.AdminKlSerija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentserijaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplikacijaBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentserijaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource klijentserijaBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Insert;
        private AplikacijaBaseDataSet aplikacijaBaseDataSet;
        private System.Windows.Forms.BindingSource klijentserijaBindingSource1;
        private AplikacijaBaseDataSetTableAdapters.Klijent_serijaTableAdapter klijent_serijaTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDserijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn glumciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn osobljeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pogledanoepizodaDataGridViewTextBoxColumn;
    }
}