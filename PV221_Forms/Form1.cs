using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PV221_Forms
{
    public partial class Form1 : Form
    {
        List<Label> labels = new List<Label>();

        decimal start;



        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add("Зима");
            comboBox1.Items.Add("Весна");
            comboBox1.Items.Add("Літо");
            comboBox1.Items.Add("Осінь");

            comboBox1.SelectedIndex = 0;


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

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;
            progressBar1.Value = 0;

            for (int i = 0; i < 100; i++)
            {
                progressBar1.Value++;
                this.Update();
                Thread.Sleep(100);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && !listBox1.Items.Contains(textBox1.Text))
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = string.Empty;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string st = "";
            foreach (string s in listBox1.SelectedItems)
            {
                st += s + "\n";
            }
            MessageBox.Show(st);


        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                foreach (string s in listBox1.SelectedItems)
                {
                    listBox2.Items.Add(s);
                }
            }


        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                while (listBox1.SelectedItems.Count > 0)
                {
                    listBox2.Items.Add(listBox1.SelectedItems[0]);
                    listBox1.Items.Remove(listBox1.SelectedItems[0]);
                }
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = numericUpDown1.Value.ToString();
            start = numericUpDown1.Value;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            start--;
            label2.Text = start.ToString();
            if (start == 0)
            {
                timer1.Stop();
                timer1.Enabled = false;
                numericUpDown1.Value = 0;
                MessageBox.Show("Boom!");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            nowTime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
