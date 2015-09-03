namespace AplikacijaGUI
{
    partial class Klijentserija
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
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.glumciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.osobljeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serijaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aplikacijaBaseDataSet = new AplikacijaGUI.AplikacijaBaseDataSet();
            this.serijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Insert = new System.Windows.Forms.Button();
            this.serijaTableAdapter = new AplikacijaGUI.AplikacijaBaseDataSetTableAdapters.SerijaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serijaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplikacijaBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serijaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.glumciDataGridViewTextBoxColumn,
            this.osobljeDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.serijaBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(1, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
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
            // serijaBindingSource1
            // 
            this.serijaBindingSource1.DataMember = "Serija";
            this.serijaBindingSource1.DataSource = this.aplikacijaBaseDataSet;
            // 
            // aplikacijaBaseDataSet
            // 
            this.aplikacijaBaseDataSet.DataSetName = "AplikacijaBaseDataSet";
            this.aplikacijaBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serijaBindingSource
            // 
            this.serijaBindingSource.DataSource = typeof(AplikacijaGUI.Serija);
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(469, 181);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(75, 23);
            this.Insert.TabIndex = 1;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.button1_Click);
            // 
            // serijaTableAdapter
            // 
            this.serijaTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Unesite sve podatke osim ID. Za glumce i osoblje unesite ID glumca tj. osoblja.";
            // 
            // Klijentserija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 217);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Klijentserija";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Klijentserija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serijaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplikacijaBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serijaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn glumciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn osobljeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource serijaBindingSource;
        private System.Windows.Forms.Button Insert;
        private AplikacijaBaseDataSet aplikacijaBaseDataSet;
        private System.Windows.Forms.BindingSource serijaBindingSource1;
        private AplikacijaBaseDataSetTableAdapters.SerijaTableAdapter serijaTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}