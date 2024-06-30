using System;
using System.ComponentModel;
using System.Windows.Forms;

public class EnhancedTextBox : TextBox
{
    private readonly ToolTip toolTip = new ToolTip();
    private bool _isNumberOnly = false;

    [Browsable(true)]
    [DefaultValue(false)]
    [Category("CustomProperty")]
    [Description("숫자만 입력받기")]
    public bool IsNumberOnly
    {
        get => _isNumberOnly;
        set
        {
            if (_isNumberOnly != value)
            {
                _isNumberOnly = value;
                UpdateEventHandlers();
            }
        }
    }

    public EnhancedTextBox()
    {
        this.KeyDown += new KeyEventHandler(this.EnhancedTextBox_KeyDown);
        this.KeyPress += new KeyPressEventHandler(this.EnhancedTextBox_KeyPress);
    }

    private void UpdateEventHandlers()
    {
        if (_isNumberOnly)
        {
            this.KeyPress += new KeyPressEventHandler(this.OnlyNumberKeyPress);
        }
        else
        {
            this.KeyPress -= new KeyPressEventHandler(this.OnlyNumberKeyPress);
        }
    }

    private void EnhancedTextBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.Control)
        {
            switch (e.KeyCode)
            {
                case Keys.Back:
                    HandleCtrlBackspace();
                    e.SuppressKeyPress = true; // 기본 동작 억제
                    break;
                case Keys.V:
                    if (_isNumberOnly && Clipboard.ContainsText() && !uint.TryParse(Clipboard.GetText(), out _))
                    {
                        System.Media.SystemSounds.Beep.Play();
                        toolTip.Show("숫자만 입력할 수 있습니다.", this, 0, -20, 1000);
                    }
                    else
                    {
                        this.Paste();
                    }
                    e.SuppressKeyPress = true; // 기본 동작 억제
                    break;
            }
        }
    }

    private void EnhancedTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == '\u0017') // Ctrl + Backspace의 ASCII 코드
        {
            e.Handled = true; // 기본 동작 억제
        }
    }

    private  void OnlyNumberKeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        {
            System.Media.SystemSounds.Beep.Play();
            toolTip.Show("숫자만 입력할 수 있습니다.", this, 0, -20, 1000);

            e.Handled = true;
        }
    }

    private void HandleCtrlBackspace()
    {
        int pos = this.SelectionStart;

        if (pos > 0)
        {
            int start = pos;

            // 현재 위치가 공백인 경우, 연속된 공백을 모두 삭제
            if (char.IsWhiteSpace(this.Text[pos - 1]))
            {
                while (start > 0 && char.IsWhiteSpace(this.Text[start - 1]))
                {
                    start--;
                }
            }
            else
            {
                // 단어의 시작 위치 찾기
                while (start > 0 && !char.IsWhiteSpace(this.Text[start - 1]))
                {
                    start--;
                }
            }

            // 현재 위치에서 단어의 시작 위치까지 삭제
            this.Text = this.Text.Remove(start, pos - start);
            this.SelectionStart = start;
        }
    }
}