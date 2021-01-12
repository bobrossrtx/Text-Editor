using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool saved = false;

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saved = true;
            if (CurrentFile == "") saveAsToolStripMenuItem1_Click(sender, e);
            else richTextBox1.SaveFile(CurrentFile, RichTextBoxStreamType.PlainText);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            saved = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (saved == false)
            {
                if (MessageBox.Show("Changes were not saved. Exit?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        string CurrentFile = "";
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                if (((DialogResult.OK == MessageBox.Show("The contents will be lost.", "Continue?", MessageBoxButtons.OKCancel))))
                {
                    richTextBox1.Text = "";
                    CurrentFile = "";
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                if (((DialogResult.OK == MessageBox.Show("The contents will be lost.", "Continue?", MessageBoxButtons.OKCancel))))
                {
                    richTextBox1.Text = "";
                    CurrentFile = "";
                }
            }

            try
            {
                if (DialogResult.OK == openFileDialog.ShowDialog())
                {
                    CurrentFile = openFileDialog.FileName;
                    if (Path.GetExtension(CurrentFile) == ".txt" || Path.GetExtension(CurrentFile) == ".cs" || Path.GetExtension(CurrentFile) == ".doc" || Path.GetExtension(CurrentFile) == ".docx" || Path.GetExtension(CurrentFile) == ".log" || Path.GetExtension(CurrentFile) == ".msg" || Path.GetExtension(CurrentFile) == ".odt" || Path.GetExtension(CurrentFile) == ".pages" || Path.GetExtension(CurrentFile) == ".rtf" || Path.GetExtension(CurrentFile) == ".tex" || Path.GetExtension(CurrentFile) == ".tif" || Path.GetExtension(CurrentFile) == ".tiff" || Path.GetExtension(CurrentFile) == ".wpd" || Path.GetExtension(CurrentFile) == ".wps" || Path.GetExtension(CurrentFile) == ".csv" || Path.GetExtension(CurrentFile) == ".dat" || Path.GetExtension(CurrentFile) == ".ged" || Path.GetExtension(CurrentFile) == ".key" || Path.GetExtension(CurrentFile) == ".keychain" || Path.GetExtension(CurrentFile) == ".pps" || Path.GetExtension(CurrentFile) == ".ppt" || Path.GetExtension(CurrentFile) == ".pptx" || Path.GetExtension(CurrentFile) == ".sdf" || Path.GetExtension(CurrentFile) == ".tar" || Path.GetExtension(CurrentFile) == ".tax2016" || Path.GetExtension(CurrentFile) == ".tax2019" || Path.GetExtension(CurrentFile) == ".vcf" || Path.GetExtension(CurrentFile) == ".xml" || Path.GetExtension(CurrentFile) == ".ai" || Path.GetExtension(CurrentFile) == ".eps" || Path.GetExtension(CurrentFile) == ".svg" || Path.GetExtension(CurrentFile) == ".indd" || Path.GetExtension(CurrentFile) == ".pct" || Path.GetExtension(CurrentFile) == ".pdf" || Path.GetExtension(CurrentFile) == ".xlr" || Path.GetExtension(CurrentFile) == ".xls" || Path.GetExtension(CurrentFile) == ".xlsx" || Path.GetExtension(CurrentFile) == ".accdb" || Path.GetExtension(CurrentFile) == ".db" || Path.GetExtension(CurrentFile) == ".dbf" || Path.GetExtension(CurrentFile) == ".mdb" || Path.GetExtension(CurrentFile) == ".pdb" || Path.GetExtension(CurrentFile) == ".sql" || Path.GetExtension(CurrentFile) == ".asp" || Path.GetExtension(CurrentFile) == ".aspx" || Path.GetExtension(CurrentFile) == ".cer" || Path.GetExtension(CurrentFile) == ".cfm" || Path.GetExtension(CurrentFile) == ".crdownload" || Path.GetExtension(CurrentFile) == ".csr" || Path.GetExtension(CurrentFile) == ".css" || Path.GetExtension(CurrentFile) == ".dcr" || Path.GetExtension(CurrentFile) == ".htm" || Path.GetExtension(CurrentFile) == ".html" || Path.GetExtension(CurrentFile) == ".js" || Path.GetExtension(CurrentFile) == ".jsp" || Path.GetExtension(CurrentFile) == ".php" || Path.GetExtension(CurrentFile) == ".rss" || Path.GetExtension(CurrentFile) == ".xhtml" || Path.GetExtension(CurrentFile) == ".ts" || Path.GetExtension(CurrentFile) == ".scss" || Path.GetExtension(CurrentFile) == ".sass" || Path.GetExtension(CurrentFile) == ".go" || Path.GetExtension(CurrentFile) == ".http")
                        richTextBox1.LoadFile(CurrentFile, RichTextBoxStreamType.PlainText);
                    else richTextBox1.LoadFile(CurrentFile);
                    this.Text = Path.GetFileName(CurrentFile) + " - Text Editor";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }

        private void saveAsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (CurrentFile == "")
            {
                saveFileDialog.FileName = "Untitled";
            }
            if (DialogResult.OK == saveFileDialog.ShowDialog())
            {
                if (Path.GetExtension(saveFileDialog.FileName) == ".txt" || Path.GetExtension(saveFileDialog.FileName) == ".cs" || Path.GetExtension(saveFileDialog.FileName) == ".doc" || Path.GetExtension(saveFileDialog.FileName) == ".docx" || Path.GetExtension(saveFileDialog.FileName) == ".log" || Path.GetExtension(saveFileDialog.FileName) == ".msg" || Path.GetExtension(saveFileDialog.FileName) == ".odt" || Path.GetExtension(saveFileDialog.FileName) == ".pages" || Path.GetExtension(saveFileDialog.FileName) == ".rtf" || Path.GetExtension(saveFileDialog.FileName) == ".tex" || Path.GetExtension(saveFileDialog.FileName) == ".tif" || Path.GetExtension(saveFileDialog.FileName) == ".tiff" || Path.GetExtension(saveFileDialog.FileName) == ".wpd" || Path.GetExtension(saveFileDialog.FileName) == ".wps" || Path.GetExtension(saveFileDialog.FileName) == ".csv" || Path.GetExtension(saveFileDialog.FileName) == ".dat" || Path.GetExtension(saveFileDialog.FileName) == ".ged" || Path.GetExtension(saveFileDialog.FileName) == ".key" || Path.GetExtension(saveFileDialog.FileName) == ".keychain" || Path.GetExtension(saveFileDialog.FileName) == ".pps" || Path.GetExtension(saveFileDialog.FileName) == ".ppt" || Path.GetExtension(saveFileDialog.FileName) == ".pptx" || Path.GetExtension(saveFileDialog.FileName) == ".sdf" || Path.GetExtension(saveFileDialog.FileName) == ".tar" || Path.GetExtension(saveFileDialog.FileName) == ".tax2016" || Path.GetExtension(saveFileDialog.FileName) == ".tax2019" || Path.GetExtension(saveFileDialog.FileName) == ".vcf" || Path.GetExtension(saveFileDialog.FileName) == ".xml" || Path.GetExtension(saveFileDialog.FileName) == ".ai" || Path.GetExtension(saveFileDialog.FileName) == ".eps" || Path.GetExtension(saveFileDialog.FileName) == ".svg" || Path.GetExtension(saveFileDialog.FileName) == ".indd" || Path.GetExtension(saveFileDialog.FileName) == ".pct" || Path.GetExtension(saveFileDialog.FileName) == ".pdf" || Path.GetExtension(saveFileDialog.FileName) == ".xlr" || Path.GetExtension(saveFileDialog.FileName) == ".xls" || Path.GetExtension(saveFileDialog.FileName) == ".xlsx" || Path.GetExtension(saveFileDialog.FileName) == ".accdb" || Path.GetExtension(saveFileDialog.FileName) == ".db" || Path.GetExtension(saveFileDialog.FileName) == ".dbf" || Path.GetExtension(saveFileDialog.FileName) == ".mdb" || Path.GetExtension(saveFileDialog.FileName) == ".pdb" || Path.GetExtension(saveFileDialog.FileName) == ".sql" || Path.GetExtension(saveFileDialog.FileName) == ".asp" || Path.GetExtension(saveFileDialog.FileName) == ".aspx" || Path.GetExtension(saveFileDialog.FileName) == ".cer" || Path.GetExtension(saveFileDialog.FileName) == ".cfm" || Path.GetExtension(saveFileDialog.FileName) == ".crdownload" || Path.GetExtension(saveFileDialog.FileName) == ".csr" || Path.GetExtension(saveFileDialog.FileName) == ".css" || Path.GetExtension(saveFileDialog.FileName) == ".dcr" || Path.GetExtension(saveFileDialog.FileName) == ".htm" || Path.GetExtension(saveFileDialog.FileName) == ".html" || Path.GetExtension(saveFileDialog.FileName) == ".js" || Path.GetExtension(saveFileDialog.FileName) == ".jsp" || Path.GetExtension(saveFileDialog.FileName) == ".php" || Path.GetExtension(saveFileDialog.FileName) == ".rss" || Path.GetExtension(saveFileDialog.FileName) == ".xhtml" || Path.GetExtension(saveFileDialog.FileName) == ".ts" || Path.GetExtension(saveFileDialog.FileName) == ".scss" || Path.GetExtension(saveFileDialog.FileName) == ".sass" || Path.GetExtension(saveFileDialog.FileName) == ".go" || Path.GetExtension(saveFileDialog.FileName) == ".http")
                {
                    richTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                }
                else richTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
                CurrentFile = saveFileDialog.FileName;
                this.Text = Path.GetFileName(CurrentFile) + " - Text Editor";
            }
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void searchButton_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string[] words = searchBox.Text.Split(',');
            foreach(string word in words )
            {
                int startIndex = 0;
                while(startIndex<richTextBox1.TextLength)
                {
                    int wordStartIndex = richTextBox1.Find(word, startIndex, RichTextBoxFinds.None);
                    if (wordStartIndex != -1)
                    {
                        richTextBox1.SelectionStart = wordStartIndex;
                        richTextBox1.SelectionLength = word.Length;
                        richTextBox1.SelectionBackColor = Color.Yellow;
                    }
                    else
                        break;
                    startIndex += wordStartIndex + word.Length;
                }
            }
        }

        private void clearSearchButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            richTextBox1.SelectionStart = 0;
            richTextBox1.SelectAll();
            richTextBox1.SelectionBackColor = Color.White;
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fd.Font;
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoBack)
                webBrowser.GoBack();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
           

                using(FolderBrowserDialog fbd = new FolderBrowserDialog() { Description="Select your path" })
                {
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        webBrowser.Url = new Uri(fbd.SelectedPath);
                        textPath.Text = fbd.SelectedPath;
                    }
                }
        

//            try
//            {
//                if (DialogResult.OK == openFileDialog.ShowDialog())
//                {
//                    CurrentFile = openFileDialog.FileName;
//                    if (Path.GetExtension(CurrentFile) == ".txt" || Path.GetExtension(CurrentFile) == ".cs" || Path.GetExtension(CurrentFile) == ".doc" || Path.GetExtension(CurrentFile) == ".docx" || Path.GetExtension(CurrentFile) == ".log" || Path.GetExtension(CurrentFile) == ".msg" || Path.GetExtension(CurrentFile) == ".odt" || Path.GetExtension(CurrentFile) == ".pages" || Path.GetExtension(CurrentFile) == ".rtf" || Path.GetExtension(CurrentFile) == ".tex" || Path.GetExtension(CurrentFile) == ".tif" || Path.GetExtension(CurrentFile) == ".tiff" || Path.GetExtension(CurrentFile) == ".wpd" || Path.GetExtension(CurrentFile) == ".wps" || Path.GetExtension(CurrentFile) == ".csv" || Path.GetExtension(CurrentFile) == ".dat" || Path.GetExtension(CurrentFile) == ".ged" || Path.GetExtension(CurrentFile) == ".key" || Path.GetExtension(CurrentFile) == ".keychain" || Path.GetExtension(CurrentFile) == ".pps" || Path.GetExtension(CurrentFile) == ".ppt" || Path.GetExtension(CurrentFile) == ".pptx" || Path.GetExtension(CurrentFile) == ".sdf" || Path.GetExtension(CurrentFile) == ".tar" || Path.GetExtension(CurrentFile) == ".tax2016" || Path.GetExtension(CurrentFile) == ".tax2019" || Path.GetExtension(CurrentFile) == ".vcf" || Path.GetExtension(CurrentFile) == ".xml" || Path.GetExtension(CurrentFile) == ".ai" || Path.GetExtension(CurrentFile) == ".eps" || Path.GetExtension(CurrentFile) == ".svg" || Path.GetExtension(CurrentFile) == ".indd" || Path.GetExtension(CurrentFile) == ".pct" || Path.GetExtension(CurrentFile) == ".pdf" || Path.GetExtension(CurrentFile) == ".xlr" || Path.GetExtension(CurrentFile) == ".xls" || Path.GetExtension(CurrentFile) == ".xlsx" || Path.GetExtension(CurrentFile) == ".accdb" || Path.GetExtension(CurrentFile) == ".db" || Path.GetExtension(CurrentFile) == ".dbf" || Path.GetExtension(CurrentFile) == ".mdb" || Path.GetExtension(CurrentFile) == ".pdb" || Path.GetExtension(CurrentFile) == ".sql" || Path.GetExtension(CurrentFile) == ".asp" || Path.GetExtension(CurrentFile) == ".aspx" || Path.GetExtension(CurrentFile) == ".cer" || Path.GetExtension(CurrentFile) == ".cfm" || Path.GetExtension(CurrentFile) == ".crdownload" || Path.GetExtension(CurrentFile) == ".csr" || Path.GetExtension(CurrentFile) == ".css" || Path.GetExtension(CurrentFile) == ".dcr" || Path.GetExtension(CurrentFile) == ".htm" || Path.GetExtension(CurrentFile) == ".html" || Path.GetExtension(CurrentFile) == ".js" || Path.GetExtension(CurrentFile) == ".jsp" || Path.GetExtension(CurrentFile) == ".php" || Path.GetExtension(CurrentFile) == ".rss" || Path.GetExtension(CurrentFile) == ".xhtml" || Path.GetExtension(CurrentFile) == ".ts" || Path.GetExtension(CurrentFile) == ".scss" || Path.GetExtension(CurrentFile) == ".sass" || Path.GetExtension(CurrentFile) == ".go" || Path.GetExtension(CurrentFile) == ".http")
//                        richTextBox1.LoadFile(CurrentFile, RichTextBoxStreamType.PlainText);
//                   else richTextBox1.LoadFile(CurrentFile);
//                    this.Text = Path.GetFileName(CurrentFile) + " - Text Editor";
//                }
//            }
            }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoForward)
                webBrowser.GoForward();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Clipboard.SetText(richTextBox1.Text);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Clipboard.GetText();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }
    }
}