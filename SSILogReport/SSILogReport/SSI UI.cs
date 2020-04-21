using System;
using System.Collections.Generic;
using System.ComponentModel;
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
                    fileInputBox.Text = fileString;
                    Report = new ReportGenerator(new LogClass(fileString, ProgramFileHandler.ReadFile(fileString)).LogList);

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

                    //TODO: Change to clickable tag text
                    tagDisplay.Insert(0, new Tuple<string, int>("ALL", Convert.ToInt32(entries)));
                    tagListBox.DataSource = tagDisplay;
                    tagListBox.DisplayMember = "Item1" + "Item2";
                    tagListBox.SelectedValueChanged += new EventHandler(ListBox_SelectedValueChanged);

                    //TODO: Change to clickable category text
                    categoryDisplay.Insert(0, new Tuple<string, int>("ALL", Convert.ToInt32(entries)));
                    categoryListBox.DataSource = categoryDisplay;
                    categoryListBox.DisplayMember = "Item1" + "Item2";
                    categoryListBox.SelectedValueChanged += new EventHandler(ListBox_SelectedValueChanged);

                    var logBindingList = new BindingList<LogClass.LogEntryClass>(Report.LogList);
                    var source = new BindingSource(logBindingList, null);
                    LogDataGridView.DataSource = logBindingList;

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

        private void ListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            ListBox listbox = (ListBox)sender;

            if (listbox.SelectedItems.Count > 1)
            {
                if (listbox.SelectedIndex == 0)
                {
                    listbox.SelectedItems.Clear();
                    listbox.SetSelected(0, true);
                }
            }

        }

        private void filterLogButton_Click(object sender, EventArgs e)
        {
            List<string> selectedTags = new List<string>();
            List<string> selectedCategories = new List<string>();

            foreach (string item in tagListBox.SelectedItems)
            {
                selectedTags.Add(item);
            }

            foreach (string item in categoryListBox.SelectedItems)
            {
                selectedCategories.Add(item);
            }
            //Report.FilterLogDisplay
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
