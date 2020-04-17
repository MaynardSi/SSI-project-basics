using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSILogReport
{
    /// <summary>
    /// Class that contains methods in report generation.
    /// This class is responsible for parsing the log file
    /// to generate needed reports.
    /// </summary>
    class ReportGenerator
    {
        public ReportGenerator(List<string> logList)
        {
            LogList = logList;
        }

        public List<string> LogList { get; private set; }

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
                string[] firstEntry = LogList.First().Split(',');
                DateTime startTime = Convert.ToDateTime(firstEntry[2]);
                return startTime;
            }
        }

        public DateTime EndTime
        {
            get
            {
                string[] lastEntry = LogList.Last().Split(',');
                DateTime endTime = Convert.ToDateTime(lastEntry[2]);
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

        public void WriteReportFile(string writePath)
        {
            string[] report =
            {
                "No. of Log Entries: " + this.Entries,
                "Start Time: " + this.StartTime.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture),
                "End Time: " + this.EndTime.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture),
                "Log Duration: " + this.LogDuration
            };

            try
            {
                File.WriteAllLines(writePath, report);
            }
            catch
            {

            }
        }

        //public DateTime GetStartTime()
        //{
        //    string[] firstEntry = LogList.First().Split(',');
        //    DateTime startTime = Convert.ToDateTime(firstEntry[2]);
        //    return startTime;
        //}

        //public DateTime GetEndTime()
        //{
        //    string[] lastEntry = LogList.Last().Split(',');
        //    DateTime endTime = Convert.ToDateTime(lastEntry[2]);
        //    return endTime;
        //}

        //public DateTime GetLogDuration()
        //{
        //    return DateTime.Now;
        //}
    }
}
