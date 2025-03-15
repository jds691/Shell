namespace Shell.UI;

public static class RichTextBoxExtensions
{
    public static void AppendText(this RichTextBox rtbx, string text, Color color)
    {
        rtbx.SelectionStart = rtbx.TextLength;
        rtbx.SelectionLength = 0;
        
        rtbx.SelectionColor = color;
        rtbx.AppendText(text);
        rtbx.ScrollToCaret();
        rtbx.SelectionColor = rtbx.ForeColor;
    }
}