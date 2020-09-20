using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKY
{
    class Run_Process
    {
        public string ExecuteCommandSync(object command, string type = null, string output = null)
        {
            try
            {
                ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd", "/c " + command);


                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;

                procStartInfo.CreateNoWindow = true;
                procStartInfo.WorkingDirectory = @"C:\";
                Process proc = new Process();
                proc.StartInfo = procStartInfo;
                proc.Start();

                if (output != null)
                {
                    string result = proc.StandardOutput.ReadToEnd();
                    //Console.WriteLine(result);
                    proc.WaitForExit();
                    return result;
                }

                if (type == null)
                {
                    proc.WaitForExit();
                }

            }
            catch (Exception objException)
            {
            }
            return null;
        }
    }
}
