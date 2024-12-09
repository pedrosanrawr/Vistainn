namespace Vistainn
{
    partial class reportsForm
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
            this.refreshButton = new Guna.UI2.WinForms.Guna2Button();
            this.generateReportButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.reportTypeComboBox = new System.Windows.Forms.ComboBox();
            this.reportTypeLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.chart = new LiveCharts.WinForms.CartesianChart();
            this.reportDetailsTextBox = new System.Windows.Forms.Label();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.Transparent;
            this.refreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshButton.BorderColor = System.Drawing.Color.Transparent;
            this.refreshButton.BorderRadius = 18;
            this.refreshButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.refreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.refreshButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.refreshButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.refreshButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.refreshButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(144)))), ((int)(((byte)(36)))));
            this.refreshButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.refreshButton.Location = new System.Drawing.Point(45, 75);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.refreshButton.Size = new System.Drawing.Size(154, 36);
            this.refreshButton.TabIndex = 16;
            this.refreshButton.Text = "REFRESH";
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // generateReportButton
            // 
            this.generateReportButton.BackColor = System.Drawing.Color.Transparent;
            this.generateReportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.generateReportButton.BorderColor = System.Drawing.Color.Transparent;
            this.generateReportButton.BorderRadius = 18;
            this.generateReportButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.generateReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateReportButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.generateReportButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.generateReportButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.generateReportButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.generateReportButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(144)))), ((int)(((byte)(36)))));
            this.generateReportButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateReportButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.generateReportButton.Location = new System.Drawing.Point(45, 28);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.generateReportButton.Size = new System.Drawing.Size(154, 36);
            this.generateReportButton.TabIndex = 15;
            this.generateReportButton.Text = "GENERATE REPORT";
            this.generateReportButton.Click += new System.EventHandler(this.generateReportButton_Click);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel4.BorderRadius = 30;
            this.guna2Panel4.BorderThickness = 3;
            this.guna2Panel4.Controls.Add(this.reportTypeComboBox);
            this.guna2Panel4.Controls.Add(this.reportTypeLabel);
            this.guna2Panel4.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.guna2Panel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.guna2Panel4.Location = new System.Drawing.Point(873, 12);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(247, 137);
            this.guna2Panel4.TabIndex = 22;
            // 
            // reportTypeComboBox
            // 
            this.reportTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reportTypeComboBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportTypeComboBox.ForeColor = System.Drawing.Color.Black;
            this.reportTypeComboBox.FormattingEnabled = true;
            this.reportTypeComboBox.Items.AddRange(new object[] {
            "Occupancy Report",
            "Revenue Report"});
            this.reportTypeComboBox.Location = new System.Drawing.Point(53, 64);
            this.reportTypeComboBox.Name = "reportTypeComboBox";
            this.reportTypeComboBox.Size = new System.Drawing.Size(137, 24);
            this.reportTypeComboBox.TabIndex = 0;
            this.reportTypeComboBox.Text = "Occupancy Report";
            // 
            // reportTypeLabel
            // 
            this.reportTypeLabel.AutoSize = true;
            this.reportTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.reportTypeLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportTypeLabel.ForeColor = System.Drawing.Color.White;
            this.reportTypeLabel.Location = new System.Drawing.Point(86, 39);
            this.reportTypeLabel.Name = "reportTypeLabel";
            this.reportTypeLabel.Size = new System.Drawing.Size(76, 15);
            this.reportTypeLabel.TabIndex = 24;
            this.reportTypeLabel.Text = "REPORT TYPE";
            this.reportTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endDateLabel
            // 
            this.endDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.endDateLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateLabel.ForeColor = System.Drawing.Color.Black;
            this.endDateLabel.Location = new System.Drawing.Point(541, 17);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(60, 15);
            this.endDateLabel.TabIndex = 24;
            this.endDateLabel.Text = "END DATE";
            this.endDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startDateLabel
            // 
            this.startDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.startDateLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateLabel.ForeColor = System.Drawing.Color.Black;
            this.startDateLabel.Location = new System.Drawing.Point(253, 17);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(68, 15);
            this.startDateLabel.TabIndex = 23;
            this.startDateLabel.Text = "START DATE";
            this.startDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endDatePicker
            // 
            this.endDatePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.endDatePicker.CalendarFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDatePicker.Location = new System.Drawing.Point(469, 35);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(200, 20);
            this.endDatePicker.TabIndex = 1;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.startDatePicker.CalendarFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDatePicker.Location = new System.Drawing.Point(186, 38);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(200, 20);
            this.startDatePicker.TabIndex = 0;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderRadius = 30;
            this.guna2Panel3.BorderThickness = 3;
            this.guna2Panel3.Controls.Add(this.refreshButton);
            this.guna2Panel3.Controls.Add(this.generateReportButton);
            this.guna2Panel3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.guna2Panel3.Location = new System.Drawing.Point(873, 159);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(247, 137);
            this.guna2Panel3.TabIndex = 21;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 30;
            this.guna2Panel1.BorderThickness = 3;
            this.guna2Panel1.Controls.Add(this.chart);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.guna2Panel1.Location = new System.Drawing.Point(57, 78);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(766, 389);
            this.guna2Panel1.TabIndex = 21;
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart.Location = new System.Drawing.Point(43, 39);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(681, 311);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart";
            // 
            // reportDetailsTextBox
            // 
            this.reportDetailsTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.reportDetailsTextBox.AutoSize = true;
            this.reportDetailsTextBox.BackColor = System.Drawing.Color.Transparent;
            this.reportDetailsTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportDetailsTextBox.ForeColor = System.Drawing.Color.Black;
            this.reportDetailsTextBox.Location = new System.Drawing.Point(272, 481);
            this.reportDetailsTextBox.Name = "reportDetailsTextBox";
            this.reportDetailsTextBox.Size = new System.Drawing.Size(0, 15);
            this.reportDetailsTextBox.TabIndex = 24;
            this.reportDetailsTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(1095, 517);
            this.Controls.Add(this.reportDetailsTextBox);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "reportsForm";
            this.Text = "reportsForm";
            this.Load += new System.EventHandler(this.reportsForm_Load);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Button generateReportButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label reportTypeLabel;
        private System.Windows.Forms.ComboBox reportTypeComboBox;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private LiveCharts.WinForms.CartesianChart chart;
        private System.Windows.Forms.Label reportDetailsTextBox;
        private Guna.UI2.WinForms.Guna2Button refreshButton;
    }
}