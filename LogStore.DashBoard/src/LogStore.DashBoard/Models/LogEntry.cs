using System;

namespace LogStore.DashBoard.Models
{
    public class LogEntry
    {
        public string LogLevel { get; set; }
        public string AppId { get; set; }
        public string AccessToken { get; set; }
        public string Id { get; set; }
        public DateTimeOffset Time { get; set; }
        public string Message { get; set; }
        public string MachineName { get; set; }
        public string ProcessId { get; set; }
        public string ThreadId { get; set; }
        public string Locale { get; set; }

    }
}