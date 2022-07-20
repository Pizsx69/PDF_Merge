using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace PDF_Merge
{
    public partial class Form1 : Form
    {
        List<string> pdfs = new List<string>();

        public Form1()
        {
            InitializeComponent();
            le.Text =char.ConvertFromUtf32(8595);
            fel.Text =char.ConvertFromUtf32(8593);
            Merge.Visible = false;
            clear.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "Pdf Files|*.pdf";

            // Allow the user to select multiple images.
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "My Image Browser";

            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {

                

                foreach (String file in openFileDialog1.FileNames)
                {
                    // Create a PictureBox.
                    try
                    {
                        //pdfs.Add(file);
                        listBox1.Items.Add(file);
                    }
                    catch (SecurityException ex)
                    {
                        // The user lacks appropriate permissions to read files, discover paths, etc.
                        MessageBox.Show("Security error. Please contact your administrator for details.\n\n" +
                            "Error message: " + ex.Message + "\n\n" +
                            "Details (send to Support):\n\n" + ex.StackTrace
                        );
                    }
                    catch (Exception ex)
                    {
                        // Could not load the image - probably related to Windows file system permissions.
                        MessageBox.Show("Cannot display the image: " + file.Substring(file.LastIndexOf('\\'))
                            + ". You may not have permission to read the file, or " +
                            "it may be corrupt.\n\nReported error: " + ex.Message);
                    }
                }
                Merge.Visible = true;
                clear.Visible = true;


            }
        }
        public static void MergePDFs(string targetPath, List<string> pdfs)
        {
            using (var targetDoc = new PdfDocument())
            {
                foreach (var pdf in pdfs)
                {
                    using (var pdfDoc = PdfReader.Open(pdf, PdfDocumentOpenMode.Import))
                    {
                        for (var i = 0; i < pdfDoc.PageCount; i++)
                            targetDoc.AddPage(pdfDoc.Pages[i]);
                    }
                }
                targetDoc.Save(targetPath);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MoveItem(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pdfs.Clear();

            foreach (String file in listBox1.Items)
            {
                pdfs.Add(file);
            }
            MergePDFs("Output.pdf", pdfs);

        }

        private void fel_Click(object sender, EventArgs e)
        {
            MoveItem(-1);
        }

        public void MoveItem(int direction)
        {
            if (listBox1.SelectedItem == null || listBox1.SelectedIndex < 0)
                return; 


            int newIndex = listBox1.SelectedIndex + direction;

            if (newIndex < 0 || newIndex >= listBox1.Items.Count)
                return; 

            object selected = listBox1.SelectedItem;


            listBox1.Items.Remove(selected);
            listBox1.Items.Insert(newIndex, selected);
           
            listBox1.SetSelected(newIndex, true);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pizsx69_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Pizsx69");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            pdfs.Clear();
            Merge.Visible = false;
        }
    }
}
