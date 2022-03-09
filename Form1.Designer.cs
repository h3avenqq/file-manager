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
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.ContextMenuStrip = this.contextMenuStrip;
            this.treeView.Location = new System.Drawing.Point(3, 95);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(470, 343);
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
            this.pbFreeSpaceC.Location = new System.Drawing.Point(172, 13);
            this.pbFreeSpaceC.Name = "pbFreeSpaceC";
            this.pbFreeSpaceC.Size = new System.Drawing.Size(242, 23);
            this.pbFreeSpaceC.TabIndex = 1;
            // 
            // pbFreeSpaceD
            // 
            this.pbFreeSpaceD.Location = new System.Drawing.Point(172, 42);
            this.pbFreeSpaceD.Name = "pbFreeSpaceD";
            this.pbFreeSpaceD.Size = new System.Drawing.Size(242, 23);
            this.pbFreeSpaceD.TabIndex = 2;
            // 
            // txtFreeSpaceC
            // 
            this.txtFreeSpaceC.AutoSize = true;
            this.txtFreeSpaceC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFreeSpaceC.Location = new System.Drawing.Point(-1, 16);
            this.txtFreeSpaceC.MaximumSize = new System.Drawing.Size(200, 50);
            this.txtFreeSpaceC.Name = "txtFreeSpaceC";
            this.txtFreeSpaceC.Size = new System.Drawing.Size(0, 20);
            this.txtFreeSpaceC.TabIndex = 3;
            // 
            // txtFreeSpaceD
            // 
            this.txtFreeSpaceD.AutoSize = true;
            this.txtFreeSpaceD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFreeSpaceD.Location = new System.Drawing.Point(-1, 42);
            this.txtFreeSpaceD.MaximumSize = new System.Drawing.Size(200, 50);
            this.txtFreeSpaceD.Name = "txtFreeSpaceD";
            this.txtFreeSpaceD.Size = new System.Drawing.Size(0, 20);
            this.txtFreeSpaceD.TabIndex = 4;
            // 
            // txtPercentC
            // 
            this.txtPercentC.AutoSize = true;
            this.txtPercentC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPercentC.Location = new System.Drawing.Point(420, 13);
            this.txtPercentC.Name = "txtPercentC";
            this.txtPercentC.Size = new System.Drawing.Size(0, 17);
            this.txtPercentC.TabIndex = 5;
            // 
            // txtPercentD
            // 
            this.txtPercentD.AutoSize = true;
            this.txtPercentD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPercentD.Location = new System.Drawing.Point(420, 42);
            this.txtPercentD.Name = "txtPercentD";
            this.txtPercentD.Size = new System.Drawing.Size(0, 17);
            this.txtPercentD.TabIndex = 6;
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
            this.comboBox1.Location = new System.Drawing.Point(231, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtPercentD);
            this.Controls.Add(this.txtPercentC);
            this.Controls.Add(this.txtFreeSpaceD);
            this.Controls.Add(this.txtFreeSpaceC);
            this.Controls.Add(this.pbFreeSpaceD);
            this.Controls.Add(this.pbFreeSpaceC);
            this.Controls.Add(this.treeView);
            this.Name = "Form1";
            this.Text = "File Manager";
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

