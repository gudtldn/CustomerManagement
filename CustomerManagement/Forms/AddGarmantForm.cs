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
    public partial class AddGarmantForm : Form
    {
        private ToolTip toolTip = new ToolTip();

        public AddGarmantForm()
        {
            InitializeComponent();
        }

        private void AddGarmantForm_Load(object sender, EventArgs e)
        {
            // 접수, 처리일자 초기화
        }

        private void AddGarmentFormPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                System.Media.SystemSounds.Beep.Play();
                toolTip.Show("숫자만 입력할 수 있습니다.", GarmentPriceTextBox, 0, -20, 1000);

                e.Handled = true;
            }
        }

        private void GarmentFormConfirmButton_Click(object sender, EventArgs e)
        {

        }

        private void GarmentFormCancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
