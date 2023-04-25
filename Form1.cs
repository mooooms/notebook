using System;
using System.Drawing;
using System.Windows.Forms;

namespace bloknot
{
    public partial class Bloknot : Form
    {
        public Bloknot() => InitializeComponent();

        private void OpenFile_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog file_Dialog = new OpenFileDialog();
            file_Dialog.Filter = "Текстовые файлы(*.rtf)|*.rtf";
            if (file_Dialog.ShowDialog().Equals(DialogResult.OK))
            {
                richTextBox1.LoadFile(file_Dialog.FileName);
            }
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog file_Dialog = new SaveFileDialog();
            file_Dialog.Filter = "Текстовые файлы(*.rtf)|*.rtf";
            if (file_Dialog.ShowDialog().Equals(DialogResult.OK))
            {
                richTextBox1.SaveFile(file_Dialog.FileName);
            }
        }

        private void Font_Click(object sender, EventArgs e)
        {
            FontDialog font_Dialog = new FontDialog();
            if (font_Dialog.ShowDialog().Equals(DialogResult.OK))
            {
                richTextBox1.SelectionFont = font_Dialog.Font;
            }

        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog color_Dialog = new ColorDialog();
            if (color_Dialog.ShowDialog().Equals(DialogResult.OK))
            {
                richTextBox1.SelectionColor = color_Dialog.Color;
            }
        }
        bool bold = false;
        private void Bold_Click(object sender, EventArgs e)
        {
            //bold = !bold;
            var f = richTextBox1.SelectionFont;
            richTextBox1.SelectionFont = new Font(f.FontFamily, f.Size,
                bold ? FontStyle.Bold : FontStyle.Regular);
        }
        bool italic = false;
        private void ItalicFont_Click(object sender, EventArgs e)
        {
            var f = richTextBox1.SelectionFont;
            richTextBox1.SelectionFont = new Font(f.FontFamily, f.Size,
                bold ? FontStyle.Bold : FontStyle.Italic);
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = richTextBox1.SelectionFont;
            richTextBox1.SelectionFont = new Font(f.FontFamily, f.Size + 1, f.Style);
        }

        private void aToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var f = richTextBox1.SelectionFont;
            richTextBox1.SelectionFont = new Font(f.FontFamily, f.Size - 1, f.Style);
        }
    }
    
}
