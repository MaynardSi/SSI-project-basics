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
                LogClass.LogEntryClass firstEntry = LogList.First();
                DateTime startTime = firstEntry.TimeInitiated;
                return startTime;
            }
        }

        public DateTime EndTime
        {
            get
            {
                LogClass.LogEntryClass lastEntry = LogList.Last();
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

        public List<string> FilterLogDisplay(List<string> tags, List<string> categories)
        {
            List<string> filteredLogDisplay = new List<string>();
            if (tags.Contains("ALL"))
            {
                tags = GetTag.Select(t => t.Item1).ToList();
            }
            if (categories.Contains("ALL"))
            {
                categories = GetCategory.Select(c => c.Item1).ToList();
            }
            //List <string> filter =
            //filteredLogDisplay = LogList.Where(l => tags.All(t => l.LogEntryString.Contains(t)));
            return filteredLogDisplay;
        }

        //TODO: Method documentation
        public void WriteReportFile(string writePath)
        {
            string[] report =
            {
                "No. of Log Entries: " + this.Entries,
                "Start Time: " + this.StartTime.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture),
                "End Time: " + this.EndTime.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture),
                "Log Duration: " + this.LogDuration
            };
            ProgramFileHandler.WriteFile(writePath, report);
        }
    }
}
