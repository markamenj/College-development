namespace AplikacijaGUI
{
    partial class Adminstart
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
            this.Serija = new System.Windows.Forms.Button();
            this.glumci = new System.Windows.Forms.Button();
            this.Osoblje = new System.Windows.Forms.Button();
            this.KlijentSerija = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Serija
            // 
            this.Serija.Location = new System.Drawing.Point(158, 13);
            this.Serija.Name = "Serija";
            this.Serija.Size = new System.Drawing.Size(75, 23);
            this.Serija.TabIndex = 0;
            this.Serija.Text = "Serija";
            this.Serija.UseVisualStyleBackColor = true;
            this.Serija.Click += new System.EventHandler(this.button1_Click);
            // 
            // glumci
            // 
            this.glumci.Location = new System.Drawing.Point(158, 43);
            this.glumci.Name = "glumci";
            this.glumci.Size = new System.Drawing.Size(75, 23);
            this.glumci.TabIndex = 1;
            this.glumci.Text = "Glumci";
            this.glumci.UseVisualStyleBackColor = true;
            this.glumci.Click += new System.EventHandler(this.button2_Click);
            // 
            // Osoblje
            // 
            this.Osoblje.Location = new System.Drawing.Point(158, 73);
            this.Osoblje.Name = "Osoblje";
            this.Osoblje.Size = new System.Drawing.Size(75, 23);
            this.Osoblje.TabIndex = 2;
            this.Osoblje.Text = "Osoblje";
            this.Osoblje.UseVisualStyleBackColor = true;
            this.Osoblje.Click += new System.EventHandler(this.button3_Click);
            // 
            // KlijentSerija
            // 
            this.KlijentSerija.Location = new System.Drawing.Point(158, 103);
            this.KlijentSerija.Name = "KlijentSerija";
            this.KlijentSerija.Size = new System.Drawing.Size(75, 23);
            this.KlijentSerija.TabIndex = 3;
            this.KlijentSerija.Text = "Klijent serija";
            this.KlijentSerija.UseVisualStyleBackColor = true;
            this.KlijentSerija.Click += new System.EventHandler(this.button4_Click);
            // 
            // Adminstart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 151);
            this.Controls.Add(this.KlijentSerija);
            this.Controls.Add(this.Osoblje);
            this.Controls.Add(this.glumci);
            this.Controls.Add(this.Serija);
            this.Name = "Adminstart";
            this.Text = "Adminstart";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Serija;
        private System.Windows.Forms.Button glumci;
        private System.Windows.Forms.Button Osoblje;
        private System.Windows.Forms.Button KlijentSerija;
    }
}