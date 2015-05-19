using System.Collections.Generic;

namespace LogStore.DashBoard.Models
{
    public class DashBoardViewModel
    {
        public IEnumerable<LogEntry> Logs { get; }

        public DashBoardViewModel()
        {
        }

        public DashBoardViewModel(IEnumerable<LogEntry> logs)
        {
            Logs = logs;
        }
    }
}