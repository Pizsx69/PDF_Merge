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
            this.SuspendLayout();
            // 
            // Tallozas
            // 
            this.Tallozas.Location = new System.Drawing.Point(12, 151);
            this.Tallozas.Name = "Tallozas";
            this.Tallozas.Size = new System.Drawing.Size(171, 27);
            this.Tallozas.TabIndex = 0;
            this.Tallozas.Text = "Tallózás";
            this.Tallozas.UseVisualStyleBackColor = true;
            this.Tallozas.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 11);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(351, 134);
            this.listBox1.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Merge
            // 
            this.Merge.Location = new System.Drawing.Point(192, 151);
            this.Merge.Name = "Merge";
            this.Merge.Size = new System.Drawing.Size(171, 27);
            this.Merge.TabIndex = 3;
            this.Merge.Text = "Egyesítés";
            this.Merge.UseVisualStyleBackColor = true;
            this.Merge.Click += new System.EventHandler(this.button2_Click);
            // 
            // le
            // 
            this.le.Location = new System.Drawing.Point(369, 86);
            this.le.Name = "le";
            this.le.Size = new System.Drawing.Size(50, 23);
            this.le.TabIndex = 4;
            this.le.Text = "button3";
            this.le.UseVisualStyleBackColor = true;
            this.le.Click += new System.EventHandler(this.button3_Click);
            // 
            // fel
            // 
            this.fel.Location = new System.Drawing.Point(369, 42);
            this.fel.Name = "fel";
            this.fel.Size = new System.Drawing.Size(50, 23);
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
            this.pizsx69.Location = new System.Drawing.Point(371, 9);
            this.pizsx69.Name = "pizsx69";
            this.pizsx69.Size = new System.Drawing.Size(48, 13);
            this.pizsx69.TabIndex = 6;
            this.pizsx69.Text = "Pizs\\x69";
            this.pizsx69.Click += new System.EventHandler(this.pizsx69_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(369, 151);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(50, 23);
            this.clear.TabIndex = 7;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 185);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.le);
            this.Controls.Add(this.pizsx69);
            this.Controls.Add(this.fel);
            this.Controls.Add(this.Merge);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Tallozas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
    }
}

