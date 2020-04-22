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
    ///
    class ReportGenerator
    {
        public ReportGenerator(List<LogClass.LogEntryClass> logList)
        {
            LogList = logList;
        }

        public List<LogClass.LogEntryClass> LogList { get; private set; }

        /// <summary>
        /// Get number of log entries
        /// </summary>
        public string Entries
        {
            get
            {
                return LogList.Count().ToString();
            }
        }

        /// <summary>
        /// Get time when log was initiated
        /// </summary>
        public DateTime StartTime
        {
            get
            {
                LogClass.LogEntryClass firstEntry = LogList.First();
                DateTime startTime = firstEntry.TimeInitiated;
                return startTime;
            }
        }

        /// <summary>
        /// Get time when log ended
        /// </summary>
        public DateTime EndTime
        {
            get
            {
                LogClass.LogEntryClass lastEntry = LogList.Last();
                DateTime endTime = lastEntry.TimeInitiated;
                return endTime;
            }
        }

        /// <summary>
        /// Get duration of log from start time to end time
        /// </summary>
        public TimeSpan LogDuration
        {
            get
            {
                TimeSpan duration = EndTime.Subtract(StartTime);
                return duration;
            }
        }

        /// <summary>
        /// Returns Count of particular category or tag
        /// </summary>
        /// <param name="isTag"></param>
        /// <param name="tagCatName"></param>
        /// <returns></returns>
        public int GetTagCategoryCount(bool isTag, string tagCatName)
        {
            int result = new int();
            if (isTag)
            {
                result = LogList.Where(s => s.Tag == tagCatName).Count();
            }
            else
            {
                result = LogList.Where(s => s.Category == tagCatName).Count();
            }
            return result;
        }

        /// <summary>
        /// Return pair of particular Tag/Category along with their respective count
        /// </summary>
        /// <param name="isTag"></param>
        /// <returns></returns>
        public List<Tuple<string, int>> GetTagCatergory(bool isTag)
        {
            //TODO: get all distinct tag names
            List<string> result = new List<string>();
            if (isTag)
            {
                result = LogList.Select(o => o.Tag).Distinct().ToList();
            }
            else
            {
                result = LogList.Select(o => o.Category).Distinct().ToList();
            }
            var tagCatTupleList = new List<Tuple<string, int>>();
            foreach (var tagCat in result)
            {
                var tagTuple = new Tuple<string, int>(tagCat, GetTagCategoryCount(isTag, tagCat));
                tagCatTupleList.Add(tagTuple);
            }
            //TODO: for each tag, get count
            return tagCatTupleList;
        }

        /// <summary>
        /// Get list of all Tags along with the count of entries with this tag
        /// </summary>
        public List<Tuple<string, int>> GetTag
        {
            get
            {
                return GetTagCatergory(true);
            }
        }

        /// <summary>
        /// Get list of all Categories along with the count of entries with this category
        /// </summary>
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
