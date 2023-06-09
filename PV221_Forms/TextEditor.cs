﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PV221_Forms
{
    public partial class TextEditor : Form
    {
        public TextEditor()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All files(*.*)|*.*|Text files(*.txt)|*.txt|RTF files(*.rtf)|*.rtf";
            openFileDialog1.FilterIndex = 3;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            countSymbol.Text = richTextBox1.Text.Length.ToString();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "All files(*.*)|*.*|Text files(*.txt)|*.txt|RTF files(*.rtf)|*.rtf";
            saveFileDialog1.FilterIndex = 3;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog1.Color;
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog(this) == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
                richTextBox1.SelectionColor = fontDialog1.Color;
            }
        }

        private void відкритиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnOpen_Click(sender, e);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {

        }

        private void англійськаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;
            menuStrip2.Visible = true;
            toolStripMenuItem13.CheckState = CheckState.Checked;
        }

        private void українськаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            menuStrip1.Visible = true;
            menuStrip2.Visible = false;
            українськаToolStripMenuItem.CheckState = CheckState.Checked;
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {

        }

        private void копіюватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.SelectedText);
        }

        private void вствитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = new string(richTextBox1.Text.Take(richTextBox1.SelectionStart).ToArray()) +
                Clipboard.GetText() +
                new string(richTextBox1.Text.Skip(richTextBox1.SelectionStart).ToArray());

        }
    }
}
