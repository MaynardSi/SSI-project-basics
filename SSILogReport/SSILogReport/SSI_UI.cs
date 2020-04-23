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
        // Property and Constructor
        internal ReportGenerator Report { get; private set; }

        public SSILogReportForm()
        {
            InitializeComponent();
        }

        // Method declarations
        /// <summary>
        /// Updates UI once a log file has been selected
        /// </summary>
        /// <param name="fileString"></param>
        private void InitFormUI(string fileString)
        {
            InitReportDisplay(fileString);
            InitFilterDisplay();
            InitLogDisplay();
        }

        /// <summary>
        /// Display basic information from selected log file using UI components
        /// </summary>
        /// <param name="fileString"></param>
        private void InitReportDisplay(string fileString)
        {
            fileInputBox.Text = fileString;
            Report = new ReportGenerator(new Log(fileString, ProgramFileHandler.ReadFile(fileString)).LogList);

            string entries = Report.Entries;
            DateTime startTime = Report.StartTime;
            DateTime endTime = Report.EndTime;
            TimeSpan logDuration = Report.LogDuration;
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
            saveReportButton.Enabled = true;
        }

        /// <summary>
        /// Display List of Tags and Categories that can be selected for log display filtering using UI components
        /// </summary>
        private void InitFilterDisplay()
        {
            List<Tuple<string, int>> tagDisplay = Report.GetTag;
            List<Tuple<string, int>> categoryDisplay = Report.GetCategory;

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
        }

        /// <summary>
        /// Display list of log entries using a DataGridView
        /// </summary>
        private void InitLogDisplay()
        {
            logDataGridView.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn EntryField = new DataGridViewTextBoxColumn
            {
                HeaderText = "No.",
                DataPropertyName = "EntryNo"
            };
            DataGridViewTextBoxColumn TagField = new DataGridViewTextBoxColumn
            {
                HeaderText = "Tag",
                DataPropertyName = "Tag"
            };
            DataGridViewTextBoxColumn CategoryField = new DataGridViewTextBoxColumn
            {
                HeaderText = "Category",
                DataPropertyName = "Category"
            };
            DataGridViewTextBoxColumn TimeField = new DataGridViewTextBoxColumn
            {
                HeaderText = "Time Started",
                DataPropertyName = "TimeInitiated",
            };
            TimeField.DefaultCellStyle.Format = "MMMM dd, yyyy HH:mm:ss.fff";
            DataGridViewTextBoxColumn ActionField = new DataGridViewTextBoxColumn
            {
                HeaderText = "Action",
                DataPropertyName = "ActionTaken"
            };
            logDataGridView.Columns.Add(EntryField);
            logDataGridView.Columns.Add(TagField);
            logDataGridView.Columns.Add(CategoryField);
            logDataGridView.Columns.Add(TimeField);
            logDataGridView.Columns.Add(ActionField);
            //Data table to Data Grid View of the log
            DataTable ldt = ToDataTable(Report.LogList);
            logDataGridView.DataSource = ldt;
        }

        /// <summary>
        /// Display list of log entries using UI components
        /// </summary>
        /// <param name="e"></param>
        private void UpdateEntryDisplay(DataGridViewCellEventArgs e)
        {
            logDataGridView.CurrentRow.Selected = true;
            try
            {
                logEntryNoTextBox.Text = logDataGridView.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                logEntryTimeInitiatedTextBox.Text = logDataGridView.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                logEntryTagTextBox.Text = logDataGridView.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                logEntryCategoryTextBox.Text = logDataGridView.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                logEntryActionTextBox.Text = logDataGridView.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            }
            catch
            {
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

        /// Event Handlers
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
                    InitFormUI(fileString);
                }
                catch
                {
                }
            }
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
            (logDataGridView.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
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

        /// <summary>
        /// Selects all Tags by simulating key press upon button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TagAddAllButton_Click(object sender, EventArgs e)
        {
            tagListBox.BeginUpdate();
            tagListBox.Select();
            SendKeys.Send("{Home}");
            SendKeys.Send("+{End}");
            tagListBox.EndUpdate();
        }

        /// <summary>
        /// Selects all Categories by simulating key press upon button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CategoryAddAllButton_Click(object sender, EventArgs e)
        {
            categoryListBox.BeginUpdate();
            categoryListBox.Select();
            SendKeys.Send("{Home}");
            SendKeys.Send("+{End}");
            categoryListBox.EndUpdate();
        }

        /// <summary>
        /// Updates
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateEntryDisplay(e);
        }
    }
}