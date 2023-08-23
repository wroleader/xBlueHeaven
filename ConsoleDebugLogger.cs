using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace xBlueHeaven
{
    public class ConsoleDebugLogger
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool FreeConsole();

        private string currentTime;
        private string level;
        private string message;

        public static void StartConsole()
        {
            AllocConsole();
            Console.Title = "xBlueHeavenDebug";
        }

        public static void StopConsole()
        {
            FreeConsole();
        }

        public void LogInformation(string text)
        {
            currentTime = DateTime.Now.ToString();
            level = " [INFO] ";
            message = currentTime + level + text;

            Console.Out.WriteLine(message);
        }
        public void LogWarning(string text)
        {
            currentTime = DateTime.Now.ToString();
            level = " [WARNING] ";
            message = currentTime + level + text;

            Console.Out.WriteLine(message);
        }
        public void LogError(string text)
        {
            currentTime = DateTime.Now.ToString();
            level = " [ERROR] ";
            message = currentTime + level + text;
        }
    }
}
