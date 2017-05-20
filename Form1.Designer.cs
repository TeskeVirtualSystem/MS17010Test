namespace MS17010Test
{
  partial class Form1
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.label1 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.testIpBox = new System.Windows.Forms.TextBox();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.resultLabel = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(12, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(490, 141);
      this.label1.TabIndex = 0;
      this.label1.Text = global::MS17010Test.strings.notice;
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(12, 171);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(193, 23);
      this.button1.TabIndex = 1;
      this.button1.Text = global::MS17010Test.strings.buttonTestMe;
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(353, 171);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(149, 23);
      this.button2.TabIndex = 2;
      this.button2.Text = global::MS17010Test.strings.buttonTestOtherIP;
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // testIpBox
      // 
      this.testIpBox.Location = new System.Drawing.Point(247, 173);
      this.testIpBox.Name = "testIpBox";
      this.testIpBox.Size = new System.Drawing.Size(100, 20);
      this.testIpBox.TabIndex = 3;
      this.testIpBox.Text = "127.0.0.1";
      // 
      // progressBar1
      // 
      this.progressBar1.Dock = System.Windows.Forms.DockStyle.Top;
      this.progressBar1.Location = new System.Drawing.Point(0, 0);
      this.progressBar1.MarqueeAnimationSpeed = 10;
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(517, 10);
      this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
      this.progressBar1.TabIndex = 4;
      this.progressBar1.Visible = false;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.resultLabel);
      this.groupBox1.Location = new System.Drawing.Point(12, 200);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(490, 214);
      this.groupBox1.TabIndex = 5;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Result";
      // 
      // resultLabel
      // 
      this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.resultLabel.Location = new System.Drawing.Point(6, 16);
      this.resultLabel.Name = "resultLabel";
      this.resultLabel.Size = new System.Drawing.Size(478, 195);
      this.resultLabel.TabIndex = 0;
      this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(517, 423);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.progressBar1);
      this.Controls.Add(this.testIpBox);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "MS17-010 Test";
      this.groupBox1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.TextBox testIpBox;
    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label resultLabel;
  }
}

