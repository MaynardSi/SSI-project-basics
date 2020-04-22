using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
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

        /// <summary>
        /// Updates UI once a log file has been selected
        /// </summary>
        /// <param name="fileString"></param>
        private void UpdateReportUI(string fileString)
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

            //Tag List Box for filtering
            tagListBox.ValueMember = "Item1";
            tagListBox.DisplayMember = tagDisplay.ToString();
            tagListBox.DataSource = tagDisplay;
            tagListBox.SelectedValueChanged += (s1, e1) => ListBox_SelectedValueChanged(s1, e1, true, categoryListBox);
            //Category List Box for filtering
            categoryListBox.ValueMember = "Item1";
            categoryListBox.DisplayMember = categoryDisplay.ToString();
            categoryListBox.DataSource = categoryDisplay;
            categoryListBox.SelectedValueChanged += (s2, e2) => ListBox_SelectedValueChanged(s2, e2, false, tagListBox);
            //Data table to Data Grid View of the log
            DataTable ldt = ToDataTable(Report.LogList);
            LogDataGridView.DataSource = ldt;

            saveReportTextBox.Text = reportPath;

            saveReportButton.Enabled = true;
        }
        /// <summary>
        /// Event handler for log file selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileString = openFileDialog1.FileName;
                try
                {
                    UpdateReportUI(fileString);
                }
                catch
                {

                }
            }
        }


        /// <summary>
        /// Method to transform collection into a datatable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <returns></returns>
        private DataTable ToDataTable<T>(IEnumerable<T> collection)
        {
            DataTable dt = new DataTable("DataTable");
            Type t = typeof(T);
            PropertyInfo[] pia = t.GetProperties();

            //Inspect the properties and create the columns in the DataTable
            foreach (PropertyInfo pi in pia)
            {
                Type ColumnType = pi.PropertyType;
                if ((ColumnType.IsGenericType))
                {
                    ColumnType = ColumnType.GetGenericArguments()[0];
                }
                dt.Columns.Add(pi.Name, ColumnType);
            }

            //Populate the data table
            foreach (T item in collection)
            {
                DataRow dr = dt.NewRow();
                dr.BeginEdit();
                foreach (PropertyInfo pi in pia)
                {
                    if (pi.GetValue(item, null) != null)
                    {
                        dr[pi.Name] = pi.GetValue(item, null);
                    }
                }
                dr.EndEdit();
                dt.Rows.Add(dr);
            }
            return dt;
        }

        /// <summary>
        /// Event handler for Tag and Category List boxes for filtering
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBox_SelectedValueChanged(object sender, EventArgs e, bool isTag, ListBox otherListbox)
        {
            ListBox listbox = (ListBox)sender;
            List<string> tagFilters = new List<string>();
            List<string> categoryFilters = new List<string>();
            string tagFiltersString = "[Tag] IN (";
            string catFiltersString = "[Category] IN (";
            string queryStatement = "";

            // Add selected items from Tag/Category List Box
            for (int i = 0; i < listbox.SelectedItems.Count; i++)
            {
                int s = listbox.SelectedIndices[i];
                Tuple<string, int> filterAddItem = (Tuple<string, int>)listbox.Items[s];
                if (isTag)
                    tagFilters.Add(filterAddItem.Item1);
                else
                    categoryFilters.Add(filterAddItem.Item1);

            }
            for (int i = 0; i < otherListbox.SelectedItems.Count; i++)
            {
                int s = otherListbox.SelectedIndices[i];
                Tuple<string, int> otherFilterAddItem = (Tuple<string, int>)otherListbox.Items[s];
                if (!isTag)
                    tagFilters.Add(otherFilterAddItem.Item1);
                else
                    categoryFilters.Add(otherFilterAddItem.Item1);

            }
            // String concatenation for formatted query statement
            tagFiltersString += string.Join(",", tagFilters.Select(x => string.Format("'{0}'", x)));
            tagFiltersString += ")";
            catFiltersString += string.Join(",", categoryFilters.Select(x => string.Format("'{0}'", x)));
            catFiltersString += ")";
            queryStatement = tagFiltersString + " AND " + catFiltersString;

            // Filter statement and method
            string rowFilter = string.Format("{0}", queryStatement);
            (LogDataGridView.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        /// <summary>
        /// Writes the log file upon pressing the save button and selecting a path.
        /// Calls the WriteReportFile method from the report object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveReportButton_Click(object sender, EventArgs e)
        {
            string path = saveReportTextBox.Text;                       //Default text for file
            SaveFileDialog SaveFileDialog1 = new SaveFileDialog();      //Save File dialog prompt
            saveFileDialog1.InitialDirectory = path;
            saveFileDialog1.FileName = path.Substring(path.LastIndexOf("\\") + 1);      //Get path from text box then trim file name
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog1.FileName;
                try
                {
                    Report.WriteReportFile(path);
                    MessageBox.Show("File Saved at " + path);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
