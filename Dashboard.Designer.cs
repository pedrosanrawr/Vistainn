namespace Vistainn
{
    partial class Dashboard
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.paymentButton = new Guna.UI2.WinForms.Guna2Button();
            this.bookButton = new Guna.UI2.WinForms.Guna2Button();
            this.customerButton = new Guna.UI2.WinForms.Guna2Button();
            this.roomButton = new Guna.UI2.WinForms.Guna2Button();
            this.reportsButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Location = new System.Drawing.Point(0, 134);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1095, 517);
            this.mainPanel.TabIndex = 8;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.guna2Panel2.BorderRadius = 30;
            this.guna2Panel2.BorderThickness = 3;
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.paymentButton);
            this.guna2Panel2.Controls.Add(this.bookButton);
            this.guna2Panel2.Controls.Add(this.customerButton);
            this.guna2Panel2.Controls.Add(this.roomButton);
            this.guna2Panel2.Controls.Add(this.reportsButton);
            this.guna2Panel2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.guna2Panel2.Location = new System.Drawing.Point(0, -31);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1095, 165);
            this.guna2Panel2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.label1.Location = new System.Drawing.Point(10, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "DASHBOARD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paymentButton
            // 
            this.paymentButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.paymentButton.BackColor = System.Drawing.Color.Transparent;
            this.paymentButton.BorderColor = System.Drawing.Color.Transparent;
            this.paymentButton.BorderRadius = 18;
            this.paymentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paymentButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.paymentButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.paymentButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.paymentButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.paymentButton.FillColor = System.Drawing.Color.Transparent;
            this.paymentButton.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.paymentButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.paymentButton.IndicateFocus = true;
            this.paymentButton.Location = new System.Drawing.Point(893, 130);
            this.paymentButton.Name = "paymentButton";
            this.paymentButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.paymentButton.Size = new System.Drawing.Size(137, 48);
            this.paymentButton.TabIndex = 19;
            this.paymentButton.Text = "PAYMENT";
            this.paymentButton.TextOffset = new System.Drawing.Point(0, -5);
            this.paymentButton.Click += new System.EventHandler(this.paymentButton_Click);
            // 
            // bookButton
            // 
            this.bookButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bookButton.BackColor = System.Drawing.Color.Transparent;
            this.bookButton.BorderColor = System.Drawing.Color.Transparent;
            this.bookButton.BorderRadius = 18;
            this.bookButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bookButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bookButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bookButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bookButton.FillColor = System.Drawing.Color.Transparent;
            this.bookButton.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.bookButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.bookButton.IndicateFocus = true;
            this.bookButton.Location = new System.Drawing.Point(686, 130);
            this.bookButton.Name = "bookButton";
            this.bookButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.bookButton.Size = new System.Drawing.Size(149, 48);
            this.bookButton.TabIndex = 18;
            this.bookButton.Text = "BOOKINGS";
            this.bookButton.TextOffset = new System.Drawing.Point(0, -5);
            this.bookButton.Click += new System.EventHandler(this.bookButton_Click);
            // 
            // customerButton
            // 
            this.customerButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerButton.BackColor = System.Drawing.Color.Transparent;
            this.customerButton.BorderColor = System.Drawing.Color.Transparent;
            this.customerButton.BorderRadius = 18;
            this.customerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customerButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.customerButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.customerButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.customerButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.customerButton.FillColor = System.Drawing.Color.Transparent;
            this.customerButton.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.customerButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.customerButton.IndicateFocus = true;
            this.customerButton.Location = new System.Drawing.Point(479, 130);
            this.customerButton.Name = "customerButton";
            this.customerButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.customerButton.Size = new System.Drawing.Size(148, 48);
            this.customerButton.TabIndex = 17;
            this.customerButton.Text = "CUSTOMER";
            this.customerButton.TextOffset = new System.Drawing.Point(0, -5);
            this.customerButton.Click += new System.EventHandler(this.customerButton_Click);
            // 
            // roomButton
            // 
            this.roomButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roomButton.BackColor = System.Drawing.Color.Transparent;
            this.roomButton.BorderColor = System.Drawing.Color.Transparent;
            this.roomButton.BorderRadius = 18;
            this.roomButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roomButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.roomButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.roomButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.roomButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.roomButton.FillColor = System.Drawing.Color.Transparent;
            this.roomButton.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.roomButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.roomButton.IndicateFocus = true;
            this.roomButton.Location = new System.Drawing.Point(272, 130);
            this.roomButton.Name = "roomButton";
            this.roomButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.roomButton.Size = new System.Drawing.Size(116, 48);
            this.roomButton.TabIndex = 16;
            this.roomButton.Text = "ROOM";
            this.roomButton.TextOffset = new System.Drawing.Point(0, -5);
            this.roomButton.Click += new System.EventHandler(this.roomButton_Click);
            // 
            // reportsButton
            // 
            this.reportsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reportsButton.BackColor = System.Drawing.Color.Transparent;
            this.reportsButton.BorderColor = System.Drawing.Color.Transparent;
            this.reportsButton.BorderRadius = 18;
            this.reportsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.reportsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.reportsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reportsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.reportsButton.FillColor = System.Drawing.Color.Transparent;
            this.reportsButton.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.reportsButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.reportsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.reportsButton.IndicateFocus = true;
            this.reportsButton.Location = new System.Drawing.Point(65, 130);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.reportsButton.Size = new System.Drawing.Size(130, 48);
            this.reportsButton.TabIndex = 15;
            this.reportsButton.Text = "REPORTS";
            this.reportsButton.TextOffset = new System.Drawing.Point(0, -5);
            this.reportsButton.Click += new System.EventHandler(this.reportsButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 648);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VISTAINN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mainPanel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button paymentButton;
        private Guna.UI2.WinForms.Guna2Button bookButton;
        private Guna.UI2.WinForms.Guna2Button customerButton;
        private Guna.UI2.WinForms.Guna2Button roomButton;
        private Guna.UI2.WinForms.Guna2Button reportsButton;
        private System.Windows.Forms.Label label1;
    }
}