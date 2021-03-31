namespace MapControlApplication111 {
  partial class AdmitBookmarkName {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdmitBookmarkName));
      this.btnAdmit = new System.Windows.Forms.Button();
      this.tbBookmarkName = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // btnAdmit
      // 
      this.btnAdmit.BackColor = System.Drawing.Color.LightCyan;
      this.btnAdmit.FlatAppearance.BorderSize = 0;
      this.btnAdmit.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
      this.btnAdmit.ForeColor = System.Drawing.SystemColors.WindowFrame;
      this.btnAdmit.Location = new System.Drawing.Point(342, 123);
      this.btnAdmit.Margin = new System.Windows.Forms.Padding(4);
      this.btnAdmit.Name = "btnAdmit";
      this.btnAdmit.Size = new System.Drawing.Size(100, 38);
      this.btnAdmit.TabIndex = 0;
      this.btnAdmit.Text = "添加";
      this.btnAdmit.UseVisualStyleBackColor = false;
      this.btnAdmit.Click += new System.EventHandler(this.btnAdmit_Click);
      // 
      // tbBookmarkName
      // 
      this.tbBookmarkName.BackColor = System.Drawing.Color.LightCyan;
      this.tbBookmarkName.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
      this.tbBookmarkName.Location = new System.Drawing.Point(107, 129);
      this.tbBookmarkName.Margin = new System.Windows.Forms.Padding(6);
      this.tbBookmarkName.Name = "tbBookmarkName";
      this.tbBookmarkName.Size = new System.Drawing.Size(193, 29);
      this.tbBookmarkName.TabIndex = 1;
      this.tbBookmarkName.Text = "默认书签";
      // 
      // AdmitBookmarkName
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.MenuHighlight;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(562, 303);
      this.Controls.Add(this.tbBookmarkName);
      this.Controls.Add(this.btnAdmit);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "AdmitBookmarkName";
      this.Text = "添加书签";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnAdmit;
    private System.Windows.Forms.TextBox tbBookmarkName;
  }
}