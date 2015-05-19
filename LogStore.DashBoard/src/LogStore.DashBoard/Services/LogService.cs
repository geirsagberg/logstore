using LogStore.DashBoard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogStore.DashBoard.Services
{
    public class LogService : ILogService
    {
        public IEnumerable<LogEntry> GetLogs()
        {
            return Enumerable.Range(0, 50).Select(_ => new LogEntry { Message = $"Logging {Guid.NewGuid()}" });
        }

    }
}
