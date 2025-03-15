using Shell.Core;

namespace Shell.UI;

public partial class Main : Form
{
    private ShellHost _host;
    
    public Main()
    {
        InitializeComponent();
        _host = new ShellHost();
        
        _host.OutputReceived += HostOnOutputReceived;
        _host.ErrorReceived += HostOnErrorReceived;
    }
    
    private void HostOnOutputReceived(object? sender, string? e)
    {
        if (e == null) return;

        Invoke(() =>
        {
            rtbxOutput.AppendText(e);
            rtbxOutput.AppendText(Environment.NewLine);
            
            rtbxOutput.ScrollToCaret();
        });
    }

    private void HostOnErrorReceived(object? sender, string? e)
    {
        if (e == null) return;
        
        Invoke(() =>
        {
            rtbxOutput.AppendText(e, Color.Red);
            rtbxOutput.AppendText(Environment.NewLine);
            
            rtbxOutput.ScrollToCaret();
        });
    }

    private void btnRun_Click(object sender, EventArgs e)
    {
        _host.RunCommand(tbxInput.Text);
        tbxInput.Clear();
    }
}