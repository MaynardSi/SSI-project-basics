using System;
using System.Collections.Generic;

/// <summary>
/// Log class which models a given log file
/// </summary>
public class Log
{
    public Log(string logName, List<string> log)
    {
        this.LogName = logName;
        this.LogList = parseLogs(log);
    }

    public string LogName { get; private set; }
    public List<LogEntry> LogList { get; set; }

    private static List<LogEntry> parseLogs(List<string> log)
    {
        List<LogEntry> logList = new List<LogEntry>();
        char[] charSeparators = new char[] { ',' };
        string[] addLine = new string[4];           // Create an array of size 4
        int countId = 0;
        foreach (string line in log)
        {
            addLine = line.Split(charSeparators, 4);
            LogEntry newLogEntry = new LogEntry(line, countId, addLine[0], addLine[1], Convert.ToDateTime(addLine[2]), addLine[3]);
            logList.Add(newLogEntry);
            countId++;
        }
        return logList;
    }

    /// <summary>LogEntry
    /// This class contains properties of a log entry.
    /// A log entry contains:
    /// 1. Id
    /// 2. Tag
    /// 3. Category
    /// 4. Time initiated
    /// 5. Action
    /// </summary>
    public class LogEntry
    {
        public int EntryNo { get; set; }
        public string Tag { get; set; }
        public string Category { get; set; }
        public DateTime TimeInitiated { get; set; }
        public string ActionTaken { get; set; }

        public LogEntry(string line, int entryNo, string tag, string category, DateTime timeInitiated, string actionTaken)
        {
            this.EntryNo = entryNo;
            this.Tag = tag;
            this.Category = category;
            this.TimeInitiated = timeInitiated;
            this.ActionTaken = actionTaken;
        }
    }
}