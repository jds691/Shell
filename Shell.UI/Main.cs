using Shell.Core;

namespace Shell.UI;

public partial class Main : Form
{
    private ShellHost _host;
    
    public Main()
    {
        InitializeComponent();
        _host = new ShellHost();
    }

    private void btnRun_Click(object sender, EventArgs e)
    {
        _host.RunCommand(tbxInput.Text);
        tbxInput.Clear();
    }
}