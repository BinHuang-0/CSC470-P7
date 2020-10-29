namespace P5
{
    partial class FormModifyIssue
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
            this.idLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.statusDropDown = new System.Windows.Forms.ComboBox();
            this.discovererDropDown = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.componentTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.componentLabel = new System.Windows.Forms.Label();
            this.discovererLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(115, 38);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(32, 20);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "id: ";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(153, 32);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(100, 26);
            this.idTextBox.TabIndex = 2;
            // 
            // statusDropDown
            // 
            this.statusDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusDropDown.FormattingEnabled = true;
            this.statusDropDown.Items.AddRange(new object[] {
            "Open",
            "Assigned",
            "Fixed",
            "Closed - Won\'t fix",
            "Closed - Fixed",
            "Closed - by design"});
            this.statusDropDown.Location = new System.Drawing.Point(153, 208);
            this.statusDropDown.Name = "statusDropDown";
            this.statusDropDown.Size = new System.Drawing.Size(400, 28);
            this.statusDropDown.TabIndex = 16;
            // 
            // discovererDropDown
            // 
            this.discovererDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.discovererDropDown.FormattingEnabled = true;
            this.discovererDropDown.Location = new System.Drawing.Point(153, 142);
            this.discovererDropDown.Name = "discovererDropDown";
            this.discovererDropDown.Size = new System.Drawing.Size(400, 28);
            this.discovererDropDown.TabIndex = 12;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(153, 107);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(400, 26);
            this.dateTimePicker.TabIndex = 11;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(153, 262);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(400, 313);
            this.descriptionTextBox.TabIndex = 18;
            // 
            // componentTextBox
            // 
            this.componentTextBox.Location = new System.Drawing.Point(153, 176);
            this.componentTextBox.Name = "componentTextBox";
            this.componentTextBox.Size = new System.Drawing.Size(400, 26);
            this.componentTextBox.TabIndex = 14;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(80, 239);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(139, 20);
            this.descriptionLabel.TabIndex = 20;
            this.descriptionLabel.Text = "Initial Description";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(80, 211);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(67, 20);
            this.statusLabel.TabIndex = 19;
            this.statusLabel.Text = "Status: ";
            // 
            // componentLabel
            // 
            this.componentLabel.AutoSize = true;
            this.componentLabel.Location = new System.Drawing.Point(43, 179);
            this.componentLabel.Name = "componentLabel";
            this.componentLabel.Size = new System.Drawing.Size(104, 20);
            this.componentLabel.TabIndex = 17;
            this.componentLabel.Text = "Component: ";
            // 
            // discovererLabel
            // 
            this.discovererLabel.AutoSize = true;
            this.discovererLabel.Location = new System.Drawing.Point(46, 145);
            this.discovererLabel.Name = "discovererLabel";
            this.discovererLabel.Size = new System.Drawing.Size(101, 20);
            this.discovererLabel.TabIndex = 15;
            this.discovererLabel.Text = "Discoverer: ";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(12, 109);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(135, 20);
            this.dateLabel.TabIndex = 13;
            this.dateLabel.Text = "Discovery Date: ";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(153, 71);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(400, 26);
            this.titleTextBox.TabIndex = 9;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(96, 74);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(51, 20);
            this.titleLabel.TabIndex = 10;
            this.titleLabel.Text = "Title: ";
            // 
            // modifyBtn
            // 
            this.modifyBtn.Location = new System.Drawing.Point(425, 601);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(128, 42);
            this.modifyBtn.TabIndex = 22;
            this.modifyBtn.Text = "Modify Issue";
            this.modifyBtn.UseVisualStyleBackColor = true;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(275, 601);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(128, 42);
            this.cancelBtn.TabIndex = 21;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // FormModifyIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 655);
            this.Controls.Add(this.modifyBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.statusDropDown);
            this.Controls.Add(this.discovererDropDown);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.componentTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.componentLabel);
            this.Controls.Add(this.discovererLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Name = "FormModifyIssue";
            this.Text = "ModifyIssue";
            this.Load += new System.EventHandler(this.FormModifyIssue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.ComboBox statusDropDown;
        private System.Windows.Forms.ComboBox discovererDropDown;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox componentTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label componentLabel;
        private System.Windows.Forms.Label discovererLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}