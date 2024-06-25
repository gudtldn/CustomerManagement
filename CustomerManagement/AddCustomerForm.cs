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
        private ToolTip toolTip = new ToolTip();

        public string CustomerName
        {
            get { return _CustomerName; }
        }
        public string CustomerPhoneNumber
        {
            get { return _CustomerPhoneNumber; }
        }

        private string GetPhoneNumber() => AddCustomerFormPNTextBox.Text.Replace("-", "");
        
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
                AddCustomerFormNameTextBox.Text = CustomerName;
                AddCustomerFormPNTextBox.Text = CustomerPhoneNumber;
            }
        }

        private void AddCustomerForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    AddCustomerFormCancelButton.PerformClick();
                    e.SuppressKeyPress = true;
                    break;
                case Keys.Enter:
                    AddCustomerFormConfirmButton.PerformClick();
                    e.SuppressKeyPress = true;
                    break;
            }
        }

        private void AddCustomerFormPNTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                System.Media.SystemSounds.Beep.Play();
                toolTip.Show("숫자만 입력할 수 있습니다.", AddCustomerFormPNTextBox, 0, -20, 1000);

                e.Handled = true;
            }
        }

        private void AddCustomerFormPNTextBox_TextChanged(object sender, EventArgs e)
        {
            string pnText = GetPhoneNumber();

            AddCustomerFormPNTextBox.Text = Utils.FormatPhoneNumber(pnText);
            AddCustomerFormPNTextBox.SelectionStart = AddCustomerFormPNTextBox.Text.Length;
        }

        private void AddCustomerFormConfirmButton_Click(object sender, EventArgs e)
        {
            string pnText = GetPhoneNumber();
            if (AddCustomerFormNameTextBox.Text == "")
            {
                MessageBox.Show("이름을 입력해주세요.", "입력 오류", MessageBoxButtons.OK);
                AddCustomerFormNameTextBox.Focus();
                return;
            }
            else if (pnText == "")
            {
                MessageBox.Show("전화번호를 입력해주세요.", "입력 오류", MessageBoxButtons.OK);
                AddCustomerFormPNTextBox.Focus();
                return;
            }

            DataSQL data = new DataSQL();
            if (AddCustomerFormNameTextBox.Text != (CustomerName ?? "")) 
            {
                if (data.GetCustomerFromName(AddCustomerFormNameTextBox.Text) != null)
                {
                    MessageBox.Show("이미 존재하는 고객명입니다.", "입력 오류", MessageBoxButtons.OK);
                    AddCustomerFormNameTextBox.Focus();
                    return;
                }
            }

            if (pnText != (CustomerPhoneNumber ?? "")) {
                if (data.GetCustomerFromPhoneNumber(pnText) != null)
                {
                    MessageBox.Show("이미 존재하는 전화번호입니다.", "입력 오류", MessageBoxButtons.OK);
                    AddCustomerFormPNTextBox.Focus();
                    return;
                }
            }

            _CustomerName = AddCustomerFormNameTextBox.Text;
            _CustomerPhoneNumber = pnText;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void AddCustomerFormCancelButton_Click(object sender, EventArgs e)
        {
            if (
                AddCustomerFormNameTextBox.Text != (CustomerName ?? "")
                || GetPhoneNumber() != (CustomerPhoneNumber ?? "")
            ) {
                if (MessageBox.Show("입력된 정보가 저장되지 않습니다. 계속하시겠습니까?", "경고", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
            }

            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
