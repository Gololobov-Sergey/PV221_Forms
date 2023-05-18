namespace PV221_Forms
{
    partial class Tree
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Гололобов С.А.");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Зайце В.В.");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Викладачі", new System.Windows.Forms.TreeNode[] { treeNode1, treeNode2 });
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Бондар Ігор Андрійович");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Бондар Софія Віталіївна");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Добровольський Денис Миколайович");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Студенти", new System.Windows.Forms.TreeNode[] { treeNode4, treeNode5, treeNode6 });
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("IT STEP", new System.Windows.Forms.TreeNode[] { treeNode3, treeNode7 });
            treeView1 = new System.Windows.Forms.TreeView();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            delToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            textBox1 = new System.Windows.Forms.TextBox();
            listView1 = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            columnHeader4 = new System.Windows.Forms.ColumnHeader();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.ContextMenuStrip = contextMenuStrip1;
            treeView1.Location = new System.Drawing.Point(38, 33);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Узел3";
            treeNode1.Text = "Гололобов С.А.";
            treeNode2.Name = "Узел4";
            treeNode2.Text = "Зайце В.В.";
            treeNode3.Name = "Узел1";
            treeNode3.Text = "Викладачі";
            treeNode4.Name = "Узел5";
            treeNode4.Text = "Бондар Ігор Андрійович";
            treeNode5.Name = "Узел6";
            treeNode5.Text = "Бондар Софія Віталіївна";
            treeNode6.Name = "Узел7";
            treeNode6.Text = "Добровольський Денис Миколайович";
            treeNode7.Name = "Узел2";
            treeNode7.Text = "Студенти";
            treeNode8.Name = "Узел0";
            treeNode8.Text = "IT STEP";
            treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] { treeNode8 });
            treeView1.Size = new System.Drawing.Size(267, 296);
            treeView1.TabIndex = 0;
            treeView1.NodeMouseClick += treeView1_NodeMouseClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { addToolStripMenuItem, delToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(107, 52);
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            addToolStripMenuItem.Text = "Add";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // delToolStripMenuItem
            // 
            delToolStripMenuItem.Name = "delToolStripMenuItem";
            delToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            delToolStripMenuItem.Text = "Del";
            delToolStripMenuItem.Click += delToolStripMenuItem_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(38, 354);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(267, 27);
            textBox1.TabIndex = 2;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.HideSelection = false;
            listView1.Location = new System.Drawing.Point(332, 37);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(403, 292);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            listView1.ColumnClick += listView1_ColumnClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Date";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Series";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Number";
            columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            columnHeader4.Width = 100;
            // 
            // Tree
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(textBox1);
            Controls.Add(treeView1);
            Name = "Tree";
            Text = "Tree";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}