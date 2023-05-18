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
    public partial class Tree : Form
    {
        TreeNode nodeSelected;

        List<Student> group = new List<Student>
        {
            new Student()
            {
                LastName = "Osipov",
                FirstName = "Oleg",
                BirthDay = new DateTime(2000, 12, 15),
                StudentCard = new StudentCard()
                {
                    Series = "AB",
                    Number = 123456
                }
            },

            new Student()
            {
                LastName = "Petrova",
                FirstName = "Maria",
                BirthDay = new DateTime(2002, 04, 20),
                StudentCard = new StudentCard()
                {
                    Series = "AB",
                    Number = 129956
                }
            },

            new Student()
            {
                LastName = "Fedorov",
                FirstName = "Petro",
                BirthDay = new DateTime(1999, 01, 10),
                StudentCard = new StudentCard()
                {
                    Series = "AC",
                    Number = 123456
                }
            },

            new Student()
            {
                LastName = "Abramova",
                FirstName = "Olga",
                BirthDay = new DateTime(2005, 12, 14),
                StudentCard = new StudentCard()
                {
                    Series = "AA",
                    Number = 124123
                }
            }
        };

        public Tree()
        {
            InitializeComponent();


            //listView1.Items.Add("Січень");
            //listView1.Items.Add("Лютий");
            //listView1.Items.Add("Березень");
            //listView1.Items.Add("Квітень");
            //listView1.Items.Add("Травень");
            //listView1.Items.Add("Червень");

            foreach (Student s in group)
            {
                ListViewItem i = new ListViewItem(s.LastName + " " + s.FirstName);
                i.SubItems.Add(s.BirthDay.ToShortDateString());
                i.SubItems.Add(s.StudentCard.Series);
                i.SubItems.Add(s.StudentCard.Number.ToString());
                listView1.Items.Add(i);

            }

        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            nodeSelected = (TreeNode)e.Node;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                nodeSelected.Nodes.Add(textBox1.Text);
            }
        }

        private void delToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Remove(nodeSelected);
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {

        }
    }
}
