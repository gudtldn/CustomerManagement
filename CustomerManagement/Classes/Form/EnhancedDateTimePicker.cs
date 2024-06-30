using System;
using System.ComponentModel;
using System.Windows.Forms;

public class EnhancedDateTimePicker : DateTimePicker
{
    private bool _isValueRequired = true;

    [Browsable(true)]
    [DefaultValue(true)]
    [Category("CustomProperty")]
    [Description("Value가 필수 입력인지?")]
    public bool IsValueRequired
    {
        get => _isValueRequired;
        set
        {
            if (_isValueRequired != value)
            {
                _isValueRequired = value;
                UpdateEventHandlers();
            }
        }
    }

    public EnhancedDateTimePicker()
    {
        this.CustomFormat = " ";
        this.Value = DateTime.Now;
    }

    private void UpdateEventHandlers()
    {
        if (!_isValueRequired)
        {
            this.KeyDown += EnhancedDateTimePicker_KeyDown;
            this.DropDown += EnhancedDateTimePicker_DropDown;
        }
        else
        {
            this.KeyDown -= EnhancedDateTimePicker_KeyDown;
            this.DropDown -= EnhancedDateTimePicker_DropDown;
        }
    }

    private void EnhancedDateTimePicker_KeyDown(object sender, KeyEventArgs e)
    {
        switch (e.KeyCode)
        {
            case Keys.Back:
            case Keys.Delete:
                this.Format = DateTimePickerFormat.Custom;
                break;
        }
        e.SuppressKeyPress = true;
    }

    private void EnhancedDateTimePicker_DropDown(object sender, EventArgs e)
    {
        if (this.Format == DateTimePickerFormat.Custom)
        {
            this.Format = DateTimePickerFormat.Short;
        }
    }
}