using System;
using System.Collections.Generic;

/// <summary>
/// Log class which models a given log file
/// </summary>
public class LogClass
{
    public LogClass(string logName, List<string> log)
    {
        this.LogName = logName;
        this.LogList = LogListInit(log);
    }

    public List<LogEntryClass> LogListInit(List<string> log)
    {
        List<LogEntryClass> logList = new List<LogEntryClass>();
        char[] charSeparators = new char[] { ',' };
        string[] addLine = new string[4];
        int countId = 0;
        foreach (var line in log)
        {
            addLine = line.Split(charSeparators, 4);
            LogEntryClass newLogEntry = new LogEntryClass(line, countId, addLine[0], addLine[1], Convert.ToDateTime(addLine[2]), addLine[3]);
            logList.Add(newLogEntry);
            countId++;
        }
        return logList;
    }

    public string LogName { get; private set; }
    public List<LogEntryClass> LogList { get; set; }

    /// <summary>
    /// This class contains properties of a log entry.
    /// A log entry contains:
    /// 1. Id
    /// 2. Tag
    /// 3. Category
    /// 4. Time initiated
    /// 5. Action
    /// </summary>
    public class LogEntryClass
    {
        public LogEntryClass(string line, int entryNo, string tag, string category, DateTime timeInitiated, string actionTaken)
        {
            this.EntryNo = entryNo;
            this.Tag = tag;
            this.Category = category;
            this.TimeInitiated = timeInitiated;
            this.ActionTaken = actionTaken;
        }

        public int EntryNo { get; set; }
        public string Tag { get; set; }
        public string Category { get; set; }
        public DateTime TimeInitiated { get; set; }
        public string ActionTaken { get; set; }

    }
}
