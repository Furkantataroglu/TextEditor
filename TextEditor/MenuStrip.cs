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
    public partial class MenuStrip : Form
    {
        public MenuStrip()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {

            NewFile.New(richTextBox1);
        }

        private void dosyaAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile.OpenFolder(openFileDialog1, richTextBox1);
        }

        private void dosyaKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile.SaveFolder(saveFileDialog1,richTextBox1);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }
    }
}
