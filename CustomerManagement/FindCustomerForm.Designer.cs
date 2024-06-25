namespace CustomerManagement
{
    partial class FindCustomerForm
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
            this.FindCustomerFormTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.FindCuscomerFormTextBox = new System.Windows.Forms.TextBox();
            this.FindCustomerFormInnerTableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.FindCustomerFormCancelButton = new System.Windows.Forms.Button();
            this.FindCustomerFormConfirmButton = new System.Windows.Forms.Button();
            this.AddCustomerFormInnerTableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FindCuscomerFormPNRB = new System.Windows.Forms.RadioButton();
            this.FindCuscomerFormNameRB = new System.Windows.Forms.RadioButton();
            this.FindCustomerFormTableLayoutPanel.SuspendLayout();
            this.FindCustomerFormInnerTableLayoutPanel3.SuspendLayout();
            this.AddCustomerFormInnerTableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FindCustomerFormTableLayoutPanel
            // 
            this.FindCustomerFormTableLayoutPanel.ColumnCount = 1;
            this.FindCustomerFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FindCustomerFormTableLayoutPanel.Controls.Add(this.FindCuscomerFormTextBox, 0, 1);
            this.FindCustomerFormTableLayoutPanel.Controls.Add(this.FindCustomerFormInnerTableLayoutPanel3, 0, 2);
            this.FindCustomerFormTableLayoutPanel.Controls.Add(this.AddCustomerFormInnerTableLayoutPanel1, 0, 0);
            this.FindCustomerFormTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FindCustomerFormTableLayoutPanel.Location = new System.Drawing.Point(40, 20);
            this.FindCustomerFormTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.FindCustomerFormTableLayoutPanel.Name = "FindCustomerFormTableLayoutPanel";
            this.FindCustomerFormTableLayoutPanel.RowCount = 3;
            this.FindCustomerFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.FindCustomerFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.FindCustomerFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FindCustomerFormTableLayoutPanel.Size = new System.Drawing.Size(304, 131);
            this.FindCustomerFormTableLayoutPanel.TabIndex = 1;
            // 
            // FindCuscomerFormTextBox
            // 
            this.FindCuscomerFormTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FindCuscomerFormTextBox.Font = new System.Drawing.Font("굴림", 12F);
            this.FindCuscomerFormTextBox.Location = new System.Drawing.Point(3, 35);
            this.FindCuscomerFormTextBox.MaxLength = 32;
            this.FindCuscomerFormTextBox.Name = "FindCuscomerFormTextBox";
            this.FindCuscomerFormTextBox.Size = new System.Drawing.Size(298, 26);
            this.FindCuscomerFormTextBox.TabIndex = 0;
            this.FindCuscomerFormTextBox.TextChanged += new System.EventHandler(this.FindCuscomerFormTextBox_TextChanged);
            this.FindCuscomerFormTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FindCustomerForm_KeyDown);
            this.FindCuscomerFormTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FindCuscomerFormTextBox_KeyPress);
            // 
            // FindCustomerFormInnerTableLayoutPanel3
            // 
            this.FindCustomerFormInnerTableLayoutPanel3.ColumnCount = 2;
            this.FindCustomerFormInnerTableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FindCustomerFormInnerTableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FindCustomerFormInnerTableLayoutPanel3.Controls.Add(this.FindCustomerFormCancelButton, 1, 0);
            this.FindCustomerFormInnerTableLayoutPanel3.Controls.Add(this.FindCustomerFormConfirmButton, 0, 0);
            this.FindCustomerFormInnerTableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FindCustomerFormInnerTableLayoutPanel3.Location = new System.Drawing.Point(0, 64);
            this.FindCustomerFormInnerTableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.FindCustomerFormInnerTableLayoutPanel3.Name = "FindCustomerFormInnerTableLayoutPanel3";
            this.FindCustomerFormInnerTableLayoutPanel3.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.FindCustomerFormInnerTableLayoutPanel3.RowCount = 1;
            this.FindCustomerFormInnerTableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FindCustomerFormInnerTableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.FindCustomerFormInnerTableLayoutPanel3.Size = new System.Drawing.Size(304, 67);
            this.FindCustomerFormInnerTableLayoutPanel3.TabIndex = 1;
            // 
            // FindCustomerFormCancelButton
            // 
            this.FindCustomerFormCancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FindCustomerFormCancelButton.Location = new System.Drawing.Point(155, 13);
            this.FindCustomerFormCancelButton.Name = "FindCustomerFormCancelButton";
            this.FindCustomerFormCancelButton.Size = new System.Drawing.Size(126, 41);
            this.FindCustomerFormCancelButton.TabIndex = 2;
            this.FindCustomerFormCancelButton.Text = "취소";
            this.FindCustomerFormCancelButton.UseVisualStyleBackColor = true;
            this.FindCustomerFormCancelButton.Click += new System.EventHandler(this.FindCustomerFormCancelButton_Click);
            // 
            // FindCustomerFormConfirmButton
            // 
            this.FindCustomerFormConfirmButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FindCustomerFormConfirmButton.Location = new System.Drawing.Point(23, 13);
            this.FindCustomerFormConfirmButton.Name = "FindCustomerFormConfirmButton";
            this.FindCustomerFormConfirmButton.Size = new System.Drawing.Size(126, 41);
            this.FindCustomerFormConfirmButton.TabIndex = 1;
            this.FindCustomerFormConfirmButton.Text = "확인";
            this.FindCustomerFormConfirmButton.UseVisualStyleBackColor = true;
            this.FindCustomerFormConfirmButton.Click += new System.EventHandler(this.FindCustomerFormConfirmButton_Click);
            // 
            // AddCustomerFormInnerTableLayoutPanel1
            // 
            this.AddCustomerFormInnerTableLayoutPanel1.ColumnCount = 2;
            this.AddCustomerFormInnerTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AddCustomerFormInnerTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AddCustomerFormInnerTableLayoutPanel1.Controls.Add(this.FindCuscomerFormPNRB, 1, 0);
            this.AddCustomerFormInnerTableLayoutPanel1.Controls.Add(this.FindCuscomerFormNameRB, 0, 0);
            this.AddCustomerFormInnerTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddCustomerFormInnerTableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.AddCustomerFormInnerTableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.AddCustomerFormInnerTableLayoutPanel1.Name = "AddCustomerFormInnerTableLayoutPanel1";
            this.AddCustomerFormInnerTableLayoutPanel1.RowCount = 1;
            this.AddCustomerFormInnerTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AddCustomerFormInnerTableLayoutPanel1.Size = new System.Drawing.Size(304, 32);
            this.AddCustomerFormInnerTableLayoutPanel1.TabIndex = 2;
            // 
            // FindCuscomerFormPNRB
            // 
            this.FindCuscomerFormPNRB.AutoSize = true;
            this.FindCuscomerFormPNRB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FindCuscomerFormPNRB.Font = new System.Drawing.Font("굴림", 9F);
            this.FindCuscomerFormPNRB.Location = new System.Drawing.Point(162, 3);
            this.FindCuscomerFormPNRB.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.FindCuscomerFormPNRB.Name = "FindCuscomerFormPNRB";
            this.FindCuscomerFormPNRB.Size = new System.Drawing.Size(139, 26);
            this.FindCuscomerFormPNRB.TabIndex = 1;
            this.FindCuscomerFormPNRB.Text = "전화번호로 검색하기";
            this.FindCuscomerFormPNRB.UseVisualStyleBackColor = true;
            this.FindCuscomerFormPNRB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FindCustomerForm_KeyDown);
            // 
            // FindCuscomerFormNameRB
            // 
            this.FindCuscomerFormNameRB.AutoSize = true;
            this.FindCuscomerFormNameRB.Checked = true;
            this.FindCuscomerFormNameRB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FindCuscomerFormNameRB.Font = new System.Drawing.Font("굴림", 9F);
            this.FindCuscomerFormNameRB.Location = new System.Drawing.Point(10, 3);
            this.FindCuscomerFormNameRB.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.FindCuscomerFormNameRB.Name = "FindCuscomerFormNameRB";
            this.FindCuscomerFormNameRB.Size = new System.Drawing.Size(139, 26);
            this.FindCuscomerFormNameRB.TabIndex = 0;
            this.FindCuscomerFormNameRB.TabStop = true;
            this.FindCuscomerFormNameRB.Text = "이름으로 검색하기";
            this.FindCuscomerFormNameRB.UseVisualStyleBackColor = true;
            this.FindCuscomerFormNameRB.CheckedChanged += new System.EventHandler(this.FindCuscomerForm_CheckedChanged);
            this.FindCuscomerFormNameRB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FindCustomerForm_KeyDown);
            // 
            // FindCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.FindCustomerFormTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindCustomerForm";
            this.Padding = new System.Windows.Forms.Padding(40, 20, 40, 10);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "고객 찾기";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FindCustomerForm_KeyDown);
            this.FindCustomerFormTableLayoutPanel.ResumeLayout(false);
            this.FindCustomerFormTableLayoutPanel.PerformLayout();
            this.FindCustomerFormInnerTableLayoutPanel3.ResumeLayout(false);
            this.AddCustomerFormInnerTableLayoutPanel1.ResumeLayout(false);
            this.AddCustomerFormInnerTableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel FindCustomerFormTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel FindCustomerFormInnerTableLayoutPanel3;
        private System.Windows.Forms.Button FindCustomerFormCancelButton;
        private System.Windows.Forms.Button FindCustomerFormConfirmButton;
        private System.Windows.Forms.TableLayoutPanel AddCustomerFormInnerTableLayoutPanel1;
        private System.Windows.Forms.RadioButton FindCuscomerFormNameRB;
        private System.Windows.Forms.RadioButton FindCuscomerFormPNRB;
        private System.Windows.Forms.TextBox FindCuscomerFormTextBox;
    }
}