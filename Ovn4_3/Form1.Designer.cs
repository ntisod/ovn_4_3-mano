namespace Ovn4_3
{
    partial class Form1
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
            this.dlgÖppnaFil = new System.Windows.Forms.OpenFileDialog();
            this.btnÖppnaFil_Click = new System.Windows.Forms.Button();
            this.dlgSparaFil = new System.Windows.Forms.SaveFileDialog();
            this.btnSparaFil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxFörnamn = new System.Windows.Forms.TextBox();
            this.tbxEfternamn = new System.Windows.Forms.TextBox();
            this.tbxepost = new System.Windows.Forms.TextBox();
            this.tbxTelefonnummer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnÖppnaFil_Click
            // 
            this.btnÖppnaFil_Click.Location = new System.Drawing.Point(425, 108);
            this.btnÖppnaFil_Click.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnÖppnaFil_Click.Name = "btnÖppnaFil_Click";
            this.btnÖppnaFil_Click.Size = new System.Drawing.Size(103, 30);
            this.btnÖppnaFil_Click.TabIndex = 0;
            this.btnÖppnaFil_Click.Text = "Öppna ";
            this.btnÖppnaFil_Click.UseVisualStyleBackColor = true;
            this.btnÖppnaFil_Click.Click += new System.EventHandler(this.btnÖppnaFil_Click_Click);
            // 
            // btnSparaFil
            // 
            this.btnSparaFil.Location = new System.Drawing.Point(425, 158);
            this.btnSparaFil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSparaFil.Name = "btnSparaFil";
            this.btnSparaFil.Size = new System.Drawing.Size(103, 26);
            this.btnSparaFil.TabIndex = 1;
            this.btnSparaFil.Text = "Spara som...";
            this.btnSparaFil.UseVisualStyleBackColor = true;
            this.btnSparaFil.Click += new System.EventHandler(this.btnSparaFil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Förnamn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Efternamn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "E-post";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Telefonnummer";
            // 
            // tbxFörnamn
            // 
            this.tbxFörnamn.Location = new System.Drawing.Point(185, 18);
            this.tbxFörnamn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxFörnamn.Name = "tbxFörnamn";
            this.tbxFörnamn.Size = new System.Drawing.Size(218, 22);
            this.tbxFörnamn.TabIndex = 6;
            this.tbxFörnamn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbxEfternamn
            // 
            this.tbxEfternamn.Location = new System.Drawing.Point(185, 64);
            this.tbxEfternamn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxEfternamn.Name = "tbxEfternamn";
            this.tbxEfternamn.Size = new System.Drawing.Size(218, 22);
            this.tbxEfternamn.TabIndex = 7;
            // 
            // tbxepost
            // 
            this.tbxepost.Location = new System.Drawing.Point(185, 105);
            this.tbxepost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxepost.Name = "tbxepost";
            this.tbxepost.Size = new System.Drawing.Size(218, 22);
            this.tbxepost.TabIndex = 8;
            // 
            // tbxTelefonnummer
            // 
            this.tbxTelefonnummer.Location = new System.Drawing.Point(185, 160);
            this.tbxTelefonnummer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxTelefonnummer.Name = "tbxTelefonnummer";
            this.tbxTelefonnummer.Size = new System.Drawing.Size(218, 22);
            this.tbxTelefonnummer.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 211);
            this.Controls.Add(this.tbxTelefonnummer);
            this.Controls.Add(this.tbxepost);
            this.Controls.Add(this.tbxEfternamn);
            this.Controls.Add(this.tbxFörnamn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSparaFil);
            this.Controls.Add(this.btnÖppnaFil_Click);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dlgÖppnaFil;
        private System.Windows.Forms.Button btnÖppnaFil_Click;
        private System.Windows.Forms.SaveFileDialog dlgSparaFil;
        private System.Windows.Forms.Button btnSparaFil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxFörnamn;
        private System.Windows.Forms.TextBox tbxEfternamn;
        private System.Windows.Forms.TextBox tbxepost;
        private System.Windows.Forms.TextBox tbxTelefonnummer;
    }
}

