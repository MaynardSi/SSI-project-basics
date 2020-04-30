using Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SSILogReport
{
    public partial class SSILogReportForm : Form
    {
        public SSILogReportForm()
        {
            InitializeComponent();
        }

        internal ReportGenerator Report { get; private set; }

        private void initFormUI(string fileString)
        {
            initReportDisplay(fileString);
            initFilterDisplay();
            initLogDisplay();
        }

        private void initReportDisplay(string fileString)
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

        private void initFilterDisplay()
        {
            List<Tuple<string, int>> tagDisplay = Report.GetTag;
            List<Tuple<string, int>> categoryDisplay = Report.GetCategory;

            //Tag List Box for filtering
            tagListBox.ValueMember = "Item1";
            tagListBox.DisplayMember = tagDisplay.ToString();
            tagListBox.DataSource = tagDisplay;
            tagListBox.SelectedValueChanged += (s1, e1) => listBox_SelectedValueChanged(s1, e1, true, categoryListBox);

            //Category List Box for filtering
            categoryListBox.ValueMember = "Item1";
            categoryListBox.DisplayMember = categoryDisplay.ToString();
            categoryListBox.DataSource = categoryDisplay;
            categoryListBox.SelectedValueChanged += (s2, e2) => listBox_SelectedValueChanged(s2, e2, false, tagListBox);
        }

        private void initLogDisplay()
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
            DataTable ldt = DataTableHandler.toDataTable(Report.LogList);
            logDataGridView.DataSource = ldt;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileString = openFileDialog1.FileName;
                try
                {
                    initFormUI(fileString);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unexpected error: {ex.Message}");
                }
            }
        }

        private void listBox_SelectedValueChanged(object sender, EventArgs e, bool isTag, ListBox otherListbox)
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
            tagFiltersString += string.Join(",", tagFilters.Select(x => string.Format($"'{x}'")));
            tagFiltersString += ")";
            catFiltersString += string.Join(",", categoryFilters.Select(x => string.Format($"'{x}'")));
            catFiltersString += ")";
            queryStatement = tagFiltersString + " AND " + catFiltersString;

            // Filter statement and method
            string rowFilter = string.Format($"{queryStatement}");
            (logDataGridView.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        private void saveReportButton_Click(object sender, EventArgs e)
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

        private void tagAddAllButton_Click(object sender, EventArgs e)
        {
            listBoxAllButton_Click(true);
        }

        private void categoryAddAllButton_Click(object sender, EventArgs e)
        {
            listBoxAllButton_Click(false);
        }

        private void listBoxAllButton_Click(bool isTag)
        {
            ListBox listbox = isTag ? tagListBox : categoryListBox;
            listbox.BeginUpdate();
            listbox.Select();
            SendKeys.Send("{Home}");
            SendKeys.Send("+{End}");
            listbox.EndUpdate();
        }

        private void logDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            updateEntryDisplay(e);
        }

        private void updateEntryDisplay(DataGridViewCellEventArgs e)
        {
            logDataGridView.CurrentRow.Selected = true;
            try
            {
                logEntryNoTextBox.Text = logDataGridView.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                logEntryTimeInitiatedTextBox.Text = logDataGridView.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                logEntryTagTextBox.Text = logDataGridView.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                logEntryCategoryTextBox.Text = logDataGridView.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();

                // JSON
                string action = logDataGridView.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                if (action.Contains("#json"))
                {
                    string[] actionList = action.Split(' ');
                    logEntryActionTextBox.Text = actionList[0] + "\n";
                    dynamic parsedJson = JsonConvert.DeserializeObject(actionList[1]);
                    logEntryActionTextBox.AppendText(JsonConvert.SerializeObject(parsedJson, Formatting.Indented));
                }
                else
                {
                    logEntryActionTextBox.Text = logDataGridView.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }
    }
}