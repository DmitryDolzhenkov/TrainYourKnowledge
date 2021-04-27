using System;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetActiveUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] runningProcesses = Process.GetProcesses("zmk-wrk07");

            string strCmdText;
           // strCmdText = "/C copy /b Image1.jpg + Archive.rar Image2.jpg";
            strCmdText = @"openfiles /query /fo table | find /I "+ @"\\zmk-wrk07\sapr_image\ts\utils\AutoWeld\WeldBetweenFaces2018i.exe" + '"';
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);

            //"openfiles /query /fo table | find /I \\zmk-wrk07\sapr_image\ts\utils\AutoWeld\WeldBetweenFaces2018i.exe";
            //IF((Test - Path - Path $FileOrFolderPath) - eq $false) {
            //    Write - Warning "File or directory does not exist."
            //}
            //Else {
            //    $LockingProcess = CMD / C 
            //    Write - Host $LockingProcess
            //}
            //GetProcessesByName(string processName, string machineName)
            var currentSessionID = Process.GetCurrentProcess().SessionId;

            //Process[] sameAsThisSession =
            //    runningProcesses.Where(p => p.SessionId == currentSessionID).ToArray();

            //foreach (var p in sameAsthisSession)
            //{
            //    Trace.WriteLine(p.ProcessName);
            //}
            //string strComputer = "."
            

            //Process p = new Process();
            //p.StartInfo.UseShellExecute = false;
            //p.StartInfo.RedirectStandardOutput = true;
            //p.StartInfo.FileName = @"\\zmk-wrk07\sapr_image\ts\utils\AutoWeld\WeldBetweenFaces2018i.exe";
            //p.StartInfo.Arguments = "";
            //p.Start();
            //string output = p.StandardOutput.ReadToEnd();
            //p.WaitForExit();

            //IsUserActive();
        }
        public static bool IsUserActive(string userName)
        {
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = "c:\\Windows\\SysNative\\qwinsta.exe";
            p.StartInfo.Arguments = userName;
            p.Start();
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            return output.Contains("  Active");
        }
    }
}
