﻿using System;
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
            if (CustomerListView.SelectedItems.Count > 1) return; // 선택된 고객이 2명 이상이면 함수를 종료

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
    }
}
