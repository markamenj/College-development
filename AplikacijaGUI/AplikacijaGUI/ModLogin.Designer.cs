namespace AplikacijaGUI
{
    partial class ModLogin
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
            this.passwordlabel = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.cbutton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Location = new System.Drawing.Point(13, 13);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(53, 13);
            this.passwordlabel.TabIndex = 0;
            this.passwordlabel.Text = "Password";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(72, 13);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(214, 20);
            this.password.TabIndex = 1;
            // 
            // cbutton
            // 
            this.cbutton.Location = new System.Drawing.Point(16, 39);
            this.cbutton.Name = "cbutton";
            this.cbutton.Size = new System.Drawing.Size(75, 23);
            this.cbutton.TabIndex = 2;
            this.cbutton.Text = "Cancel";
            this.cbutton.UseVisualStyleBackColor = true;
            this.cbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(211, 39);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 3;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ModLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 73);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.cbutton);
            this.Controls.Add(this.password);
            this.Controls.Add(this.passwordlabel);
            this.Name = "ModLogin";
            this.Text = "ModLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button cbutton;
        private System.Windows.Forms.Button OKButton;
    }
}