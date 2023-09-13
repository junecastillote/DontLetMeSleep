namespace DontLetMeSleep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.StartStopCheckBox = new System.Windows.Forms.CheckBox();
            this.CustomIntervalTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartStopCheckBox
            // 
            this.StartStopCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.StartStopCheckBox.AutoSize = true;
            this.StartStopCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.StartStopCheckBox.Image = global::DontLetMeSleep.Properties.Resources.START_BUTTON;
            this.StartStopCheckBox.Location = new System.Drawing.Point(12, 12);
            this.StartStopCheckBox.Name = "StartStopCheckBox";
            this.StartStopCheckBox.Size = new System.Drawing.Size(134, 134);
            this.StartStopCheckBox.TabIndex = 0;
            this.StartStopCheckBox.UseVisualStyleBackColor = false;
            this.StartStopCheckBox.CheckedChanged += new System.EventHandler(this.StartStopCheckBox_CheckedChanged);
            // 
            // CustomIntervalTextBox
            // 
            this.CustomIntervalTextBox.Location = new System.Drawing.Point(104, 157);
            this.CustomIntervalTextBox.Name = "CustomIntervalTextBox";
            this.CustomIntervalTextBox.Size = new System.Drawing.Size(42, 20);
            this.CustomIntervalTextBox.TabIndex = 3;
            this.CustomIntervalTextBox.Text = "30";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Interval (seconds)";
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripProgressBar1,
            this.ToolStripStatusLabel1});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 188);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(157, 22);
            this.StatusStrip1.TabIndex = 6;
            this.StatusStrip1.Text = "statusStrip1";
            // 
            // ToolStripProgressBar1
            // 
            this.ToolStripProgressBar1.Name = "ToolStripProgressBar1";
            this.ToolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(157, 210);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomIntervalTextBox);
            this.Controls.Add(this.StartStopCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Don\'t Let Me Sleep";
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox StartStopCheckBox;
        private System.Windows.Forms.TextBox CustomIntervalTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip StatusStrip1;
        private System.Windows.Forms.ToolStripProgressBar ToolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
    }
}

