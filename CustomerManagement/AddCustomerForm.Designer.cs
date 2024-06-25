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
            this.AddCustomerFormTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AddCustomerFormInnerTableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AddCustomerFormPNTextBox = new System.Windows.Forms.TextBox();
            this.AddCustomerFormPNLabel = new System.Windows.Forms.Label();
            this.AddCustomerFormNameLabel = new System.Windows.Forms.Label();
            this.AddCustomerFormNameTextBox = new System.Windows.Forms.TextBox();
            this.AddCustomerFormInnerTableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.AddCustomerFormCancelButton = new System.Windows.Forms.Button();
            this.AddCustomerFormConfirmButton = new System.Windows.Forms.Button();
            this.AddCustomerFormTableLayoutPanel.SuspendLayout();
            this.AddCustomerFormInnerTableLayoutPanel1.SuspendLayout();
            this.AddCustomerFormInnerTableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddCustomerFormTableLayoutPanel
            // 
            this.AddCustomerFormTableLayoutPanel.ColumnCount = 1;
            this.AddCustomerFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AddCustomerFormTableLayoutPanel.Controls.Add(this.AddCustomerFormInnerTableLayoutPanel1, 0, 0);
            this.AddCustomerFormTableLayoutPanel.Controls.Add(this.AddCustomerFormInnerTableLayoutPanel2, 0, 1);
            this.AddCustomerFormTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddCustomerFormTableLayoutPanel.Location = new System.Drawing.Point(40, 20);
            this.AddCustomerFormTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.AddCustomerFormTableLayoutPanel.Name = "AddCustomerFormTableLayoutPanel";
            this.AddCustomerFormTableLayoutPanel.RowCount = 2;
            this.AddCustomerFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AddCustomerFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AddCustomerFormTableLayoutPanel.Size = new System.Drawing.Size(304, 131);
            this.AddCustomerFormTableLayoutPanel.TabIndex = 0;
            // 
            // AddCustomerFormInnerTableLayoutPanel1
            // 
            this.AddCustomerFormInnerTableLayoutPanel1.ColumnCount = 2;
            this.AddCustomerFormInnerTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.5F));
            this.AddCustomerFormInnerTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.5F));
            this.AddCustomerFormInnerTableLayoutPanel1.Controls.Add(this.AddCustomerFormPNTextBox, 1, 1);
            this.AddCustomerFormInnerTableLayoutPanel1.Controls.Add(this.AddCustomerFormPNLabel, 0, 1);
            this.AddCustomerFormInnerTableLayoutPanel1.Controls.Add(this.AddCustomerFormNameLabel, 0, 0);
            this.AddCustomerFormInnerTableLayoutPanel1.Controls.Add(this.AddCustomerFormNameTextBox, 1, 0);
            this.AddCustomerFormInnerTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddCustomerFormInnerTableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.AddCustomerFormInnerTableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.AddCustomerFormInnerTableLayoutPanel1.Name = "AddCustomerFormInnerTableLayoutPanel1";
            this.AddCustomerFormInnerTableLayoutPanel1.RowCount = 2;
            this.AddCustomerFormInnerTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AddCustomerFormInnerTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AddCustomerFormInnerTableLayoutPanel1.Size = new System.Drawing.Size(304, 65);
            this.AddCustomerFormInnerTableLayoutPanel1.TabIndex = 0;
            // 
            // AddCustomerFormPNTextBox
            // 
            this.AddCustomerFormPNTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCustomerFormPNTextBox.Font = new System.Drawing.Font("굴림", 12F);
            this.AddCustomerFormPNTextBox.Location = new System.Drawing.Point(83, 35);
            this.AddCustomerFormPNTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.AddCustomerFormPNTextBox.MaxLength = 13;
            this.AddCustomerFormPNTextBox.Name = "AddCustomerFormPNTextBox";
            this.AddCustomerFormPNTextBox.Size = new System.Drawing.Size(221, 26);
            this.AddCustomerFormPNTextBox.TabIndex = 3;
            this.AddCustomerFormPNTextBox.TextChanged += new System.EventHandler(this.AddCustomerFormPNTextBox_TextChanged);
            this.AddCustomerFormPNTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddCustomerForm_KeyDown);
            this.AddCustomerFormPNTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddCustomerFormPNTextBox_KeyPress);
            // 
            // AddCustomerFormPNLabel
            // 
            this.AddCustomerFormPNLabel.AutoSize = true;
            this.AddCustomerFormPNLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddCustomerFormPNLabel.Font = new System.Drawing.Font("굴림", 12F);
            this.AddCustomerFormPNLabel.Location = new System.Drawing.Point(3, 32);
            this.AddCustomerFormPNLabel.Name = "AddCustomerFormPNLabel";
            this.AddCustomerFormPNLabel.Size = new System.Drawing.Size(77, 33);
            this.AddCustomerFormPNLabel.TabIndex = 1;
            this.AddCustomerFormPNLabel.Text = "전화번호:";
            this.AddCustomerFormPNLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddCustomerFormNameLabel
            // 
            this.AddCustomerFormNameLabel.AutoSize = true;
            this.AddCustomerFormNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddCustomerFormNameLabel.Font = new System.Drawing.Font("굴림", 12F);
            this.AddCustomerFormNameLabel.Location = new System.Drawing.Point(3, 0);
            this.AddCustomerFormNameLabel.Name = "AddCustomerFormNameLabel";
            this.AddCustomerFormNameLabel.Size = new System.Drawing.Size(77, 32);
            this.AddCustomerFormNameLabel.TabIndex = 0;
            this.AddCustomerFormNameLabel.Text = "고객명:";
            this.AddCustomerFormNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.AddCustomerFormInnerTableLayoutPanel2.ColumnCount = 2;
            this.AddCustomerFormInnerTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AddCustomerFormInnerTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AddCustomerFormInnerTableLayoutPanel2.Controls.Add(this.AddCustomerFormCancelButton, 1, 0);
            this.AddCustomerFormInnerTableLayoutPanel2.Controls.Add(this.AddCustomerFormConfirmButton, 0, 0);
            this.AddCustomerFormInnerTableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddCustomerFormInnerTableLayoutPanel2.Location = new System.Drawing.Point(0, 65);
            this.AddCustomerFormInnerTableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.AddCustomerFormInnerTableLayoutPanel2.Name = "AddCustomerFormInnerTableLayoutPanel2";
            this.AddCustomerFormInnerTableLayoutPanel2.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.AddCustomerFormInnerTableLayoutPanel2.RowCount = 1;
            this.AddCustomerFormInnerTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AddCustomerFormInnerTableLayoutPanel2.Size = new System.Drawing.Size(304, 66);
            this.AddCustomerFormInnerTableLayoutPanel2.TabIndex = 1;
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
            this.Controls.Add(this.AddCustomerFormTableLayoutPanel);
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
            this.AddCustomerFormTableLayoutPanel.ResumeLayout(false);
            this.AddCustomerFormInnerTableLayoutPanel1.ResumeLayout(false);
            this.AddCustomerFormInnerTableLayoutPanel1.PerformLayout();
            this.AddCustomerFormInnerTableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel AddCustomerFormTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel AddCustomerFormInnerTableLayoutPanel1;
        private System.Windows.Forms.Label AddCustomerFormNameLabel;
        private System.Windows.Forms.Label AddCustomerFormPNLabel;
        private System.Windows.Forms.TextBox AddCustomerFormNameTextBox;
        private System.Windows.Forms.TextBox AddCustomerFormPNTextBox;
        private System.Windows.Forms.TableLayoutPanel AddCustomerFormInnerTableLayoutPanel2;
        private System.Windows.Forms.Button AddCustomerFormCancelButton;
        private System.Windows.Forms.Button AddCustomerFormConfirmButton;
    }
}