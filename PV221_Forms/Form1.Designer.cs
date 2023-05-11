namespace PV221_Forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            listBox1 = new System.Windows.Forms.ListBox();
            textBox1 = new System.Windows.Forms.TextBox();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            listBox2 = new System.Windows.Forms.ListBox();
            btnCopy = new System.Windows.Forms.Button();
            btnMove = new System.Windows.Forms.Button();
            checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            comboBox1 = new System.Windows.Forms.ComboBox();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            progressBar1 = new System.Windows.Forms.ProgressBar();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            timer1 = new System.Windows.Forms.Timer(components);
            btnStart = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            button4 = new System.Windows.Forms.Button();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            nowTime = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            fghjkklhgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dfsghToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            sadfghjToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            timer2 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(701, 439);
            button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(146, 28);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(11, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(120, 75);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "січень", "лютий", "березень", "квітень", "травень", "червень" });
            listBox1.Location = new System.Drawing.Point(107, 121);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            listBox1.Size = new System.Drawing.Size(134, 144);
            listBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(107, 285);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(134, 27);
            textBox1.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(107, 336);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(134, 29);
            button2.TabIndex = 5;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(107, 381);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(134, 29);
            button3.TabIndex = 6;
            button3.Text = "Print";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new System.Drawing.Point(294, 121);
            listBox2.Name = "listBox2";
            listBox2.Size = new System.Drawing.Size(125, 144);
            listBox2.TabIndex = 7;
            // 
            // btnCopy
            // 
            btnCopy.Location = new System.Drawing.Point(294, 336);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new System.Drawing.Size(125, 29);
            btnCopy.TabIndex = 8;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // btnMove
            // 
            btnMove.Location = new System.Drawing.Point(294, 381);
            btnMove.Name = "btnMove";
            btnMove.Size = new System.Drawing.Size(125, 29);
            btnMove.TabIndex = 9;
            btnMove.Text = "Move";
            btnMove.UseVisualStyleBackColor = true;
            btnMove.Click += btnMove_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "січень", "лютий", "березень", "квітень", "травень", "червень" });
            checkedListBox1.Location = new System.Drawing.Point(465, 121);
            checkedListBox1.MultiColumn = true;
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new System.Drawing.Size(133, 114);
            checkedListBox1.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(640, 121);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(175, 28);
            comboBox1.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new System.Drawing.Point(465, 335);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(199, 27);
            dateTimePicker1.TabIndex = 12;
            // 
            // progressBar1
            // 
            progressBar1.Location = new System.Drawing.Point(99, 439);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new System.Drawing.Size(555, 24);
            progressBar1.Step = 1;
            progressBar1.TabIndex = 13;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new System.Drawing.Point(107, 69);
            numericUpDown1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(134, 27);
            numericUpDown1.TabIndex = 14;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // btnStart
            // 
            btnStart.Location = new System.Drawing.Point(397, 67);
            btnStart.Name = "btnStart";
            btnStart.Size = new System.Drawing.Size(94, 29);
            btnStart.TabIndex = 15;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(275, 40);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(99, 56);
            label2.TabIndex = 16;
            label2.Text = "0";
            label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(505, 67);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(94, 29);
            button4.TabIndex = 17;
            button4.Text = "Stop";
            toolTip1.SetToolTip(button4, "Зупиняє таймер");
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { nowTime, toolStripSplitButton1 });
            statusStrip1.Location = new System.Drawing.Point(0, 513);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new System.Windows.Forms.Padding(16, 0, 1, 0);
            statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            statusStrip1.Size = new System.Drawing.Size(1111, 26);
            statusStrip1.TabIndex = 18;
            statusStrip1.Text = "statusStrip1";
            // 
            // nowTime
            // 
            nowTime.Name = "nowTime";
            nowTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            nowTime.Size = new System.Drawing.Size(151, 20);
            nowTime.Text = "toolStripStatusLabel1";
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.AutoSize = false;
            toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { fghjkklhgToolStripMenuItem, dfsghToolStripMenuItem, sadfghjToolStripMenuItem });
            toolStripSplitButton1.Image = Properties.Resources.Csharp_Logo;
            toolStripSplitButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new System.Drawing.Size(100, 24);
            toolStripSplitButton1.Text = "Language";
            // 
            // fghjkklhgToolStripMenuItem
            // 
            fghjkklhgToolStripMenuItem.Name = "fghjkklhgToolStripMenuItem";
            fghjkklhgToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            fghjkklhgToolStripMenuItem.Text = "fghjkklhg";
            // 
            // dfsghToolStripMenuItem
            // 
            dfsghToolStripMenuItem.Name = "dfsghToolStripMenuItem";
            dfsghToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            dfsghToolStripMenuItem.Text = "dfsgh";
            // 
            // sadfghjToolStripMenuItem
            // 
            sadfghjToolStripMenuItem.Name = "sadfghjToolStripMenuItem";
            sadfghjToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            sadfghjToolStripMenuItem.Text = "sadfghj";
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Csharp_Logo;
            pictureBox1.Location = new System.Drawing.Point(664, 176);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(114, 125);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(1111, 539);
            Controls.Add(pictureBox1);
            Controls.Add(statusStrip1);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(btnStart);
            Controls.Add(numericUpDown1);
            Controls.Add(progressBar1);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(checkedListBox1);
            Controls.Add(btnMove);
            Controls.Add(btnCopy);
            Controls.Add(listBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form1";
            MouseClick += Form1_MouseClick;
            MouseMove += Form1_MouseMove;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel nowTime;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem fghjkklhgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dfsghToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sadfghjToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
