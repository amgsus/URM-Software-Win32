namespace URM
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.sp = new System.IO.Ports.SerialPort(this.components);
            this.bg = new System.ComponentModel.BackgroundWorker();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPort = new System.Windows.Forms.ToolStripMenuItem();
            this.mniPortClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mniPortCloseSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.workspaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniWorkspaceNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mniWorkspaceReload = new System.Windows.Forms.ToolStripMenuItem();
            this.mniWorkspaceSave = new System.Windows.Forms.ToolStripMenuItem();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.grpO1 = new System.Windows.Forms.GroupBox();
            this.txtHintO1 = new System.Windows.Forms.TextBox();
            this.chkO1 = new System.Windows.Forms.CheckBox();
            this.grpO3 = new System.Windows.Forms.GroupBox();
            this.txtHintO3 = new System.Windows.Forms.TextBox();
            this.chkO3 = new System.Windows.Forms.CheckBox();
            this.grpO2 = new System.Windows.Forms.GroupBox();
            this.txtHintO2 = new System.Windows.Forms.TextBox();
            this.chkO2 = new System.Windows.Forms.CheckBox();
            this.grpO4 = new System.Windows.Forms.GroupBox();
            this.txtHintO4 = new System.Windows.Forms.TextBox();
            this.chkO4 = new System.Windows.Forms.CheckBox();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.grpI4 = new System.Windows.Forms.GroupBox();
            this.lblI4 = new System.Windows.Forms.Label();
            this.txtHintI4 = new System.Windows.Forms.TextBox();
            this.grpI2 = new System.Windows.Forms.GroupBox();
            this.lblI2 = new System.Windows.Forms.Label();
            this.txtHintI2 = new System.Windows.Forms.TextBox();
            this.grpI3 = new System.Windows.Forms.GroupBox();
            this.lblI3 = new System.Windows.Forms.Label();
            this.txtHintI3 = new System.Windows.Forms.TextBox();
            this.grpI1 = new System.Windows.Forms.GroupBox();
            this.lblI1 = new System.Windows.Forms.Label();
            this.txtHintI1 = new System.Windows.Forms.TextBox();
            this.tim = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.grpO1.SuspendLayout();
            this.grpO3.SuspendLayout();
            this.grpO2.SuspendLayout();
            this.grpO4.SuspendLayout();
            this.grpI4.SuspendLayout();
            this.grpI2.SuspendLayout();
            this.grpI3.SuspendLayout();
            this.grpI1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sp
            // 
            this.sp.ReadTimeout = 2500;
            // 
            // bg
            // 
            this.bg.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bg_DoWork);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mnuPort,
            this.workspaceToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(809, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(92, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // mnuPort
            // 
            this.mnuPort.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniPortClose,
            this.mniPortCloseSeparator});
            this.mnuPort.Name = "mnuPort";
            this.mnuPort.Size = new System.Drawing.Size(41, 20);
            this.mnuPort.Text = "Port";
            this.mnuPort.DropDownOpening += new System.EventHandler(this.mnuPort_DropDownOpening);
            // 
            // mniPortClose
            // 
            this.mniPortClose.Name = "mniPortClose";
            this.mniPortClose.Size = new System.Drawing.Size(103, 22);
            this.mniPortClose.Text = "Close";
            this.mniPortClose.Click += new System.EventHandler(this.mniPortClose_Click);
            // 
            // mniPortCloseSeparator
            // 
            this.mniPortCloseSeparator.Name = "mniPortCloseSeparator";
            this.mniPortCloseSeparator.Size = new System.Drawing.Size(100, 6);
            // 
            // workspaceToolStripMenuItem
            // 
            this.workspaceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniWorkspaceNew,
            this.mniWorkspaceReload,
            this.mniWorkspaceSave});
            this.workspaceToolStripMenuItem.Name = "workspaceToolStripMenuItem";
            this.workspaceToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.workspaceToolStripMenuItem.Text = "Workspace";
            // 
            // mniWorkspaceNew
            // 
            this.mniWorkspaceNew.Name = "mniWorkspaceNew";
            this.mniWorkspaceNew.Size = new System.Drawing.Size(110, 22);
            this.mniWorkspaceNew.Text = "New";
            this.mniWorkspaceNew.Click += new System.EventHandler(this.mniWorkspaceNew_Click);
            // 
            // mniWorkspaceReload
            // 
            this.mniWorkspaceReload.Name = "mniWorkspaceReload";
            this.mniWorkspaceReload.Size = new System.Drawing.Size(110, 22);
            this.mniWorkspaceReload.Text = "Reload";
            this.mniWorkspaceReload.DropDownOpening += new System.EventHandler(this.mniWorkspaceReload_DropDownOpening);
            this.mniWorkspaceReload.Click += new System.EventHandler(this.mniWorkspaceReload_Click);
            // 
            // mniWorkspaceSave
            // 
            this.mniWorkspaceSave.Name = "mniWorkspaceSave";
            this.mniWorkspaceSave.Size = new System.Drawing.Size(110, 22);
            this.mniWorkspaceSave.Text = "Save";
            this.mniWorkspaceSave.Click += new System.EventHandler(this.mniWorkspaceSave_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(504, 32);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(296, 328);
            this.txtLog.TabIndex = 1;
            // 
            // grpO1
            // 
            this.grpO1.Controls.Add(this.txtHintO1);
            this.grpO1.Controls.Add(this.chkO1);
            this.grpO1.Location = new System.Drawing.Point(8, 32);
            this.grpO1.Name = "grpO1";
            this.grpO1.Size = new System.Drawing.Size(240, 80);
            this.grpO1.TabIndex = 2;
            this.grpO1.TabStop = false;
            this.grpO1.Text = "Output 1";
            // 
            // txtHintO1
            // 
            this.txtHintO1.Location = new System.Drawing.Point(16, 48);
            this.txtHintO1.Name = "txtHintO1";
            this.txtHintO1.Size = new System.Drawing.Size(208, 20);
            this.txtHintO1.TabIndex = 1;
            // 
            // chkO1
            // 
            this.chkO1.AutoSize = true;
            this.chkO1.Location = new System.Drawing.Point(16, 24);
            this.chkO1.Name = "chkO1";
            this.chkO1.Size = new System.Drawing.Size(65, 17);
            this.chkO1.TabIndex = 0;
            this.chkO1.Text = "Activate";
            this.chkO1.UseVisualStyleBackColor = true;
            this.chkO1.CheckedChanged += new System.EventHandler(this.chkO1_CheckedChanged);
            // 
            // grpO3
            // 
            this.grpO3.Controls.Add(this.txtHintO3);
            this.grpO3.Controls.Add(this.chkO3);
            this.grpO3.Location = new System.Drawing.Point(8, 120);
            this.grpO3.Name = "grpO3";
            this.grpO3.Size = new System.Drawing.Size(240, 80);
            this.grpO3.TabIndex = 3;
            this.grpO3.TabStop = false;
            this.grpO3.Text = "Output 3";
            // 
            // txtHintO3
            // 
            this.txtHintO3.Location = new System.Drawing.Point(16, 48);
            this.txtHintO3.Name = "txtHintO3";
            this.txtHintO3.Size = new System.Drawing.Size(208, 20);
            this.txtHintO3.TabIndex = 1;
            // 
            // chkO3
            // 
            this.chkO3.AutoSize = true;
            this.chkO3.Location = new System.Drawing.Point(16, 24);
            this.chkO3.Name = "chkO3";
            this.chkO3.Size = new System.Drawing.Size(65, 17);
            this.chkO3.TabIndex = 0;
            this.chkO3.Text = "Activate";
            this.chkO3.UseVisualStyleBackColor = true;
            this.chkO3.CheckedChanged += new System.EventHandler(this.chkO1_CheckedChanged);
            // 
            // grpO2
            // 
            this.grpO2.Controls.Add(this.txtHintO2);
            this.grpO2.Controls.Add(this.chkO2);
            this.grpO2.Location = new System.Drawing.Point(256, 32);
            this.grpO2.Name = "grpO2";
            this.grpO2.Size = new System.Drawing.Size(240, 80);
            this.grpO2.TabIndex = 4;
            this.grpO2.TabStop = false;
            this.grpO2.Text = "Output 2";
            // 
            // txtHintO2
            // 
            this.txtHintO2.Location = new System.Drawing.Point(16, 48);
            this.txtHintO2.Name = "txtHintO2";
            this.txtHintO2.Size = new System.Drawing.Size(208, 20);
            this.txtHintO2.TabIndex = 1;
            // 
            // chkO2
            // 
            this.chkO2.AutoSize = true;
            this.chkO2.Location = new System.Drawing.Point(16, 24);
            this.chkO2.Name = "chkO2";
            this.chkO2.Size = new System.Drawing.Size(65, 17);
            this.chkO2.TabIndex = 0;
            this.chkO2.Text = "Activate";
            this.chkO2.UseVisualStyleBackColor = true;
            this.chkO2.CheckedChanged += new System.EventHandler(this.chkO1_CheckedChanged);
            // 
            // grpO4
            // 
            this.grpO4.Controls.Add(this.txtHintO4);
            this.grpO4.Controls.Add(this.chkO4);
            this.grpO4.Location = new System.Drawing.Point(256, 120);
            this.grpO4.Name = "grpO4";
            this.grpO4.Size = new System.Drawing.Size(240, 80);
            this.grpO4.TabIndex = 5;
            this.grpO4.TabStop = false;
            this.grpO4.Text = "Output 4";
            // 
            // txtHintO4
            // 
            this.txtHintO4.Location = new System.Drawing.Point(16, 48);
            this.txtHintO4.Name = "txtHintO4";
            this.txtHintO4.Size = new System.Drawing.Size(208, 20);
            this.txtHintO4.TabIndex = 1;
            // 
            // chkO4
            // 
            this.chkO4.AutoSize = true;
            this.chkO4.Location = new System.Drawing.Point(16, 24);
            this.chkO4.Name = "chkO4";
            this.chkO4.Size = new System.Drawing.Size(65, 17);
            this.chkO4.TabIndex = 0;
            this.chkO4.Text = "Activate";
            this.chkO4.UseVisualStyleBackColor = true;
            this.chkO4.CheckedChanged += new System.EventHandler(this.chkO1_CheckedChanged);
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(503, 368);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(75, 23);
            this.btnClearLog.TabIndex = 6;
            this.btnClearLog.Text = "Clear";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // grpI4
            // 
            this.grpI4.Controls.Add(this.lblI4);
            this.grpI4.Controls.Add(this.txtHintI4);
            this.grpI4.Location = new System.Drawing.Point(256, 312);
            this.grpI4.Name = "grpI4";
            this.grpI4.Size = new System.Drawing.Size(240, 80);
            this.grpI4.TabIndex = 10;
            this.grpI4.TabStop = false;
            this.grpI4.Text = "Input 4";
            // 
            // lblI4
            // 
            this.lblI4.AutoSize = true;
            this.lblI4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblI4.ForeColor = System.Drawing.Color.Black;
            this.lblI4.Location = new System.Drawing.Point(16, 24);
            this.lblI4.Name = "lblI4";
            this.lblI4.Size = new System.Drawing.Size(53, 13);
            this.lblI4.TabIndex = 3;
            this.lblI4.Text = "Inactive";
            // 
            // txtHintI4
            // 
            this.txtHintI4.Location = new System.Drawing.Point(16, 48);
            this.txtHintI4.Name = "txtHintI4";
            this.txtHintI4.Size = new System.Drawing.Size(208, 20);
            this.txtHintI4.TabIndex = 1;
            // 
            // grpI2
            // 
            this.grpI2.Controls.Add(this.lblI2);
            this.grpI2.Controls.Add(this.txtHintI2);
            this.grpI2.Location = new System.Drawing.Point(256, 224);
            this.grpI2.Name = "grpI2";
            this.grpI2.Size = new System.Drawing.Size(240, 80);
            this.grpI2.TabIndex = 9;
            this.grpI2.TabStop = false;
            this.grpI2.Text = "Input 2";
            // 
            // lblI2
            // 
            this.lblI2.AutoSize = true;
            this.lblI2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblI2.ForeColor = System.Drawing.Color.Black;
            this.lblI2.Location = new System.Drawing.Point(16, 24);
            this.lblI2.Name = "lblI2";
            this.lblI2.Size = new System.Drawing.Size(53, 13);
            this.lblI2.TabIndex = 3;
            this.lblI2.Text = "Inactive";
            // 
            // txtHintI2
            // 
            this.txtHintI2.Location = new System.Drawing.Point(16, 48);
            this.txtHintI2.Name = "txtHintI2";
            this.txtHintI2.Size = new System.Drawing.Size(208, 20);
            this.txtHintI2.TabIndex = 1;
            // 
            // grpI3
            // 
            this.grpI3.Controls.Add(this.lblI3);
            this.grpI3.Controls.Add(this.txtHintI3);
            this.grpI3.Location = new System.Drawing.Point(8, 312);
            this.grpI3.Name = "grpI3";
            this.grpI3.Size = new System.Drawing.Size(240, 80);
            this.grpI3.TabIndex = 8;
            this.grpI3.TabStop = false;
            this.grpI3.Text = "Input 3";
            // 
            // lblI3
            // 
            this.lblI3.AutoSize = true;
            this.lblI3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblI3.ForeColor = System.Drawing.Color.Black;
            this.lblI3.Location = new System.Drawing.Point(16, 24);
            this.lblI3.Name = "lblI3";
            this.lblI3.Size = new System.Drawing.Size(53, 13);
            this.lblI3.TabIndex = 3;
            this.lblI3.Text = "Inactive";
            // 
            // txtHintI3
            // 
            this.txtHintI3.Location = new System.Drawing.Point(16, 48);
            this.txtHintI3.Name = "txtHintI3";
            this.txtHintI3.Size = new System.Drawing.Size(208, 20);
            this.txtHintI3.TabIndex = 1;
            // 
            // grpI1
            // 
            this.grpI1.Controls.Add(this.lblI1);
            this.grpI1.Controls.Add(this.txtHintI1);
            this.grpI1.Location = new System.Drawing.Point(8, 224);
            this.grpI1.Name = "grpI1";
            this.grpI1.Size = new System.Drawing.Size(240, 80);
            this.grpI1.TabIndex = 7;
            this.grpI1.TabStop = false;
            this.grpI1.Text = "Input 1";
            // 
            // lblI1
            // 
            this.lblI1.AutoSize = true;
            this.lblI1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblI1.ForeColor = System.Drawing.Color.Black;
            this.lblI1.Location = new System.Drawing.Point(16, 24);
            this.lblI1.Name = "lblI1";
            this.lblI1.Size = new System.Drawing.Size(53, 13);
            this.lblI1.TabIndex = 2;
            this.lblI1.Text = "Inactive";
            // 
            // txtHintI1
            // 
            this.txtHintI1.Location = new System.Drawing.Point(16, 48);
            this.txtHintI1.Name = "txtHintI1";
            this.txtHintI1.Size = new System.Drawing.Size(208, 20);
            this.txtHintI1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 401);
            this.Controls.Add(this.grpI4);
            this.Controls.Add(this.grpI2);
            this.Controls.Add(this.grpI3);
            this.Controls.Add(this.grpI1);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.grpO4);
            this.Controls.Add(this.grpO2);
            this.Controls.Add(this.grpO3);
            this.Controls.Add(this.grpO1);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USB Relay Module";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.grpO1.ResumeLayout(false);
            this.grpO1.PerformLayout();
            this.grpO3.ResumeLayout(false);
            this.grpO3.PerformLayout();
            this.grpO2.ResumeLayout(false);
            this.grpO2.PerformLayout();
            this.grpO4.ResumeLayout(false);
            this.grpO4.PerformLayout();
            this.grpI4.ResumeLayout(false);
            this.grpI4.PerformLayout();
            this.grpI2.ResumeLayout(false);
            this.grpI2.PerformLayout();
            this.grpI3.ResumeLayout(false);
            this.grpI3.PerformLayout();
            this.grpI1.ResumeLayout(false);
            this.grpI1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort sp;
        private System.ComponentModel.BackgroundWorker bg;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuPort;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.ToolStripMenuItem mniPortClose;
        private System.Windows.Forms.ToolStripSeparator mniPortCloseSeparator;
        private System.Windows.Forms.GroupBox grpO1;
        private System.Windows.Forms.TextBox txtHintO1;
        private System.Windows.Forms.CheckBox chkO1;
        private System.Windows.Forms.GroupBox grpO3;
        private System.Windows.Forms.TextBox txtHintO3;
        private System.Windows.Forms.CheckBox chkO3;
        private System.Windows.Forms.GroupBox grpO2;
        private System.Windows.Forms.TextBox txtHintO2;
        private System.Windows.Forms.CheckBox chkO2;
        private System.Windows.Forms.GroupBox grpO4;
        private System.Windows.Forms.TextBox txtHintO4;
        private System.Windows.Forms.CheckBox chkO4;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.GroupBox grpI4;
        private System.Windows.Forms.TextBox txtHintI4;
        private System.Windows.Forms.GroupBox grpI2;
        private System.Windows.Forms.TextBox txtHintI2;
        private System.Windows.Forms.GroupBox grpI3;
        private System.Windows.Forms.TextBox txtHintI3;
        private System.Windows.Forms.GroupBox grpI1;
        private System.Windows.Forms.TextBox txtHintI1;
        private System.Windows.Forms.Label lblI1;
        private System.Windows.Forms.Label lblI4;
        private System.Windows.Forms.Label lblI2;
        private System.Windows.Forms.Label lblI3;
        private System.Windows.Forms.ToolStripMenuItem workspaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniWorkspaceNew;
        private System.Windows.Forms.ToolStripMenuItem mniWorkspaceReload;
        private System.Windows.Forms.ToolStripMenuItem mniWorkspaceSave;
        private System.Windows.Forms.Timer tim;
    }
}

