using CustomerManagement.Classes;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace CustomerManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void UpdateTotalCustomer()
        {
            int totalCustomer = CustomerListView.Items.Count;
            MainStatusCountLabel.Text = $"{totalCustomer:n0}명";
        }

        private void UpdateTotalGarment()
        {
            int totalGarment = GarmentListView.Items.Count;
            int totalMoney = 0;
            foreach (ListViewItem item in GarmentListView.Items)
            {
                if (int.TryParse(item.SubItems[4].Text.Replace(" 원", "").Replace(",", ""), out int price))
                    totalMoney += price;
            }

            GarmentStatusCountLabel.Text = $"자료 수: {totalGarment:n0}개";
            GarmentStatusTotalMoneyLabel.Text = $"총 금액: {totalMoney:n0}원";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DataSQL data = new DataSQL();
            foreach (Customer customer in data.GetAllCustomers())
            {
                ListViewItem item = new ListViewItem(customer.Name);
                item.SubItems.Add(Utils.FormatPhoneNumber(customer.PhoneNumber));
                item.Tag = customer;
                CustomerListView.Items.Add(item);
            }

            if (CustomerListView.Items.Count > 0)
                CustomerListView.Items[0].Selected = true;

            CustomerListView.ListViewItemSorter = new ListViewItemComparer(0, SortOrder.Ascending);
            GarmentListView.ListViewItemSorter = new ListViewItemComparer(0, SortOrder.Ascending);

            GarmentStatusCountLabel.Text = "";
            GarmentStatusTotalMoneyLabel.Text = "";

            UpdateTotalCustomer();
        }

        private void CustomerListView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.F:
                        Customer_Find_Button.PerformClick();
                        e.SuppressKeyPress = true;
                        break;
                    case Keys.N:
                        Customer_Add_Button.PerformClick();
                        e.SuppressKeyPress = true;
                        break;
                }
            }
            else
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        Customer_Modify_Button.PerformClick();
                        e.SuppressKeyPress = true;
                        break;
                    case Keys.Delete:
                        Customer_Delete_Button.PerformClick();
                        e.SuppressKeyPress = true;
                        break;
                    case Keys.F1:
                        MessageBox.Show($"현재버전: {Updater.CURRENT_VERSION}", "버전정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        e.SuppressKeyPress = true;
                        break;
                }
            }
        }

        private void CustomerListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 선택된 고객이 2명 이상이면 함수를 종료
            if (CustomerListView.SelectedItems.Count > 1) return;

            GarmentListView.Items.Clear(); // 선택된 고객의 의류정보를 가져오기 전에 리스트뷰를 비움
            Customer_Name_Label.Text = ""; // 선택된 고객이 없으면 라벨을 초기화

            // 의류정보의 개수와 총 금액을 초기화
            GarmentStatusCountLabel.Text = "";
            GarmentStatusTotalMoneyLabel.Text = "";

            if (CustomerListView.SelectedItems.Count == 0) return; // 선택된 고객이 없으면 함수를 종료

            // DB에서 선택된 고객의 의류정보를 가져와서 GarmentListView에 추가
            DataSQL data = new DataSQL();
            Customer customer = (Customer)CustomerListView.SelectedItems[0].Tag;

            foreach (Garment garment in data.GetGarments(customer))
            {
                ListViewItem item = new ListViewItem(garment.ReceptionDate?.ToString("yyyy-MM-dd"));
                item.SubItems.Add(garment.ProcessingDate?.ToString("yyyy-MM-dd"));
                item.SubItems.Add(garment.IsCompleted ? "완료" : "미완료");
                item.SubItems.Add(garment.Contents);
                item.SubItems.Add($"{garment.Price:n0} 원");
                item.SubItems.Add(garment.Note);
                item.Tag = garment;
                GarmentListView.Items.Add(item);
            }

            Customer_Name_Label.Text = customer.Name; // 선택된 고객의 이름을 라벨에 표시
            Customer_Name_Label.Tag = customer; // 선택된 고객의 정보를 라벨의 Tag에 저장
            UpdateTotalGarment();
        }

        private void CustomerListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // 리스트뷰 정렬
            if ((CustomerListView.ListViewItemSorter as ListViewItemComparer).Column == e.Column)
                CustomerListView.Sorting = CustomerListView.Sorting == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
            else
                CustomerListView.Sorting = SortOrder.Ascending;

            CustomerListView.ListViewItemSorter = new ListViewItemComparer(e.Column, CustomerListView.Sorting);
        }

        private void CustomerListView_DoubleClick(object sender, EventArgs e) => Customer_Modify_Button.PerformClick();

        private void Customer_Add_Button_Click(object sender, EventArgs e)
        {
            AddCustomerForm form = new AddCustomerForm();
            if (form.ShowDialog() == DialogResult.Cancel) return;

            DataSQL data = new DataSQL();
            data.AddCustomer(form.CustomerName, form.CustomerPhoneNumber);

            CustomerListView.Items.Add(new ListViewItem(form.CustomerName)
            {
                SubItems = { Utils.FormatPhoneNumber(form.CustomerPhoneNumber) },
                Tag = new Customer(
                    data.GetCustomer(form.CustomerName, form.CustomerPhoneNumber).Value.ID,
                    form.CustomerName,
                    form.CustomerPhoneNumber
                )
            });

            if ((CustomerListView.ListViewItemSorter as ListViewItemComparer).Column != 0)
                CustomerListView.ListViewItemSorter = new ListViewItemComparer();

            if (Utils.BinarySearchListView(CustomerListView, form.CustomerName) is int idx)
            {
                CustomerListView.SelectedItems.Clear();
                CustomerListView.Items[idx].Selected = true;
                CustomerListView.Items[idx].EnsureVisible();
            }

            UpdateTotalCustomer();
        }

        private void Customer_Modify_Button_Click(object sender, EventArgs e)
        {
            if (CustomerListView.SelectedItems.Count > 1)
            {
                MessageBox.Show("한 번에 하나의 고객만 수정할 수 있습니다.", "수정 오류", MessageBoxButtons.OK);
                return;
            }
            else if (CustomerListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("고객을 선택해주세요.", "선택 오류", MessageBoxButtons.OK);
                return;
            }

            AddCustomerForm form = new AddCustomerForm(
                ((Customer)CustomerListView.SelectedItems[0].Tag).Name,
                ((Customer)CustomerListView.SelectedItems[0].Tag).PhoneNumber
            ) {
                Text = "고객 수정"
            };
            if (form.ShowDialog() == DialogResult.Cancel) return;

            DataSQL data = new DataSQL();
            Customer customer = (Customer)CustomerListView.SelectedItems[0].Tag;
            data.UpdateCustomer(customer, form.CustomerName, form.CustomerPhoneNumber);

            Customer_Name_Label.Text = form.CustomerName;

            CustomerListView.SelectedItems[0].Text = form.CustomerName;
            CustomerListView.SelectedItems[0].SubItems[1].Text = Utils.FormatPhoneNumber(form.CustomerPhoneNumber);
            CustomerListView.SelectedItems[0].Tag = new Customer(customer.ID, form.CustomerName, form.CustomerPhoneNumber);

            CustomerListView.Sort();
            CustomerListView.SelectedItems[0].EnsureVisible();
        }

        private void Customer_Delete_Button_Click(object sender, EventArgs e)
        {
            if (CustomerListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("고객을 선택해주세요.", "선택 오류", MessageBoxButtons.OK);
                return;
            }

            var selectedItems = CustomerListView.SelectedItems;
            DialogResult dialogResult = MessageBox.Show(
                $"정말로 {selectedItems.Count}개의 고객 정보를 삭제하시겠습니까?",
                "삭제 확인",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (dialogResult == DialogResult.No) return;

            DataSQL data = new DataSQL();
            foreach (ListViewItem item in selectedItems)
            {
                data.DeleteCustomer((Customer)item.Tag);
                CustomerListView.Items.Remove(item);
            }

            UpdateTotalCustomer();
        }

        private void Customer_Find_Button_Click(object sender, EventArgs e)
        {
            FindCustomerForm form = new FindCustomerForm(CustomerListView);
            if (form.ShowDialog() == DialogResult.Cancel) return;

            if (form.FindIndex is int idx)
            {
                CustomerListView.SelectedItems.Clear();
                CustomerListView.Items[idx].Selected = true;
                CustomerListView.Items[idx].EnsureVisible();
            }
        }

        private void GarmentListView_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.N:
                        Garment_Add_Button.PerformClick();
                        e.SuppressKeyPress = true;
                        break;
                }
            }
            else
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        Garment_Modify_Button.PerformClick();
                        e.SuppressKeyPress = true;
                        break;
                    case Keys.Delete:
                        Garment_Delete_Button.PerformClick();
                        e.SuppressKeyPress = true;
                        break;
                    case Keys.F1:
                        MessageBox.Show($"현재버전: {Updater.CURRENT_VERSION}", "버전정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        e.SuppressKeyPress = true;
                        break;
                }
            }
        }

        private void GarmentListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // 리스트뷰 정렬
            if ((GarmentListView.ListViewItemSorter as ListViewItemComparer).Column == e.Column)
                GarmentListView.Sorting = GarmentListView.Sorting == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
            else
                GarmentListView.Sorting = SortOrder.Ascending;

            GarmentListView.ListViewItemSorter = new ListViewItemComparer(e.Column, GarmentListView.Sorting);
        }

        private void GarmentListView_DoubleClick(object sender, EventArgs e)
        {
            if (GarmentListView.SelectedItems.Count == 1)
                Garment_Modify_Button.PerformClick();
        }

        private void Garment_Add_Button_Click(object sender, EventArgs e)
        {
            if (CustomerListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("고객을 선택해주세요.", "선택 오류", MessageBoxButtons.OK);
                return;
            }

            AddGarmantForm form = new AddGarmantForm();
            if (form.ShowDialog() == DialogResult.Cancel) return;

            DataSQL data = new DataSQL();
            Customer customer = (Customer)Customer_Name_Label.Tag;

            data.AddGarment(
                customer,
                form.Garment.ReceptionDate,
                form.Garment.ProcessingDate,
                form.Garment.IsCompleted,
                form.Garment.Contents,
                form.Garment.Price,
                form.Garment.Note
            );

            int garmentId = data.GetGarment(
                customer,
                form.Garment.ReceptionDate,
                form.Garment.ProcessingDate,
                form.Garment.IsCompleted,
                form.Garment.Contents,
                form.Garment.Price,
                form.Garment.Note
            ).ID;

            GarmentListView.Items.Add(new ListViewItem(form.Garment.ReceptionDate?.ToString("yyyy-MM-dd") ?? "")
            {
                SubItems = {
                    form.Garment.ProcessingDate?.ToString("yyyy-MM-dd") ?? "",
                    form.Garment.IsCompleted ? "완료" : "미완료",
                    form.Garment.Contents,
                    $"{form.Garment.Price:n0} 원",
                    form.Garment.Note
                },
                Tag = new Garment(
                    garmentId,
                    form.Garment.ReceptionDate,
                    form.Garment.ProcessingDate,
                    form.Garment.IsCompleted,
                    form.Garment.Contents,
                    form.Garment.Price,
                    form.Garment.Note,
                    customer.ID
                )
            });

            if ((GarmentListView.ListViewItemSorter as ListViewItemComparer).Column != 0)
                GarmentListView.ListViewItemSorter = new ListViewItemComparer();

            var garments = GarmentListView.Items.Cast<ListViewItem>().Select(item => (Garment)item.Tag);
            for (int i = 0; i < GarmentListView.Items.Count; i++)
            {
                if (garments.ElementAt(i).ID == garmentId)
                {
                    GarmentListView.SelectedItems.Clear();
                    GarmentListView.Items[i].Selected = true;
                    GarmentListView.Items[i].EnsureVisible();
                    break;
                }
            }

            UpdateTotalGarment();
        }

        private void Garment_Modify_Button_Click(object sender, EventArgs e)
        {
            if (GarmentListView.SelectedItems.Count > 1)
            {
                MessageBox.Show("한 번에 하나의 자료만 수정할 수 있습니다.", "수정 오류", MessageBoxButtons.OK);
                return;
            }
            else if (GarmentListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("자료를 선택해주세요.", "선택 오류", MessageBoxButtons.OK);
                return;
            }

            AddGarmantForm form = new AddGarmantForm((Garment)GarmentListView.SelectedItems[0].Tag) { Text = "자료수정" };
            if (form.ShowDialog() == DialogResult.Cancel) return;

            DataSQL data = new DataSQL();
            Customer customer = (Customer)Customer_Name_Label.Tag;
            Garment garment = (Garment)GarmentListView.SelectedItems[0].Tag;

            data.UpdateGarment(
                garment,
                form.Garment.ReceptionDate,
                form.Garment.ProcessingDate,
                form.Garment.IsCompleted,
                form.Garment.Contents,
                form.Garment.Price,
                form.Garment.Note
            );

            GarmentListView.SelectedItems[0].Text = form.Garment.ReceptionDate?.ToString("yyyy-MM-dd") ?? "";
            GarmentListView.SelectedItems[0].SubItems[1].Text = form.Garment.ProcessingDate?.ToString("yyyy-MM-dd") ?? "";
            GarmentListView.SelectedItems[0].SubItems[2].Text = form.Garment.IsCompleted ? "완료" : "미완료";
            GarmentListView.SelectedItems[0].SubItems[3].Text = form.Garment.Contents;
            GarmentListView.SelectedItems[0].SubItems[4].Text = $"{form.Garment.Price:n0} 원";
            GarmentListView.SelectedItems[0].SubItems[5].Text = form.Garment.Note;
            GarmentListView.SelectedItems[0].Tag = new Garment(
                garment.ID,
                form.Garment.ReceptionDate,
                form.Garment.ProcessingDate,
                form.Garment.IsCompleted,
                form.Garment.Contents,
                form.Garment.Price,
                form.Garment.Note,
                customer.ID
            );

            UpdateTotalGarment();

            GarmentListView.Sort();
            GarmentListView.SelectedItems[0].EnsureVisible();
        }

        private void Garment_Delete_Button_Click(object sender, EventArgs e)
        {
            if (GarmentListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("자료를 선택해주세요.", "선택 오류", MessageBoxButtons.OK);
                return;
            }

            var selectedItems = GarmentListView.SelectedItems;
            DialogResult dialogResult = MessageBox.Show(
                $"정말로 {selectedItems.Count}개의 자료를 삭제하시겠습니까?",
                "삭제 확인",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (dialogResult == DialogResult.No) return;

            DataSQL data = new DataSQL();
            foreach (ListViewItem item in selectedItems)
            {
                data.DeleteGarment((Garment)item.Tag);
                GarmentListView.Items.Remove(item);
            }

            UpdateTotalGarment();
        }
    }
}
