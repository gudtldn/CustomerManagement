using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using CustomerManagement.Classes;


namespace CustomerManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            // TODO: 단축키 설정
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
        }

        private void CustomerListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 선택된 고객이 2명 이상이면 함수를 종료
            if (CustomerListView.SelectedItems.Count > 1) return;

            GarmentListView.Items.Clear(); // 선택된 고객의 의류정보를 가져오기 전에 리스트뷰를 비움
            Customer_Name_Label.Text = ""; // 선택된 고객이 없으면 라벨을 초기화

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
                MessageBoxButtons.YesNo
            );
            if (dialogResult == DialogResult.No) return;

            DataSQL data = new DataSQL();
            foreach (ListViewItem item in selectedItems)
            {
                data.DeleteCustomer((Customer)item.Tag);
                CustomerListView.Items.Remove(item);
            }
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
    }
}
