
namespace CustomerManagement
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CustomerButton_TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Customer_Find_Button = new System.Windows.Forms.Button();
            this.Customer_Delete_Button = new System.Windows.Forms.Button();
            this.Customer_Add_Button = new System.Windows.Forms.Button();
            this.Customer_Modify_Button = new System.Windows.Forms.Button();
            this.CustomerListView = new System.Windows.Forms.ListView();
            this.CustomerListView_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerListView_PN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GarmentTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Garment_Button_TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Garment_Delete_Button = new System.Windows.Forms.Button();
            this.Garment_Modify_Button = new System.Windows.Forms.Button();
            this.Garment_New_Button = new System.Windows.Forms.Button();
            this.Customer_Name_Label = new System.Windows.Forms.Label();
            this.GarmentListView = new System.Windows.Forms.ListView();
            this.GarmentListView_ReceptionDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GarmentListView_ProcessingDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GarmentListView_Completion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GarmentListView_Content = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GarmentListView_Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GarmentListView_Note = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            this.MainTableLayoutPanel.SuspendLayout();
            this.CustomerButton_TableLayoutPanel.SuspendLayout();
            this.GarmentTableLayoutPanel.SuspendLayout();
            this.Garment_Button_TableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.MainSplitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Controls.Add(this.MainTableLayoutPanel);
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.GarmentTableLayoutPanel);
            this.MainSplitContainer.Size = new System.Drawing.Size(1264, 701);
            this.MainSplitContainer.SplitterDistance = 420;
            this.MainSplitContainer.SplitterWidth = 2;
            this.MainSplitContainer.TabIndex = 0;
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 1;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Controls.Add(this.CustomerButton_TableLayoutPanel, 0, 0);
            this.MainTableLayoutPanel.Controls.Add(this.CustomerListView, 0, 1);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 2;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.5F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(420, 701);
            this.MainTableLayoutPanel.TabIndex = 0;
            // 
            // CustomerButton_TableLayoutPanel
            // 
            this.CustomerButton_TableLayoutPanel.ColumnCount = 7;
            this.CustomerButton_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.33F));
            this.CustomerButton_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.CustomerButton_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.CustomerButton_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.CustomerButton_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.33F));
            this.CustomerButton_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.CustomerButton_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.34F));
            this.CustomerButton_TableLayoutPanel.Controls.Add(this.Customer_Find_Button, 5, 0);
            this.CustomerButton_TableLayoutPanel.Controls.Add(this.Customer_Delete_Button, 3, 0);
            this.CustomerButton_TableLayoutPanel.Controls.Add(this.Customer_Add_Button, 1, 0);
            this.CustomerButton_TableLayoutPanel.Controls.Add(this.Customer_Modify_Button, 2, 0);
            this.CustomerButton_TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerButton_TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.CustomerButton_TableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.CustomerButton_TableLayoutPanel.Name = "CustomerButton_TableLayoutPanel";
            this.CustomerButton_TableLayoutPanel.RowCount = 1;
            this.CustomerButton_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CustomerButton_TableLayoutPanel.Size = new System.Drawing.Size(420, 52);
            this.CustomerButton_TableLayoutPanel.TabIndex = 3;
            // 
            // Customer_Find_Button
            // 
            this.Customer_Find_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Customer_Find_Button.Image = global::CustomerManagement.Properties.Resources.find;
            this.Customer_Find_Button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Customer_Find_Button.Location = new System.Drawing.Point(294, 0);
            this.Customer_Find_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Customer_Find_Button.Name = "Customer_Find_Button";
            this.Customer_Find_Button.Size = new System.Drawing.Size(50, 52);
            this.Customer_Find_Button.TabIndex = 3;
            this.Customer_Find_Button.UseVisualStyleBackColor = true;
            this.Customer_Find_Button.Click += new System.EventHandler(this.Customer_Find_Button_Click);
            // 
            // Customer_Delete_Button
            // 
            this.Customer_Delete_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Customer_Delete_Button.Image = global::CustomerManagement.Properties.Resources.delete;
            this.Customer_Delete_Button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Customer_Delete_Button.Location = new System.Drawing.Point(172, 0);
            this.Customer_Delete_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Customer_Delete_Button.Name = "Customer_Delete_Button";
            this.Customer_Delete_Button.Size = new System.Drawing.Size(50, 52);
            this.Customer_Delete_Button.TabIndex = 2;
            this.Customer_Delete_Button.UseVisualStyleBackColor = true;
            this.Customer_Delete_Button.Click += new System.EventHandler(this.Customer_Delete_Button_Click);
            // 
            // Customer_Add_Button
            // 
            this.Customer_Add_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Customer_Add_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Customer_Add_Button.Image = global::CustomerManagement.Properties.Resources._new;
            this.Customer_Add_Button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Customer_Add_Button.Location = new System.Drawing.Point(72, 0);
            this.Customer_Add_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Customer_Add_Button.Name = "Customer_Add_Button";
            this.Customer_Add_Button.Size = new System.Drawing.Size(50, 52);
            this.Customer_Add_Button.TabIndex = 0;
            this.Customer_Add_Button.UseVisualStyleBackColor = true;
            this.Customer_Add_Button.Click += new System.EventHandler(this.Customer_Add_Button_Click);
            // 
            // Customer_Modify_Button
            // 
            this.Customer_Modify_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Customer_Modify_Button.Image = global::CustomerManagement.Properties.Resources.modify;
            this.Customer_Modify_Button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Customer_Modify_Button.Location = new System.Drawing.Point(122, 0);
            this.Customer_Modify_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Customer_Modify_Button.Name = "Customer_Modify_Button";
            this.Customer_Modify_Button.Size = new System.Drawing.Size(50, 52);
            this.Customer_Modify_Button.TabIndex = 1;
            this.Customer_Modify_Button.UseVisualStyleBackColor = true;
            this.Customer_Modify_Button.Click += new System.EventHandler(this.Customer_Modify_Button_Click);
            // 
            // CustomerListView
            // 
            this.CustomerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CustomerListView_Name,
            this.CustomerListView_PN});
            this.CustomerListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerListView.FullRowSelect = true;
            this.CustomerListView.HideSelection = false;
            this.CustomerListView.Location = new System.Drawing.Point(0, 52);
            this.CustomerListView.Margin = new System.Windows.Forms.Padding(0);
            this.CustomerListView.Name = "CustomerListView";
            this.CustomerListView.Size = new System.Drawing.Size(420, 649);
            this.CustomerListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.CustomerListView.TabIndex = 0;
            this.CustomerListView.UseCompatibleStateImageBehavior = false;
            this.CustomerListView.View = System.Windows.Forms.View.Details;
            this.CustomerListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.CustomerListView_ColumnClick);
            this.CustomerListView.SelectedIndexChanged += new System.EventHandler(this.CustomerListView_SelectedIndexChanged);
            // 
            // CustomerListView_Name
            // 
            this.CustomerListView_Name.Text = "이름";
            this.CustomerListView_Name.Width = 225;
            // 
            // CustomerListView_PN
            // 
            this.CustomerListView_PN.Text = "전화번호";
            this.CustomerListView_PN.Width = 185;
            // 
            // GarmentTableLayoutPanel
            // 
            this.GarmentTableLayoutPanel.ColumnCount = 1;
            this.GarmentTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GarmentTableLayoutPanel.Controls.Add(this.Garment_Button_TableLayoutPanel, 0, 0);
            this.GarmentTableLayoutPanel.Controls.Add(this.GarmentListView, 0, 1);
            this.GarmentTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GarmentTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.GarmentTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.GarmentTableLayoutPanel.Name = "GarmentTableLayoutPanel";
            this.GarmentTableLayoutPanel.RowCount = 2;
            this.GarmentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.GarmentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.5F));
            this.GarmentTableLayoutPanel.Size = new System.Drawing.Size(842, 701);
            this.GarmentTableLayoutPanel.TabIndex = 1;
            // 
            // Garment_Button_TableLayoutPanel
            // 
            this.Garment_Button_TableLayoutPanel.ColumnCount = 5;
            this.Garment_Button_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.Garment_Button_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.Garment_Button_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.Garment_Button_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.Garment_Button_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.Garment_Button_TableLayoutPanel.Controls.Add(this.Garment_Delete_Button, 3, 0);
            this.Garment_Button_TableLayoutPanel.Controls.Add(this.Garment_Modify_Button, 2, 0);
            this.Garment_Button_TableLayoutPanel.Controls.Add(this.Garment_New_Button, 1, 0);
            this.Garment_Button_TableLayoutPanel.Controls.Add(this.Customer_Name_Label, 0, 0);
            this.Garment_Button_TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Garment_Button_TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.Garment_Button_TableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.Garment_Button_TableLayoutPanel.Name = "Garment_Button_TableLayoutPanel";
            this.Garment_Button_TableLayoutPanel.RowCount = 1;
            this.Garment_Button_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Garment_Button_TableLayoutPanel.Size = new System.Drawing.Size(842, 52);
            this.Garment_Button_TableLayoutPanel.TabIndex = 5;
            // 
            // Garment_Delete_Button
            // 
            this.Garment_Delete_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Garment_Delete_Button.Image = ((System.Drawing.Image)(resources.GetObject("Garment_Delete_Button.Image")));
            this.Garment_Delete_Button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Garment_Delete_Button.Location = new System.Drawing.Point(689, 0);
            this.Garment_Delete_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Garment_Delete_Button.Name = "Garment_Delete_Button";
            this.Garment_Delete_Button.Size = new System.Drawing.Size(50, 52);
            this.Garment_Delete_Button.TabIndex = 5;
            this.Garment_Delete_Button.UseVisualStyleBackColor = true;
            // 
            // Garment_Modify_Button
            // 
            this.Garment_Modify_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Garment_Modify_Button.Image = global::CustomerManagement.Properties.Resources.modify;
            this.Garment_Modify_Button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Garment_Modify_Button.Location = new System.Drawing.Point(639, 0);
            this.Garment_Modify_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Garment_Modify_Button.Name = "Garment_Modify_Button";
            this.Garment_Modify_Button.Size = new System.Drawing.Size(50, 52);
            this.Garment_Modify_Button.TabIndex = 2;
            this.Garment_Modify_Button.UseVisualStyleBackColor = true;
            // 
            // Garment_New_Button
            // 
            this.Garment_New_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Garment_New_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Garment_New_Button.Image = global::CustomerManagement.Properties.Resources._new;
            this.Garment_New_Button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Garment_New_Button.Location = new System.Drawing.Point(589, 0);
            this.Garment_New_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Garment_New_Button.Name = "Garment_New_Button";
            this.Garment_New_Button.Size = new System.Drawing.Size(50, 52);
            this.Garment_New_Button.TabIndex = 1;
            this.Garment_New_Button.UseVisualStyleBackColor = true;
            // 
            // Customer_Name_Label
            // 
            this.Customer_Name_Label.AutoSize = true;
            this.Customer_Name_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Customer_Name_Label.Font = new System.Drawing.Font("굴림", 18F);
            this.Customer_Name_Label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Customer_Name_Label.Location = new System.Drawing.Point(9, 0);
            this.Customer_Name_Label.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.Customer_Name_Label.Name = "Customer_Name_Label";
            this.Customer_Name_Label.Size = new System.Drawing.Size(571, 52);
            this.Customer_Name_Label.TabIndex = 6;
            this.Customer_Name_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GarmentListView
            // 
            this.GarmentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.GarmentListView_ReceptionDate,
            this.GarmentListView_ProcessingDate,
            this.GarmentListView_Completion,
            this.GarmentListView_Content,
            this.GarmentListView_Amount,
            this.GarmentListView_Note});
            this.GarmentListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GarmentListView.FullRowSelect = true;
            this.GarmentListView.HideSelection = false;
            this.GarmentListView.Location = new System.Drawing.Point(0, 52);
            this.GarmentListView.Margin = new System.Windows.Forms.Padding(0);
            this.GarmentListView.Name = "GarmentListView";
            this.GarmentListView.Size = new System.Drawing.Size(842, 649);
            this.GarmentListView.TabIndex = 0;
            this.GarmentListView.UseCompatibleStateImageBehavior = false;
            this.GarmentListView.View = System.Windows.Forms.View.Details;
            // 
            // GarmentListView_ReceptionDate
            // 
            this.GarmentListView_ReceptionDate.Text = "접수일자";
            this.GarmentListView_ReceptionDate.Width = 105;
            // 
            // GarmentListView_ProcessingDate
            // 
            this.GarmentListView_ProcessingDate.Text = "처리일자";
            this.GarmentListView_ProcessingDate.Width = 105;
            // 
            // GarmentListView_Completion
            // 
            this.GarmentListView_Completion.Text = "완료구분";
            this.GarmentListView_Completion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GarmentListView_Content
            // 
            this.GarmentListView_Content.Text = "내용";
            this.GarmentListView_Content.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GarmentListView_Content.Width = 350;
            // 
            // GarmentListView_Amount
            // 
            this.GarmentListView_Amount.Text = "금액";
            this.GarmentListView_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GarmentListView_Amount.Width = 100;
            // 
            // GarmentListView_Note
            // 
            this.GarmentListView_Note.Text = "비고";
            this.GarmentListView_Note.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GarmentListView_Note.Width = 119;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 701);
            this.Controls.Add(this.MainSplitContainer);
            this.MinimumSize = new System.Drawing.Size(640, 369);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "고객관리";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.CustomerButton_TableLayoutPanel.ResumeLayout(false);
            this.GarmentTableLayoutPanel.ResumeLayout(false);
            this.Garment_Button_TableLayoutPanel.ResumeLayout(false);
            this.Garment_Button_TableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer MainSplitContainer;
        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.ListView CustomerListView;
        private System.Windows.Forms.TableLayoutPanel GarmentTableLayoutPanel;
        private System.Windows.Forms.ColumnHeader CustomerListView_Name;
        private System.Windows.Forms.ColumnHeader CustomerListView_PN;
        private System.Windows.Forms.ListView GarmentListView;
        private System.Windows.Forms.ColumnHeader GarmentListView_ReceptionDate;
        private System.Windows.Forms.ColumnHeader GarmentListView_ProcessingDate;
        private System.Windows.Forms.ColumnHeader GarmentListView_Completion;
        private System.Windows.Forms.ColumnHeader GarmentListView_Content;
        private System.Windows.Forms.ColumnHeader GarmentListView_Amount;
        private System.Windows.Forms.ColumnHeader GarmentListView_Note;
        private System.Windows.Forms.TableLayoutPanel CustomerButton_TableLayoutPanel;
        private System.Windows.Forms.Button Customer_Find_Button;
        private System.Windows.Forms.Button Customer_Delete_Button;
        private System.Windows.Forms.Button Customer_Add_Button;
        private System.Windows.Forms.Button Customer_Modify_Button;
        private System.Windows.Forms.TableLayoutPanel Garment_Button_TableLayoutPanel;
        private System.Windows.Forms.Button Garment_Delete_Button;
        private System.Windows.Forms.Button Garment_Modify_Button;
        private System.Windows.Forms.Button Garment_New_Button;
        private System.Windows.Forms.Label Customer_Name_Label;
    }
}

