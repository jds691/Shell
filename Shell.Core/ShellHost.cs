using System.Diagnostics;

namespace Shell.Core;

public class ShellHost
{
    private Process? _currentProcess;
    
    public void RunCommand(string command)
    {
        if (_currentProcess == null)
        {
            _currentProcess = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
        
            startInfo.FileName = "cmd.exe";
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            startInfo.WorkingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        
            startInfo.RedirectStandardInput = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
        
            _currentProcess.StartInfo = startInfo;

            _currentProcess.OutputDataReceived += (_, args) => { Console.WriteLine(args.Data); };
            _currentProcess.ErrorDataReceived += (_, args) => { Console.WriteLine(args.Data); };
            _currentProcess.EnableRaisingEvents = true;
        
            _currentProcess.Start();   
            
            _currentProcess.BeginOutputReadLine();
            _currentProcess.BeginErrorReadLine();
        }
        
        _currentProcess.StandardInput.WriteLine(command);
        _currentProcess.StandardInput.Flush();
    }
}