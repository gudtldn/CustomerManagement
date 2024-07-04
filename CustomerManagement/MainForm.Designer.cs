
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
            System.Windows.Forms.SplitContainer MainSplitContainer;
            System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
            System.Windows.Forms.TableLayoutPanel CustomerButton_TableLayoutPanel;
            System.Windows.Forms.ColumnHeader CustomerListView_Name;
            System.Windows.Forms.ColumnHeader CustomerListView_PN;
            System.Windows.Forms.TableLayoutPanel MainStatusTableLayoutPanel;
            System.Windows.Forms.Label MainStatusLabel;
            System.Windows.Forms.TableLayoutPanel GarmentTableLayoutPanel;
            System.Windows.Forms.TableLayoutPanel Garment_Button_TableLayoutPanel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.ColumnHeader GarmentListView_ReceptionDate;
            System.Windows.Forms.ColumnHeader GarmentListView_ProcessingDate;
            System.Windows.Forms.ColumnHeader GarmentListView_Completion;
            System.Windows.Forms.ColumnHeader GarmentListView_Content;
            System.Windows.Forms.ColumnHeader GarmentListView_Amount;
            System.Windows.Forms.ColumnHeader GarmentListView_Note;
            System.Windows.Forms.TableLayoutPanel GarmentStatusTableLayoutPanel;
            System.Windows.Forms.ColumnHeader CustomerListView_Note;
            this.Customer_Find_Button = new System.Windows.Forms.Button();
            this.Customer_Delete_Button = new System.Windows.Forms.Button();
            this.Customer_Add_Button = new System.Windows.Forms.Button();
            this.Customer_Modify_Button = new System.Windows.Forms.Button();
            this.CustomerListView = new System.Windows.Forms.ListView();
            this.MainStatusCountLabel = new System.Windows.Forms.Label();
            this.Garment_Delete_Button = new System.Windows.Forms.Button();
            this.Garment_Modify_Button = new System.Windows.Forms.Button();
            this.Garment_Add_Button = new System.Windows.Forms.Button();
            this.Customer_Name_Label = new System.Windows.Forms.Label();
            this.GarmentListView = new System.Windows.Forms.ListView();
            this.GarmentStatusTotalMoneyLabel = new System.Windows.Forms.Label();
            this.GarmentStatusCountLabel = new System.Windows.Forms.Label();
            MainSplitContainer = new System.Windows.Forms.SplitContainer();
            MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            CustomerButton_TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            CustomerListView_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            CustomerListView_PN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            MainStatusTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            MainStatusLabel = new System.Windows.Forms.Label();
            GarmentTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            Garment_Button_TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            GarmentListView_ReceptionDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            GarmentListView_ProcessingDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            GarmentListView_Completion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            GarmentListView_Content = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            GarmentListView_Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            GarmentListView_Note = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            GarmentStatusTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            CustomerListView_Note = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(MainSplitContainer)).BeginInit();
            MainSplitContainer.Panel1.SuspendLayout();
            MainSplitContainer.Panel2.SuspendLayout();
            MainSplitContainer.SuspendLayout();
            MainTableLayoutPanel.SuspendLayout();
            CustomerButton_TableLayoutPanel.SuspendLayout();
            MainStatusTableLayoutPanel.SuspendLayout();
            GarmentTableLayoutPanel.SuspendLayout();
            Garment_Button_TableLayoutPanel.SuspendLayout();
            GarmentStatusTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainSplitContainer
            // 
            MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            MainSplitContainer.Location = new System.Drawing.Point(0, 0);
            MainSplitContainer.Margin = new System.Windows.Forms.Padding(0);
            MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            MainSplitContainer.Panel1.Controls.Add(MainTableLayoutPanel);
            // 
            // MainSplitContainer.Panel2
            // 
            MainSplitContainer.Panel2.Controls.Add(GarmentTableLayoutPanel);
            MainSplitContainer.Size = new System.Drawing.Size(1264, 701);
            MainSplitContainer.SplitterDistance = 420;
            MainSplitContainer.SplitterWidth = 2;
            MainSplitContainer.TabIndex = 0;
            // 
            // MainTableLayoutPanel
            // 
            MainTableLayoutPanel.ColumnCount = 1;
            MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            MainTableLayoutPanel.Controls.Add(CustomerButton_TableLayoutPanel, 0, 0);
            MainTableLayoutPanel.Controls.Add(this.CustomerListView, 0, 1);
            MainTableLayoutPanel.Controls.Add(MainStatusTableLayoutPanel, 0, 2);
            MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            MainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            MainTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            MainTableLayoutPanel.RowCount = 3;
            MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            MainTableLayoutPanel.Size = new System.Drawing.Size(420, 701);
            MainTableLayoutPanel.TabIndex = 0;
            // 
            // CustomerButton_TableLayoutPanel
            // 
            CustomerButton_TableLayoutPanel.ColumnCount = 7;
            CustomerButton_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.33F));
            CustomerButton_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            CustomerButton_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            CustomerButton_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            CustomerButton_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.33F));
            CustomerButton_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            CustomerButton_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.34F));
            CustomerButton_TableLayoutPanel.Controls.Add(this.Customer_Find_Button, 5, 0);
            CustomerButton_TableLayoutPanel.Controls.Add(this.Customer_Delete_Button, 3, 0);
            CustomerButton_TableLayoutPanel.Controls.Add(this.Customer_Add_Button, 1, 0);
            CustomerButton_TableLayoutPanel.Controls.Add(this.Customer_Modify_Button, 2, 0);
            CustomerButton_TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            CustomerButton_TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            CustomerButton_TableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            CustomerButton_TableLayoutPanel.Name = "CustomerButton_TableLayoutPanel";
            CustomerButton_TableLayoutPanel.RowCount = 1;
            CustomerButton_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            CustomerButton_TableLayoutPanel.Size = new System.Drawing.Size(420, 55);
            CustomerButton_TableLayoutPanel.TabIndex = 3;
            // 
            // Customer_Find_Button
            // 
            this.Customer_Find_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Customer_Find_Button.Image = global::CustomerManagement.Properties.Resources.find;
            this.Customer_Find_Button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Customer_Find_Button.Location = new System.Drawing.Point(294, 0);
            this.Customer_Find_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Customer_Find_Button.Name = "Customer_Find_Button";
            this.Customer_Find_Button.Size = new System.Drawing.Size(50, 55);
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
            this.Customer_Delete_Button.Size = new System.Drawing.Size(50, 55);
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
            this.Customer_Add_Button.Size = new System.Drawing.Size(50, 55);
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
            this.Customer_Modify_Button.Size = new System.Drawing.Size(50, 55);
            this.Customer_Modify_Button.TabIndex = 1;
            this.Customer_Modify_Button.UseVisualStyleBackColor = true;
            this.Customer_Modify_Button.Click += new System.EventHandler(this.Customer_Modify_Button_Click);
            // 
            // CustomerListView
            // 
            this.CustomerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            CustomerListView_Name,
            CustomerListView_PN,
            CustomerListView_Note});
            this.CustomerListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerListView.FullRowSelect = true;
            this.CustomerListView.GridLines = true;
            this.CustomerListView.HideSelection = false;
            this.CustomerListView.Location = new System.Drawing.Point(0, 55);
            this.CustomerListView.Margin = new System.Windows.Forms.Padding(0);
            this.CustomerListView.Name = "CustomerListView";
            this.CustomerListView.Size = new System.Drawing.Size(420, 626);
            this.CustomerListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.CustomerListView.TabIndex = 0;
            this.CustomerListView.UseCompatibleStateImageBehavior = false;
            this.CustomerListView.View = System.Windows.Forms.View.Details;
            this.CustomerListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.CustomerListView_ColumnClick);
            this.CustomerListView.SelectedIndexChanged += new System.EventHandler(this.CustomerListView_SelectedIndexChanged);
            this.CustomerListView.DoubleClick += new System.EventHandler(this.CustomerListView_DoubleClick);
            this.CustomerListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomerListView_KeyDown);
            // 
            // CustomerListView_Name
            // 
            CustomerListView_Name.Text = "이름";
            CustomerListView_Name.Width = 100;
            // 
            // CustomerListView_PN
            // 
            CustomerListView_PN.Text = "전화번호";
            CustomerListView_PN.Width = 120;
            // 
            // MainStatusTableLayoutPanel
            // 
            MainStatusTableLayoutPanel.ColumnCount = 2;
            MainStatusTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            MainStatusTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            MainStatusTableLayoutPanel.Controls.Add(this.MainStatusCountLabel, 1, 0);
            MainStatusTableLayoutPanel.Controls.Add(MainStatusLabel, 0, 0);
            MainStatusTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            MainStatusTableLayoutPanel.Location = new System.Drawing.Point(0, 681);
            MainStatusTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            MainStatusTableLayoutPanel.Name = "MainStatusTableLayoutPanel";
            MainStatusTableLayoutPanel.RowCount = 1;
            MainStatusTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            MainStatusTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            MainStatusTableLayoutPanel.Size = new System.Drawing.Size(420, 20);
            MainStatusTableLayoutPanel.TabIndex = 4;
            // 
            // MainStatusCountLabel
            // 
            this.MainStatusCountLabel.AutoSize = true;
            this.MainStatusCountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainStatusCountLabel.Font = new System.Drawing.Font("굴림", 10F);
            this.MainStatusCountLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainStatusCountLabel.Location = new System.Drawing.Point(225, 0);
            this.MainStatusCountLabel.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.MainStatusCountLabel.Name = "MainStatusCountLabel";
            this.MainStatusCountLabel.Size = new System.Drawing.Size(180, 20);
            this.MainStatusCountLabel.TabIndex = 1;
            this.MainStatusCountLabel.Text = "N명";
            this.MainStatusCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainStatusLabel
            // 
            MainStatusLabel.AutoSize = true;
            MainStatusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            MainStatusLabel.Font = new System.Drawing.Font("굴림", 10F);
            MainStatusLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            MainStatusLabel.Location = new System.Drawing.Point(5, 0);
            MainStatusLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            MainStatusLabel.Name = "MainStatusLabel";
            MainStatusLabel.Size = new System.Drawing.Size(200, 20);
            MainStatusLabel.TabIndex = 0;
            MainStatusLabel.Text = "고객 수";
            MainStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GarmentTableLayoutPanel
            // 
            GarmentTableLayoutPanel.ColumnCount = 1;
            GarmentTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            GarmentTableLayoutPanel.Controls.Add(Garment_Button_TableLayoutPanel, 0, 0);
            GarmentTableLayoutPanel.Controls.Add(this.GarmentListView, 0, 1);
            GarmentTableLayoutPanel.Controls.Add(GarmentStatusTableLayoutPanel, 0, 2);
            GarmentTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            GarmentTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            GarmentTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            GarmentTableLayoutPanel.Name = "GarmentTableLayoutPanel";
            GarmentTableLayoutPanel.RowCount = 3;
            GarmentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            GarmentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            GarmentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            GarmentTableLayoutPanel.Size = new System.Drawing.Size(842, 701);
            GarmentTableLayoutPanel.TabIndex = 1;
            // 
            // Garment_Button_TableLayoutPanel
            // 
            Garment_Button_TableLayoutPanel.ColumnCount = 5;
            Garment_Button_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            Garment_Button_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            Garment_Button_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            Garment_Button_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            Garment_Button_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            Garment_Button_TableLayoutPanel.Controls.Add(this.Garment_Delete_Button, 3, 0);
            Garment_Button_TableLayoutPanel.Controls.Add(this.Garment_Modify_Button, 2, 0);
            Garment_Button_TableLayoutPanel.Controls.Add(this.Garment_Add_Button, 1, 0);
            Garment_Button_TableLayoutPanel.Controls.Add(this.Customer_Name_Label, 0, 0);
            Garment_Button_TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            Garment_Button_TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            Garment_Button_TableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            Garment_Button_TableLayoutPanel.Name = "Garment_Button_TableLayoutPanel";
            Garment_Button_TableLayoutPanel.RowCount = 1;
            Garment_Button_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            Garment_Button_TableLayoutPanel.Size = new System.Drawing.Size(842, 55);
            Garment_Button_TableLayoutPanel.TabIndex = 5;
            // 
            // Garment_Delete_Button
            // 
            this.Garment_Delete_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Garment_Delete_Button.Image = ((System.Drawing.Image)(resources.GetObject("Garment_Delete_Button.Image")));
            this.Garment_Delete_Button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Garment_Delete_Button.Location = new System.Drawing.Point(689, 0);
            this.Garment_Delete_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Garment_Delete_Button.Name = "Garment_Delete_Button";
            this.Garment_Delete_Button.Size = new System.Drawing.Size(50, 55);
            this.Garment_Delete_Button.TabIndex = 5;
            this.Garment_Delete_Button.UseVisualStyleBackColor = true;
            this.Garment_Delete_Button.Click += new System.EventHandler(this.Garment_Delete_Button_Click);
            // 
            // Garment_Modify_Button
            // 
            this.Garment_Modify_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Garment_Modify_Button.Image = global::CustomerManagement.Properties.Resources.modify;
            this.Garment_Modify_Button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Garment_Modify_Button.Location = new System.Drawing.Point(639, 0);
            this.Garment_Modify_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Garment_Modify_Button.Name = "Garment_Modify_Button";
            this.Garment_Modify_Button.Size = new System.Drawing.Size(50, 55);
            this.Garment_Modify_Button.TabIndex = 2;
            this.Garment_Modify_Button.UseVisualStyleBackColor = true;
            this.Garment_Modify_Button.Click += new System.EventHandler(this.Garment_Modify_Button_Click);
            // 
            // Garment_Add_Button
            // 
            this.Garment_Add_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Garment_Add_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Garment_Add_Button.Image = global::CustomerManagement.Properties.Resources._new;
            this.Garment_Add_Button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Garment_Add_Button.Location = new System.Drawing.Point(589, 0);
            this.Garment_Add_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Garment_Add_Button.Name = "Garment_Add_Button";
            this.Garment_Add_Button.Size = new System.Drawing.Size(50, 55);
            this.Garment_Add_Button.TabIndex = 1;
            this.Garment_Add_Button.UseVisualStyleBackColor = true;
            this.Garment_Add_Button.Click += new System.EventHandler(this.Garment_Add_Button_Click);
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
            this.Customer_Name_Label.Size = new System.Drawing.Size(571, 55);
            this.Customer_Name_Label.TabIndex = 6;
            this.Customer_Name_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GarmentListView
            // 
            this.GarmentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            GarmentListView_ReceptionDate,
            GarmentListView_ProcessingDate,
            GarmentListView_Completion,
            GarmentListView_Content,
            GarmentListView_Amount,
            GarmentListView_Note});
            this.GarmentListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GarmentListView.FullRowSelect = true;
            this.GarmentListView.GridLines = true;
            this.GarmentListView.HideSelection = false;
            this.GarmentListView.Location = new System.Drawing.Point(0, 55);
            this.GarmentListView.Margin = new System.Windows.Forms.Padding(0);
            this.GarmentListView.Name = "GarmentListView";
            this.GarmentListView.Size = new System.Drawing.Size(842, 626);
            this.GarmentListView.TabIndex = 0;
            this.GarmentListView.UseCompatibleStateImageBehavior = false;
            this.GarmentListView.View = System.Windows.Forms.View.Details;
            this.GarmentListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.GarmentListView_ColumnClick);
            this.GarmentListView.DoubleClick += new System.EventHandler(this.GarmentListView_DoubleClick);
            this.GarmentListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GarmentListView_KeyDown);
            // 
            // GarmentListView_ReceptionDate
            // 
            GarmentListView_ReceptionDate.Text = "접수일자";
            GarmentListView_ReceptionDate.Width = 105;
            // 
            // GarmentListView_ProcessingDate
            // 
            GarmentListView_ProcessingDate.Text = "납품일자";
            GarmentListView_ProcessingDate.Width = 105;
            // 
            // GarmentListView_Completion
            // 
            GarmentListView_Completion.Text = "완납여부";
            GarmentListView_Completion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GarmentListView_Content
            // 
            GarmentListView_Content.Text = "내용";
            GarmentListView_Content.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            GarmentListView_Content.Width = 340;
            // 
            // GarmentListView_Amount
            // 
            GarmentListView_Amount.Text = "금액";
            GarmentListView_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            GarmentListView_Amount.Width = 100;
            // 
            // GarmentListView_Note
            // 
            GarmentListView_Note.Text = "비고";
            GarmentListView_Note.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            GarmentListView_Note.Width = 119;
            // 
            // GarmentStatusTableLayoutPanel
            // 
            GarmentStatusTableLayoutPanel.ColumnCount = 2;
            GarmentStatusTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            GarmentStatusTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            GarmentStatusTableLayoutPanel.Controls.Add(this.GarmentStatusTotalMoneyLabel, 1, 0);
            GarmentStatusTableLayoutPanel.Controls.Add(this.GarmentStatusCountLabel, 0, 0);
            GarmentStatusTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            GarmentStatusTableLayoutPanel.Location = new System.Drawing.Point(0, 681);
            GarmentStatusTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            GarmentStatusTableLayoutPanel.Name = "GarmentStatusTableLayoutPanel";
            GarmentStatusTableLayoutPanel.RowCount = 1;
            GarmentStatusTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            GarmentStatusTableLayoutPanel.Size = new System.Drawing.Size(842, 20);
            GarmentStatusTableLayoutPanel.TabIndex = 6;
            // 
            // GarmentStatusTotalMoneyLabel
            // 
            this.GarmentStatusTotalMoneyLabel.AutoSize = true;
            this.GarmentStatusTotalMoneyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GarmentStatusTotalMoneyLabel.Font = new System.Drawing.Font("굴림", 10F);
            this.GarmentStatusTotalMoneyLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GarmentStatusTotalMoneyLabel.Location = new System.Drawing.Point(436, 0);
            this.GarmentStatusTotalMoneyLabel.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.GarmentStatusTotalMoneyLabel.Name = "GarmentStatusTotalMoneyLabel";
            this.GarmentStatusTotalMoneyLabel.Size = new System.Drawing.Size(391, 20);
            this.GarmentStatusTotalMoneyLabel.TabIndex = 3;
            this.GarmentStatusTotalMoneyLabel.Text = "총 금액: NNNN원";
            this.GarmentStatusTotalMoneyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GarmentStatusCountLabel
            // 
            this.GarmentStatusCountLabel.AutoSize = true;
            this.GarmentStatusCountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GarmentStatusCountLabel.Font = new System.Drawing.Font("굴림", 10F);
            this.GarmentStatusCountLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GarmentStatusCountLabel.Location = new System.Drawing.Point(15, 0);
            this.GarmentStatusCountLabel.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.GarmentStatusCountLabel.Name = "GarmentStatusCountLabel";
            this.GarmentStatusCountLabel.Size = new System.Drawing.Size(391, 20);
            this.GarmentStatusCountLabel.TabIndex = 2;
            this.GarmentStatusCountLabel.Text = "자료 수: N개";
            this.GarmentStatusCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CustomerListView_Note
            // 
            CustomerListView_Note.Text = "비고";
            CustomerListView_Note.Width = 175;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 701);
            this.Controls.Add(MainSplitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 369);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "고객관리";
            this.Load += new System.EventHandler(this.MainForm_Load);
            MainSplitContainer.Panel1.ResumeLayout(false);
            MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(MainSplitContainer)).EndInit();
            MainSplitContainer.ResumeLayout(false);
            MainTableLayoutPanel.ResumeLayout(false);
            CustomerButton_TableLayoutPanel.ResumeLayout(false);
            MainStatusTableLayoutPanel.ResumeLayout(false);
            MainStatusTableLayoutPanel.PerformLayout();
            GarmentTableLayoutPanel.ResumeLayout(false);
            Garment_Button_TableLayoutPanel.ResumeLayout(false);
            Garment_Button_TableLayoutPanel.PerformLayout();
            GarmentStatusTableLayoutPanel.ResumeLayout(false);
            GarmentStatusTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView CustomerListView;
        private System.Windows.Forms.ListView GarmentListView;
        private System.Windows.Forms.Button Customer_Find_Button;
        private System.Windows.Forms.Button Customer_Delete_Button;
        private System.Windows.Forms.Button Customer_Add_Button;
        private System.Windows.Forms.Button Customer_Modify_Button;
        private System.Windows.Forms.Button Garment_Delete_Button;
        private System.Windows.Forms.Button Garment_Modify_Button;
        private System.Windows.Forms.Button Garment_Add_Button;
        private System.Windows.Forms.Label Customer_Name_Label;
        private System.Windows.Forms.Label MainStatusCountLabel;
        private System.Windows.Forms.Label GarmentStatusTotalMoneyLabel;
        private System.Windows.Forms.Label GarmentStatusCountLabel;
    }
}

