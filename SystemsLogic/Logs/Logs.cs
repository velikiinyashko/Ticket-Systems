using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemsLogic.Logs
{
    class EventLogs
    {
        public string NameSource;
        public string LogText { get; set; }
        EventLog GetEventLog;

        public EventLogs(string NameSource)
        {
            this.NameSource = NameSource;
            if (!EventLog.SourceExists(this.NameSource))
            {
                EventLog.CreateEventSource(this.NameSource, "Ticket Systems");
                GetEventLog = new EventLog();
                GetEventLog.Source = this.NameSource;
            }
        }

        public void WriteEventLogInfo()
        {
            GetEventLog.WriteEntry(LogText, EventLogEntryType.Information);
        }

        public void WrineEventLogError()
        {
            GetEventLog.WriteEntry(LogText, EventLogEntryType.Error);
        }
    }
}
