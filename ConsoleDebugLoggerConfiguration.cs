using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xBlueHeaven
{
    public sealed class ConsoleDebugLoggerConfiguration
    {
        public int EventId { get; set; }

        public Dictionary<LogLevel, ConsoleColor> LogLevelToColorMap { get; set; } = new()
        {
            [LogLevel.Information] = ConsoleColor.Green,
            [LogLevel.Error] = ConsoleColor.Red,
            [LogLevel.Warning] = ConsoleColor.Yellow,
            [LogLevel.Debug] = ConsoleColor.White
        };
    }
}
