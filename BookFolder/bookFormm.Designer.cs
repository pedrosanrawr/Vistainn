﻿namespace Vistainn
{
    partial class bookFormm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.searchButton = new Guna.UI2.WinForms.Guna2Button();
            this.searchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.deleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.addBookButton = new Guna.UI2.WinForms.Guna2Button();
            this.refreshButton = new Guna.UI2.WinForms.Guna2Button();
            this.editButton = new Guna.UI2.WinForms.Guna2Button();
            this.bookTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.BookingId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AoName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AoPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AoQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.logOutButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookTable)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderRadius = 30;
            this.guna2Panel3.BorderThickness = 3;
            this.guna2Panel3.Controls.Add(this.searchButton);
            this.guna2Panel3.Controls.Add(this.searchTextBox);
            this.guna2Panel3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.guna2Panel3.Location = new System.Drawing.Point(875, 12);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(247, 137);
            this.guna2Panel3.TabIndex = 20;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchButton.BackColor = System.Drawing.Color.Transparent;
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchButton.BorderColor = System.Drawing.Color.Transparent;
            this.searchButton.BorderRadius = 18;
            this.searchButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.searchButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.searchButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.searchButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.searchButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(144)))), ((int)(((byte)(36)))));
            this.searchButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.searchButton.Location = new System.Drawing.Point(39, 77);
            this.searchButton.Name = "searchButton";
            this.searchButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.searchButton.Size = new System.Drawing.Size(154, 36);
            this.searchButton.TabIndex = 15;
            this.searchButton.Text = "SEARCH";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchTextBox.BackColor = System.Drawing.Color.Transparent;
            this.searchTextBox.BorderRadius = 15;
            this.searchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTextBox.DefaultText = "";
            this.searchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.searchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.searchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.searchTextBox.Location = new System.Drawing.Point(39, 25);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PasswordChar = '\0';
            this.searchTextBox.PlaceholderText = "";
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.Size = new System.Drawing.Size(154, 36);
            this.searchTextBox.TabIndex = 15;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 30;
            this.guna2Panel1.BorderThickness = 3;
            this.guna2Panel1.Controls.Add(this.deleteButton);
            this.guna2Panel1.Controls.Add(this.addBookButton);
            this.guna2Panel1.Controls.Add(this.refreshButton);
            this.guna2Panel1.Controls.Add(this.editButton);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.guna2Panel1.Location = new System.Drawing.Point(875, 155);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(250, 266);
            this.guna2Panel1.TabIndex = 18;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton.BorderColor = System.Drawing.Color.Transparent;
            this.deleteButton.BorderRadius = 18;
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteButton.FillColor = System.Drawing.Color.DarkRed;
            this.deleteButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.deleteButton.Location = new System.Drawing.Point(39, 140);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.deleteButton.Size = new System.Drawing.Size(154, 41);
            this.deleteButton.TabIndex = 19;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addBookButton
            // 
            this.addBookButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addBookButton.BackColor = System.Drawing.Color.Transparent;
            this.addBookButton.BorderColor = System.Drawing.Color.Transparent;
            this.addBookButton.BorderRadius = 18;
            this.addBookButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBookButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addBookButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addBookButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addBookButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addBookButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(144)))), ((int)(((byte)(36)))));
            this.addBookButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBookButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.addBookButton.Location = new System.Drawing.Point(39, 20);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.addBookButton.Size = new System.Drawing.Size(154, 41);
            this.addBookButton.TabIndex = 16;
            this.addBookButton.Text = "ADD";
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.refreshButton.BackColor = System.Drawing.Color.Transparent;
            this.refreshButton.BorderColor = System.Drawing.Color.Transparent;
            this.refreshButton.BorderRadius = 18;
            this.refreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.refreshButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.refreshButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.refreshButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.refreshButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(144)))), ((int)(((byte)(36)))));
            this.refreshButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.refreshButton.Location = new System.Drawing.Point(39, 200);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.refreshButton.Size = new System.Drawing.Size(154, 41);
            this.refreshButton.TabIndex = 15;
            this.refreshButton.Text = "RESFRESH";
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // editButton
            // 
            this.editButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.editButton.BackColor = System.Drawing.Color.Transparent;
            this.editButton.BorderColor = System.Drawing.Color.Transparent;
            this.editButton.BorderRadius = 18;
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.editButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.editButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.editButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.editButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(144)))), ((int)(((byte)(36)))));
            this.editButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.editButton.Location = new System.Drawing.Point(39, 80);
            this.editButton.Name = "editButton";
            this.editButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.editButton.Size = new System.Drawing.Size(154, 41);
            this.editButton.TabIndex = 14;
            this.editButton.Text = "EDIT";
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // bookTable
            // 
            this.bookTable.AllowUserToAddRows = false;
            this.bookTable.AllowUserToDeleteRows = false;
            this.bookTable.AllowUserToResizeColumns = false;
            this.bookTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(193)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.bookTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bookTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.bookTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bookTable.ColumnHeadersHeight = 25;
            this.bookTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.bookTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookingId,
            this.FullName,
            this.PhoneNo,
            this.Email,
            this.RoomNo,
            this.RoomType,
            this.Pax,
            this.CheckIn,
            this.CheckOut,
            this.AoName,
            this.AoPrice,
            this.AoQty,
            this.Status});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bookTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.bookTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.bookTable.Location = new System.Drawing.Point(12, 12);
            this.bookTable.Name = "bookTable";
            this.bookTable.ReadOnly = true;
            this.bookTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bookTable.RowHeadersVisible = false;
            this.bookTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.bookTable.RowTemplate.Height = 20;
            this.bookTable.Size = new System.Drawing.Size(843, 493);
            this.bookTable.TabIndex = 1;
            this.bookTable.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Turquoise;
            this.bookTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(193)))), ((int)(((byte)(190)))));
            this.bookTable.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.bookTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.bookTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.bookTable.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.bookTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.bookTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.bookTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bookTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.bookTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.bookTable.ThemeStyle.HeaderStyle.Height = 25;
            this.bookTable.ThemeStyle.ReadOnly = true;
            this.bookTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.bookTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bookTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.bookTable.ThemeStyle.RowsStyle.Height = 20;
            this.bookTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.bookTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            // 
            // BookingId
            // 
            this.BookingId.DataPropertyName = "BookingId";
            this.BookingId.HeaderText = "BOOKING ID";
            this.BookingId.Name = "BookingId";
            this.BookingId.ReadOnly = true;
            this.BookingId.Width = 95;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "CUSTOMER\'S NAME";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 132;
            // 
            // PhoneNo
            // 
            this.PhoneNo.DataPropertyName = "PhoneNo";
            this.PhoneNo.HeaderText = "PHONE NUMBER";
            this.PhoneNo.Name = "PhoneNo";
            this.PhoneNo.ReadOnly = true;
            this.PhoneNo.Width = 118;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "EMAIL";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 61;
            // 
            // RoomNo
            // 
            this.RoomNo.DataPropertyName = "RoomNo";
            this.RoomNo.HeaderText = "ROOM NUMBER";
            this.RoomNo.Name = "RoomNo";
            this.RoomNo.ReadOnly = true;
            this.RoomNo.Width = 114;
            // 
            // RoomType
            // 
            this.RoomType.DataPropertyName = "RoomType";
            this.RoomType.HeaderText = "ROOM TYPE";
            this.RoomType.Name = "RoomType";
            this.RoomType.ReadOnly = true;
            this.RoomType.Width = 93;
            // 
            // Pax
            // 
            this.Pax.DataPropertyName = "Pax";
            this.Pax.HeaderText = "PAX";
            this.Pax.Name = "Pax";
            this.Pax.ReadOnly = true;
            this.Pax.Width = 52;
            // 
            // CheckIn
            // 
            this.CheckIn.DataPropertyName = "CheckIn";
            this.CheckIn.HeaderText = "CHECK IN";
            this.CheckIn.Name = "CheckIn";
            this.CheckIn.ReadOnly = true;
            this.CheckIn.Width = 81;
            // 
            // CheckOut
            // 
            this.CheckOut.DataPropertyName = "CheckOut";
            this.CheckOut.HeaderText = "CHECK OUT";
            this.CheckOut.Name = "CheckOut";
            this.CheckOut.ReadOnly = true;
            this.CheckOut.Width = 91;
            // 
            // AoName
            // 
            this.AoName.DataPropertyName = "AoName";
            this.AoName.HeaderText = "AO NAME";
            this.AoName.Name = "AoName";
            this.AoName.ReadOnly = true;
            this.AoName.Width = 83;
            // 
            // AoPrice
            // 
            this.AoPrice.DataPropertyName = "AoPrice";
            this.AoPrice.HeaderText = "AO PRICE";
            this.AoPrice.Name = "AoPrice";
            this.AoPrice.ReadOnly = true;
            this.AoPrice.Width = 80;
            // 
            // AoQty
            // 
            this.AoQty.DataPropertyName = "AoQty";
            this.AoQty.HeaderText = "AO QUANTITY";
            this.AoQty.Name = "AoQty";
            this.AoQty.ReadOnly = true;
            this.AoQty.Width = 102;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "STATUS";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 67;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderRadius = 30;
            this.guna2Panel2.BorderThickness = 3;
            this.guna2Panel2.Controls.Add(this.logOutButton);
            this.guna2Panel2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.guna2Panel2.Location = new System.Drawing.Point(875, 427);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(250, 78);
            this.guna2Panel2.TabIndex = 20;
            // 
            // logOutButton
            // 
            this.logOutButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.logOutButton.BackColor = System.Drawing.Color.Transparent;
            this.logOutButton.BorderColor = System.Drawing.Color.Transparent;
            this.logOutButton.BorderRadius = 18;
            this.logOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOutButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logOutButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logOutButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logOutButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logOutButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(144)))), ((int)(((byte)(36)))));
            this.logOutButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.logOutButton.Location = new System.Drawing.Point(42, 19);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.logOutButton.Size = new System.Drawing.Size(154, 41);
            this.logOutButton.TabIndex = 16;
            this.logOutButton.Text = "LOG OUT";
            // 
            // bookFormm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(1095, 517);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.bookTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bookFormm";
            this.Text = "bookForm";
            this.Load += new System.EventHandler(this.bookForm_Load);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookTable)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button searchButton;
        private Guna.UI2.WinForms.Guna2TextBox searchTextBox;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button refreshButton;
        private Guna.UI2.WinForms.Guna2Button editButton;
        public Guna.UI2.WinForms.Guna2DataGridView bookTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pax;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn AoName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AoPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn AoQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private Guna.UI2.WinForms.Guna2Button addBookButton;
        private Guna.UI2.WinForms.Guna2Button deleteButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button logOutButton;
    }
}