using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_работа._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            label1.Text = "Новый";
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                label1.Text = openFileDialog1.FileName;
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(saveFileDialog1.FileName);
                streamWriter.WriteLine(richTextBox1.Text);
                streamWriter.Close();
                label1.Text = saveFileDialog1.FileName;
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Focus();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                System.Drawing.Font currentFront = richTextBox1.SelectionFont;
                richTextBox1.SelectionFont = new Font(currentFront, currentFront.Style ^ FontStyle.Bold);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                System.Drawing.Font currentFront = richTextBox1.SelectionFont;
                richTextBox1.SelectionFont = new Font(currentFront, currentFront.Style ^ FontStyle.Italic);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FontDialog fn = new FontDialog();
            DialogResult res = fn.ShowDialog();
            if (res == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fn.Font;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ColorDialog fn = new ColorDialog();
            DialogResult res = fn.ShowDialog();
            if (res == DialogResult.OK)
            {
                richTextBox1.SelectionColor = fn.Color;
            }
        }
    }
}
