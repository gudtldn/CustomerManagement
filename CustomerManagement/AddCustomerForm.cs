using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerManagement
{
    public partial class AddCustomerForm : Form
    {
        private string _CustomerName = null;
        private string _CustomerPhoneNumber = null;

        public string CustomerName
        {
            get { return _CustomerName; }
        }
        public string CustomerPhoneNumber
        {
            get { return _CustomerPhoneNumber; }
        }

        public AddCustomerForm(string name, string phoneNumber)
        {
            _CustomerName = name;
            _CustomerPhoneNumber = phoneNumber;
            InitializeComponent();
        }

        public AddCustomerForm()
        {
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

        private void AddCustomerForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                AddCuscomerFormCancelButton.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                AddCuscomerFormConfirmButton.PerformClick();
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
