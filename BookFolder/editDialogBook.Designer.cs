using MySql.Data.MySqlClient;

namespace Vistainn.BookFolder
{
    partial class editBookDialog
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
            this.updateButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fullNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bookingIdTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.statusComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.roomNoComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.roomTypeComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.checkInDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.checkOutDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.phoneNoTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.emailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.aoNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.aoPriceTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.paxNumericUpDown = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.aoQuantityTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paxNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 30;
            this.guna2Panel1.BorderThickness = 3;
            this.guna2Panel1.Controls.Add(this.updateButton);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.guna2Panel1.Location = new System.Drawing.Point(-5, 616);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(502, 144);
            this.guna2Panel1.TabIndex = 69;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.Transparent;
            this.updateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateButton.BorderColor = System.Drawing.Color.Transparent;
            this.updateButton.BorderRadius = 10;
            this.updateButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.updateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(144)))), ((int)(((byte)(36)))));
            this.updateButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.updateButton.Location = new System.Drawing.Point(200, 38);
            this.updateButton.Name = "updateButton";
            this.updateButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.updateButton.Size = new System.Drawing.Size(103, 26);
            this.updateButton.TabIndex = 31;
            this.updateButton.Text = "UPDATE";
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderRadius = 30;
            this.guna2Panel3.BorderThickness = 3;
            this.guna2Panel3.Controls.Add(this.label4);
            this.guna2Panel3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.guna2Panel3.Location = new System.Drawing.Point(0, -39);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(498, 144);
            this.guna2Panel3.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.label4.Location = new System.Drawing.Point(140, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 32);
            this.label4.TabIndex = 18;
            this.label4.Text = "EDIT BOOKINGS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.label7.Location = new System.Drawing.Point(53, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 66;
            this.label7.Text = "CHECK-IN";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.label6.Location = new System.Drawing.Point(294, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 65;
            this.label6.Text = "ROOM TYPE";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.label5.Location = new System.Drawing.Point(56, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 62;
            this.label5.Text = "ROOM NUMBER";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.BorderRadius = 10;
            this.fullNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fullNameTextBox.DefaultText = "";
            this.fullNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fullNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fullNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fullNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fullNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.fullNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fullNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.fullNameTextBox.Location = new System.Drawing.Point(153, 174);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.PasswordChar = '\0';
            this.fullNameTextBox.PlaceholderText = "";
            this.fullNameTextBox.SelectedText = "";
            this.fullNameTextBox.Size = new System.Drawing.Size(218, 26);
            this.fullNameTextBox.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.label3.Location = new System.Drawing.Point(150, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 60;
            this.label3.Text = "CUSTOMER NAME";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bookingIdTextBox
            // 
            this.bookingIdTextBox.BorderRadius = 10;
            this.bookingIdTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bookingIdTextBox.DefaultText = "";
            this.bookingIdTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.bookingIdTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.bookingIdTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bookingIdTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bookingIdTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.bookingIdTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bookingIdTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.bookingIdTextBox.Location = new System.Drawing.Point(56, 174);
            this.bookingIdTextBox.Name = "bookingIdTextBox";
            this.bookingIdTextBox.PasswordChar = '\0';
            this.bookingIdTextBox.PlaceholderText = "";
            this.bookingIdTextBox.ReadOnly = true;
            this.bookingIdTextBox.SelectedText = "";
            this.bookingIdTextBox.Size = new System.Drawing.Size(78, 26);
            this.bookingIdTextBox.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.label2.Location = new System.Drawing.Point(53, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 58;
            this.label2.Text = "BOOKING ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.label1.Location = new System.Drawing.Point(51, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 70;
            this.label1.Text = "CHECK-OUT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.label8.Location = new System.Drawing.Point(56, 509);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 72;
            this.label8.Text = "STATUS";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusComboBox
            // 
            this.statusComboBox.BackColor = System.Drawing.Color.Transparent;
            this.statusComboBox.BorderRadius = 10;
            this.statusComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.DropDownWidth = 105;
            this.statusComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.statusComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.statusComboBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.statusComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.statusComboBox.IntegralHeight = false;
            this.statusComboBox.ItemHeight = 30;
            this.statusComboBox.Items.AddRange(new object[] {
            "Confirmed",
            "Checked-In",
            "Checked-Out",
            "Cancelled"});
            this.statusComboBox.Location = new System.Drawing.Point(59, 527);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(152, 36);
            this.statusComboBox.TabIndex = 106;
            // 
            // roomNoComboBox
            // 
            this.roomNoComboBox.BackColor = System.Drawing.Color.Transparent;
            this.roomNoComboBox.BorderRadius = 10;
            this.roomNoComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.roomNoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomNoComboBox.DropDownWidth = 105;
            this.roomNoComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.roomNoComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.roomNoComboBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.roomNoComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.roomNoComboBox.IntegralHeight = false;
            this.roomNoComboBox.ItemHeight = 30;
            this.roomNoComboBox.Location = new System.Drawing.Point(56, 399);
            this.roomNoComboBox.Name = "roomNoComboBox";
            this.roomNoComboBox.Size = new System.Drawing.Size(152, 36);
            this.roomNoComboBox.TabIndex = 107;
            // 
            // roomTypeComboBox
            // 
            this.roomTypeComboBox.BackColor = System.Drawing.Color.Transparent;
            this.roomTypeComboBox.BorderRadius = 10;
            this.roomTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.roomTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomTypeComboBox.DropDownWidth = 105;
            this.roomTypeComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.roomTypeComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.roomTypeComboBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.roomTypeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.roomTypeComboBox.IntegralHeight = false;
            this.roomTypeComboBox.ItemHeight = 30;
            this.roomTypeComboBox.Items.AddRange(new object[] {
            "Single Room",
            "Deluxe Room",
            "Loft Room",
            "Studio Room",
            "Executive Room",
            "Premium Room",
            "Penthouse",
            "Junior Suite",
            "Grand Room"});
            this.roomTypeComboBox.Location = new System.Drawing.Point(294, 399);
            this.roomTypeComboBox.Name = "roomTypeComboBox";
            this.roomTypeComboBox.Size = new System.Drawing.Size(152, 36);
            this.roomTypeComboBox.TabIndex = 108;
            this.roomTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.roomTypeComboBox_SelectedIndexChanged);
            // 
            // checkInDateTimePicker
            // 
            this.checkInDateTimePicker.BackColor = System.Drawing.Color.Transparent;
            this.checkInDateTimePicker.BorderRadius = 10;
            this.checkInDateTimePicker.Checked = true;
            this.checkInDateTimePicker.FillColor = System.Drawing.Color.DimGray;
            this.checkInDateTimePicker.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.checkInDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.checkInDateTimePicker.Location = new System.Drawing.Point(56, 285);
            this.checkInDateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.checkInDateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.checkInDateTimePicker.Name = "checkInDateTimePicker";
            this.checkInDateTimePicker.Size = new System.Drawing.Size(390, 30);
            this.checkInDateTimePicker.TabIndex = 109;
            this.checkInDateTimePicker.Value = new System.DateTime(2024, 11, 16, 9, 16, 16, 375);
            // 
            // checkOutDateTimePicker
            // 
            this.checkOutDateTimePicker.BackColor = System.Drawing.Color.Transparent;
            this.checkOutDateTimePicker.BorderRadius = 10;
            this.checkOutDateTimePicker.Checked = true;
            this.checkOutDateTimePicker.FillColor = System.Drawing.Color.DimGray;
            this.checkOutDateTimePicker.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.checkOutDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.checkOutDateTimePicker.Location = new System.Drawing.Point(56, 341);
            this.checkOutDateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.checkOutDateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.checkOutDateTimePicker.Name = "checkOutDateTimePicker";
            this.checkOutDateTimePicker.Size = new System.Drawing.Size(390, 30);
            this.checkOutDateTimePicker.TabIndex = 110;
            this.checkOutDateTimePicker.Value = new System.DateTime(2024, 11, 16, 9, 16, 16, 375);
            // 
            // phoneNoTextBox
            // 
            this.phoneNoTextBox.BorderRadius = 10;
            this.phoneNoTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneNoTextBox.DefaultText = "";
            this.phoneNoTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phoneNoTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phoneNoTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneNoTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneNoTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.phoneNoTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.phoneNoTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.phoneNoTextBox.Location = new System.Drawing.Point(56, 231);
            this.phoneNoTextBox.Name = "phoneNoTextBox";
            this.phoneNoTextBox.PasswordChar = '\0';
            this.phoneNoTextBox.PlaceholderText = "";
            this.phoneNoTextBox.SelectedText = "";
            this.phoneNoTextBox.Size = new System.Drawing.Size(169, 26);
            this.phoneNoTextBox.TabIndex = 112;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.label9.Location = new System.Drawing.Point(53, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 15);
            this.label9.TabIndex = 111;
            this.label9.Text = "PHONE NUMBER";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BorderRadius = 10;
            this.emailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTextBox.DefaultText = "";
            this.emailTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.emailTextBox.Location = new System.Drawing.Point(253, 231);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PasswordChar = '\0';
            this.emailTextBox.PlaceholderText = "";
            this.emailTextBox.SelectedText = "";
            this.emailTextBox.Size = new System.Drawing.Size(193, 26);
            this.emailTextBox.TabIndex = 114;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.label10.Location = new System.Drawing.Point(250, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 15);
            this.label10.TabIndex = 113;
            this.label10.Text = "EMAIL";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.label11.Location = new System.Drawing.Point(386, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 15);
            this.label11.TabIndex = 115;
            this.label11.Text = "PAX";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aoNameTextBox
            // 
            this.aoNameTextBox.BorderRadius = 10;
            this.aoNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.aoNameTextBox.DefaultText = "";
            this.aoNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.aoNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.aoNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.aoNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.aoNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.aoNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.aoNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.aoNameTextBox.Location = new System.Drawing.Point(59, 467);
            this.aoNameTextBox.Name = "aoNameTextBox";
            this.aoNameTextBox.PasswordChar = '\0';
            this.aoNameTextBox.PlaceholderText = "";
            this.aoNameTextBox.SelectedText = "";
            this.aoNameTextBox.Size = new System.Drawing.Size(127, 26);
            this.aoNameTextBox.TabIndex = 118;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.label12.Location = new System.Drawing.Point(56, 449);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 15);
            this.label12.TabIndex = 117;
            this.label12.Text = "AO NAME";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aoPriceTextBox
            // 
            this.aoPriceTextBox.BorderRadius = 10;
            this.aoPriceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.aoPriceTextBox.DefaultText = "";
            this.aoPriceTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.aoPriceTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.aoPriceTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.aoPriceTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.aoPriceTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.aoPriceTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.aoPriceTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.aoPriceTextBox.Location = new System.Drawing.Point(203, 467);
            this.aoPriceTextBox.Name = "aoPriceTextBox";
            this.aoPriceTextBox.PasswordChar = '\0';
            this.aoPriceTextBox.PlaceholderText = "";
            this.aoPriceTextBox.SelectedText = "";
            this.aoPriceTextBox.Size = new System.Drawing.Size(127, 26);
            this.aoPriceTextBox.TabIndex = 120;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.label13.Location = new System.Drawing.Point(200, 449);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 15);
            this.label13.TabIndex = 119;
            this.label13.Text = "AO PRICE";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.label14.Location = new System.Drawing.Point(346, 449);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 15);
            this.label14.TabIndex = 121;
            this.label14.Text = "AO QUANTITY";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paxNumericUpDown
            // 
            this.paxNumericUpDown.BackColor = System.Drawing.Color.Transparent;
            this.paxNumericUpDown.BorderRadius = 12;
            this.paxNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.paxNumericUpDown.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.paxNumericUpDown.Location = new System.Drawing.Point(389, 171);
            this.paxNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.paxNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.paxNumericUpDown.Name = "paxNumericUpDown";
            this.paxNumericUpDown.Size = new System.Drawing.Size(57, 29);
            this.paxNumericUpDown.TabIndex = 123;
            this.paxNumericUpDown.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.paxNumericUpDown.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(144)))), ((int)(((byte)(36)))));
            this.paxNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // aoQuantityTextBox
            // 
            this.aoQuantityTextBox.BorderRadius = 10;
            this.aoQuantityTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.aoQuantityTextBox.DefaultText = "";
            this.aoQuantityTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.aoQuantityTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.aoQuantityTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.aoQuantityTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.aoQuantityTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.aoQuantityTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.aoQuantityTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.aoQuantityTextBox.Location = new System.Drawing.Point(349, 467);
            this.aoQuantityTextBox.Name = "aoQuantityTextBox";
            this.aoQuantityTextBox.PasswordChar = '\0';
            this.aoQuantityTextBox.PlaceholderText = "";
            this.aoQuantityTextBox.SelectedText = "";
            this.aoQuantityTextBox.Size = new System.Drawing.Size(97, 26);
            this.aoQuantityTextBox.TabIndex = 124;
            // 
            // editBookDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(496, 719);
            this.Controls.Add(this.aoQuantityTextBox);
            this.Controls.Add(this.paxNumericUpDown);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.aoPriceTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.aoNameTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.phoneNoTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkOutDateTimePicker);
            this.Controls.Add(this.checkInDateTimePicker);
            this.Controls.Add(this.roomTypeComboBox);
            this.Controls.Add(this.roomNoComboBox);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bookingIdTextBox);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "editBookDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDIT BOOKINGS";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paxNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button updateButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public Guna.UI2.WinForms.Guna2TextBox fullNameTextBox;
        private System.Windows.Forms.Label label3;
        public Guna.UI2.WinForms.Guna2TextBox bookingIdTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        public Guna.UI2.WinForms.Guna2ComboBox statusComboBox;
        public Guna.UI2.WinForms.Guna2ComboBox roomNoComboBox;
        public Guna.UI2.WinForms.Guna2ComboBox roomTypeComboBox;
        public Guna.UI2.WinForms.Guna2DateTimePicker checkInDateTimePicker;
        public Guna.UI2.WinForms.Guna2DateTimePicker checkOutDateTimePicker;
        public Guna.UI2.WinForms.Guna2TextBox phoneNoTextBox;
        private System.Windows.Forms.Label label9;
        public Guna.UI2.WinForms.Guna2TextBox emailTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public Guna.UI2.WinForms.Guna2TextBox aoNameTextBox;
        private System.Windows.Forms.Label label12;
        public Guna.UI2.WinForms.Guna2TextBox aoPriceTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        public Guna.UI2.WinForms.Guna2NumericUpDown paxNumericUpDown;
        public Guna.UI2.WinForms.Guna2TextBox aoQuantityTextBox;
    }
}