using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace xBlueHeaven
{
    public sealed class ConsoleDebugLogger : ILogger
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool FreeConsole();

        private readonly string _name;
        private readonly Func<ConsoleDebugLoggerConfiguration> _getCurrentConfig;

        public ConsoleDebugLogger(
            string name,
            Func<ConsoleDebugLoggerConfiguration> getCurrentConfig) => (_name, _getCurrentConfig) = (name, getCurrentConfig);

        public IDisposable? BeginScope<TState>(TState state) where TState : notnull => default!;

        public bool IsEnabled(LogLevel logLevel) =>
            _getCurrentConfig().LogLevelToColorMap.ContainsKey(logLevel);

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            if (!IsEnabled(logLevel))
            {
                return;
            }

            ConsoleDebugLoggerConfiguration config = _getCurrentConfig();

            if (config.EventId == 0 || config.EventId == eventId.Id)
            {
                ConsoleColor originalColor = Console.ForegroundColor;

                Console.ForegroundColor = config.LogLevelToColorMap[logLevel];
                Console.WriteLine($"[{eventId.Id,2}: {logLevel,-12}]");

                Console.ForegroundColor = originalColor;
                Console.Write($"     {_name} - ");

                Console.ForegroundColor = config.LogLevelToColorMap[logLevel];
                Console.Write($"{formatter(state, exception)}");

                Console.ForegroundColor = originalColor;
                Console.WriteLine();
            }
        }

        public static void StartConsole()
        {
            AllocConsole();
            Console.Title = "xBlueHeavenDebug";
        }

        public static void StopConsole()
        {
            FreeConsole();
        }
    }
}
