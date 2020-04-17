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
            this.logTextbox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.saveReportButton = new System.Windows.Forms.Button();
            this.saveReportTextBox = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
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
            this.browseButton.Size = new System.Drawing.Size(105, 28);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(388, 34);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // ReportLabel
            // 
            this.ReportLabel.AutoSize = true;
            this.ReportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportLabel.Location = new System.Drawing.Point(10, 61);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(15, 101);
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
            this.logLabel.Location = new System.Drawing.Point(16, 242);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(54, 25);
            this.logLabel.TabIndex = 5;
            this.logLabel.Text = "Log:";
            // 
            // logTextbox
            // 
            this.logTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.logTextbox.Location = new System.Drawing.Point(15, 270);
            this.logTextbox.Name = "logTextbox";
            this.logTextbox.ReadOnly = true;
            this.logTextbox.Size = new System.Drawing.Size(382, 190);
            this.logTextbox.TabIndex = 6;
            this.logTextbox.Text = "";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel3.Controls.Add(this.saveReportButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.saveReportTextBox, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(15, 466);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(388, 34);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // saveReportButton
            // 
            this.saveReportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveReportButton.AutoSize = true;
            this.saveReportButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveReportButton.Location = new System.Drawing.Point(280, 3);
            this.saveReportButton.Name = "saveReportButton";
            this.saveReportButton.Size = new System.Drawing.Size(105, 28);
            this.saveReportButton.TabIndex = 0;
            this.saveReportButton.Text = "Save Report";
            this.saveReportButton.UseVisualStyleBackColor = true;
            this.saveReportButton.Click += new System.EventHandler(this.SaveReportButton_Click);
            // 
            // saveReportTextBox
            // 
            this.saveReportTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveReportTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.saveReportTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.saveReportTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveReportTextBox.Location = new System.Drawing.Point(5, 5);
            this.saveReportTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.saveReportTextBox.Name = "saveReportTextBox";
            this.saveReportTextBox.ReadOnly = true;
            this.saveReportTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.saveReportTextBox.Size = new System.Drawing.Size(267, 24);
            this.saveReportTextBox.TabIndex = 1;
            // 
            // SSILogReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 512);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.logTextbox);
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
        private System.Windows.Forms.RichTextBox logTextbox;
        private System.Windows.Forms.Label logDurationLabel;
        private System.Windows.Forms.TextBox logDurationTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button saveReportButton;
        private System.Windows.Forms.TextBox saveReportTextBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

