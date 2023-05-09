using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PV221_Forms
{
    public partial class Form1 : Form
    {
        List<Label> labels = new List<Label>();
        public Form1()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Hello WinForm", "New Form", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                MessageBox.Show("Yes");
            }
            else
            {
                MessageBox.Show("No");
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = "X = " + e.X.ToString() + ", Y = " + e.Y.ToString();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MessageBox.Show("Left");
            }

            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Right");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Label l = new Label();
            labels.Add(l);
            

        }


    }
}
