namespace AplikacijaGUI
{
    partial class AdminPass
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
            this.Password = new System.Windows.Forms.Label();
            this.password1 = new System.Windows.Forms.TextBox();
            this.Cbutton1 = new System.Windows.Forms.Button();
            this.OKbutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(13, 26);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(53, 13);
            this.Password.TabIndex = 0;
            this.Password.Text = "Password";
            this.Password.Click += new System.EventHandler(this.label1_Click);
            // 
            // password1
            // 
            this.password1.Location = new System.Drawing.Point(72, 18);
            this.password1.Name = "password1";
            this.password1.Size = new System.Drawing.Size(343, 20);
            this.password1.TabIndex = 1;
            // 
            // Cbutton1
            // 
            this.Cbutton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cbutton1.Location = new System.Drawing.Point(12, 92);
            this.Cbutton1.Name = "Cbutton1";
            this.Cbutton1.Size = new System.Drawing.Size(75, 23);
            this.Cbutton1.TabIndex = 2;
            this.Cbutton1.Text = "Cancel";
            this.Cbutton1.UseVisualStyleBackColor = true;
            this.Cbutton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OKbutton1
            // 
            this.OKbutton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OKbutton1.Location = new System.Drawing.Point(340, 92);
            this.OKbutton1.Name = "OKbutton1";
            this.OKbutton1.Size = new System.Drawing.Size(75, 23);
            this.OKbutton1.TabIndex = 3;
            this.OKbutton1.Text = "OK";
            this.OKbutton1.UseVisualStyleBackColor = true;
            this.OKbutton1.Click += new System.EventHandler(this.OKbutton1_Click);
            // 
            // AdminPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 127);
            this.Controls.Add(this.OKbutton1);
            this.Controls.Add(this.Cbutton1);
            this.Controls.Add(this.password1);
            this.Controls.Add(this.Password);
            this.Name = "AdminPass";
            this.Text = "AdminPass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox password1;
        private System.Windows.Forms.Button Cbutton1;
        private System.Windows.Forms.Button OKbutton1;
    }
}