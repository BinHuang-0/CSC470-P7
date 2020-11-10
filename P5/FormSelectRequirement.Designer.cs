namespace P7
{
    partial class FormSelectRequirement
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.featureComboBox = new System.Windows.Forms.ComboBox();
            this.requirementDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Requirement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.selectBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.requirementDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Feature: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Requirements: ";
            // 
            // featureComboBox
            // 
            this.featureComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.featureComboBox.FormattingEnabled = true;
            this.featureComboBox.Location = new System.Drawing.Point(126, 34);
            this.featureComboBox.Name = "featureComboBox";
            this.featureComboBox.Size = new System.Drawing.Size(606, 24);
            this.featureComboBox.TabIndex = 2;
            this.featureComboBox.SelectedIndexChanged += new System.EventHandler(this.featureComboBox_SelectedIndexChanged);
            // 
            // requirementDataGridView
            // 
            this.requirementDataGridView.AllowUserToAddRows = false;
            this.requirementDataGridView.AllowUserToDeleteRows = false;
            this.requirementDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requirementDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Requirement});
            this.requirementDataGridView.Location = new System.Drawing.Point(126, 71);
            this.requirementDataGridView.Name = "requirementDataGridView";
            this.requirementDataGridView.ReadOnly = true;
            this.requirementDataGridView.RowHeadersWidth = 51;
            this.requirementDataGridView.RowTemplate.Height = 24;
            this.requirementDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.requirementDataGridView.Size = new System.Drawing.Size(606, 302);
            this.requirementDataGridView.TabIndex = 3;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // Requirement
            // 
            this.Requirement.HeaderText = "Requirement";
            this.Requirement.MinimumWidth = 6;
            this.Requirement.Name = "Requirement";
            this.Requirement.ReadOnly = true;
            this.Requirement.Width = 350;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(392, 403);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(167, 23);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(565, 403);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(167, 23);
            this.selectBtn.TabIndex = 5;
            this.selectBtn.Text = "Select Requirement";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // FormSelectRequirement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.requirementDataGridView);
            this.Controls.Add(this.featureComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSelectRequirement";
            this.Text = "Select Requirement";
            this.Load += new System.EventHandler(this.FormSelectRequirement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.requirementDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox featureComboBox;
        private System.Windows.Forms.DataGridView requirementDataGridView;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Requirement;
    }
}