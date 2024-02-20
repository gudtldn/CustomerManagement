
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
            this.MainButton_TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Main_Find_Button = new System.Windows.Forms.Button();
            this.Main_Delete_Button = new System.Windows.Forms.Button();
            this.Main_Add_Button = new System.Windows.Forms.Button();
            this.Main_Modify_Button = new System.Windows.Forms.Button();
            this.MainListView = new System.Windows.Forms.ListView();
            this.MainListView_CustomerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MainListView_PN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Sub_Button_TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Sub_Delete_Button = new System.Windows.Forms.Button();
            this.Sub_Modify_Button = new System.Windows.Forms.Button();
            this.Sub_New_Button = new System.Windows.Forms.Button();
            this.Customer_Name_Label = new System.Windows.Forms.Label();
            this.SubListView = new System.Windows.Forms.ListView();
            this.SubListView_ReceptionDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubListView_ProcessingDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubListView_Completion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubListView_Content = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubListView_Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubListView_Note = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            this.MainTableLayoutPanel.SuspendLayout();
            this.MainButton_TableLayoutPanel.SuspendLayout();
            this.SubTableLayoutPanel.SuspendLayout();
            this.Sub_Button_TableLayoutPanel.SuspendLayout();
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
            this.MainSplitContainer.Panel2.Controls.Add(this.SubTableLayoutPanel);
            this.MainSplitContainer.Size = new System.Drawing.Size(1264, 701);
            this.MainSplitContainer.SplitterDistance = 421;
            this.MainSplitContainer.SplitterWidth = 2;
            this.MainSplitContainer.TabIndex = 0;
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 1;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Controls.Add(this.MainButton_TableLayoutPanel, 0, 0);
            this.MainTableLayoutPanel.Controls.Add(this.MainListView, 0, 1);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 2;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.5F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(421, 701);
            this.MainTableLayoutPanel.TabIndex = 0;
            // 
            // MainButton_TableLayoutPanel
            // 
            this.MainButton_TableLayoutPanel.ColumnCount = 7;
            this.MainButton_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.33F));
            this.MainButton_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.MainButton_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.MainButton_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.MainButton_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.33F));
            this.MainButton_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.MainButton_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.34F));
            this.MainButton_TableLayoutPanel.Controls.Add(this.Main_Find_Button, 5, 0);
            this.MainButton_TableLayoutPanel.Controls.Add(this.Main_Delete_Button, 3, 0);
            this.MainButton_TableLayoutPanel.Controls.Add(this.Main_Add_Button, 1, 0);
            this.MainButton_TableLayoutPanel.Controls.Add(this.Main_Modify_Button, 2, 0);
            this.MainButton_TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainButton_TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainButton_TableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainButton_TableLayoutPanel.Name = "MainButton_TableLayoutPanel";
            this.MainButton_TableLayoutPanel.RowCount = 1;
            this.MainButton_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainButton_TableLayoutPanel.Size = new System.Drawing.Size(421, 52);
            this.MainButton_TableLayoutPanel.TabIndex = 3;
            // 
            // Main_Find_Button
            // 
            this.Main_Find_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Find_Button.Image = global::CustomerManagement.Properties.Resources.find;
            this.Main_Find_Button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Main_Find_Button.Location = new System.Drawing.Point(294, 0);
            this.Main_Find_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Main_Find_Button.Name = "Main_Find_Button";
            this.Main_Find_Button.Size = new System.Drawing.Size(50, 52);
            this.Main_Find_Button.TabIndex = 3;
            this.Main_Find_Button.UseVisualStyleBackColor = true;
            // 
            // Main_Delete_Button
            // 
            this.Main_Delete_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Delete_Button.Image = global::CustomerManagement.Properties.Resources.delete;
            this.Main_Delete_Button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Main_Delete_Button.Location = new System.Drawing.Point(172, 0);
            this.Main_Delete_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Main_Delete_Button.Name = "Main_Delete_Button";
            this.Main_Delete_Button.Size = new System.Drawing.Size(50, 52);
            this.Main_Delete_Button.TabIndex = 2;
            this.Main_Delete_Button.UseVisualStyleBackColor = true;
            // 
            // Main_Add_Button
            // 
            this.Main_Add_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Main_Add_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Add_Button.Image = global::CustomerManagement.Properties.Resources._new;
            this.Main_Add_Button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Main_Add_Button.Location = new System.Drawing.Point(72, 0);
            this.Main_Add_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Main_Add_Button.Name = "Main_Add_Button";
            this.Main_Add_Button.Size = new System.Drawing.Size(50, 52);
            this.Main_Add_Button.TabIndex = 0;
            this.Main_Add_Button.UseVisualStyleBackColor = true;
            // 
            // Main_Modify_Button
            // 
            this.Main_Modify_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Modify_Button.Image = global::CustomerManagement.Properties.Resources.modify;
            this.Main_Modify_Button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Main_Modify_Button.Location = new System.Drawing.Point(122, 0);
            this.Main_Modify_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Main_Modify_Button.Name = "Main_Modify_Button";
            this.Main_Modify_Button.Size = new System.Drawing.Size(50, 52);
            this.Main_Modify_Button.TabIndex = 1;
            this.Main_Modify_Button.UseVisualStyleBackColor = true;
            // 
            // MainListView
            // 
            this.MainListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MainListView_CustomerName,
            this.MainListView_PN});
            this.MainListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainListView.HideSelection = false;
            this.MainListView.Location = new System.Drawing.Point(0, 52);
            this.MainListView.Margin = new System.Windows.Forms.Padding(0);
            this.MainListView.Name = "MainListView";
            this.MainListView.Size = new System.Drawing.Size(421, 649);
            this.MainListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.MainListView.TabIndex = 0;
            this.MainListView.UseCompatibleStateImageBehavior = false;
            this.MainListView.View = System.Windows.Forms.View.Details;
            this.MainListView.VirtualMode = true;
            // 
            // MainListView_CustomerName
            // 
            this.MainListView_CustomerName.Text = "이름";
            this.MainListView_CustomerName.Width = 225;
            // 
            // MainListView_PN
            // 
            this.MainListView_PN.Text = "전화번호";
            this.MainListView_PN.Width = 185;
            // 
            // SubTableLayoutPanel
            // 
            this.SubTableLayoutPanel.ColumnCount = 1;
            this.SubTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SubTableLayoutPanel.Controls.Add(this.Sub_Button_TableLayoutPanel, 0, 0);
            this.SubTableLayoutPanel.Controls.Add(this.SubListView, 0, 1);
            this.SubTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.SubTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.SubTableLayoutPanel.Name = "SubTableLayoutPanel";
            this.SubTableLayoutPanel.RowCount = 2;
            this.SubTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.SubTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.5F));
            this.SubTableLayoutPanel.Size = new System.Drawing.Size(841, 701);
            this.SubTableLayoutPanel.TabIndex = 1;
            // 
            // Sub_Button_TableLayoutPanel
            // 
            this.Sub_Button_TableLayoutPanel.ColumnCount = 5;
            this.Sub_Button_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.Sub_Button_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.Sub_Button_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.Sub_Button_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.Sub_Button_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.Sub_Button_TableLayoutPanel.Controls.Add(this.Sub_Delete_Button, 3, 0);
            this.Sub_Button_TableLayoutPanel.Controls.Add(this.Sub_Modify_Button, 2, 0);
            this.Sub_Button_TableLayoutPanel.Controls.Add(this.Sub_New_Button, 1, 0);
            this.Sub_Button_TableLayoutPanel.Controls.Add(this.Customer_Name_Label, 0, 0);
            this.Sub_Button_TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sub_Button_TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.Sub_Button_TableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.Sub_Button_TableLayoutPanel.Name = "Sub_Button_TableLayoutPanel";
            this.Sub_Button_TableLayoutPanel.RowCount = 1;
            this.Sub_Button_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Sub_Button_TableLayoutPanel.Size = new System.Drawing.Size(841, 52);
            this.Sub_Button_TableLayoutPanel.TabIndex = 5;
            // 
            // Sub_Delete_Button
            // 
            this.Sub_Delete_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sub_Delete_Button.Image = ((System.Drawing.Image)(resources.GetObject("Sub_Delete_Button.Image")));
            this.Sub_Delete_Button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Sub_Delete_Button.Location = new System.Drawing.Point(688, 0);
            this.Sub_Delete_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Sub_Delete_Button.Name = "Sub_Delete_Button";
            this.Sub_Delete_Button.Size = new System.Drawing.Size(50, 52);
            this.Sub_Delete_Button.TabIndex = 5;
            this.Sub_Delete_Button.UseVisualStyleBackColor = true;
            // 
            // Sub_Modify_Button
            // 
            this.Sub_Modify_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sub_Modify_Button.Image = global::CustomerManagement.Properties.Resources.modify;
            this.Sub_Modify_Button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Sub_Modify_Button.Location = new System.Drawing.Point(638, 0);
            this.Sub_Modify_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Sub_Modify_Button.Name = "Sub_Modify_Button";
            this.Sub_Modify_Button.Size = new System.Drawing.Size(50, 52);
            this.Sub_Modify_Button.TabIndex = 2;
            this.Sub_Modify_Button.UseVisualStyleBackColor = true;
            // 
            // Sub_New_Button
            // 
            this.Sub_New_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sub_New_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sub_New_Button.Image = global::CustomerManagement.Properties.Resources._new;
            this.Sub_New_Button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Sub_New_Button.Location = new System.Drawing.Point(588, 0);
            this.Sub_New_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Sub_New_Button.Name = "Sub_New_Button";
            this.Sub_New_Button.Size = new System.Drawing.Size(50, 52);
            this.Sub_New_Button.TabIndex = 1;
            this.Sub_New_Button.UseVisualStyleBackColor = true;
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
            this.Customer_Name_Label.Size = new System.Drawing.Size(570, 52);
            this.Customer_Name_Label.TabIndex = 6;
            this.Customer_Name_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SubListView
            // 
            this.SubListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SubListView_ReceptionDate,
            this.SubListView_ProcessingDate,
            this.SubListView_Completion,
            this.SubListView_Content,
            this.SubListView_Amount,
            this.SubListView_Note});
            this.SubListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubListView.HideSelection = false;
            this.SubListView.Location = new System.Drawing.Point(0, 52);
            this.SubListView.Margin = new System.Windows.Forms.Padding(0);
            this.SubListView.Name = "SubListView";
            this.SubListView.Size = new System.Drawing.Size(841, 649);
            this.SubListView.TabIndex = 0;
            this.SubListView.UseCompatibleStateImageBehavior = false;
            this.SubListView.View = System.Windows.Forms.View.Details;
            // 
            // SubListView_ReceptionDate
            // 
            this.SubListView_ReceptionDate.Text = "접수일자";
            this.SubListView_ReceptionDate.Width = 105;
            // 
            // SubListView_ProcessingDate
            // 
            this.SubListView_ProcessingDate.Text = "처리일자";
            this.SubListView_ProcessingDate.Width = 105;
            // 
            // SubListView_Completion
            // 
            this.SubListView_Completion.Text = "완료구분";
            this.SubListView_Completion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SubListView_Content
            // 
            this.SubListView_Content.Text = "내용";
            this.SubListView_Content.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SubListView_Content.Width = 350;
            // 
            // SubListView_Amount
            // 
            this.SubListView_Amount.Text = "금액";
            this.SubListView_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SubListView_Amount.Width = 100;
            // 
            // SubListView_Note
            // 
            this.SubListView_Note.Text = "비고";
            this.SubListView_Note.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SubListView_Note.Width = 119;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 701);
            this.Controls.Add(this.MainSplitContainer);
            this.MinimumSize = new System.Drawing.Size(640, 370);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "고객관리";
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.MainButton_TableLayoutPanel.ResumeLayout(false);
            this.SubTableLayoutPanel.ResumeLayout(false);
            this.Sub_Button_TableLayoutPanel.ResumeLayout(false);
            this.Sub_Button_TableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer MainSplitContainer;
        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.ListView MainListView;
        private System.Windows.Forms.TableLayoutPanel SubTableLayoutPanel;
        private System.Windows.Forms.ColumnHeader MainListView_CustomerName;
        private System.Windows.Forms.ColumnHeader MainListView_PN;
        private System.Windows.Forms.ListView SubListView;
        private System.Windows.Forms.ColumnHeader SubListView_ReceptionDate;
        private System.Windows.Forms.ColumnHeader SubListView_ProcessingDate;
        private System.Windows.Forms.ColumnHeader SubListView_Completion;
        private System.Windows.Forms.ColumnHeader SubListView_Content;
        private System.Windows.Forms.ColumnHeader SubListView_Amount;
        private System.Windows.Forms.ColumnHeader SubListView_Note;
        private System.Windows.Forms.TableLayoutPanel MainButton_TableLayoutPanel;
        private System.Windows.Forms.Button Main_Find_Button;
        private System.Windows.Forms.Button Main_Delete_Button;
        private System.Windows.Forms.Button Main_Add_Button;
        private System.Windows.Forms.Button Main_Modify_Button;
        private System.Windows.Forms.TableLayoutPanel Sub_Button_TableLayoutPanel;
        private System.Windows.Forms.Button Sub_Delete_Button;
        private System.Windows.Forms.Button Sub_Modify_Button;
        private System.Windows.Forms.Button Sub_New_Button;
        private System.Windows.Forms.Label Customer_Name_Label;
    }
}

