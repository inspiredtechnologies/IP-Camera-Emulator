namespace IpCameraEmulatorStd
{
  partial class FormSettings
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
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnApply = new System.Windows.Forms.Button();
      this.chkShowSystemResourceUsage = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(216, 106);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(87, 25);
      this.btnCancel.TabIndex = 10;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnApply
      // 
      this.btnApply.Location = new System.Drawing.Point(97, 106);
      this.btnApply.Name = "btnApply";
      this.btnApply.Size = new System.Drawing.Size(87, 25);
      this.btnApply.TabIndex = 9;
      this.btnApply.Text = "Apply";
      this.btnApply.UseVisualStyleBackColor = true;
      this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
      // 
      // chkShowSystemResourceUsage
      // 
      this.chkShowSystemResourceUsage.AutoSize = true;
      this.chkShowSystemResourceUsage.Location = new System.Drawing.Point(35, 26);
      this.chkShowSystemResourceUsage.Name = "chkShowSystemResourceUsage";
      this.chkShowSystemResourceUsage.Size = new System.Drawing.Size(164, 17);
      this.chkShowSystemResourceUsage.TabIndex = 11;
      this.chkShowSystemResourceUsage.Text = "Show system resource usage";
      this.chkShowSystemResourceUsage.UseVisualStyleBackColor = true;
      // 
      // FormSettings
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(398, 152);
      this.Controls.Add(this.chkShowSystemResourceUsage);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnApply);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FormSettings";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Settings";
      this.Load += new System.EventHandler(this.FormSettings_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnApply;
    private System.Windows.Forms.CheckBox chkShowSystemResourceUsage;
  }
}