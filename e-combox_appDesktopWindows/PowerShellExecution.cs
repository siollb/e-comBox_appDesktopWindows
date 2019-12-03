using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.ComponentModel;

namespace e_combox_appDesktopWindows.Scripts
{
    class PowerShellExecution
    {
        public event EventHandler exeFinished = delegate { };
        public async Task<String> ExecuteShellScript(string script)
        {
                ProcessStartInfo startInfo = new ProcessStartInfo()
                {
                    FileName = "powershell.exe",
                    Arguments = $"-NoProfile -ExecutionPolicy bypass \"{script}\"",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                };

            String output = await Task.Run(() => StartScript(startInfo));
            return output.ToString();
        }

        private string StartScript(ProcessStartInfo psi)
        {
            Process proc = Process.Start(psi);
            String output = proc.StandardOutput.ReadToEnd();
            proc.WaitForExit();

            Trace.WriteLine("Sortie: ");
            Debug.WriteLine(output.ToString());
            Trace.WriteLine("-------------");
            proc.Close();

            return output.ToString();
        }


    }
}
