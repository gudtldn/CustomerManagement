using CustomerManagement.Classes;
using System;
using System.Windows.Forms;

namespace CustomerManagement
{
    public partial class AddCustomerForm : Form
    {
        public string CustomerName { get; private set; }
        public string CustomerPhoneNumber { get; private set; }
        public string CustomerNote { get; private set; }

        private string GetPhoneNumber() => AddCustomerFormPNTextBox.Text.Replace("-", "");

        public AddCustomerForm(Customer customer)
        {
            CustomerName = customer.Name;
            CustomerPhoneNumber = customer.PhoneNumber;
            CustomerNote = customer.Note;
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
                AddCustomerFormNoteTextBox.Text = CustomerNote;
            }
        }

        private void AddCustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK) return;

            if (
                AddCustomerFormNameTextBox.Text != (CustomerName ?? "")
                || GetPhoneNumber() != (CustomerPhoneNumber ?? "")
            ) {
                if (
                    MessageBox.Show(
                        "입력된 정보가 저장되지 않습니다. 계속하시겠습니까?",
                        "알림",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    ) == DialogResult.No
                ) {
                    e.Cancel = true;
                    return;
                };
            }

            DialogResult = DialogResult.Cancel;
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

        private void AddCustomerFormPNTextBox_TextChanged(object sender, EventArgs e)
        {
            string pnText = GetPhoneNumber();

            AddCustomerFormPNTextBox.Text = Utils.FormatPhoneNumber(pnText);
            AddCustomerFormPNTextBox.SelectionStart = AddCustomerFormPNTextBox.Text.Length;
        }

        private void AddCustomerFormConfirmButton_Click(object sender, EventArgs e)
        {
            if (AddCustomerFormNameTextBox.Text == "")
            {
                MessageBox.Show("이름을 입력해주세요.", "입력 오류", MessageBoxButtons.OK);
                AddCustomerFormNameTextBox.Focus();
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

            CustomerName = AddCustomerFormNameTextBox.Text;
            CustomerPhoneNumber = GetPhoneNumber();
            CustomerNote = AddCustomerFormNoteTextBox.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void AddCustomerFormCancelButton_Click(object sender, EventArgs e) => Close();
    }
}
