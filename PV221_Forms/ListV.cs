using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PV221_Forms
{
    public partial class ListV : Form
    {
        public ListV()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;

            ListView l = new ListView();
            l.Items.Add("qqqq");
            l.Items[0].Tag = 0.5M;

            ObservableCollection<Student> group = new ObservableCollection<Student>
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

            dataGridView1.DataSource = group;

            foreach (DataGridViewColumn c in dataGridView1.Columns)
            {
                c.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: listView1.View = View.List; break;
                case 1: listView1.View = View.LargeIcon; break;
                case 2: listView1.View = View.SmallIcon; break;
                case 3: listView1.View = View.Tile; break;
                case 4: listView1.View = View.Details; break;
            }
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            listBox1.DoDragDrop(listBox1.SelectedItem, DragDropEffects.All);
        }

        private void listBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {

            }

            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            e.Data.GetData(typeof(ListViewItem));
            if (e.Effect != DragDropEffects.None)
            {
                listBox2.Items.Add(e.Data.GetData(DataFormats.StringFormat));

                if (e.Effect == DragDropEffects.Move)
                {
                    listBox1.Items.Remove(e.Data.GetData(DataFormats.StringFormat));
                }
            }
        }

        private void listBox2_DragOver(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                e.Effect = DragDropEffects.None;
                return;
            }

            // Set the effect based upon the KeyState.
            if ((e.KeyState & (8 + 32)) == (8 + 32) &&
                (e.AllowedEffect & DragDropEffects.Link) == DragDropEffects.Link)
            {
                // KeyState 8 + 32 = CTRL + ALT

                // Link drag-and-drop effect.
                e.Effect = DragDropEffects.Link;
            }
            else if ((e.KeyState & 32) == 32 &&
                (e.AllowedEffect & DragDropEffects.Link) == DragDropEffects.Link)
            {
                // ALT KeyState for link.
                e.Effect = DragDropEffects.Link;
            }
            else if ((e.KeyState & 4) == 4 &&
                (e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move)
            {
                // SHIFT KeyState for move.
                e.Effect = DragDropEffects.Move;
            }
            else if ((e.KeyState & 8) == 8 &&
                (e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                // CTRL KeyState for copy.
                e.Effect = DragDropEffects.Copy;
            }
            else if ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move)
            {
                // By default, the drop action should be move, if allowed.
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}
