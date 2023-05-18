namespace PV221_Forms
{
    partial class TextEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditor));
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            countSymbol = new System.Windows.Forms.ToolStripStatusLabel();
            saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            копіюватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            вирізатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            вствитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            закритиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            colorDialog1 = new System.Windows.Forms.ColorDialog();
            fontDialog1 = new System.Windows.Forms.FontDialog();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            новийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            відкритиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            зберегтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            зберегтиЯкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            довідкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            проНасToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            налаштуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            моваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            українськаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            англійськаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            колірФонуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip2 = new System.Windows.Forms.MenuStrip();
            toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            btnOpen = new System.Windows.Forms.ToolStripButton();
            toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator21 = new System.Windows.Forms.ToolStripSeparator();
            toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            statusStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            menuStrip2.SuspendLayout();
            toolStrip1.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripStatusLabel1, countSymbol });
            statusStrip1.Location = new System.Drawing.Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(800, 26);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new System.Drawing.Size(75, 20);
            toolStripStatusLabel1.Text = "Символів";
            // 
            // countSymbol
            // 
            countSymbol.AutoSize = false;
            countSymbol.Name = "countSymbol";
            countSymbol.Size = new System.Drawing.Size(50, 20);
            countSymbol.Text = "0";
            countSymbol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "rtf";
            // 
            // folderBrowserDialog1
            // 
            folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            richTextBox1.ContextMenuStrip = contextMenuStrip1;
            richTextBox1.Location = new System.Drawing.Point(0, 70);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            richTextBox1.Size = new System.Drawing.Size(800, 354);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { копіюватиToolStripMenuItem, вирізатиToolStripMenuItem, вствитиToolStripMenuItem, toolStripSeparator1, закритиToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(204, 106);
            // 
            // копіюватиToolStripMenuItem
            // 
            копіюватиToolStripMenuItem.Name = "копіюватиToolStripMenuItem";
            копіюватиToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C;
            копіюватиToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            копіюватиToolStripMenuItem.Text = "Копіювати";
            копіюватиToolStripMenuItem.Click += копіюватиToolStripMenuItem_Click;
            // 
            // вирізатиToolStripMenuItem
            // 
            вирізатиToolStripMenuItem.Name = "вирізатиToolStripMenuItem";
            вирізатиToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            вирізатиToolStripMenuItem.Text = "Вирізати";
            // 
            // вствитиToolStripMenuItem
            // 
            вствитиToolStripMenuItem.Name = "вствитиToolStripMenuItem";
            вствитиToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            вствитиToolStripMenuItem.Text = "Вствити";
            вствитиToolStripMenuItem.Click += вствитиToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(200, 6);
            // 
            // закритиToolStripMenuItem
            // 
            закритиToolStripMenuItem.Name = "закритиToolStripMenuItem";
            закритиToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            закритиToolStripMenuItem.Text = "Закрити";
            // 
            // fontDialog1
            // 
            fontDialog1.ShowColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { файлToolStripMenuItem, довідкаToolStripMenuItem, налаштуванняToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(800, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { новийToolStripMenuItem, відкритиToolStripMenuItem, зберегтиToolStripMenuItem, зберегтиЯкToolStripMenuItem, toolStripSeparator7, toolStripMenuItem1 });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // новийToolStripMenuItem
            // 
            новийToolStripMenuItem.Name = "новийToolStripMenuItem";
            новийToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            новийToolStripMenuItem.Text = "Новий";
            // 
            // відкритиToolStripMenuItem
            // 
            відкритиToolStripMenuItem.Image = Properties.Resources.folder_open_outline;
            відкритиToolStripMenuItem.Name = "відкритиToolStripMenuItem";
            відкритиToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O;
            відкритиToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            відкритиToolStripMenuItem.Text = "Відкрити";
            відкритиToolStripMenuItem.Click += відкритиToolStripMenuItem_Click;
            // 
            // зберегтиToolStripMenuItem
            // 
            зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            зберегтиToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            зберегтиToolStripMenuItem.Text = "Зберегти";
            // 
            // зберегтиЯкToolStripMenuItem
            // 
            зберегтиЯкToolStripMenuItem.Name = "зберегтиЯкToolStripMenuItem";
            зберегтиЯкToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            зберегтиЯкToolStripMenuItem.Text = "Зберегти як..";
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new System.Drawing.Size(203, 6);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(206, 26);
            toolStripMenuItem1.Text = "Вихід";
            // 
            // довідкаToolStripMenuItem
            // 
            довідкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { проНасToolStripMenuItem });
            довідкаToolStripMenuItem.Name = "довідкаToolStripMenuItem";
            довідкаToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            довідкаToolStripMenuItem.Text = "Довідка";
            // 
            // проНасToolStripMenuItem
            // 
            проНасToolStripMenuItem.Name = "проНасToolStripMenuItem";
            проНасToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            проНасToolStripMenuItem.Text = "Про нас";
            // 
            // налаштуванняToolStripMenuItem
            // 
            налаштуванняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { моваToolStripMenuItem, колірФонуToolStripMenuItem });
            налаштуванняToolStripMenuItem.Name = "налаштуванняToolStripMenuItem";
            налаштуванняToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            налаштуванняToolStripMenuItem.Text = "Налаштування";
            // 
            // моваToolStripMenuItem
            // 
            моваToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { українськаToolStripMenuItem, англійськаToolStripMenuItem });
            моваToolStripMenuItem.Name = "моваToolStripMenuItem";
            моваToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            моваToolStripMenuItem.Text = "Мова";
            // 
            // українськаToolStripMenuItem
            // 
            українськаToolStripMenuItem.Checked = true;
            українськаToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            українськаToolStripMenuItem.Name = "українськаToolStripMenuItem";
            українськаToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            українськаToolStripMenuItem.Text = "Українська";
            українськаToolStripMenuItem.Click += українськаToolStripMenuItem_Click;
            // 
            // англійськаToolStripMenuItem
            // 
            англійськаToolStripMenuItem.Name = "англійськаToolStripMenuItem";
            англійськаToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            англійськаToolStripMenuItem.Text = "Англійська";
            англійськаToolStripMenuItem.Click += англійськаToolStripMenuItem_Click;
            // 
            // колірФонуToolStripMenuItem
            // 
            колірФонуToolStripMenuItem.Name = "колірФонуToolStripMenuItem";
            колірФонуToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            колірФонуToolStripMenuItem.Text = "Колір фону";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem8, toolStripMenuItem10 });
            menuStrip2.Location = new System.Drawing.Point(0, 28);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new System.Drawing.Size(800, 28);
            menuStrip2.TabIndex = 4;
            menuStrip2.Text = "menuStrip2";
            menuStrip2.Visible = false;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripMenuItem3, toolStripMenuItem4, toolStripMenuItem5, toolStripMenuItem6, toolStripSeparator8, toolStripMenuItem7 });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new System.Drawing.Size(46, 24);
            toolStripMenuItem2.Text = "File";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new System.Drawing.Size(180, 26);
            toolStripMenuItem3.Text = "Новий";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new System.Drawing.Size(180, 26);
            toolStripMenuItem4.Text = "Відкрити";
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new System.Drawing.Size(180, 26);
            toolStripMenuItem5.Text = "Зберегти";
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new System.Drawing.Size(180, 26);
            toolStripMenuItem6.Text = "Зберегти як..";
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new System.Drawing.Size(180, 26);
            toolStripMenuItem7.Text = "Вихід";
            // 
            // toolStripMenuItem8
            // 
            toolStripMenuItem8.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripMenuItem9 });
            toolStripMenuItem8.Name = "toolStripMenuItem8";
            toolStripMenuItem8.Size = new System.Drawing.Size(77, 24);
            toolStripMenuItem8.Text = "Довідка";
            // 
            // toolStripMenuItem9
            // 
            toolStripMenuItem9.Name = "toolStripMenuItem9";
            toolStripMenuItem9.Size = new System.Drawing.Size(149, 26);
            toolStripMenuItem9.Text = "Про нас";
            // 
            // toolStripMenuItem10
            // 
            toolStripMenuItem10.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripMenuItem11, toolStripMenuItem14 });
            toolStripMenuItem10.Name = "toolStripMenuItem10";
            toolStripMenuItem10.Size = new System.Drawing.Size(76, 24);
            toolStripMenuItem10.Text = "Settings";
            toolStripMenuItem10.Click += toolStripMenuItem10_Click;
            // 
            // toolStripMenuItem11
            // 
            toolStripMenuItem11.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripMenuItem12, toolStripMenuItem13 });
            toolStripMenuItem11.Name = "toolStripMenuItem11";
            toolStripMenuItem11.Size = new System.Drawing.Size(170, 26);
            toolStripMenuItem11.Text = "Мова";
            // 
            // toolStripMenuItem12
            // 
            toolStripMenuItem12.Name = "toolStripMenuItem12";
            toolStripMenuItem12.Size = new System.Drawing.Size(168, 26);
            toolStripMenuItem12.Text = "Українська";
            toolStripMenuItem12.Click += toolStripMenuItem12_Click;
            // 
            // toolStripMenuItem13
            // 
            toolStripMenuItem13.Name = "toolStripMenuItem13";
            toolStripMenuItem13.Size = new System.Drawing.Size(168, 26);
            toolStripMenuItem13.Text = "Англійська";
            toolStripMenuItem13.Click += toolStripMenuItem13_Click;
            // 
            // toolStripMenuItem14
            // 
            toolStripMenuItem14.Name = "toolStripMenuItem14";
            toolStripMenuItem14.Size = new System.Drawing.Size(170, 26);
            toolStripMenuItem14.Text = "Колір фону";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnOpen, toolStripButton2, toolStripButton3, toolStripButton1, toolStripButton4, toolStripButton5, toolStripSeparator21 });
            toolStrip1.Location = new System.Drawing.Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(800, 39);
            toolStrip1.TabIndex = 6;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnOpen
            // 
            btnOpen.AutoSize = false;
            btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnOpen.Image = (System.Drawing.Image)resources.GetObject("btnOpen.Image");
            btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new System.Drawing.Size(36, 36);
            btnOpen.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            toolStripButton2.AutoSize = false;
            toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (System.Drawing.Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new System.Drawing.Size(36, 36);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            toolStripButton3.AutoSize = false;
            toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (System.Drawing.Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new System.Drawing.Size(36, 36);
            toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton1
            // 
            toolStripButton1.AutoSize = false;
            toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (System.Drawing.Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new System.Drawing.Size(36, 36);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = (System.Drawing.Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new System.Drawing.Size(29, 36);
            toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButton5.Image = (System.Drawing.Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new System.Drawing.Size(29, 36);
            toolStripButton5.Text = "toolStripButton5";
            // 
            // toolStripSeparator21
            // 
            toolStripSeparator21.Name = "toolStripSeparator21";
            toolStripSeparator21.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(8, 0);
            toolStripContainer1.Location = new System.Drawing.Point(536, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new System.Drawing.Size(8, 8);
            toolStripContainer1.TabIndex = 7;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // TextEditor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(toolStripContainer1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip2);
            Controls.Add(richTextBox1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TextEditor";
            Text = "TextEditor";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel countSymbol;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відкритиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиЯкToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem довідкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проНасToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem налаштуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem моваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem українськаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem англійськаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem колірФонуToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator21;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem копіюватиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вирізатиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вствитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem закритиToolStripMenuItem;
    }
}