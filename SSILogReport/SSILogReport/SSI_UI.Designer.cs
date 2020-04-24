namespace SSILogReport
{
    partial class SSILogReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileInputBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.browseButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.reportHeadLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.logDurationLabel = new System.Windows.Forms.Label();
            this.startTimeTextBox = new System.Windows.Forms.TextBox();
            this.entriesTextBox = new System.Windows.Forms.TextBox();
            this.entriesLabel = new System.Windows.Forms.Label();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.endTimeLabel = new System.Windows.Forms.Label();
            this.endTimeTextBox = new System.Windows.Forms.TextBox();
            this.logDurationTextBox = new System.Windows.Forms.TextBox();
            this.logHeadLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.saveReportButton = new System.Windows.Forms.Button();
            this.saveReportTextBox = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.categoryAddAllButton = new System.Windows.Forms.Button();
            this.categoriesListLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tagListLabel = new System.Windows.Forms.Label();
            this.tagAddAllButton = new System.Windows.Forms.Button();
            this.categoryListBox = new System.Windows.Forms.ListBox();
            this.tagListBox = new System.Windows.Forms.ListBox();
            this.logDataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.logEntryTimeInitiatedTextBox = new System.Windows.Forms.TextBox();
            this.logEntryNoTextBox = new System.Windows.Forms.TextBox();
            this.logEntryNoLabel = new System.Windows.Forms.Label();
            this.logTimeInitiatedLabel = new System.Windows.Forms.Label();
            this.logEntryTagTextBox = new System.Windows.Forms.TextBox();
            this.logEntryCategoryTextBox = new System.Windows.Forms.TextBox();
            this.logEntryTagLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.logEntryActionTextBox = new System.Windows.Forms.RichTextBox();
            this.entryHeadLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logDataGridView)).BeginInit();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileInputBox
            // 
            this.fileInputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileInputBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.fileInputBox.Cursor = System.Windows.Forms.Cursors.No;
            this.fileInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileInputBox.Location = new System.Drawing.Point(3, 5);
            this.fileInputBox.Margin = new System.Windows.Forms.Padding(3, 5, 5, 5);
            this.fileInputBox.Name = "fileInputBox";
            this.fileInputBox.ReadOnly = true;
            this.fileInputBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fileInputBox.Size = new System.Drawing.Size(817, 24);
            this.fileInputBox.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            // 
            // browseButton
            // 
            this.browseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.browseButton.AutoSize = true;
            this.browseButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.browseButton.Location = new System.Drawing.Point(828, 3);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(269, 29);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.fileInputBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.browseButton, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1100, 35);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // reportHeadLabel
            // 
            this.reportHeadLabel.AutoSize = true;
            this.reportHeadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportHeadLabel.Location = new System.Drawing.Point(3, 0);
            this.reportHeadLabel.Name = "reportHeadLabel";
            this.reportHeadLabel.Size = new System.Drawing.Size(82, 25);
            this.reportHeadLabel.TabIndex = 3;
            this.reportHeadLabel.Text = "Report:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.60733F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.39267F));
            this.tableLayoutPanel2.Controls.Add(this.logDurationLabel, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.startTimeTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.entriesTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.entriesLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.startTimeLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.endTimeLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.endTimeTextBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.logDurationTextBox, 1, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 28);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(384, 127);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // logDurationLabel
            // 
            this.logDurationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logDurationLabel.AutoSize = true;
            this.logDurationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logDurationLabel.Location = new System.Drawing.Point(3, 78);
            this.logDurationLabel.Name = "logDurationLabel";
            this.logDurationLabel.Size = new System.Drawing.Size(88, 26);
            this.logDurationLabel.TabIndex = 6;
            this.logDurationLabel.Text = "Log Duration: ";
            this.logDurationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startTimeTextBox
            // 
            this.startTimeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startTimeTextBox.Location = new System.Drawing.Point(97, 29);
            this.startTimeTextBox.Name = "startTimeTextBox";
            this.startTimeTextBox.Size = new System.Drawing.Size(284, 20);
            this.startTimeTextBox.TabIndex = 3;
            // 
            // entriesTextBox
            // 
            this.entriesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.entriesTextBox.Location = new System.Drawing.Point(97, 3);
            this.entriesTextBox.Name = "entriesTextBox";
            this.entriesTextBox.Size = new System.Drawing.Size(284, 20);
            this.entriesTextBox.TabIndex = 2;
            // 
            // entriesLabel
            // 
            this.entriesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.entriesLabel.AutoSize = true;
            this.entriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entriesLabel.Location = new System.Drawing.Point(41, 0);
            this.entriesLabel.Name = "entriesLabel";
            this.entriesLabel.Size = new System.Drawing.Size(50, 26);
            this.entriesLabel.TabIndex = 4;
            this.entriesLabel.Text = "Entries:";
            this.entriesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimeLabel.Location = new System.Drawing.Point(18, 26);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(73, 26);
            this.startTimeLabel.TabIndex = 0;
            this.startTimeLabel.Text = "Start Time: ";
            this.startTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTimeLabel.Location = new System.Drawing.Point(27, 52);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(64, 26);
            this.endTimeLabel.TabIndex = 1;
            this.endTimeLabel.Text = "End Time:";
            this.endTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endTimeTextBox
            // 
            this.endTimeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.endTimeTextBox.Location = new System.Drawing.Point(97, 55);
            this.endTimeTextBox.Name = "endTimeTextBox";
            this.endTimeTextBox.Size = new System.Drawing.Size(284, 20);
            this.endTimeTextBox.TabIndex = 5;
            // 
            // logDurationTextBox
            // 
            this.logDurationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logDurationTextBox.Location = new System.Drawing.Point(97, 81);
            this.logDurationTextBox.Name = "logDurationTextBox";
            this.logDurationTextBox.Size = new System.Drawing.Size(284, 20);
            this.logDurationTextBox.TabIndex = 7;
            // 
            // logHeadLabel
            // 
            this.logHeadLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.logHeadLabel.AutoSize = true;
            this.logHeadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logHeadLabel.Location = new System.Drawing.Point(0, 0);
            this.logHeadLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.logHeadLabel.Name = "logHeadLabel";
            this.logHeadLabel.Size = new System.Drawing.Size(54, 25);
            this.logHeadLabel.TabIndex = 5;
            this.logHeadLabel.Text = "Log:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.saveReportButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.saveReportTextBox, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 774);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1100, 34);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // saveReportButton
            // 
            this.saveReportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveReportButton.AutoSize = true;
            this.saveReportButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveReportButton.Enabled = false;
            this.saveReportButton.Location = new System.Drawing.Point(828, 3);
            this.saveReportButton.Name = "saveReportButton";
            this.saveReportButton.Size = new System.Drawing.Size(269, 28);
            this.saveReportButton.TabIndex = 0;
            this.saveReportButton.Text = "Save Report";
            this.saveReportButton.UseVisualStyleBackColor = true;
            this.saveReportButton.Click += new System.EventHandler(this.saveReportButton_Click);
            // 
            // saveReportTextBox
            // 
            this.saveReportTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveReportTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.saveReportTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.saveReportTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveReportTextBox.Location = new System.Drawing.Point(3, 5);
            this.saveReportTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 5, 5);
            this.saveReportTextBox.Name = "saveReportTextBox";
            this.saveReportTextBox.ReadOnly = true;
            this.saveReportTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.saveReportTextBox.Size = new System.Drawing.Size(817, 24);
            this.saveReportTextBox.TabIndex = 1;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "log";
            this.saveFileDialog1.Filter = "Log files(*.log)|*.log|Text files (*.txt)|*.txt|All files (*.*)|*.*";
            this.saveFileDialog1.RestoreDirectory = true;
            this.saveFileDialog1.Title = "Save Log Report";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel10, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.categoryListBox, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tagListBox, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 161);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.66265F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.33735F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(384, 213);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Controls.Add(this.categoryAddAllButton, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.categoriesListLabel, 0, 0);
            this.tableLayoutPanel10.Location = new System.Drawing.Point(195, 3);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(186, 24);
            this.tableLayoutPanel10.TabIndex = 17;
            // 
            // categoryAddAllButton
            // 
            this.categoryAddAllButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.categoryAddAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.categoryAddAllButton.Location = new System.Drawing.Point(166, 2);
            this.categoryAddAllButton.Margin = new System.Windows.Forms.Padding(0);
            this.categoryAddAllButton.Name = "categoryAddAllButton";
            this.categoryAddAllButton.Size = new System.Drawing.Size(20, 20);
            this.categoryAddAllButton.TabIndex = 8;
            this.categoryAddAllButton.Text = "+";
            this.categoryAddAllButton.UseVisualStyleBackColor = true;
            this.categoryAddAllButton.Click += new System.EventHandler(this.categoryAddAllButton_Click);
            // 
            // categoriesListLabel
            // 
            this.categoriesListLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.categoriesListLabel.AutoSize = true;
            this.categoriesListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriesListLabel.Location = new System.Drawing.Point(3, 0);
            this.categoriesListLabel.Name = "categoriesListLabel";
            this.categoriesListLabel.Size = new System.Drawing.Size(71, 24);
            this.categoriesListLabel.TabIndex = 17;
            this.categoriesListLabel.Text = "Categories:";
            this.categoriesListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.tagListLabel, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tagAddAllButton, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(186, 24);
            this.tableLayoutPanel5.TabIndex = 16;
            // 
            // tagListLabel
            // 
            this.tagListLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tagListLabel.AutoSize = true;
            this.tagListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagListLabel.Location = new System.Drawing.Point(3, 0);
            this.tagListLabel.Name = "tagListLabel";
            this.tagListLabel.Size = new System.Drawing.Size(39, 24);
            this.tagListLabel.TabIndex = 16;
            this.tagListLabel.Text = "Tags:";
            this.tagListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tagAddAllButton
            // 
            this.tagAddAllButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tagAddAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.tagAddAllButton.Location = new System.Drawing.Point(166, 2);
            this.tagAddAllButton.Margin = new System.Windows.Forms.Padding(0);
            this.tagAddAllButton.Name = "tagAddAllButton";
            this.tagAddAllButton.Size = new System.Drawing.Size(20, 20);
            this.tagAddAllButton.TabIndex = 8;
            this.tagAddAllButton.Text = "+";
            this.tagAddAllButton.UseVisualStyleBackColor = true;
            this.tagAddAllButton.Click += new System.EventHandler(this.tagAddAllButton_Click);
            // 
            // categoryListBox
            // 
            this.categoryListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryListBox.Location = new System.Drawing.Point(195, 33);
            this.categoryListBox.Name = "categoryListBox";
            this.categoryListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.categoryListBox.Size = new System.Drawing.Size(186, 156);
            this.categoryListBox.TabIndex = 10;
            // 
            // tagListBox
            // 
            this.tagListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tagListBox.Location = new System.Drawing.Point(3, 33);
            this.tagListBox.Name = "tagListBox";
            this.tagListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.tagListBox.Size = new System.Drawing.Size(186, 156);
            this.tagListBox.TabIndex = 9;
            // 
            // logDataGridView
            // 
            this.logDataGridView.AllowUserToAddRows = false;
            this.logDataGridView.AllowUserToDeleteRows = false;
            this.logDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.logDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.logDataGridView.Location = new System.Drawing.Point(3, 63);
            this.logDataGridView.Name = "logDataGridView";
            this.logDataGridView.ReadOnly = true;
            this.logDataGridView.Size = new System.Drawing.Size(1094, 693);
            this.logDataGridView.TabIndex = 12;
            this.logDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.logDataGridView_CellClick);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.60733F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.39267F));
            this.tableLayoutPanel7.Controls.Add(this.label1, 0, 4);
            this.tableLayoutPanel7.Controls.Add(this.logEntryTimeInitiatedTextBox, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.logEntryNoTextBox, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.logEntryNoLabel, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.logTimeInitiatedLabel, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.logEntryTagTextBox, 1, 3);
            this.tableLayoutPanel7.Controls.Add(this.logEntryCategoryTextBox, 1, 4);
            this.tableLayoutPanel7.Controls.Add(this.logEntryTagLabel, 0, 3);
            this.tableLayoutPanel7.Controls.Add(this.label2, 0, 5);
            this.tableLayoutPanel7.Controls.Add(this.logEntryActionTextBox, 1, 5);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 405);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 6;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(384, 351);
            this.tableLayoutPanel7.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Category: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logEntryTimeInitiatedTextBox
            // 
            this.logEntryTimeInitiatedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logEntryTimeInitiatedTextBox.Location = new System.Drawing.Point(97, 29);
            this.logEntryTimeInitiatedTextBox.Name = "logEntryTimeInitiatedTextBox";
            this.logEntryTimeInitiatedTextBox.Size = new System.Drawing.Size(284, 20);
            this.logEntryTimeInitiatedTextBox.TabIndex = 3;
            // 
            // logEntryNoTextBox
            // 
            this.logEntryNoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logEntryNoTextBox.Location = new System.Drawing.Point(97, 3);
            this.logEntryNoTextBox.Name = "logEntryNoTextBox";
            this.logEntryNoTextBox.Size = new System.Drawing.Size(284, 20);
            this.logEntryNoTextBox.TabIndex = 2;
            // 
            // logEntryNoLabel
            // 
            this.logEntryNoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logEntryNoLabel.AutoSize = true;
            this.logEntryNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logEntryNoLabel.Location = new System.Drawing.Point(26, 0);
            this.logEntryNoLabel.Name = "logEntryNoLabel";
            this.logEntryNoLabel.Size = new System.Drawing.Size(65, 26);
            this.logEntryNoLabel.TabIndex = 4;
            this.logEntryNoLabel.Text = "Log Entry:";
            this.logEntryNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logTimeInitiatedLabel
            // 
            this.logTimeInitiatedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logTimeInitiatedLabel.AutoSize = true;
            this.logTimeInitiatedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logTimeInitiatedLabel.Location = new System.Drawing.Point(34, 26);
            this.logTimeInitiatedLabel.Name = "logTimeInitiatedLabel";
            this.logTimeInitiatedLabel.Size = new System.Drawing.Size(57, 26);
            this.logTimeInitiatedLabel.TabIndex = 0;
            this.logTimeInitiatedLabel.Text = "Initiated:";
            this.logTimeInitiatedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logEntryTagTextBox
            // 
            this.logEntryTagTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logEntryTagTextBox.Location = new System.Drawing.Point(97, 55);
            this.logEntryTagTextBox.Name = "logEntryTagTextBox";
            this.logEntryTagTextBox.Size = new System.Drawing.Size(284, 20);
            this.logEntryTagTextBox.TabIndex = 5;
            // 
            // logEntryCategoryTextBox
            // 
            this.logEntryCategoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logEntryCategoryTextBox.Location = new System.Drawing.Point(97, 81);
            this.logEntryCategoryTextBox.Name = "logEntryCategoryTextBox";
            this.logEntryCategoryTextBox.Size = new System.Drawing.Size(284, 20);
            this.logEntryCategoryTextBox.TabIndex = 7;
            // 
            // logEntryTagLabel
            // 
            this.logEntryTagLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logEntryTagLabel.AutoSize = true;
            this.logEntryTagLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logEntryTagLabel.Location = new System.Drawing.Point(58, 52);
            this.logEntryTagLabel.Name = "logEntryTagLabel";
            this.logEntryTagLabel.Size = new System.Drawing.Size(33, 26);
            this.logEntryTagLabel.TabIndex = 1;
            this.logEntryTagLabel.Text = "Tag:";
            this.logEntryTagLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Action: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logEntryActionTextBox
            // 
            this.logEntryActionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logEntryActionTextBox.Location = new System.Drawing.Point(97, 107);
            this.logEntryActionTextBox.Name = "logEntryActionTextBox";
            this.logEntryActionTextBox.Size = new System.Drawing.Size(284, 241);
            this.logEntryActionTextBox.TabIndex = 9;
            this.logEntryActionTextBox.Text = "";
            // 
            // entryHeadLabel
            // 
            this.entryHeadLabel.AutoSize = true;
            this.entryHeadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryHeadLabel.Location = new System.Drawing.Point(3, 377);
            this.entryHeadLabel.Name = "entryHeadLabel";
            this.entryHeadLabel.Size = new System.Drawing.Size(68, 25);
            this.entryHeadLabel.TabIndex = 13;
            this.entryHeadLabel.Text = "Entry:";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel8.AutoSize = true;
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.logDataGridView, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.logHeadLabel, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel8.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(446, 25);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 4;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.Size = new System.Drawing.Size(1100, 824);
            this.tableLayoutPanel8.TabIndex = 15;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.entryHeadLabel, 0, 3);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel7, 0, 4);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel9.Controls.Add(this.reportHeadLabel, 0, 0);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(30, 25);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 5;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.Size = new System.Drawing.Size(410, 824);
            this.tableLayoutPanel9.TabIndex = 16;
            // 
            // SSILogReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.tableLayoutPanel9);
            this.Controls.Add(this.tableLayoutPanel8);
            this.Name = "SSILogReportForm";
            this.Text = "SSI Log Report";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logDataGridView)).EndInit();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fileInputBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label reportHeadLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.Label endTimeLabel;
        private System.Windows.Forms.TextBox startTimeTextBox;
        private System.Windows.Forms.TextBox entriesTextBox;
        private System.Windows.Forms.Label entriesLabel;
        private System.Windows.Forms.TextBox endTimeTextBox;
        private System.Windows.Forms.Label logHeadLabel;
        private System.Windows.Forms.Label logDurationLabel;
        private System.Windows.Forms.TextBox logDurationTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button saveReportButton;
        private System.Windows.Forms.TextBox saveReportTextBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ListBox tagListBox;
        private System.Windows.Forms.DataGridView logDataGridView;
        private System.Windows.Forms.Button tagAddAllButton;
        private System.Windows.Forms.ListBox categoryListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox logEntryTimeInitiatedTextBox;
        private System.Windows.Forms.TextBox logEntryNoTextBox;
        private System.Windows.Forms.Label logEntryNoLabel;
        private System.Windows.Forms.Label logTimeInitiatedLabel;
        private System.Windows.Forms.Label logEntryTagLabel;
        private System.Windows.Forms.TextBox logEntryTagTextBox;
        private System.Windows.Forms.TextBox logEntryCategoryTextBox;
        private System.Windows.Forms.Label entryHeadLabel;
        private System.Windows.Forms.Button categoryAddAllButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label categoriesListLabel;
        private System.Windows.Forms.Label tagListLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox logEntryActionTextBox;
    }
}

