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
