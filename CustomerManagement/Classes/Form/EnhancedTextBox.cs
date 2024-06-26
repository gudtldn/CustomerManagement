using System;
using System.Windows.Forms;

public class EnhancedTextBox : TextBox
{
    public EnhancedTextBox()
    {
        this.KeyDown += new KeyEventHandler(this.EnhancedTextBox_KeyDown);
        this.KeyPress += new KeyPressEventHandler(this.EnhancedTextBox_KeyPress);
    }

    private void EnhancedTextBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.Control && e.KeyCode == Keys.Back)
        {
            HandleCtrlBackspace();
            e.SuppressKeyPress = true; // 기본 동작 억제
        }
    }

    private void EnhancedTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == '\u0017') // Ctrl + Backspace의 ASCII 코드
        {
            e.Handled = true; // 기본 동작 억제
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