using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextEditor
{
    
    
    public partial class FormTextEditor : Form
    {
        String path; string[] patharray;
        public string FindText;
        private bool matchCase;
        private object btn;

        public FormTextEditor()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newFile();
            
        }

        private void newFile()
        {
            richTextBox1.Text = null;
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void FormTextEditor_Load(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (.txt)|*.txt";
            ofd.Title = "Open a file...";
            if (ofd.ShowDialog() == DialogResult.OK) 
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                path = ofd.FileName;
                richTextBox1.Text = File.ReadAllText(path);
                patharray = File.ReadAllLines(path);
                sr.Close();
            }
            Text = ofd.FileName;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        /*{
           
            File.WriteAllText(path, richTextBox1.Text);
        }  */
        {
            SaveFileDialog sfd = new SaveFileDialog();
            {
                File.WriteAllText(path, richTextBox1.Text);  
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void programInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Text Editor" +
                "\nPhillip Dillard" +
                "\nVersion 1.0" +
                "\nWebDevelopBootCamp");
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files (.txt)|*.txt";
            sfd.Title = "Save file...";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName);
                sw.Write(richTextBox1.Text);
                sw.Close();
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
              

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            fontDialog1.Font = richTextBox1.Font;
            fontDialog1.Color = richTextBox1.ForeColor;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.Font = fontDialog1.Font;
               richTextBox1.ForeColor = fontDialog1.Color;

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
           //int x=new int();
            Form1 r = new Form1();
            r.ShowDialog();
            if (FindText != "")
            {
                richTextBox1.Find(FindText);
            }
          
        }


       

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (wordWrapToolStripMenuItem.Checked)
            {
                case true:
                    wordWrapToolStripMenuItem.Checked = false;
                    richTextBox1.WordWrap = false;
                    richTextBox1.ScrollBars = RichTextBoxScrollBars.Both;
                    break;
                case false:
                    wordWrapToolStripMenuItem.Checked = true;
                    richTextBox1.WordWrap = true;
                    richTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical;
                    break;

            }
                
        }

        private void findAndReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void theme1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
