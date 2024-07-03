using CustomerManagement.Classes;
using System;
using System.Windows.Forms;

namespace CustomerManagement
{
    public partial class AddGarmantForm : Form
    {
        public Garment Garment { get; private set; }

        public AddGarmantForm(Garment garment)
        {
            Garment = garment;
            InitializeComponent();
        }

        public AddGarmantForm()
        {
            Garment = new Garment(-1, DateTime.Now, null, false, "", 0, "", -1);
            InitializeComponent();
        }

        private void GarmentForm_Load(object sender, EventArgs e)
        {
            GarmentReceptionDateTimePicker.Value = Garment.ReceptionDate ?? DateTime.Now;
            GarmentIsCompletedCheckBox.Checked = Garment.IsCompleted;
            GarmentPriceTextBox.Text = Garment.Price.ToString();
            GarmentContentsTextBox.Text = Garment.Contents;
            GarmentNoteTextBox.Text = Garment.Note;
            if (Garment.ProcessingDate is DateTime processingDate)
            {
                GarmentProcessingDateTimePicker.Format = DateTimePickerFormat.Short;
                GarmentProcessingDateTimePicker.Value = processingDate;
            }
            else
            {
                GarmentProcessingDateTimePicker.Format = DateTimePickerFormat.Custom;
            }
        }

        private void AddGarmantForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK) return;

            Garment UpdatedGarment = new Garment(
                -1,
                GarmentReceptionDateTimePicker.Value,
                GarmentProcessingDateTimePicker.Format == DateTimePickerFormat.Custom ?
                    null : (DateTime?)GarmentProcessingDateTimePicker.Value,
                GarmentIsCompletedCheckBox.Checked,
                GarmentContentsTextBox.Text,
                int.Parse(GarmentPriceTextBox.Text == "" ? "0" : GarmentPriceTextBox.Text),
                GarmentNoteTextBox.Text,
                Garment.CustomerID
            );

            if (Garment != UpdatedGarment)
            {
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

        private void GarmentForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    GarmentFormCancelButton.PerformClick();
                    e.SuppressKeyPress = true;
                    break;
                case Keys.Enter:
                    GarmentFormConfirmButton.PerformClick();
                    e.SuppressKeyPress = true;
                    break;
            }
        }

        private void GarmentFormConfirmButton_Click(object sender, EventArgs e)
        {
            if (GarmentPriceTextBox.Text == "")
            {
                MessageBox.Show("가격을 입력해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GarmentPriceTextBox.Focus();
                return;
            }
            else if (GarmentContentsTextBox.Text == "")
            {
                MessageBox.Show("내용을 입력해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GarmentContentsTextBox.Focus();
                return;
            }

            Garment = new Garment(
                -1,
                GarmentReceptionDateTimePicker.Value,
                GarmentProcessingDateTimePicker.Format == DateTimePickerFormat.Custom ?
                    null : (DateTime?)GarmentProcessingDateTimePicker.Value,
                GarmentIsCompletedCheckBox.Checked,
                GarmentContentsTextBox.Text,
                int.Parse(GarmentPriceTextBox.Text == "" ? "0" : GarmentPriceTextBox.Text),
                GarmentNoteTextBox.Text,
                Garment.CustomerID
            );

            DialogResult = DialogResult.OK;
            Close();
        }

        private void GarmentFormCancelButton_Click(object sender, EventArgs e) => Close();
    }
}
