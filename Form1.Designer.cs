namespace file_manager
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.treeView = new System.Windows.Forms.TreeView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuCut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuRename = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.pbFreeSpaceC = new System.Windows.Forms.ProgressBar();
            this.pbFreeSpaceD = new System.Windows.Forms.ProgressBar();
            this.txtFreeSpaceC = new System.Windows.Forms.Label();
            this.txtFreeSpaceD = new System.Windows.Forms.Label();
            this.txtPercentC = new System.Windows.Forms.Label();
            this.txtPercentD = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtDeadline = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.btnStart = new System.Windows.Forms.Button();
            this.contextMenuStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tab2.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.ContextMenuStrip = this.contextMenuStrip;
            this.treeView.Location = new System.Drawing.Point(3, 93);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(458, 322);
            this.treeView.TabIndex = 0;
            this.treeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView_BeforeExpand);
            this.treeView.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView_BeforeSelect);
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuCopy,
            this.toolStripSeparator1,
            this.toolStripMenuCut,
            this.toolStripSeparator4,
            this.toolStripMenuPaste,
            this.toolStripSeparator2,
            this.toolStripMenuRename,
            this.toolStripSeparator3,
            this.toolStripMenuDelete,
            this.toolStripSeparator5,
            this.toolStripMenuItemInfo});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(128, 166);
            // 
            // toolStripMenuCopy
            // 
            this.toolStripMenuCopy.Name = "toolStripMenuCopy";
            this.toolStripMenuCopy.Size = new System.Drawing.Size(127, 22);
            this.toolStripMenuCopy.Text = "Copy";
            this.toolStripMenuCopy.Click += new System.EventHandler(this.toolStripMenuCopy_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(124, 6);
            // 
            // toolStripMenuCut
            // 
            this.toolStripMenuCut.Name = "toolStripMenuCut";
            this.toolStripMenuCut.Size = new System.Drawing.Size(127, 22);
            this.toolStripMenuCut.Text = "Cut";
            this.toolStripMenuCut.Click += new System.EventHandler(this.toolStripMenuCut_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(124, 6);
            // 
            // toolStripMenuPaste
            // 
            this.toolStripMenuPaste.Name = "toolStripMenuPaste";
            this.toolStripMenuPaste.Size = new System.Drawing.Size(127, 22);
            this.toolStripMenuPaste.Text = "Paste";
            this.toolStripMenuPaste.Click += new System.EventHandler(this.toolStripMenuPaste_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(124, 6);
            // 
            // toolStripMenuRename
            // 
            this.toolStripMenuRename.Name = "toolStripMenuRename";
            this.toolStripMenuRename.Size = new System.Drawing.Size(127, 22);
            this.toolStripMenuRename.Text = "Rename";
            this.toolStripMenuRename.Click += new System.EventHandler(this.toolStripMenuRename_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(124, 6);
            // 
            // toolStripMenuDelete
            // 
            this.toolStripMenuDelete.Name = "toolStripMenuDelete";
            this.toolStripMenuDelete.Size = new System.Drawing.Size(127, 22);
            this.toolStripMenuDelete.Text = "Delete";
            this.toolStripMenuDelete.Click += new System.EventHandler(this.toolStripMenuDelete_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(124, 6);
            // 
            // toolStripMenuItemInfo
            // 
            this.toolStripMenuItemInfo.Name = "toolStripMenuItemInfo";
            this.toolStripMenuItemInfo.Size = new System.Drawing.Size(127, 22);
            this.toolStripMenuItemInfo.Text = "Properites";
            this.toolStripMenuItemInfo.Click += new System.EventHandler(this.toolStripMenuItemInfo_Click);
            // 
            // pbFreeSpaceC
            // 
            this.pbFreeSpaceC.Location = new System.Drawing.Point(168, 8);
            this.pbFreeSpaceC.Name = "pbFreeSpaceC";
            this.pbFreeSpaceC.Size = new System.Drawing.Size(242, 23);
            this.pbFreeSpaceC.TabIndex = 1;
            // 
            // pbFreeSpaceD
            // 
            this.pbFreeSpaceD.Location = new System.Drawing.Point(168, 37);
            this.pbFreeSpaceD.Name = "pbFreeSpaceD";
            this.pbFreeSpaceD.Size = new System.Drawing.Size(242, 23);
            this.pbFreeSpaceD.TabIndex = 2;
            // 
            // txtFreeSpaceC
            // 
            this.txtFreeSpaceC.AutoSize = true;
            this.txtFreeSpaceC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFreeSpaceC.Location = new System.Drawing.Point(-4, 11);
            this.txtFreeSpaceC.MaximumSize = new System.Drawing.Size(200, 50);
            this.txtFreeSpaceC.Name = "txtFreeSpaceC";
            this.txtFreeSpaceC.Size = new System.Drawing.Size(80, 20);
            this.txtFreeSpaceC.TabIndex = 3;
            this.txtFreeSpaceC.Text = "diskspace";
            // 
            // txtFreeSpaceD
            // 
            this.txtFreeSpaceD.AutoSize = true;
            this.txtFreeSpaceD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFreeSpaceD.Location = new System.Drawing.Point(-4, 37);
            this.txtFreeSpaceD.MaximumSize = new System.Drawing.Size(200, 50);
            this.txtFreeSpaceD.Name = "txtFreeSpaceD";
            this.txtFreeSpaceD.Size = new System.Drawing.Size(80, 20);
            this.txtFreeSpaceD.TabIndex = 4;
            this.txtFreeSpaceD.Text = "diskspace";
            // 
            // txtPercentC
            // 
            this.txtPercentC.AutoSize = true;
            this.txtPercentC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPercentC.Location = new System.Drawing.Point(416, 8);
            this.txtPercentC.Name = "txtPercentC";
            this.txtPercentC.Size = new System.Drawing.Size(36, 17);
            this.txtPercentC.TabIndex = 5;
            this.txtPercentC.Text = "perc";
            // 
            // txtPercentD
            // 
            this.txtPercentD.AutoSize = true;
            this.txtPercentD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPercentD.Location = new System.Drawing.Point(416, 43);
            this.txtPercentD.Name = "txtPercentD";
            this.txtPercentD.Size = new System.Drawing.Size(36, 17);
            this.txtPercentD.TabIndex = 6;
            this.txtPercentD.Text = "perc";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Highest",
            "AboveNormal",
            "Normal",
            "BelowNormal",
            "Lowest"});
            this.comboBox1.Location = new System.Drawing.Point(289, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtDeadline
            // 
            this.txtDeadline.AutoSize = true;
            this.txtDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDeadline.Location = new System.Drawing.Point(95, 137);
            this.txtDeadline.Margin = new System.Windows.Forms.Padding(2, 0, 3, 0);
            this.txtDeadline.MaximumSize = new System.Drawing.Size(10000, 100);
            this.txtDeadline.Name = "txtDeadline";
            this.txtDeadline.Size = new System.Drawing.Size(114, 26);
            this.txtDeadline.TabIndex = 8;
            this.txtDeadline.Text = "PressStart";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePicker1.Location = new System.Drawing.Point(100, 166);
            this.dateTimePicker1.MinDate = new System.DateTime(2022, 3, 16, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(260, 20);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(227, 192);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Disable";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab1);
            this.tabControl1.Controls.Add(this.tab2);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(472, 449);
            this.tabControl1.TabIndex = 11;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.pbFreeSpaceC);
            this.tab1.Controls.Add(this.treeView);
            this.tab1.Controls.Add(this.txtFreeSpaceD);
            this.tab1.Controls.Add(this.txtPercentD);
            this.tab1.Controls.Add(this.txtFreeSpaceC);
            this.tab1.Controls.Add(this.pbFreeSpaceD);
            this.tab1.Controls.Add(this.txtPercentC);
            this.tab1.Controls.Add(this.comboBox1);
            this.tab1.Location = new System.Drawing.Point(4, 22);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(464, 423);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "File Manager";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.btnStart);
            this.tab2.Controls.Add(this.dateTimePicker1);
            this.tab2.Controls.Add(this.btnCancel);
            this.tab2.Controls.Add(this.txtDeadline);
            this.tab2.Location = new System.Drawing.Point(4, 22);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(464, 423);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Deadline";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(144, 192);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(84, 23);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "File Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuCopy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuRename;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuCut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemInfo;
        private System.Windows.Forms.ProgressBar pbFreeSpaceD;
        private System.Windows.Forms.Label txtFreeSpaceC;
        private System.Windows.Forms.ProgressBar pbFreeSpaceC;
        private System.Windows.Forms.Label txtFreeSpaceD;
        private System.Windows.Forms.Label txtPercentC;
        private System.Windows.Forms.Label txtPercentD;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label txtDeadline;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.Button btnStart;
    }
}

