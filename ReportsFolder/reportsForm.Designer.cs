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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.chart = new LiveCharts.WinForms.CartesianChart();
            this.reportDetailsTextBox = new System.Windows.Forms.Label();
            this.refreshButton = new Guna.UI2.WinForms.Guna2Button();
            this.generateReportButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.endDatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.reportTypeComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.reportTypeLabel = new System.Windows.Forms.Label();
            this.startDatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.pdfLinkLabel = new System.Windows.Forms.LinkLabel();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
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
            this.guna2Panel1.Location = new System.Drawing.Point(12, 37);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.BorderRadius = 30;
            this.guna2Panel1.ShadowDecoration.Depth = 15;
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.guna2Panel1.Size = new System.Drawing.Size(970, 538);
            this.guna2Panel1.TabIndex = 21;
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chart.Location = new System.Drawing.Point(46, 35);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(878, 468);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart";
            // 
            // reportDetailsTextBox
            // 
            this.reportDetailsTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.reportDetailsTextBox.BackColor = System.Drawing.Color.Transparent;
            this.reportDetailsTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportDetailsTextBox.ForeColor = System.Drawing.Color.Black;
            this.reportDetailsTextBox.Location = new System.Drawing.Point(241, 616);
            this.reportDetailsTextBox.Name = "reportDetailsTextBox";
            this.reportDetailsTextBox.Size = new System.Drawing.Size(513, 51);
            this.reportDetailsTextBox.TabIndex = 24;
            this.reportDetailsTextBox.Text = "label";
            this.reportDetailsTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.Transparent;
            this.refreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshButton.BorderColor = System.Drawing.Color.Transparent;
            this.refreshButton.BorderRadius = 25;
            this.refreshButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.refreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.refreshButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.refreshButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.refreshButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.refreshButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(144)))), ((int)(((byte)(36)))));
            this.refreshButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.refreshButton.Location = new System.Drawing.Point(50, 136);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.refreshButton.Size = new System.Drawing.Size(208, 54);
            this.refreshButton.TabIndex = 29;
            this.refreshButton.Text = "REFRESH";
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // generateReportButton
            // 
            this.generateReportButton.BackColor = System.Drawing.Color.Transparent;
            this.generateReportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.generateReportButton.BorderColor = System.Drawing.Color.Transparent;
            this.generateReportButton.BorderRadius = 25;
            this.generateReportButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.generateReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateReportButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.generateReportButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.generateReportButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.generateReportButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.generateReportButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(144)))), ((int)(((byte)(36)))));
            this.generateReportButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateReportButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.generateReportButton.Location = new System.Drawing.Point(50, 52);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.generateReportButton.Size = new System.Drawing.Size(208, 54);
            this.generateReportButton.TabIndex = 28;
            this.generateReportButton.Text = "GENERATE REPORT";
            this.generateReportButton.Click += new System.EventHandler(this.generateReportButton_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderRadius = 30;
            this.guna2Panel2.BorderThickness = 3;
            this.guna2Panel2.Controls.Add(this.endDatePicker);
            this.guna2Panel2.Controls.Add(this.startDateLabel);
            this.guna2Panel2.Controls.Add(this.reportTypeComboBox);
            this.guna2Panel2.Controls.Add(this.reportTypeLabel);
            this.guna2Panel2.Controls.Add(this.startDatePicker);
            this.guna2Panel2.Controls.Add(this.endDateLabel);
            this.guna2Panel2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.guna2Panel2.Location = new System.Drawing.Point(1013, 12);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.BorderRadius = 30;
            this.guna2Panel2.ShadowDecoration.Depth = 15;
            this.guna2Panel2.ShadowDecoration.Enabled = true;
            this.guna2Panel2.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.guna2Panel2.Size = new System.Drawing.Size(309, 365);
            this.guna2Panel2.TabIndex = 22;
            // 
            // endDatePicker
            // 
            this.endDatePicker.BorderRadius = 20;
            this.endDatePicker.Checked = true;
            this.endDatePicker.FillColor = System.Drawing.Color.White;
            this.endDatePicker.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.endDatePicker.Location = new System.Drawing.Point(30, 178);
            this.endDatePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.endDatePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(249, 45);
            this.endDatePicker.TabIndex = 34;
            this.endDatePicker.Value = new System.DateTime(2024, 12, 20, 22, 13, 1, 874);
            // 
            // startDateLabel
            // 
            this.startDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.startDateLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.startDateLabel.Location = new System.Drawing.Point(30, 41);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(126, 25);
            this.startDateLabel.TabIndex = 30;
            this.startDateLabel.Text = "START DATE";
            this.startDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportTypeComboBox
            // 
            this.reportTypeComboBox.BackColor = System.Drawing.Color.Transparent;
            this.reportTypeComboBox.BorderRadius = 15;
            this.reportTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.reportTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reportTypeComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.reportTypeComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.reportTypeComboBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportTypeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.reportTypeComboBox.ItemHeight = 30;
            this.reportTypeComboBox.Items.AddRange(new object[] {
            "Occupancy Report",
            "Revenue Report"});
            this.reportTypeComboBox.Location = new System.Drawing.Point(30, 284);
            this.reportTypeComboBox.Name = "reportTypeComboBox";
            this.reportTypeComboBox.Size = new System.Drawing.Size(249, 36);
            this.reportTypeComboBox.StartIndex = 0;
            this.reportTypeComboBox.TabIndex = 35;
            // 
            // reportTypeLabel
            // 
            this.reportTypeLabel.AutoSize = true;
            this.reportTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.reportTypeLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportTypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.reportTypeLabel.Location = new System.Drawing.Point(30, 253);
            this.reportTypeLabel.Name = "reportTypeLabel";
            this.reportTypeLabel.Size = new System.Drawing.Size(137, 25);
            this.reportTypeLabel.TabIndex = 31;
            this.reportTypeLabel.Text = "REPORT TYPE";
            this.reportTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startDatePicker
            // 
            this.startDatePicker.BorderRadius = 20;
            this.startDatePicker.Checked = true;
            this.startDatePicker.FillColor = System.Drawing.Color.White;
            this.startDatePicker.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.startDatePicker.Location = new System.Drawing.Point(30, 72);
            this.startDatePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.startDatePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(249, 45);
            this.startDatePicker.TabIndex = 33;
            this.startDatePicker.Value = new System.DateTime(2024, 12, 20, 22, 13, 1, 874);
            // 
            // endDateLabel
            // 
            this.endDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.endDateLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.endDateLabel.Location = new System.Drawing.Point(30, 147);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(111, 25);
            this.endDateLabel.TabIndex = 32;
            this.endDateLabel.Text = "END DATE";
            this.endDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderRadius = 30;
            this.guna2Panel3.BorderThickness = 3;
            this.guna2Panel3.Controls.Add(this.pdfLinkLabel);
            this.guna2Panel3.Controls.Add(this.refreshButton);
            this.guna2Panel3.Controls.Add(this.generateReportButton);
            this.guna2Panel3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.guna2Panel3.Location = new System.Drawing.Point(1013, 383);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.BorderRadius = 30;
            this.guna2Panel3.ShadowDecoration.Depth = 15;
            this.guna2Panel3.ShadowDecoration.Enabled = true;
            this.guna2Panel3.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.guna2Panel3.Size = new System.Drawing.Size(309, 294);
            this.guna2Panel3.TabIndex = 36;
            // 
            // pdfLinkLabel
            // 
            this.pdfLinkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(144)))), ((int)(((byte)(36)))));
            this.pdfLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pdfLinkLabel.AutoSize = true;
            this.pdfLinkLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pdfLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.pdfLinkLabel.Location = new System.Drawing.Point(80, 233);
            this.pdfLinkLabel.Name = "pdfLinkLabel";
            this.pdfLinkLabel.Size = new System.Drawing.Size(149, 22);
            this.pdfLinkLabel.TabIndex = 37;
            this.pdfLinkLabel.TabStop = true;
            this.pdfLinkLabel.Text = "EXPORT TO PDF";
            this.pdfLinkLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(144)))), ((int)(((byte)(36)))));
            this.pdfLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.pdfLinkLabel_LinkClicked);
            // 
            // reportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(1334, 689);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.reportDetailsTextBox);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "reportsForm";
            this.Text = "reportsForm";
            this.Load += new System.EventHandler(this.reportsForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private LiveCharts.WinForms.CartesianChart chart;
        private System.Windows.Forms.Label reportDetailsTextBox;
        private Guna.UI2.WinForms.Guna2Button refreshButton;
        private Guna.UI2.WinForms.Guna2Button generateReportButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2DateTimePicker endDatePicker;
        private System.Windows.Forms.Label startDateLabel;
        private Guna.UI2.WinForms.Guna2ComboBox reportTypeComboBox;
        private System.Windows.Forms.Label reportTypeLabel;
        private Guna.UI2.WinForms.Guna2DateTimePicker startDatePicker;
        private System.Windows.Forms.Label endDateLabel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        public System.Windows.Forms.LinkLabel pdfLinkLabel;
    }
}