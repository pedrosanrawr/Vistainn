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
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
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
            this.guna2Panel1.Location = new System.Drawing.Point(0, 507);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(447, 144);
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
            this.updateButton.Location = new System.Drawing.Point(168, 37);
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
            this.guna2Panel3.Location = new System.Drawing.Point(-1, -25);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(447, 144);
            this.guna2Panel3.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.label4.Location = new System.Drawing.Point(118, 80);
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
            this.label7.Location = new System.Drawing.Point(48, 288);
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
            this.label6.Location = new System.Drawing.Point(233, 215);
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
            this.label5.Location = new System.Drawing.Point(48, 215);
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
            this.fullNameTextBox.Location = new System.Drawing.Point(178, 168);
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
            this.label3.Location = new System.Drawing.Point(175, 150);
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
            this.bookingIdTextBox.Location = new System.Drawing.Point(53, 168);
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
            this.label2.Location = new System.Drawing.Point(50, 150);
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
            this.label1.Location = new System.Drawing.Point(48, 350);
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
            this.label8.Location = new System.Drawing.Point(147, 414);
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
            this.statusComboBox.Location = new System.Drawing.Point(150, 432);
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
            this.roomNoComboBox.Location = new System.Drawing.Point(51, 233);
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
            this.roomTypeComboBox.Location = new System.Drawing.Point(236, 233);
            this.roomTypeComboBox.Name = "roomTypeComboBox";
            this.roomTypeComboBox.Size = new System.Drawing.Size(152, 36);
            this.roomTypeComboBox.TabIndex = 108;
            // 
            // checkInDateTimePicker
            // 
            this.checkInDateTimePicker.BackColor = System.Drawing.Color.Transparent;
            this.checkInDateTimePicker.BorderRadius = 10;
            this.checkInDateTimePicker.Checked = true;
            this.checkInDateTimePicker.FillColor = System.Drawing.Color.DimGray;
            this.checkInDateTimePicker.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.checkInDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.checkInDateTimePicker.Location = new System.Drawing.Point(51, 306);
            this.checkInDateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.checkInDateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.checkInDateTimePicker.Name = "checkInDateTimePicker";
            this.checkInDateTimePicker.Size = new System.Drawing.Size(337, 30);
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
            this.checkOutDateTimePicker.Location = new System.Drawing.Point(53, 368);
            this.checkOutDateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.checkOutDateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.checkOutDateTimePicker.Name = "checkOutDateTimePicker";
            this.checkOutDateTimePicker.Size = new System.Drawing.Size(335, 30);
            this.checkOutDateTimePicker.TabIndex = 110;
            this.checkOutDateTimePicker.Value = new System.DateTime(2024, 11, 16, 9, 16, 16, 375);
            // 
            // editBookDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(446, 603);
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
    }
}