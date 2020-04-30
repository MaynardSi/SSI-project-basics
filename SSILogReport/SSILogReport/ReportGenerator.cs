using Common;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace SSILogReport
{
    /// <summary>
    /// Class that contains methods in report generation.
    /// This class is responsible for parsing the log file
    /// to generate needed reports.
    /// </summary>
    internal class ReportGenerator
    {
        public ReportGenerator(List<Log.LogEntry> logList)
        {
            LogList = logList;
        }

        public List<Log.LogEntry> LogList { get; private set; }

        public string Entries
        {
            get
            {
                return LogList.Count().ToString();
            }
        }

        public DateTime StartTime
        {
            get
            {
                Log.LogEntry firstEntry = LogList.First();
                DateTime startTime = firstEntry.TimeInitiated;
                return startTime;
            }
        }

        public DateTime EndTime
        {
            get
            {
                Log.LogEntry lastEntry = LogList.Last();
                DateTime endTime = lastEntry.TimeInitiated;
                return endTime;
            }
        }

        public TimeSpan LogDuration
        {
            get
            {
                TimeSpan duration = EndTime.Subtract(StartTime);
                return duration;
            }
        }

        public int GetTagCategoryCount(bool isTag, string tagCatName)
        {
            int result = isTag ? LogList.Where(s => s.Tag == tagCatName).Count() : LogList.Where(s => s.Category == tagCatName).Count();
            return result;
        }

        public List<Tuple<string, int>> GetTagCatergory(bool isTag)
        {
            List<string> result = new List<string>();

            // Get all distinct tag/category names
            result = isTag ? LogList.Select(o => o.Tag).Distinct().ToList() : LogList.Select(o => o.Category).Distinct().ToList();

            // Create a list of (tag/category, number of tag/category occurences) pairs
            List<Tuple<string, int>> tagCatTupleList = new List<Tuple<string, int>>();
            foreach (string tagCat in result)
            {
                Tuple<string, int> tagTuple = new Tuple<string, int>(tagCat, GetTagCategoryCount(isTag, tagCat));
                tagCatTupleList.Add(tagTuple);
            }
            return tagCatTupleList;
        }

        public List<Tuple<string, int>> GetTag
        {
            get
            {
                return GetTagCatergory(true);
            }
        }

        public List<Tuple<string, int>> GetCategory
        {
            get
            {
                return GetTagCatergory(false);
            }
        }

        /// <summary>
        /// Write report into a log file. Report Contains the following:
        /// 1. No. of log entries
        /// 2. Start time
        /// 3. End time
        /// 4. Duration from log start time to end time
        /// 5. All tags and count of how many times they are found on the log
        /// 6. All categories and count of how many times they are found on the log
        /// </summary>
        /// <param name="writePath"></param>
        public void WriteReportFile(string writePath)
        {
            string[] report =
            {
                "No. of Log Entries: " + this.Entries,
                "Start Time: " + this.StartTime.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture),
                "End Time: " + this.EndTime.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture),
                "Log Duration: " + this.LogDuration,
                "Tags: " + string.Join(", ", this.GetTag.Select(t => $"['{t.Item1}', '{t.Item2}']")),
                "Categories: " + string.Join(", ", this.GetCategory.Select(t => $"['{t.Item1}', '{t.Item2}']")),
            };
            ProgramFileHandler.WriteFile(writePath, report);
        }
    }
}