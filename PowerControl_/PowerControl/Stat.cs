using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerControl
{
    static class Stat
    {
        public static void ShutDown()
        {
            var psi = new ProcessStartInfo("shutdown", "/s /t 0")
            {
                CreateNoWindow = true,
                UseShellExecute = false
            };
            Process.Start(psi);
        }

        public static void Restart()
        {
            var psi = new ProcessStartInfo("shutdown", "/r /t 0")
            {
                CreateNoWindow = true,
                UseShellExecute = false
            };
            Process.Start(psi);
        }

        public static void Hiber()
        {
            var psi = new ProcessStartInfo("shutdown", "/h")
            {
                CreateNoWindow = true,
                UseShellExecute = false
            };
            Process.Start(psi);
        }

        public static void SignOut()
        {
            var psi = new ProcessStartInfo("shutdown", "/l")
            {
                CreateNoWindow = true,
                UseShellExecute = false
            };
            Process.Start(psi);
        }

        public static void Lock()
        {
            var psi = new ProcessStartInfo(@"C:\WINDOWS\system32\rundll32.exe", "user32.dll,LockWorkStation")
            {
                CreateNoWindow = true,
                UseShellExecute = false
            };
            Process.Start(psi);
        }

        public static void Sleep()
        {
            var psi = new ProcessStartInfo(@"C:\WINDOWS\system32\rundll32.exe", "powrprof.dll,SetSuspendState 0,1,0")
            {
                CreateNoWindow = true,
                UseShellExecute = false
            };
            Process.Start(psi);
        }
    }
}
