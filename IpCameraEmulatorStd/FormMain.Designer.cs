namespace IpCameraEmulatorStd
{
  partial class FormMain
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
      this.tsMain = new System.Windows.Forms.ToolStrip();
      this.tbAdd = new System.Windows.Forms.ToolStripButton();
      this.tbEdit = new System.Windows.Forms.ToolStripButton();
      this.tbDelete = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.tbSettings = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.tbStart = new System.Windows.Forms.ToolStripButton();
      this.tssbInfo = new System.Windows.Forms.ToolStripSplitButton();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.tmrGetStatus = new System.Windows.Forms.Timer(this.components);
      this.cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.channelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmiEnableChannel = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmiDisableChannel = new System.Windows.Forms.ToolStripMenuItem();
      this.statusStripMain = new System.Windows.Forms.StatusStrip();
      this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
      this.tsslCpuLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.tsslCpuUsage = new System.Windows.Forms.ToolStripStatusLabel();
      this.tsslMemLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.tsslMemoryUsage = new System.Windows.Forms.ToolStripStatusLabel();
      this.tsslNetLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.tsslNwUsage = new System.Windows.Forms.ToolStripStatusLabel();
      this.lvMain = new System.Windows.Forms.ListView();
      this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.tsMain.SuspendLayout();
      this.cmsMain.SuspendLayout();
      this.statusStripMain.SuspendLayout();
      this.SuspendLayout();
      // 
      // tsMain
      // 
      this.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
      this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbAdd,
            this.tbEdit,
            this.tbDelete,
            this.toolStripSeparator1,
            this.tbSettings,
            this.toolStripSeparator2,
            this.tbStart,
            this.tssbInfo});
      this.tsMain.Location = new System.Drawing.Point(0, 0);
      this.tsMain.Name = "tsMain";
      this.tsMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
      this.tsMain.Size = new System.Drawing.Size(982, 46);
      this.tsMain.TabIndex = 0;
      this.tsMain.Text = "toolStrip1";
      // 
      // tbAdd
      // 
      this.tbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tbAdd.Image")));
      this.tbAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.tbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tbAdd.Name = "tbAdd";
      this.tbAdd.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
      this.tbAdd.Size = new System.Drawing.Size(45, 43);
      this.tbAdd.Text = " Add ";
      this.tbAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.tbAdd.ToolTipText = "Add Channel";
      this.tbAdd.Click += new System.EventHandler(this.tbAdd_Click);
      // 
      // tbEdit
      // 
      this.tbEdit.Enabled = false;
      this.tbEdit.Image = ((System.Drawing.Image)(resources.GetObject("tbEdit.Image")));
      this.tbEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.tbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tbEdit.Name = "tbEdit";
      this.tbEdit.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
      this.tbEdit.Size = new System.Drawing.Size(43, 43);
      this.tbEdit.Text = " Edit ";
      this.tbEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.tbEdit.ToolTipText = "Edit Channel Properties";
      this.tbEdit.Click += new System.EventHandler(this.tbEdit_Click);
      // 
      // tbDelete
      // 
      this.tbDelete.Enabled = false;
      this.tbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tbDelete.Image")));
      this.tbDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.tbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tbDelete.Name = "tbDelete";
      this.tbDelete.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
      this.tbDelete.Size = new System.Drawing.Size(50, 43);
      this.tbDelete.Text = "Delete";
      this.tbDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.tbDelete.ToolTipText = "Delete Channel";
      this.tbDelete.Click += new System.EventHandler(this.tbDelete_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 46);
      // 
      // tbSettings
      // 
      this.tbSettings.Image = ((System.Drawing.Image)(resources.GetObject("tbSettings.Image")));
      this.tbSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.tbSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tbSettings.Name = "tbSettings";
      this.tbSettings.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
      this.tbSettings.Size = new System.Drawing.Size(59, 43);
      this.tbSettings.Text = "Settings";
      this.tbSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.tbSettings.ToolTipText = "Settings";
      this.tbSettings.Click += new System.EventHandler(this.tbSettings_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(6, 46);
      // 
      // tbStart
      // 
      this.tbStart.Image = ((System.Drawing.Image)(resources.GetObject("tbStart.Image")));
      this.tbStart.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.tbStart.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tbStart.Name = "tbStart";
      this.tbStart.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
      this.tbStart.Size = new System.Drawing.Size(41, 43);
      this.tbStart.Tag = "false";
      this.tbStart.Text = "Start";
      this.tbStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.tbStart.ToolTipText = "Start Emulator Service";
      this.tbStart.Click += new System.EventHandler(this.tbStart_Click);
      // 
      // tssbInfo
      // 
      this.tssbInfo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.tssbInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
      this.tssbInfo.Image = ((System.Drawing.Image)(resources.GetObject("tssbInfo.Image")));
      this.tssbInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.tssbInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tssbInfo.Name = "tssbInfo";
      this.tssbInfo.Size = new System.Drawing.Size(44, 43);
      this.tssbInfo.Text = "Info";
      this.tssbInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.tssbInfo.ButtonClick += new System.EventHandler(this.tssbInfo_ButtonClick);
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
      this.aboutToolStripMenuItem.Text = "About...";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
      // 
      // tmrGetStatus
      // 
      this.tmrGetStatus.Interval = 1000;
      this.tmrGetStatus.Tick += new System.EventHandler(this.tmrGetStatus_Tick);
      // 
      // cmsMain
      // 
      this.cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.channelToolStripMenuItem});
      this.cmsMain.Name = "cmsMain";
      this.cmsMain.Size = new System.Drawing.Size(119, 26);
      // 
      // channelToolStripMenuItem
      // 
      this.channelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEnableChannel,
            this.tsmiDisableChannel});
      this.channelToolStripMenuItem.Name = "channelToolStripMenuItem";
      this.channelToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
      this.channelToolStripMenuItem.Text = "Channel";
      // 
      // tsmiEnableChannel
      // 
      this.tsmiEnableChannel.Name = "tsmiEnableChannel";
      this.tsmiEnableChannel.Size = new System.Drawing.Size(112, 22);
      this.tsmiEnableChannel.Text = "Enable";
      this.tsmiEnableChannel.Click += new System.EventHandler(this.tsmiEnableChannel_Click);
      // 
      // tsmiDisableChannel
      // 
      this.tsmiDisableChannel.Name = "tsmiDisableChannel";
      this.tsmiDisableChannel.Size = new System.Drawing.Size(112, 22);
      this.tsmiDisableChannel.Text = "Disable";
      this.tsmiDisableChannel.Click += new System.EventHandler(this.tsmiDisableChannel_Click);
      // 
      // statusStripMain
      // 
      this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus,
            this.tsslCpuLabel,
            this.tsslCpuUsage,
            this.tsslMemLabel,
            this.tsslMemoryUsage,
            this.tsslNetLabel,
            this.tsslNwUsage});
      this.statusStripMain.Location = new System.Drawing.Point(0, 334);
      this.statusStripMain.Name = "statusStripMain";
      this.statusStripMain.Size = new System.Drawing.Size(982, 23);
      this.statusStripMain.TabIndex = 3;
      this.statusStripMain.Text = "statusStripMain";
      // 
      // tsslStatus
      // 
      this.tsslStatus.Name = "tsslStatus";
      this.tsslStatus.Size = new System.Drawing.Size(715, 18);
      this.tsslStatus.Spring = true;
      // 
      // tsslCpuLabel
      // 
      this.tsslCpuLabel.Name = "tsslCpuLabel";
      this.tsslCpuLabel.Size = new System.Drawing.Size(33, 18);
      this.tsslCpuLabel.Text = "CPU:";
      // 
      // tsslCpuUsage
      // 
      this.tsslCpuUsage.AutoSize = false;
      this.tsslCpuUsage.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
      this.tsslCpuUsage.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
      this.tsslCpuUsage.Name = "tsslCpuUsage";
      this.tsslCpuUsage.Size = new System.Drawing.Size(50, 18);
      this.tsslCpuUsage.Text = "      ";
      this.tsslCpuUsage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // tsslMemLabel
      // 
      this.tsslMemLabel.Name = "tsslMemLabel";
      this.tsslMemLabel.Size = new System.Drawing.Size(38, 18);
      this.tsslMemLabel.Text = "MEM:";
      // 
      // tsslMemoryUsage
      // 
      this.tsslMemoryUsage.AutoSize = false;
      this.tsslMemoryUsage.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
      this.tsslMemoryUsage.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
      this.tsslMemoryUsage.Name = "tsslMemoryUsage";
      this.tsslMemoryUsage.Size = new System.Drawing.Size(50, 18);
      this.tsslMemoryUsage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // tsslNetLabel
      // 
      this.tsslNetLabel.Name = "tsslNetLabel";
      this.tsslNetLabel.Size = new System.Drawing.Size(31, 18);
      this.tsslNetLabel.Text = "NET:";
      // 
      // tsslNwUsage
      // 
      this.tsslNwUsage.AutoSize = false;
      this.tsslNwUsage.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
      this.tsslNwUsage.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
      this.tsslNwUsage.Name = "tsslNwUsage";
      this.tsslNwUsage.Size = new System.Drawing.Size(50, 18);
      this.tsslNwUsage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lvMain
      // 
      this.lvMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader6,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
      this.lvMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lvMain.FullRowSelect = true;
      this.lvMain.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
      this.lvMain.HideSelection = false;
      this.lvMain.Location = new System.Drawing.Point(0, 46);
      this.lvMain.Name = "lvMain";
      this.lvMain.Size = new System.Drawing.Size(982, 288);
      this.lvMain.TabIndex = 4;
      this.lvMain.UseCompatibleStateImageBehavior = false;
      this.lvMain.View = System.Windows.Forms.View.Details;
      this.lvMain.SelectedIndexChanged += new System.EventHandler(this.lvMain_SelectedIndexChanged);
      this.lvMain.DoubleClick += new System.EventHandler(this.lvMain_DoubleClick);
      this.lvMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvMain_MouseClick);
      // 
      // columnHeader1
      // 
      this.columnHeader1.Text = "Channel";
      this.columnHeader1.Width = 65;
      // 
      // columnHeader6
      // 
      this.columnHeader6.Text = "Name";
      this.columnHeader6.Width = 123;
      // 
      // columnHeader2
      // 
      this.columnHeader2.Text = "Video File";
      this.columnHeader2.Width = 321;
      // 
      // columnHeader3
      // 
      this.columnHeader3.Text = "Port";
      this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.columnHeader3.Width = 83;
      // 
      // columnHeader4
      // 
      this.columnHeader4.Text = "Enabled";
      this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.columnHeader4.Width = 78;
      // 
      // columnHeader5
      // 
      this.columnHeader5.Text = "Status";
      this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.columnHeader5.Width = 134;
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(982, 357);
      this.Controls.Add(this.lvMain);
      this.Controls.Add(this.statusStripMain);
      this.Controls.Add(this.tsMain);
      this.DoubleBuffered = true;
      this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FormMain";
      this.Text = "IP Camera Emulator";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
      this.Load += new System.EventHandler(this.FormMain_Load);
      this.Shown += new System.EventHandler(this.FormMain_Shown);
      this.tsMain.ResumeLayout(false);
      this.tsMain.PerformLayout();
      this.cmsMain.ResumeLayout(false);
      this.statusStripMain.ResumeLayout(false);
      this.statusStripMain.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolStrip tsMain;
    private System.Windows.Forms.ToolStripButton tbAdd;
    private System.Windows.Forms.ToolStripButton tbEdit;
    private System.Windows.Forms.ToolStripButton tbDelete;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripButton tbSettings;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripButton tbStart;
    private System.Windows.Forms.Timer tmrGetStatus;
    private System.Windows.Forms.ContextMenuStrip cmsMain;
    private System.Windows.Forms.ToolStripMenuItem channelToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem tsmiEnableChannel;
    private System.Windows.Forms.ToolStripMenuItem tsmiDisableChannel;
    private System.Windows.Forms.StatusStrip statusStripMain;
    private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
    private System.Windows.Forms.ToolStripStatusLabel tsslCpuLabel;
    private System.Windows.Forms.ToolStripStatusLabel tsslCpuUsage;
    private System.Windows.Forms.ToolStripStatusLabel tsslMemLabel;
    private System.Windows.Forms.ToolStripStatusLabel tsslMemoryUsage;
    private System.Windows.Forms.ToolStripStatusLabel tsslNetLabel;
    private System.Windows.Forms.ToolStripStatusLabel tsslNwUsage;
    private System.Windows.Forms.ListView lvMain;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader6;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.ColumnHeader columnHeader3;
    private System.Windows.Forms.ColumnHeader columnHeader4;
    private System.Windows.Forms.ColumnHeader columnHeader5;
    private System.Windows.Forms.ToolStripSplitButton tssbInfo;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
  }
}

