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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_SizeChanged(object sender, EventArgs e)
        {
            float s = Width * Height / 30000;
            button1.Font = new Font("Tahoma", s);
            button2.Font = new Font("Tahoma", s);

            button4.Font = new Font("Tahoma", s);
        }
    }
}
