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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChildForm f = new ChildForm();
            f.Text = "Add";
            
            //f.TextTB = textBox1.Text;
            if (f.ShowDialog(", ") == DialogResult.OK)
            {
                listBox1.Items.Add(f.Name + ", " + f.Price);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ChildForm f = new ChildForm();
            f.Text = "Edit";
            string edit = listBox1.SelectedItem.ToString();
            if (f.ShowDialog(listBox1.SelectedItem.ToString()) == DialogResult.OK)
            {
                listBox1.Items.Remove(edit);
                listBox1.Items.Add(f.Name + ", " + f.Price);
            }
        }
    }
}
