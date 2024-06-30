namespace CustomerManagement
{
    partial class AddCustomerForm
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
            System.Windows.Forms.TableLayoutPanel AddCustomerFormTableLayoutPanel;
            System.Windows.Forms.TableLayoutPanel AddCustomerFormInnerTableLayoutPanel1;
            System.Windows.Forms.Label AddCustomerFormPNLabel;
            System.Windows.Forms.Label AddCustomerFormNameLabel;
            System.Windows.Forms.TableLayoutPanel AddCustomerFormInnerTableLayoutPanel2;
            this.AddCustomerFormPNTextBox = new EnhancedTextBox();
            this.AddCustomerFormNameTextBox = new EnhancedTextBox();
            this.AddCustomerFormCancelButton = new System.Windows.Forms.Button();
            this.AddCustomerFormConfirmButton = new System.Windows.Forms.Button();
            AddCustomerFormTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            AddCustomerFormInnerTableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            AddCustomerFormPNLabel = new System.Windows.Forms.Label();
            AddCustomerFormNameLabel = new System.Windows.Forms.Label();
            AddCustomerFormInnerTableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            AddCustomerFormTableLayoutPanel.SuspendLayout();
            AddCustomerFormInnerTableLayoutPanel1.SuspendLayout();
            AddCustomerFormInnerTableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddCustomerFormTableLayoutPanel
            // 
            AddCustomerFormTableLayoutPanel.ColumnCount = 1;
            AddCustomerFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            AddCustomerFormTableLayoutPanel.Controls.Add(AddCustomerFormInnerTableLayoutPanel1, 0, 0);
            AddCustomerFormTableLayoutPanel.Controls.Add(AddCustomerFormInnerTableLayoutPanel2, 0, 1);
            AddCustomerFormTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            AddCustomerFormTableLayoutPanel.Location = new System.Drawing.Point(40, 20);
            AddCustomerFormTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            AddCustomerFormTableLayoutPanel.Name = "AddCustomerFormTableLayoutPanel";
            AddCustomerFormTableLayoutPanel.RowCount = 2;
            AddCustomerFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            AddCustomerFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            AddCustomerFormTableLayoutPanel.Size = new System.Drawing.Size(304, 131);
            AddCustomerFormTableLayoutPanel.TabIndex = 0;
            // 
            // AddCustomerFormInnerTableLayoutPanel1
            // 
            AddCustomerFormInnerTableLayoutPanel1.ColumnCount = 2;
            AddCustomerFormInnerTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.5F));
            AddCustomerFormInnerTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.5F));
            AddCustomerFormInnerTableLayoutPanel1.Controls.Add(this.AddCustomerFormPNTextBox, 1, 1);
            AddCustomerFormInnerTableLayoutPanel1.Controls.Add(AddCustomerFormPNLabel, 0, 1);
            AddCustomerFormInnerTableLayoutPanel1.Controls.Add(AddCustomerFormNameLabel, 0, 0);
            AddCustomerFormInnerTableLayoutPanel1.Controls.Add(this.AddCustomerFormNameTextBox, 1, 0);
            AddCustomerFormInnerTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            AddCustomerFormInnerTableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            AddCustomerFormInnerTableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            AddCustomerFormInnerTableLayoutPanel1.Name = "AddCustomerFormInnerTableLayoutPanel1";
            AddCustomerFormInnerTableLayoutPanel1.RowCount = 2;
            AddCustomerFormInnerTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            AddCustomerFormInnerTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            AddCustomerFormInnerTableLayoutPanel1.Size = new System.Drawing.Size(304, 65);
            AddCustomerFormInnerTableLayoutPanel1.TabIndex = 0;
            // 
            // AddCustomerFormPNTextBox
            // 
            this.AddCustomerFormPNTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCustomerFormPNTextBox.Font = new System.Drawing.Font("굴림", 12F);
            this.AddCustomerFormPNTextBox.IsNumberOnly = true;
            this.AddCustomerFormPNTextBox.Location = new System.Drawing.Point(83, 35);
            this.AddCustomerFormPNTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.AddCustomerFormPNTextBox.MaxLength = 13;
            this.AddCustomerFormPNTextBox.Name = "AddCustomerFormPNTextBox";
            this.AddCustomerFormPNTextBox.Size = new System.Drawing.Size(221, 26);
            this.AddCustomerFormPNTextBox.TabIndex = 3;
            this.AddCustomerFormPNTextBox.TextChanged += new System.EventHandler(this.AddCustomerFormPNTextBox_TextChanged);
            this.AddCustomerFormPNTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddCustomerForm_KeyDown);
            // 
            // AddCustomerFormPNLabel
            // 
            AddCustomerFormPNLabel.AutoSize = true;
            AddCustomerFormPNLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            AddCustomerFormPNLabel.Font = new System.Drawing.Font("굴림", 12F);
            AddCustomerFormPNLabel.Location = new System.Drawing.Point(3, 32);
            AddCustomerFormPNLabel.Name = "AddCustomerFormPNLabel";
            AddCustomerFormPNLabel.Size = new System.Drawing.Size(77, 33);
            AddCustomerFormPNLabel.TabIndex = 1;
            AddCustomerFormPNLabel.Text = "전화번호:";
            AddCustomerFormPNLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddCustomerFormNameLabel
            // 
            AddCustomerFormNameLabel.AutoSize = true;
            AddCustomerFormNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            AddCustomerFormNameLabel.Font = new System.Drawing.Font("굴림", 12F);
            AddCustomerFormNameLabel.Location = new System.Drawing.Point(3, 0);
            AddCustomerFormNameLabel.Name = "AddCustomerFormNameLabel";
            AddCustomerFormNameLabel.Size = new System.Drawing.Size(77, 32);
            AddCustomerFormNameLabel.TabIndex = 0;
            AddCustomerFormNameLabel.Text = "고객명:";
            AddCustomerFormNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddCustomerFormNameTextBox
            // 
            this.AddCustomerFormNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCustomerFormNameTextBox.Font = new System.Drawing.Font("굴림", 12F);
            this.AddCustomerFormNameTextBox.Location = new System.Drawing.Point(83, 3);
            this.AddCustomerFormNameTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.AddCustomerFormNameTextBox.MaxLength = 32;
            this.AddCustomerFormNameTextBox.Name = "AddCustomerFormNameTextBox";
            this.AddCustomerFormNameTextBox.Size = new System.Drawing.Size(221, 26);
            this.AddCustomerFormNameTextBox.TabIndex = 2;
            this.AddCustomerFormNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddCustomerForm_KeyDown);
            // 
            // AddCustomerFormInnerTableLayoutPanel2
            // 
            AddCustomerFormInnerTableLayoutPanel2.ColumnCount = 2;
            AddCustomerFormInnerTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            AddCustomerFormInnerTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            AddCustomerFormInnerTableLayoutPanel2.Controls.Add(this.AddCustomerFormCancelButton, 1, 0);
            AddCustomerFormInnerTableLayoutPanel2.Controls.Add(this.AddCustomerFormConfirmButton, 0, 0);
            AddCustomerFormInnerTableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            AddCustomerFormInnerTableLayoutPanel2.Location = new System.Drawing.Point(0, 65);
            AddCustomerFormInnerTableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            AddCustomerFormInnerTableLayoutPanel2.Name = "AddCustomerFormInnerTableLayoutPanel2";
            AddCustomerFormInnerTableLayoutPanel2.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            AddCustomerFormInnerTableLayoutPanel2.RowCount = 1;
            AddCustomerFormInnerTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            AddCustomerFormInnerTableLayoutPanel2.Size = new System.Drawing.Size(304, 66);
            AddCustomerFormInnerTableLayoutPanel2.TabIndex = 1;
            // 
            // AddCustomerFormCancelButton
            // 
            this.AddCustomerFormCancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddCustomerFormCancelButton.Location = new System.Drawing.Point(155, 13);
            this.AddCustomerFormCancelButton.Name = "AddCustomerFormCancelButton";
            this.AddCustomerFormCancelButton.Size = new System.Drawing.Size(126, 40);
            this.AddCustomerFormCancelButton.TabIndex = 1;
            this.AddCustomerFormCancelButton.Text = "취소";
            this.AddCustomerFormCancelButton.UseVisualStyleBackColor = true;
            this.AddCustomerFormCancelButton.Click += new System.EventHandler(this.AddCustomerFormCancelButton_Click);
            // 
            // AddCustomerFormConfirmButton
            // 
            this.AddCustomerFormConfirmButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddCustomerFormConfirmButton.Location = new System.Drawing.Point(23, 13);
            this.AddCustomerFormConfirmButton.Name = "AddCustomerFormConfirmButton";
            this.AddCustomerFormConfirmButton.Size = new System.Drawing.Size(126, 40);
            this.AddCustomerFormConfirmButton.TabIndex = 0;
            this.AddCustomerFormConfirmButton.Text = "확인";
            this.AddCustomerFormConfirmButton.UseVisualStyleBackColor = true;
            this.AddCustomerFormConfirmButton.Click += new System.EventHandler(this.AddCustomerFormConfirmButton_Click);
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(AddCustomerFormTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCustomerForm";
            this.Padding = new System.Windows.Forms.Padding(40, 20, 40, 10);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "고객 추가";
            this.Load += new System.EventHandler(this.AddCustomerForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddCustomerForm_KeyDown);
            AddCustomerFormTableLayoutPanel.ResumeLayout(false);
            AddCustomerFormInnerTableLayoutPanel1.ResumeLayout(false);
            AddCustomerFormInnerTableLayoutPanel1.PerformLayout();
            AddCustomerFormInnerTableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddCustomerFormCancelButton;
        private System.Windows.Forms.Button AddCustomerFormConfirmButton;
        private EnhancedTextBox AddCustomerFormNameTextBox;
        private EnhancedTextBox AddCustomerFormPNTextBox;
    }
}