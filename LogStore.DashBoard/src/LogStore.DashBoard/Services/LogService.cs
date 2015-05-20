using LogStore.DashBoard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ploeh.AutoFixture;

namespace LogStore.DashBoard.Services
{
    public class LogService : ILogService
    {
        public IEnumerable<LogEntry> GetLogs()
        {
            var fixture = new Fixture();
            return Enumerable.Range(0, 50).Select(_ => fixture.Create<LogEntry>());
        }

    }
}
