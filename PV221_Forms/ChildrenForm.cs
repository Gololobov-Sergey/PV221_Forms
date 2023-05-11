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
    public partial class ChildForm : Form
    {
        public string Name
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        public string Price
        {
            get { return txtPrice.Text; }
            set { txtPrice.Text = value; }
        }
        public ChildForm()
        {
            InitializeComponent();
            //textBox1.Text = s;
        }

        public DialogResult ShowDialog(string text)
        {
            string[] t = text.Split(", ");
            txtName.Text = t[0];
            txtPrice.Text = t[1];
            if (t[0] == "")
            {
                label1.Text = "Hello";
            }
            return ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
