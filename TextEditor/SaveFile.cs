using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    internal class SaveFile
    {
        public static void SaveFolder(SaveFileDialog saveFileDialog1, RichTextBox richTextBox1)
        {
            saveFileDialog1.Filter = "Text Files(.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.Write(richTextBox1.Text);
                sw.Close();
            }
        }
    }
}
