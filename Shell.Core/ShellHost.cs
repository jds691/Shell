using System.Diagnostics;

namespace Shell.Core;

public class ShellHost
{
    private Process _currentProcess;
    
    public event EventHandler<string?> OutputReceived; 
    public event EventHandler<string?> ErrorReceived;

    public ShellHost()
    {
        _currentProcess = new Process();
        ProcessStartInfo startInfo = new ProcessStartInfo();
        
        startInfo.FileName = "powershell.exe";
        startInfo.UseShellExecute = false;
        startInfo.CreateNoWindow = true;
        startInfo.WorkingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        
        startInfo.RedirectStandardInput = true;
        startInfo.RedirectStandardOutput = true;
        startInfo.RedirectStandardError = true;
        
        _currentProcess.StartInfo = startInfo;

        _currentProcess.OutputDataReceived += (_, args) =>
        {
            OutputReceived?.Invoke(this, args.Data);
        };
        _currentProcess.ErrorDataReceived += (_, args) =>
        {
            ErrorReceived?.Invoke(this, args.Data);
        };
        _currentProcess.EnableRaisingEvents = true;
        
        _currentProcess.Start();   
            
        _currentProcess.BeginOutputReadLine();
        _currentProcess.BeginErrorReadLine();
    }
    
    public void RunCommand(string command)
    {
        _currentProcess.StandardInput.WriteLine(command);
        _currentProcess.StandardInput.Flush();
    }
}