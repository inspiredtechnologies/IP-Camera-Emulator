namespace IpCameraEmulatorStd
{
  partial class FormChannel
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
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.chkChannelEnabled = new System.Windows.Forms.CheckBox();
      this.lblBatchAddition = new System.Windows.Forms.Label();
      this.updChannelQty = new System.Windows.Forms.NumericUpDown();
      this.txtVideoFilePath = new System.Windows.Forms.TextBox();
      this.updRtspPort = new System.Windows.Forms.NumericUpDown();
      this.btnBrowse = new System.Windows.Forms.Button();
      this.txtChannelName = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txtChannelIndex = new System.Windows.Forms.TextBox();
      this.lblChannelIndex = new System.Windows.Forms.Label();
      this.btnAdd = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.toolTips = new System.Windows.Forms.ToolTip(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.updChannelQty)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.updRtspPort)).BeginInit();
      this.SuspendLayout();
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(42, 110);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(61, 15);
      this.label3.TabIndex = 2;
      this.label3.Text = "Video File:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(36, 149);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(62, 15);
      this.label4.TabIndex = 3;
      this.label4.Text = "RTSP Port:";
      // 
      // chkChannelEnabled
      // 
      this.chkChannelEnabled.AutoSize = true;
      this.chkChannelEnabled.Checked = true;
      this.chkChannelEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chkChannelEnabled.Location = new System.Drawing.Point(114, 193);
      this.chkChannelEnabled.Name = "chkChannelEnabled";
      this.chkChannelEnabled.Size = new System.Drawing.Size(68, 19);
      this.chkChannelEnabled.TabIndex = 6;
      this.chkChannelEnabled.Text = "Enabled";
      this.chkChannelEnabled.UseVisualStyleBackColor = true;
      // 
      // lblBatchAddition
      // 
      this.lblBatchAddition.AutoSize = true;
      this.lblBatchAddition.Location = new System.Drawing.Point(241, 28);
      this.lblBatchAddition.Name = "lblBatchAddition";
      this.lblBatchAddition.Size = new System.Drawing.Size(89, 15);
      this.lblBatchAddition.TabIndex = 5;
      this.lblBatchAddition.Text = "Batch Addition:";
      // 
      // updChannelQty
      // 
      this.updChannelQty.Location = new System.Drawing.Point(336, 24);
      this.updChannelQty.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.updChannelQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.updChannelQty.Name = "updChannelQty";
      this.updChannelQty.Size = new System.Drawing.Size(65, 23);
      this.updChannelQty.TabIndex = 1;
      this.updChannelQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.toolTips.SetToolTip(this.updChannelQty, "Add more than one channel at a time");
      this.updChannelQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // txtVideoFilePath
      // 
      this.txtVideoFilePath.Location = new System.Drawing.Point(114, 106);
      this.txtVideoFilePath.MaxLength = 255;
      this.txtVideoFilePath.Name = "txtVideoFilePath";
      this.txtVideoFilePath.Size = new System.Drawing.Size(251, 23);
      this.txtVideoFilePath.TabIndex = 3;
      // 
      // updRtspPort
      // 
      this.updRtspPort.Location = new System.Drawing.Point(114, 147);
      this.updRtspPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
      this.updRtspPort.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
      this.updRtspPort.Name = "updRtspPort";
      this.updRtspPort.Size = new System.Drawing.Size(87, 23);
      this.updRtspPort.TabIndex = 5;
      this.updRtspPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.toolTips.SetToolTip(this.updRtspPort, "Each channel requires a unique RTSP server port");
      this.updRtspPort.Value = new decimal(new int[] {
            8554,
            0,
            0,
            0});
      this.updRtspPort.ValueChanged += new System.EventHandler(this.updRtspPort_ValueChanged);
      // 
      // btnBrowse
      // 
      this.btnBrowse.Location = new System.Drawing.Point(373, 104);
      this.btnBrowse.Name = "btnBrowse";
      this.btnBrowse.Size = new System.Drawing.Size(36, 27);
      this.btnBrowse.TabIndex = 4;
      this.btnBrowse.Text = "...";
      this.btnBrowse.UseVisualStyleBackColor = true;
      this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
      // 
      // txtChannelName
      // 
      this.txtChannelName.Location = new System.Drawing.Point(114, 63);
      this.txtChannelName.MaxLength = 32;
      this.txtChannelName.Name = "txtChannelName";
      this.txtChannelName.Size = new System.Drawing.Size(251, 23);
      this.txtChannelName.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(14, 67);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(89, 15);
      this.label1.TabIndex = 11;
      this.label1.Text = "Channel Name:";
      // 
      // txtChannelIndex
      // 
      this.txtChannelIndex.Location = new System.Drawing.Point(114, 24);
      this.txtChannelIndex.MaxLength = 4;
      this.txtChannelIndex.Name = "txtChannelIndex";
      this.txtChannelIndex.Size = new System.Drawing.Size(88, 23);
      this.txtChannelIndex.TabIndex = 0;
      // 
      // lblChannelIndex
      // 
      this.lblChannelIndex.AutoSize = true;
      this.lblChannelIndex.Location = new System.Drawing.Point(16, 28);
      this.lblChannelIndex.Name = "lblChannelIndex";
      this.lblChannelIndex.Size = new System.Drawing.Size(85, 15);
      this.lblChannelIndex.TabIndex = 13;
      this.lblChannelIndex.Text = "Channel Index:";
      // 
      // btnAdd
      // 
      this.btnAdd.Location = new System.Drawing.Point(114, 252);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(87, 27);
      this.btnAdd.TabIndex = 7;
      this.btnAdd.Text = "Add";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(233, 252);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(87, 27);
      this.btnCancel.TabIndex = 8;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      // 
      // FormChannel
      // 
      this.AcceptButton = this.btnAdd;
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(429, 302);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnAdd);
      this.Controls.Add(this.txtChannelIndex);
      this.Controls.Add(this.lblChannelIndex);
      this.Controls.Add(this.txtChannelName);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnBrowse);
      this.Controls.Add(this.updRtspPort);
      this.Controls.Add(this.txtVideoFilePath);
      this.Controls.Add(this.updChannelQty);
      this.Controls.Add(this.lblBatchAddition);
      this.Controls.Add(this.chkChannelEnabled);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FormChannel";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Add Channel";
      this.Load += new System.EventHandler(this.FormChannel_Load);
      this.Shown += new System.EventHandler(this.FormChannel_Shown);
      ((System.ComponentModel.ISupportInitialize)(this.updChannelQty)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.updRtspPort)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.CheckBox chkChannelEnabled;
    private System.Windows.Forms.Label lblBatchAddition;
    private System.Windows.Forms.NumericUpDown updChannelQty;
    private System.Windows.Forms.TextBox txtVideoFilePath;
    private System.Windows.Forms.NumericUpDown updRtspPort;
    private System.Windows.Forms.Button btnBrowse;
    private System.Windows.Forms.TextBox txtChannelName;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtChannelIndex;
    private System.Windows.Forms.Label lblChannelIndex;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.OpenFileDialog openFileDialog;
    private System.Windows.Forms.ToolTip toolTips;
  }
}