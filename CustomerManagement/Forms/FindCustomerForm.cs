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
    public partial class FindCustomerForm : Form
    {
        private int? findIndex = null;
        private readonly ListView listView;
        private ToolTip toolTip = new ToolTip();

        public int? FindIndex { get { return findIndex; } }

        public FindCustomerForm(ListView listView)
        {
            this.listView = listView;
            InitializeComponent();
            /* TODO: 찾기 폼 변경하기
                * 웹에서 검색창을 누르면 검색창이 나오는 것처럼
                * 이제 거기에 라디오 버튼을 추가
                * 다음, 이전 버튼을 추가
            */
        }

        private void FindCustomerForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
            case Keys.Escape:
                FindCustomerFormCancelButton.PerformClick();
                e.SuppressKeyPress = true;
                break;
            case Keys.Enter:
                FindCustomerFormConfirmButton.PerformClick();
                e.SuppressKeyPress = true;
                break;
            }

            if (e.Alt)
            {
                switch (e.KeyCode)
                {
                case Keys.D1:
                    FindCuscomerFormNameRB.Checked = true;
                    e.SuppressKeyPress = true;
                    break;
                case Keys.D2:
                    FindCuscomerFormPNRB.Checked = true;
                    e.SuppressKeyPress = true;
                    break;
                }
            }
        }

        private void FindCuscomerFormTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (FindCuscomerFormNameRB.Checked) return;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                System.Media.SystemSounds.Beep.Play();
                toolTip.Show("숫자만 입력할 수 있습니다.", FindCuscomerFormTextBox, 0, -20, 1000);

                e.Handled = true;
            }
        }

        private void FindCuscomerForm_CheckedChanged(object sender, EventArgs e)
        {
            if (FindCuscomerFormNameRB.Checked)
                FindCuscomerFormTextBox.MaxLength = 32;
            else if (FindCuscomerFormPNRB.Checked)
            {
                FindCuscomerFormTextBox.MaxLength = 13;
                FindCuscomerFormTextBox.Text = Utils.FormatPhoneNumber(FindCuscomerFormTextBox.Text);
            }
            FindCuscomerFormTextBox.Focus();
            FindCuscomerFormTextBox.SelectAll();
        }

        private void FindCuscomerFormTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FindCuscomerFormNameRB.Checked) return;

            string text = FindCuscomerFormTextBox.Text.Replace("-", "");
            FindCuscomerFormTextBox.Text = Utils.FormatPhoneNumber(text);
            FindCuscomerFormTextBox.SelectionStart = FindCuscomerFormTextBox.Text.Length;
        }

        private void FindCustomerFormConfirmButton_Click(object sender, EventArgs e)
        {
            if (FindCuscomerFormTextBox.Text.Length == 0)
            {
                MessageBox.Show("검색어를 입력해주세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FindCuscomerFormTextBox.Focus();
                return;
            }

            listView.ListViewItemSorter = new ListViewItemComparer();
            if (FindCuscomerFormNameRB.Checked)
            {
                List<string> list = listView.Items.Cast<ListViewItem>().Select(item => item.Text).ToList();
                int idx = list.FindIndex(item => item.Contains(FindCuscomerFormTextBox.Text));
                findIndex = idx < 0 ? (int?)null : idx;
            }
            else if (FindCuscomerFormPNRB.Checked)
            {
                var list = listView.Items.Cast<ListViewItem>().Select(item => item.SubItems[1].Text.Replace("-", "")).ToList();
                int idx = list.FindIndex(item => item == FindCuscomerFormTextBox.Text.Replace("-", ""));
                findIndex = idx < 0 ? (int?)null : idx;
            }

            if (findIndex == null)
            {
                MessageBox.Show("검색 결과가 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FindCuscomerFormTextBox.Focus();
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void FindCustomerFormCancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
