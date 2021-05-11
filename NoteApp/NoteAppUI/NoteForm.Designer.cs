
namespace NoteAppUI
{
    partial class NoteForm
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
            this.EditTitleLabel = new System.Windows.Forms.Label();
            this.EditTitleTextBox = new System.Windows.Forms.TextBox();
            this.EditCategoryLabel = new System.Windows.Forms.Label();
            this.EditCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.EditCreatedLabel = new System.Windows.Forms.Label();
            this.EditCreatedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EditModifiedLabel = new System.Windows.Forms.Label();
            this.EditModifiedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EditTextBox = new System.Windows.Forms.TextBox();
            this.EditOKButton = new System.Windows.Forms.Button();
            this.EditCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EditTitleLabel
            // 
            this.EditTitleLabel.AutoSize = true;
            this.EditTitleLabel.Location = new System.Drawing.Point(12, 9);
            this.EditTitleLabel.Name = "EditTitleLabel";
            this.EditTitleLabel.Size = new System.Drawing.Size(30, 13);
            this.EditTitleLabel.TabIndex = 9;
            this.EditTitleLabel.Text = "Title:";
            // 
            // EditTitleTextBox
            // 
            this.EditTitleTextBox.Location = new System.Drawing.Point(70, 6);
            this.EditTitleTextBox.Name = "EditTitleTextBox";
            this.EditTitleTextBox.Size = new System.Drawing.Size(601, 20);
            this.EditTitleTextBox.TabIndex = 10;
            // 
            // EditCategoryLabel
            // 
            this.EditCategoryLabel.AutoSize = true;
            this.EditCategoryLabel.Location = new System.Drawing.Point(12, 42);
            this.EditCategoryLabel.Name = "EditCategoryLabel";
            this.EditCategoryLabel.Size = new System.Drawing.Size(52, 13);
            this.EditCategoryLabel.TabIndex = 11;
            this.EditCategoryLabel.Text = "Category:";
            // 
            // EditCategoryComboBox
            // 
            this.EditCategoryComboBox.FormattingEnabled = true;
            this.EditCategoryComboBox.Location = new System.Drawing.Point(70, 42);
            this.EditCategoryComboBox.Name = "EditCategoryComboBox";
            this.EditCategoryComboBox.Size = new System.Drawing.Size(162, 21);
            this.EditCategoryComboBox.TabIndex = 12;
            // 
            // EditCreatedLabel
            // 
            this.EditCreatedLabel.AutoSize = true;
            this.EditCreatedLabel.Location = new System.Drawing.Point(12, 91);
            this.EditCreatedLabel.Name = "EditCreatedLabel";
            this.EditCreatedLabel.Size = new System.Drawing.Size(47, 13);
            this.EditCreatedLabel.TabIndex = 13;
            this.EditCreatedLabel.Text = "Created:";
            // 
            // EditCreatedDateTimePicker
            // 
            this.EditCreatedDateTimePicker.Enabled = false;
            this.EditCreatedDateTimePicker.Location = new System.Drawing.Point(70, 85);
            this.EditCreatedDateTimePicker.Name = "EditCreatedDateTimePicker";
            this.EditCreatedDateTimePicker.Size = new System.Drawing.Size(117, 20);
            this.EditCreatedDateTimePicker.TabIndex = 14;
            // 
            // EditModifiedLabel
            // 
            this.EditModifiedLabel.AutoSize = true;
            this.EditModifiedLabel.Location = new System.Drawing.Point(206, 91);
            this.EditModifiedLabel.Name = "EditModifiedLabel";
            this.EditModifiedLabel.Size = new System.Drawing.Size(50, 13);
            this.EditModifiedLabel.TabIndex = 15;
            this.EditModifiedLabel.Text = "Modified:";
            // 
            // EditModifiedDateTimePicker
            // 
            this.EditModifiedDateTimePicker.Enabled = false;
            this.EditModifiedDateTimePicker.Location = new System.Drawing.Point(262, 85);
            this.EditModifiedDateTimePicker.Name = "EditModifiedDateTimePicker";
            this.EditModifiedDateTimePicker.Size = new System.Drawing.Size(115, 20);
            this.EditModifiedDateTimePicker.TabIndex = 16;
            // 
            // EditTextBox
            // 
            this.EditTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditTextBox.Location = new System.Drawing.Point(15, 111);
            this.EditTextBox.MaximumSize = new System.Drawing.Size(1000, 700);
            this.EditTextBox.MinimumSize = new System.Drawing.Size(656, 308);
            this.EditTextBox.Multiline = true;
            this.EditTextBox.Name = "EditTextBox";
            this.EditTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EditTextBox.Size = new System.Drawing.Size(656, 328);
            this.EditTextBox.TabIndex = 17;
            // 
            // EditOKButton
            // 
            this.EditOKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditOKButton.Location = new System.Drawing.Point(537, 445);
            this.EditOKButton.Name = "EditOKButton";
            this.EditOKButton.Size = new System.Drawing.Size(64, 22);
            this.EditOKButton.TabIndex = 18;
            this.EditOKButton.Text = "OK";
            this.EditOKButton.UseVisualStyleBackColor = true;
            this.EditOKButton.Click += new System.EventHandler(this.EditOKButton_Click);
            // 
            // EditCancelButton
            // 
            this.EditCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditCancelButton.Location = new System.Drawing.Point(607, 445);
            this.EditCancelButton.Name = "EditCancelButton";
            this.EditCancelButton.Size = new System.Drawing.Size(64, 22);
            this.EditCancelButton.TabIndex = 19;
            this.EditCancelButton.Text = "Cancel";
            this.EditCancelButton.UseVisualStyleBackColor = true;
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 470);
            this.Controls.Add(this.EditCancelButton);
            this.Controls.Add(this.EditOKButton);
            this.Controls.Add(this.EditTextBox);
            this.Controls.Add(this.EditModifiedDateTimePicker);
            this.Controls.Add(this.EditModifiedLabel);
            this.Controls.Add(this.EditCreatedDateTimePicker);
            this.Controls.Add(this.EditCreatedLabel);
            this.Controls.Add(this.EditCategoryComboBox);
            this.Controls.Add(this.EditCategoryLabel);
            this.Controls.Add(this.EditTitleTextBox);
            this.Controls.Add(this.EditTitleLabel);
            this.Name = "NoteForm";
            this.Text = "Add/Edit Note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EditTitleLabel;
        private System.Windows.Forms.TextBox EditTitleTextBox;
        private System.Windows.Forms.Label EditCategoryLabel;
        private System.Windows.Forms.ComboBox EditCategoryComboBox;
        private System.Windows.Forms.Label EditCreatedLabel;
        private System.Windows.Forms.DateTimePicker EditCreatedDateTimePicker;
        private System.Windows.Forms.Label EditModifiedLabel;
        private System.Windows.Forms.DateTimePicker EditModifiedDateTimePicker;
        private System.Windows.Forms.TextBox EditTextBox;
        private System.Windows.Forms.Button EditOKButton;
        private System.Windows.Forms.Button EditCancelButton;
    }
}