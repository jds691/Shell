using System.Diagnostics;

namespace Shell.Core;

public class ShellHost
{
    private Process _currentProcess;
    
    public event EventHandler<string?> OutputReceived; 
    public event EventHandler<string?> ErrorReceived;

    private static int _errorLoopCount = 0;

    public ShellHost()
    {
        InitialiseShell();
    }

    private void InitialiseShell()
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
        try
        {
            _currentProcess.StandardInput.WriteLine(command);
            _currentProcess.StandardInput.Flush();

            _errorLoopCount = 0;
        }
        catch (Exception e)
        {
            _errorLoopCount++;

            if (_errorLoopCount == 11)
            {
                ErrorReceived?.Invoke(this, "This command is causing repeated errors in the shell, please do not reattempt it.");
                _errorLoopCount = 0;
            }
            else
            {
                ErrorReceived?.Invoke(this, $"Encountered an error running the command, restarting the shell and retrying ({_errorLoopCount}/10)...");
                InitialiseShell();
                RunCommand(command);
            }
        }
    }
}