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
            {
                CustomerListView.Items[0].Selected = true;
                foreach (Garment garment in data.GetGarments((Customer)CustomerListView.Items[0].Tag))
                {
                    ListViewItem item = new ListViewItem(garment.ReceptionDate.ToString());
                    item.SubItems.Add(garment.ProcessingDate.ToString());
                    item.SubItems.Add(garment.IsCompleted ? "완료" : "미완료");
                    item.SubItems.Add(garment.Contents);
                    item.SubItems.Add($"{garment.Price:n0} 원");
                    item.SubItems.Add(garment.Note);
                    item.Tag = garment;
                    GarmentListView.Items.Add(item);
                }
            }
        }
    }
}
