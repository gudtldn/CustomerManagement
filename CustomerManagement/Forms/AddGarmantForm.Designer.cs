namespace CustomerManagement
{
    partial class AddGarmantForm
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
            System.Windows.Forms.Label GarmentIsCompletedLabel;
            System.Windows.Forms.Label GarmentProcessingDateLabel;
            System.Windows.Forms.Label GarmentReceptionDateLabel;
            System.Windows.Forms.Label GarmentPriceLabel;
            this.GarmentContentsLabel = new System.Windows.Forms.Label();
            this.CustomerFormInnerTableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.GarmentFormCancelButton = new System.Windows.Forms.Button();
            this.GarmentFormConfirmButton = new System.Windows.Forms.Button();
            this.GarmentFormTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CustomerFormInnerTableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GarmentNoteLabel = new System.Windows.Forms.Label();
            this.GarmentNoteTextBox = new EnhancedTextBox();
            this.GarmentContentsTextBox = new EnhancedTextBox();
            this.GarmentProcessingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.GarmentReceptionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.GarmentIsCompletedCheckBox = new System.Windows.Forms.CheckBox();
            this.GarmentPriceTextBox = new EnhancedTextBox();
            GarmentIsCompletedLabel = new System.Windows.Forms.Label();
            GarmentProcessingDateLabel = new System.Windows.Forms.Label();
            GarmentReceptionDateLabel = new System.Windows.Forms.Label();
            GarmentPriceLabel = new System.Windows.Forms.Label();
            this.CustomerFormInnerTableLayoutPanel2.SuspendLayout();
            this.GarmentFormTableLayoutPanel.SuspendLayout();
            this.CustomerFormInnerTableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GarmentIsCompletedLabel
            // 
            GarmentIsCompletedLabel.AutoSize = true;
            GarmentIsCompletedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            GarmentIsCompletedLabel.Font = new System.Drawing.Font("굴림", 10F);
            GarmentIsCompletedLabel.Location = new System.Drawing.Point(3, 33);
            GarmentIsCompletedLabel.Name = "GarmentIsCompletedLabel";
            GarmentIsCompletedLabel.Size = new System.Drawing.Size(72, 33);
            GarmentIsCompletedLabel.TabIndex = 4;
            GarmentIsCompletedLabel.Text = "완료구분:";
            GarmentIsCompletedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GarmentProcessingDateLabel
            // 
            GarmentProcessingDateLabel.AutoSize = true;
            GarmentProcessingDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            GarmentProcessingDateLabel.Font = new System.Drawing.Font("굴림", 10F);
            GarmentProcessingDateLabel.Location = new System.Drawing.Point(199, 0);
            GarmentProcessingDateLabel.Name = "GarmentProcessingDateLabel";
            GarmentProcessingDateLabel.Size = new System.Drawing.Size(72, 33);
            GarmentProcessingDateLabel.TabIndex = 2;
            GarmentProcessingDateLabel.Text = "처리일자:";
            GarmentProcessingDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GarmentReceptionDateLabel
            // 
            GarmentReceptionDateLabel.AutoSize = true;
            GarmentReceptionDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            GarmentReceptionDateLabel.Font = new System.Drawing.Font("굴림", 10F);
            GarmentReceptionDateLabel.Location = new System.Drawing.Point(3, 0);
            GarmentReceptionDateLabel.Name = "GarmentReceptionDateLabel";
            GarmentReceptionDateLabel.Size = new System.Drawing.Size(72, 33);
            GarmentReceptionDateLabel.TabIndex = 0;
            GarmentReceptionDateLabel.Text = "접수일자:";
            GarmentReceptionDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GarmentPriceLabel
            // 
            GarmentPriceLabel.AutoSize = true;
            GarmentPriceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            GarmentPriceLabel.Font = new System.Drawing.Font("굴림", 10F);
            GarmentPriceLabel.Location = new System.Drawing.Point(199, 33);
            GarmentPriceLabel.Name = "GarmentPriceLabel";
            GarmentPriceLabel.Size = new System.Drawing.Size(72, 33);
            GarmentPriceLabel.TabIndex = 6;
            GarmentPriceLabel.Text = "금액:";
            GarmentPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GarmentContentsLabel
            // 
            this.GarmentContentsLabel.AutoSize = true;
            this.GarmentContentsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GarmentContentsLabel.Font = new System.Drawing.Font("굴림", 10F);
            this.GarmentContentsLabel.Location = new System.Drawing.Point(3, 66);
            this.GarmentContentsLabel.Name = "GarmentContentsLabel";
            this.GarmentContentsLabel.Size = new System.Drawing.Size(72, 33);
            this.GarmentContentsLabel.TabIndex = 8;
            this.GarmentContentsLabel.Text = "내용:";
            this.GarmentContentsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CustomerFormInnerTableLayoutPanel2
            // 
            this.CustomerFormInnerTableLayoutPanel2.ColumnCount = 2;
            this.CustomerFormInnerTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CustomerFormInnerTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CustomerFormInnerTableLayoutPanel2.Controls.Add(this.GarmentFormCancelButton, 1, 0);
            this.CustomerFormInnerTableLayoutPanel2.Controls.Add(this.GarmentFormConfirmButton, 0, 0);
            this.CustomerFormInnerTableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerFormInnerTableLayoutPanel2.Location = new System.Drawing.Point(0, 135);
            this.CustomerFormInnerTableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.CustomerFormInnerTableLayoutPanel2.Name = "CustomerFormInnerTableLayoutPanel2";
            this.CustomerFormInnerTableLayoutPanel2.Padding = new System.Windows.Forms.Padding(70, 0, 70, 0);
            this.CustomerFormInnerTableLayoutPanel2.RowCount = 1;
            this.CustomerFormInnerTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CustomerFormInnerTableLayoutPanel2.Size = new System.Drawing.Size(394, 46);
            this.CustomerFormInnerTableLayoutPanel2.TabIndex = 2;
            // 
            // GarmentFormCancelButton
            // 
            this.GarmentFormCancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GarmentFormCancelButton.Location = new System.Drawing.Point(200, 3);
            this.GarmentFormCancelButton.Name = "GarmentFormCancelButton";
            this.GarmentFormCancelButton.Size = new System.Drawing.Size(121, 40);
            this.GarmentFormCancelButton.TabIndex = 1;
            this.GarmentFormCancelButton.Text = "취소";
            this.GarmentFormCancelButton.UseVisualStyleBackColor = true;
            this.GarmentFormCancelButton.Click += new System.EventHandler(this.GarmentFormCancelButton_Click);
            // 
            // GarmentFormConfirmButton
            // 
            this.GarmentFormConfirmButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GarmentFormConfirmButton.Location = new System.Drawing.Point(73, 3);
            this.GarmentFormConfirmButton.Name = "GarmentFormConfirmButton";
            this.GarmentFormConfirmButton.Size = new System.Drawing.Size(121, 40);
            this.GarmentFormConfirmButton.TabIndex = 0;
            this.GarmentFormConfirmButton.Text = "확인";
            this.GarmentFormConfirmButton.UseVisualStyleBackColor = true;
            this.GarmentFormConfirmButton.Click += new System.EventHandler(this.GarmentFormConfirmButton_Click);
            // 
            // GarmentFormTableLayoutPanel
            // 
            this.GarmentFormTableLayoutPanel.ColumnCount = 1;
            this.GarmentFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GarmentFormTableLayoutPanel.Controls.Add(this.CustomerFormInnerTableLayoutPanel2, 0, 1);
            this.GarmentFormTableLayoutPanel.Controls.Add(this.CustomerFormInnerTableLayoutPanel1, 0, 0);
            this.GarmentFormTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GarmentFormTableLayoutPanel.Location = new System.Drawing.Point(20, 20);
            this.GarmentFormTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.GarmentFormTableLayoutPanel.Name = "GarmentFormTableLayoutPanel";
            this.GarmentFormTableLayoutPanel.RowCount = 2;
            this.GarmentFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.GarmentFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.GarmentFormTableLayoutPanel.Size = new System.Drawing.Size(394, 181);
            this.GarmentFormTableLayoutPanel.TabIndex = 0;
            // 
            // CustomerFormInnerTableLayoutPanel1
            // 
            this.CustomerFormInnerTableLayoutPanel1.ColumnCount = 4;
            this.CustomerFormInnerTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CustomerFormInnerTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.CustomerFormInnerTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CustomerFormInnerTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.CustomerFormInnerTableLayoutPanel1.Controls.Add(this.GarmentNoteLabel, 0, 3);
            this.CustomerFormInnerTableLayoutPanel1.Controls.Add(this.GarmentNoteTextBox, 1, 3);
            this.CustomerFormInnerTableLayoutPanel1.Controls.Add(this.GarmentContentsTextBox, 1, 2);
            this.CustomerFormInnerTableLayoutPanel1.Controls.Add(this.GarmentContentsLabel, 0, 2);
            this.CustomerFormInnerTableLayoutPanel1.Controls.Add(GarmentPriceLabel, 2, 1);
            this.CustomerFormInnerTableLayoutPanel1.Controls.Add(GarmentIsCompletedLabel, 0, 1);
            this.CustomerFormInnerTableLayoutPanel1.Controls.Add(this.GarmentProcessingDateTimePicker, 3, 0);
            this.CustomerFormInnerTableLayoutPanel1.Controls.Add(GarmentProcessingDateLabel, 2, 0);
            this.CustomerFormInnerTableLayoutPanel1.Controls.Add(GarmentReceptionDateLabel, 0, 0);
            this.CustomerFormInnerTableLayoutPanel1.Controls.Add(this.GarmentReceptionDateTimePicker, 1, 0);
            this.CustomerFormInnerTableLayoutPanel1.Controls.Add(this.GarmentIsCompletedCheckBox, 1, 1);
            this.CustomerFormInnerTableLayoutPanel1.Controls.Add(this.GarmentPriceTextBox, 3, 1);
            this.CustomerFormInnerTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerFormInnerTableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.CustomerFormInnerTableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.CustomerFormInnerTableLayoutPanel1.Name = "CustomerFormInnerTableLayoutPanel1";
            this.CustomerFormInnerTableLayoutPanel1.RowCount = 4;
            this.CustomerFormInnerTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CustomerFormInnerTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CustomerFormInnerTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CustomerFormInnerTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CustomerFormInnerTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CustomerFormInnerTableLayoutPanel1.Size = new System.Drawing.Size(394, 135);
            this.CustomerFormInnerTableLayoutPanel1.TabIndex = 0;
            // 
            // GarmentNoteLabel
            // 
            this.GarmentNoteLabel.AutoSize = true;
            this.GarmentNoteLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GarmentNoteLabel.Font = new System.Drawing.Font("굴림", 10F);
            this.GarmentNoteLabel.Location = new System.Drawing.Point(3, 99);
            this.GarmentNoteLabel.Name = "GarmentNoteLabel";
            this.GarmentNoteLabel.Size = new System.Drawing.Size(72, 36);
            this.GarmentNoteLabel.TabIndex = 11;
            this.GarmentNoteLabel.Text = "비고:";
            this.GarmentNoteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GarmentNoteTextBox
            // 
            this.CustomerFormInnerTableLayoutPanel1.SetColumnSpan(this.GarmentNoteTextBox, 3);
            this.GarmentNoteTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GarmentNoteTextBox.Font = new System.Drawing.Font("굴림", 10F);
            this.GarmentNoteTextBox.Location = new System.Drawing.Point(83, 104);
            this.GarmentNoteTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.GarmentNoteTextBox.Name = "GarmentNoteTextBox";
            this.GarmentNoteTextBox.Size = new System.Drawing.Size(306, 23);
            this.GarmentNoteTextBox.TabIndex = 10;
            // 
            // GarmentContentsTextBox
            // 
            this.CustomerFormInnerTableLayoutPanel1.SetColumnSpan(this.GarmentContentsTextBox, 3);
            this.GarmentContentsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GarmentContentsTextBox.Font = new System.Drawing.Font("굴림", 10F);
            this.GarmentContentsTextBox.Location = new System.Drawing.Point(83, 71);
            this.GarmentContentsTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.GarmentContentsTextBox.Name = "GarmentContentsTextBox";
            this.GarmentContentsTextBox.Size = new System.Drawing.Size(306, 23);
            this.GarmentContentsTextBox.TabIndex = 9;
            // 
            // GarmentProcessingDateTimePicker
            // 
            this.GarmentProcessingDateTimePicker.CalendarFont = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.GarmentProcessingDateTimePicker.CustomFormat = "";
            this.GarmentProcessingDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GarmentProcessingDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.GarmentProcessingDateTimePicker.Location = new System.Drawing.Point(279, 5);
            this.GarmentProcessingDateTimePicker.Margin = new System.Windows.Forms.Padding(5);
            this.GarmentProcessingDateTimePicker.Name = "GarmentProcessingDateTimePicker";
            this.GarmentProcessingDateTimePicker.Size = new System.Drawing.Size(110, 21);
            this.GarmentProcessingDateTimePicker.TabIndex = 3;
            this.GarmentProcessingDateTimePicker.Value = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            // 
            // GarmentReceptionDateTimePicker
            // 
            this.GarmentReceptionDateTimePicker.CalendarFont = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.GarmentReceptionDateTimePicker.CustomFormat = "";
            this.GarmentReceptionDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GarmentReceptionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.GarmentReceptionDateTimePicker.Location = new System.Drawing.Point(83, 5);
            this.GarmentReceptionDateTimePicker.Margin = new System.Windows.Forms.Padding(5);
            this.GarmentReceptionDateTimePicker.Name = "GarmentReceptionDateTimePicker";
            this.GarmentReceptionDateTimePicker.Size = new System.Drawing.Size(108, 21);
            this.GarmentReceptionDateTimePicker.TabIndex = 1;
            this.GarmentReceptionDateTimePicker.Value = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            // 
            // GarmentIsCompletedCheckBox
            // 
            this.GarmentIsCompletedCheckBox.AutoSize = true;
            this.GarmentIsCompletedCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GarmentIsCompletedCheckBox.Font = new System.Drawing.Font("굴림", 9F);
            this.GarmentIsCompletedCheckBox.Location = new System.Drawing.Point(83, 38);
            this.GarmentIsCompletedCheckBox.Margin = new System.Windows.Forms.Padding(5);
            this.GarmentIsCompletedCheckBox.Name = "GarmentIsCompletedCheckBox";
            this.GarmentIsCompletedCheckBox.Size = new System.Drawing.Size(108, 23);
            this.GarmentIsCompletedCheckBox.TabIndex = 5;
            this.GarmentIsCompletedCheckBox.UseVisualStyleBackColor = true;
            // 
            // GarmentPriceTextBox
            // 
            this.GarmentPriceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GarmentPriceTextBox.Font = new System.Drawing.Font("굴림", 10F);
            this.GarmentPriceTextBox.Location = new System.Drawing.Point(279, 38);
            this.GarmentPriceTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.GarmentPriceTextBox.Name = "GarmentPriceTextBox";
            this.GarmentPriceTextBox.Size = new System.Drawing.Size(110, 23);
            this.GarmentPriceTextBox.TabIndex = 7;
            this.GarmentPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.GarmentPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddGarmentFormPriceTextBox_KeyPress);
            // 
            // AddGarmantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 211);
            this.Controls.Add(this.GarmentFormTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddGarmantForm";
            this.Padding = new System.Windows.Forms.Padding(20, 20, 20, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "자료추가";
            this.Load += new System.EventHandler(this.AddGarmantForm_Load);
            this.CustomerFormInnerTableLayoutPanel2.ResumeLayout(false);
            this.GarmentFormTableLayoutPanel.ResumeLayout(false);
            this.CustomerFormInnerTableLayoutPanel1.ResumeLayout(false);
            this.CustomerFormInnerTableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button GarmentFormCancelButton;
        private System.Windows.Forms.Button GarmentFormConfirmButton;
        private System.Windows.Forms.DateTimePicker GarmentProcessingDateTimePicker;
        private System.Windows.Forms.DateTimePicker GarmentReceptionDateTimePicker;
        private System.Windows.Forms.TableLayoutPanel GarmentFormTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel CustomerFormInnerTableLayoutPanel1;
        private System.Windows.Forms.CheckBox GarmentIsCompletedCheckBox;
        private System.Windows.Forms.TableLayoutPanel CustomerFormInnerTableLayoutPanel2;
        private EnhancedTextBox GarmentPriceTextBox;
        private EnhancedTextBox GarmentContentsTextBox;
        private System.Windows.Forms.Label GarmentContentsLabel;
        private System.Windows.Forms.Label GarmentNoteLabel;
        private EnhancedTextBox GarmentNoteTextBox;
    }
}