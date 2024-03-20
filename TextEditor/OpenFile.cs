using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    internal class OpenFile
    {
        public static void OpenFolder(OpenFileDialog openFileDialog1, RichTextBox richTextBox1)
        {
            openFileDialog1.Title = "Dosyayı Seç";
            openFileDialog1.Multiselect = false;
            openFileDialog1.Filter = "Text Files(.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }
    }
}
