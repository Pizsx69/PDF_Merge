namespace PDF_Merge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Tallozas = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Merge = new System.Windows.Forms.Button();
            this.le = new System.Windows.Forms.Button();
            this.fel = new System.Windows.Forms.Button();
            this.pizsx69 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.outfilename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Tallozas
            // 
            this.Tallozas.Location = new System.Drawing.Point(16, 215);
            this.Tallozas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tallozas.Name = "Tallozas";
            this.Tallozas.Size = new System.Drawing.Size(228, 33);
            this.Tallozas.TabIndex = 0;
            this.Tallozas.Text = "Tallózás";
            this.Tallozas.UseVisualStyleBackColor = true;
            this.Tallozas.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(16, 14);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(467, 164);
            this.listBox1.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Merge
            // 
            this.Merge.Location = new System.Drawing.Point(255, 215);
            this.Merge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Merge.Name = "Merge";
            this.Merge.Size = new System.Drawing.Size(228, 33);
            this.Merge.TabIndex = 3;
            this.Merge.Text = "Egyesítés";
            this.Merge.UseVisualStyleBackColor = true;
            this.Merge.Click += new System.EventHandler(this.button2_Click);
            // 
            // le
            // 
            this.le.Location = new System.Drawing.Point(492, 106);
            this.le.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.le.Name = "le";
            this.le.Size = new System.Drawing.Size(67, 28);
            this.le.TabIndex = 4;
            this.le.Text = "button3";
            this.le.UseVisualStyleBackColor = true;
            this.le.Click += new System.EventHandler(this.button3_Click);
            // 
            // fel
            // 
            this.fel.Location = new System.Drawing.Point(492, 52);
            this.fel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fel.Name = "fel";
            this.fel.Size = new System.Drawing.Size(67, 28);
            this.fel.TabIndex = 5;
            this.fel.Text = "button4";
            this.fel.UseVisualStyleBackColor = true;
            this.fel.Click += new System.EventHandler(this.fel_Click);
            // 
            // pizsx69
            // 
            this.pizsx69.AutoSize = true;
            this.pizsx69.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pizsx69.ForeColor = System.Drawing.Color.Gainsboro;
            this.pizsx69.Location = new System.Drawing.Point(497, 11);
            this.pizsx69.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pizsx69.Name = "pizsx69";
            this.pizsx69.Size = new System.Drawing.Size(56, 16);
            this.pizsx69.TabIndex = 6;
            this.pizsx69.Text = "Pizs\\x69";
            this.pizsx69.Click += new System.EventHandler(this.pizsx69_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(491, 215);
            this.clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(67, 33);
            this.clear.TabIndex = 7;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // outfilename
            // 
            this.outfilename.Location = new System.Drawing.Point(99, 183);
            this.outfilename.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outfilename.Name = "outfilename";
            this.outfilename.Size = new System.Drawing.Size(324, 22);
            this.outfilename.TabIndex = 8;
            this.outfilename.Text = "Outputfile";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 187);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fájl neve: ";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(432, 183);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(51, 22);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = ".pdf";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 257);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outfilename);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.le);
            this.Controls.Add(this.pizsx69);
            this.Controls.Add(this.fel);
            this.Controls.Add(this.Merge);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Tallozas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "PDF Egyesítés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Tallozas;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Merge;
        private System.Windows.Forms.Button le;
        private System.Windows.Forms.Button fel;
        private System.Windows.Forms.Label pizsx69;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox outfilename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

