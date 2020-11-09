namespace P7
{
    partial class FormIssueDashboard
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
            this.numberOfIssuesLabel = new System.Windows.Forms.Label();
            this.issuesMonthListBox = new System.Windows.Forms.ListBox();
            this.monthsTextbox = new System.Windows.Forms.Label();
            this.discoverTextbox = new System.Windows.Forms.Label();
            this.issuesDiscovererListBox = new System.Windows.Forms.ListBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numberOfIssuesLabel
            // 
            this.numberOfIssuesLabel.AutoSize = true;
            this.numberOfIssuesLabel.Location = new System.Drawing.Point(26, 30);
            this.numberOfIssuesLabel.Name = "numberOfIssuesLabel";
            this.numberOfIssuesLabel.Size = new System.Drawing.Size(193, 20);
            this.numberOfIssuesLabel.TabIndex = 0;
            this.numberOfIssuesLabel.Text = "Total Number of Issues: ";
            // 
            // issuesMonthListBox
            // 
            this.issuesMonthListBox.FormattingEnabled = true;
            this.issuesMonthListBox.ItemHeight = 20;
            this.issuesMonthListBox.Location = new System.Drawing.Point(30, 99);
            this.issuesMonthListBox.Name = "issuesMonthListBox";
            this.issuesMonthListBox.ScrollAlwaysVisible = true;
            this.issuesMonthListBox.Size = new System.Drawing.Size(287, 124);
            this.issuesMonthListBox.TabIndex = 1;
            // 
            // monthsTextbox
            // 
            this.monthsTextbox.AutoSize = true;
            this.monthsTextbox.Location = new System.Drawing.Point(26, 76);
            this.monthsTextbox.Name = "monthsTextbox";
            this.monthsTextbox.Size = new System.Drawing.Size(131, 20);
            this.monthsTextbox.TabIndex = 2;
            this.monthsTextbox.Text = "Issues by Month";
            // 
            // discoverTextbox
            // 
            this.discoverTextbox.AutoSize = true;
            this.discoverTextbox.Location = new System.Drawing.Point(26, 259);
            this.discoverTextbox.Name = "discoverTextbox";
            this.discoverTextbox.Size = new System.Drawing.Size(167, 20);
            this.discoverTextbox.TabIndex = 3;
            this.discoverTextbox.Text = "Issues by Discoverer";
            // 
            // issuesDiscovererListBox
            // 
            this.issuesDiscovererListBox.FormattingEnabled = true;
            this.issuesDiscovererListBox.ItemHeight = 20;
            this.issuesDiscovererListBox.Location = new System.Drawing.Point(30, 294);
            this.issuesDiscovererListBox.Name = "issuesDiscovererListBox";
            this.issuesDiscovererListBox.ScrollAlwaysVisible = true;
            this.issuesDiscovererListBox.Size = new System.Drawing.Size(287, 124);
            this.issuesDiscovererListBox.TabIndex = 4;
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(227, 447);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(90, 32);
            this.closeBtn.TabIndex = 5;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // FormIssueDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 520);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.issuesDiscovererListBox);
            this.Controls.Add(this.discoverTextbox);
            this.Controls.Add(this.monthsTextbox);
            this.Controls.Add(this.issuesMonthListBox);
            this.Controls.Add(this.numberOfIssuesLabel);
            this.Name = "FormIssueDashboard";
            this.Text = "Issue Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numberOfIssuesLabel;
        private System.Windows.Forms.ListBox issuesMonthListBox;
        private System.Windows.Forms.Label monthsTextbox;
        private System.Windows.Forms.Label discoverTextbox;
        private System.Windows.Forms.ListBox issuesDiscovererListBox;
        private System.Windows.Forms.Button closeBtn;
    }
}