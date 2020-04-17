using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSILogReport
{
    public partial class SSILogReportForm : Form
    {
        public SSILogReportForm()
        {
            InitializeComponent();
        }

        private LogClass Log { get; set; }
        internal ReportGenerator Report { get; private set; }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileString = openFileDialog1.FileName;
                MessageBox.Show(openFileDialog1.FileName);
                try
                {
                    Log = new LogClass(fileString, ProgramFileHandler.ReadFile(fileString));
                    fileInputBox.Text = fileString;
                    Report = new ReportGenerator(Log.LogList);

                    var entries = Report.Entries;
                    var startTime = Report.StartTime;
                    var endTime = Report.EndTime;
                    var logDuration = Report.LogDuration;
                    string[] splitpath = fileString.Split('.');
                    string reportPath = String.Join("_report.", splitpath);

                    entriesTextBox.Text = entries;
                    startTimeTextBox.Text = startTime.ToString("MMMM dd, yyyy HH:mm:ss.fff");
                    endTimeTextBox.Text = endTime.ToString("MMMM dd, yyyy HH:mm:ss.fff");
                    logDurationTextBox.Text = logDuration.ToString("%d") + " days " +
                        logDuration.ToString("%h") + " hours " +
                        logDuration.ToString("%m") + " minutes " +
                        logDuration.ToString("%s") + " seconds " +
                        logDuration.ToString("%f") + " milliseconds";
                    saveReportTextBox.Text = reportPath;
                    //List<string> logList = ProgramFileHandler.ReadFile(fileString);
                    //MessageBox.Show(logList.Count().ToString());
                    //Console.WriteLine(sr.ReadToEnd());
                    //logList.ForEach(item => LogTextbox.AppendText(item.Count() + "_" + item));
                }
                catch
                {

                }
            }
        }

        private void SaveReportButton_Click(object sender, EventArgs e)
        {
            string path = saveReportTextBox.Text;
            string dir = path.Substring(0, path.LastIndexOf("\\") + 1);
            if (path != "")
            {
                if (Directory.Exists(dir))
                {
                    Report.WriteReportFile(path);
                    MessageBox.Show("Successfully saved at \n" + path);
                }
                else
                {
                    MessageBox.Show(path + " is not a valid file or directory.");
                }
            }
            else
            {
                MessageBox.Show("Please select a file!");
            }
        }
    }
}
