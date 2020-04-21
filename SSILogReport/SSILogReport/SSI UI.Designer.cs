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
            this.ReportLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.logDurationLabel = new System.Windows.Forms.Label();
            this.startTimeTextBox = new System.Windows.Forms.TextBox();
            this.entriesTextBox = new System.Windows.Forms.TextBox();
            this.entriesLabel = new System.Windows.Forms.Label();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.endTimeLabel = new System.Windows.Forms.Label();
            this.endTimeTextBox = new System.Windows.Forms.TextBox();
            this.logDurationTextBox = new System.Windows.Forms.TextBox();
            this.logLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.saveReportButton = new System.Windows.Forms.Button();
            this.saveReportTextBox = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.categoryListBox = new System.Windows.Forms.ListBox();
            this.tagLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.tagListBox = new System.Windows.Forms.ListBox();
            this.filterLogButton = new System.Windows.Forms.Button();
            this.LogDataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fileInputBox
            // 
            this.fileInputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileInputBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.fileInputBox.Cursor = System.Windows.Forms.Cursors.No;
            this.fileInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileInputBox.Location = new System.Drawing.Point(5, 5);
            this.fileInputBox.Margin = new System.Windows.Forms.Padding(5);
            this.fileInputBox.Name = "fileInputBox";
            this.fileInputBox.ReadOnly = true;
            this.fileInputBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fileInputBox.Size = new System.Drawing.Size(267, 24);
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
            this.browseButton.Location = new System.Drawing.Point(280, 3);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(105, 29);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel1.Controls.Add(this.browseButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.fileInputBox, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(388, 35);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // ReportLabel
            // 
            this.ReportLabel.AutoSize = true;
            this.ReportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportLabel.Location = new System.Drawing.Point(10, 52);
            this.ReportLabel.Name = "ReportLabel";
            this.ReportLabel.Size = new System.Drawing.Size(76, 25);
            this.ReportLabel.TabIndex = 3;
            this.ReportLabel.Text = "Report";
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(15, 80);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(382, 105);
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
            this.logDurationLabel.Size = new System.Drawing.Size(88, 27);
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
            this.startTimeTextBox.Size = new System.Drawing.Size(282, 20);
            this.startTimeTextBox.TabIndex = 3;
            // 
            // entriesTextBox
            // 
            this.entriesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.entriesTextBox.Location = new System.Drawing.Point(97, 3);
            this.entriesTextBox.Name = "entriesTextBox";
            this.entriesTextBox.Size = new System.Drawing.Size(282, 20);
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
            this.endTimeTextBox.Size = new System.Drawing.Size(282, 20);
            this.endTimeTextBox.TabIndex = 5;
            // 
            // logDurationTextBox
            // 
            this.logDurationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logDurationTextBox.Location = new System.Drawing.Point(97, 81);
            this.logDurationTextBox.Name = "logDurationTextBox";
            this.logDurationTextBox.Size = new System.Drawing.Size(282, 20);
            this.logDurationTextBox.TabIndex = 7;
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logLabel.Location = new System.Drawing.Point(16, 328);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(54, 25);
            this.logLabel.TabIndex = 5;
            this.logLabel.Text = "Log:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel3.Controls.Add(this.saveReportButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.saveReportTextBox, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(15, 538);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(382, 34);
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
            this.saveReportButton.Location = new System.Drawing.Point(275, 3);
            this.saveReportButton.Name = "saveReportButton";
            this.saveReportButton.Size = new System.Drawing.Size(104, 28);
            this.saveReportButton.TabIndex = 0;
            this.saveReportButton.Text = "Save Report";
            this.saveReportButton.UseVisualStyleBackColor = true;
            this.saveReportButton.Click += new System.EventHandler(this.SaveReportButton_Click);
            // 
            // saveReportTextBox
            // 
            this.saveReportTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.saveReportTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.saveReportTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveReportTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveReportTextBox.Location = new System.Drawing.Point(5, 5);
            this.saveReportTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.saveReportTextBox.Name = "saveReportTextBox";
            this.saveReportTextBox.ReadOnly = true;
            this.saveReportTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.saveReportTextBox.Size = new System.Drawing.Size(262, 24);
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
            this.tableLayoutPanel4.Controls.Add(this.categoryListBox, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tagLabel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.categoryLabel, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tagListBox, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(15, 191);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.16418F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.83582F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(382, 134);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // categoryListBox
            // 
            this.categoryListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryListBox.Location = new System.Drawing.Point(194, 26);
            this.categoryListBox.Name = "categoryListBox";
            this.categoryListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.categoryListBox.Size = new System.Drawing.Size(185, 105);
            this.categoryListBox.TabIndex = 10;
            // 
            // tagLabel
            // 
            this.tagLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tagLabel.AutoSize = true;
            this.tagLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagLabel.Location = new System.Drawing.Point(3, 0);
            this.tagLabel.Name = "tagLabel";
            this.tagLabel.Size = new System.Drawing.Size(33, 23);
            this.tagLabel.TabIndex = 7;
            this.tagLabel.Text = "Tag:";
            this.tagLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // categoryLabel
            // 
            this.categoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.Location = new System.Drawing.Point(194, 0);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(61, 23);
            this.categoryLabel.TabIndex = 8;
            this.categoryLabel.Text = "Category:";
            this.categoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tagListBox
            // 
            this.tagListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tagListBox.Location = new System.Drawing.Point(3, 26);
            this.tagListBox.Name = "tagListBox";
            this.tagListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.tagListBox.Size = new System.Drawing.Size(185, 105);
            this.tagListBox.TabIndex = 9;
            // 
            // filterLogButton
            // 
            this.filterLogButton.Location = new System.Drawing.Point(319, 332);
            this.filterLogButton.Name = "filterLogButton";
            this.filterLogButton.Size = new System.Drawing.Size(75, 23);
            this.filterLogButton.TabIndex = 11;
            this.filterLogButton.Text = "Filter Log";
            this.filterLogButton.UseVisualStyleBackColor = true;
            this.filterLogButton.Click += new System.EventHandler(this.filterLogButton_Click);
            // 
            // LogDataGridView
            // 
            this.LogDataGridView.AllowUserToAddRows = false;
            this.LogDataGridView.AllowUserToDeleteRows = false;
            this.LogDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.LogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LogDataGridView.Location = new System.Drawing.Point(20, 356);
            this.LogDataGridView.Name = "LogDataGridView";
            this.LogDataGridView.ReadOnly = true;
            this.LogDataGridView.Size = new System.Drawing.Size(374, 176);
            this.LogDataGridView.TabIndex = 12;
            // 
            // SSILogReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 584);
            this.Controls.Add(this.LogDataGridView);
            this.Controls.Add(this.filterLogButton);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.ReportLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SSILogReportForm";
            this.Text = "SSI Log Report";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fileInputBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label ReportLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.Label endTimeLabel;
        private System.Windows.Forms.TextBox startTimeTextBox;
        private System.Windows.Forms.TextBox entriesTextBox;
        private System.Windows.Forms.Label entriesLabel;
        private System.Windows.Forms.TextBox endTimeTextBox;
        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.Label logDurationLabel;
        private System.Windows.Forms.TextBox logDurationTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button saveReportButton;
        private System.Windows.Forms.TextBox saveReportTextBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label tagLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ListBox tagListBox;
        private System.Windows.Forms.ListBox categoryListBox;
        private System.Windows.Forms.Button filterLogButton;
        private System.Windows.Forms.DataGridView LogDataGridView;
    }
}

