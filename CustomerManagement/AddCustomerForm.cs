using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerManagement.Classes;

namespace CustomerManagement
{
    public partial class AddCustomerForm : Form
    {
        private string _CustomerName = null;
        private string _CustomerPhoneNumber = null;
        private readonly ListView _ListView;

        public string CustomerName
        {
            get { return _CustomerName; }
        }
        public string CustomerPhoneNumber
        {
            get { return _CustomerPhoneNumber; }
        }

        public AddCustomerForm(ListView listView, string name, string phoneNumber)
        {
            _ListView = listView;
            _CustomerName = name;
            _CustomerPhoneNumber = phoneNumber;
            InitializeComponent();
        }

        public AddCustomerForm(ListView listView)
        {
            _ListView = listView;
            InitializeComponent();
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            if (CustomerName != null && CustomerPhoneNumber != null)
            {
                AddCuscomerFormNameTextBox.Text = CustomerName;
                AddCuscomerFormPNTextBox.Text = CustomerPhoneNumber;
            }
        }

        private void AddCustomerForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                AddCuscomerFormCancelButton.PerformClick();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                AddCuscomerFormConfirmButton.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void AddCuscomerFormConfirmButton_Click(object sender, EventArgs e)
        {
            if (AddCuscomerFormNameTextBox.Text == "")
            {
                MessageBox.Show("이름을 입력해주세요.", "입력 오류", MessageBoxButtons.OK);
                AddCuscomerFormNameTextBox.Focus();
                return;
            }
            else if (AddCuscomerFormPNTextBox.Text == "")
            {
                MessageBox.Show("전화번호를 입력해주세요.", "입력 오류", MessageBoxButtons.OK);
                AddCuscomerFormPNTextBox.Focus();
                return;
            }

            DataSQL data = new DataSQL();
            if (AddCuscomerFormNameTextBox.Text != (CustomerName ?? "")) 
            {
                if (data.GetCustomerFromName(AddCuscomerFormNameTextBox.Text) != null)
                {
                    MessageBox.Show("이미 존재하는 고객명입니다.", "입력 오류", MessageBoxButtons.OK);
                    AddCuscomerFormNameTextBox.Focus();
                    return;
                }
            }

            if (AddCuscomerFormPNTextBox.Text != (CustomerPhoneNumber ?? "")) {
                if (data.GetCustomerFromPhoneNumber(AddCuscomerFormPNTextBox.Text) != null)
                {
                    MessageBox.Show("이미 존재하는 전화번호입니다.", "입력 오류", MessageBoxButtons.OK);
                    AddCuscomerFormPNTextBox.Focus();
                    return;
                }
            }

            _CustomerName = AddCuscomerFormNameTextBox.Text;
            _CustomerPhoneNumber = AddCuscomerFormPNTextBox.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void AddCuscomerFormCancelButton_Click(object sender, EventArgs e)
        {
            if (
                AddCuscomerFormNameTextBox.Text != (CustomerName ?? "")
                || AddCuscomerFormPNTextBox.Text != (CustomerPhoneNumber ?? "")
            ) {
                if (MessageBox.Show("입력된 정보가 저장되지 않습니다. 계속하시겠습니까?", "경고", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
            }

            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
