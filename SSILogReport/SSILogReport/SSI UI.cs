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
                    var tagDisplay = Report.GetTag;
                    var categoryDisplay = Report.GetCategory;
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
                    tagTexbox.Text = string.Join("\r\n", Report.GetTag);
                    categoryTextbox.Text = string.Join("\r\n", Report.GetCategory);
                    //TODO: Replace line below
                    logTextbox.Text = string.Join("\r\n", ProgramFileHandler.ReadFile(fileString));
                    saveReportTextBox.Text = reportPath;

                    saveReportButton.Enabled = true;
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
            string path = saveReportTextBox.Text;                       //Default text for file
            SaveFileDialog SaveFileDialog1 = new SaveFileDialog();      //Save File dialog prompt
            saveFileDialog1.InitialDirectory = path;
            saveFileDialog1.FileName = path.Substring(path.LastIndexOf("\\") + 1);      //Get path from text box then trim file name
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog1.FileName;
                Report.WriteReportFile(path);
            }
        }
    }
}
