using LogStore.DashBoard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogStore.DashBoard.Services
{
    public interface ILogService
    {
        IEnumerable<LogEntry> GetLogs();
    }
}
