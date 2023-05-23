namespace PV221_Forms
{
    partial class ListV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("ewrtyyeww", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("wetyytrewqwe", 1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("dgfhjfd", 2);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListV));
            listView1 = new System.Windows.Forms.ListView();
            imageList2 = new System.Windows.Forms.ImageList(components);
            imageList1 = new System.Windows.Forms.ImageList(components);
            comboBox1 = new System.Windows.Forms.ComboBox();
            listBox1 = new System.Windows.Forms.ListBox();
            listBox2 = new System.Windows.Forms.ListBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.HideSelection = false;
            listViewItem1.Tag = new decimal(new int[] { 100, 0, 0, 0 });
            listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
            listView1.LargeImageList = imageList2;
            listView1.Location = new System.Drawing.Point(54, 52);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(319, 322);
            listView1.SmallImageList = imageList1;
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            imageList2.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = System.Drawing.Color.Transparent;
            imageList2.Images.SetKeyName(0, "Csharp_Logo.png");
            imageList2.Images.SetKeyName(1, "winform-logo.jpg");
            imageList2.Images.SetKeyName(2, "arduino5804.jpg");
            // 
            // imageList1
            // 
            imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            imageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "Csharp_Logo.png");
            imageList1.Images.SetKeyName(1, "winform-logo.jpg");
            imageList1.Images.SetKeyName(2, "arduino5804.jpg");
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Список", "Великі іконки", "Маленькі іконки", "Плитки", "Детально" });
            comboBox1.Location = new System.Drawing.Point(222, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(151, 28);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "Список", "Великі іконки", "Маленькі іконки", "Плитки", "Детально" });
            listBox1.Location = new System.Drawing.Point(429, 52);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(203, 324);
            listBox1.TabIndex = 2;
            listBox1.MouseDown += listBox1_MouseDown;
            // 
            // listBox2
            // 
            listBox2.AllowDrop = true;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new System.Drawing.Point(708, 50);
            listBox2.Name = "listBox2";
            listBox2.Size = new System.Drawing.Size(203, 324);
            listBox2.TabIndex = 3;
            listBox2.DragDrop += listBox2_DragDrop;
            listBox2.DragEnter += listBox2_DragEnter;
            listBox2.DragOver += listBox2_DragOver;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1 });
            dataGridView1.Location = new System.Drawing.Point(54, 395);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new System.Drawing.Size(857, 239);
            dataGridView1.TabIndex = 4;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            Column1.Width = 125;
            // 
            // ListV
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(965, 659);
            Controls.Add(dataGridView1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(comboBox1);
            Controls.Add(listView1);
            Name = "ListV";
            Text = "ListV";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}