namespace Vistainn
{
    partial class staffProfile
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
            this.viewPasswordChange = new Guna.UI2.WinForms.Guna2CheckBox();
            this.changeButton = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rNewPassTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.newPassTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.oldPassTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.logOutButton = new Guna.UI2.WinForms.Guna2Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 30;
            this.guna2Panel1.BorderThickness = 3;
            this.guna2Panel1.Controls.Add(this.viewPasswordChange);
            this.guna2Panel1.Controls.Add(this.changeButton);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.rNewPassTextBox);
            this.guna2Panel1.Controls.Add(this.newPassTextBox);
            this.guna2Panel1.Controls.Add(this.oldPassTextBox);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.guna2Panel1.Location = new System.Drawing.Point(382, 225);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(330, 321);
            this.guna2Panel1.TabIndex = 74;
            // 
            // viewPasswordChange
            // 
            this.viewPasswordChange.AutoSize = true;
            this.viewPasswordChange.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.viewPasswordChange.CheckedState.BorderRadius = 2;
            this.viewPasswordChange.CheckedState.BorderThickness = 0;
            this.viewPasswordChange.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.viewPasswordChange.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.viewPasswordChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.viewPasswordChange.Location = new System.Drawing.Point(139, 204);
            this.viewPasswordChange.Name = "viewPasswordChange";
            this.viewPasswordChange.Size = new System.Drawing.Size(53, 20);
            this.viewPasswordChange.TabIndex = 122;
            this.viewPasswordChange.Text = "VIEW";
            this.viewPasswordChange.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.viewPasswordChange.UncheckedState.BorderRadius = 2;
            this.viewPasswordChange.UncheckedState.BorderThickness = 0;
            this.viewPasswordChange.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.viewPasswordChange.CheckedChanged += new System.EventHandler(this.viewPasswordChange_CheckedChanged);
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.Transparent;
            this.changeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.changeButton.BorderColor = System.Drawing.Color.Transparent;
            this.changeButton.BorderRadius = 10;
            this.changeButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.changeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.changeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.changeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.changeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.changeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(144)))), ((int)(((byte)(36)))));
            this.changeButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.changeButton.Location = new System.Drawing.Point(114, 244);
            this.changeButton.Name = "changeButton";
            this.changeButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.changeButton.Size = new System.Drawing.Size(103, 26);
            this.changeButton.TabIndex = 121;
            this.changeButton.Text = "CHANGE";
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.label5.Location = new System.Drawing.Point(69, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 15);
            this.label5.TabIndex = 120;
            this.label5.Text = "RE-ENTER NEW PASSWORD";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.label4.Location = new System.Drawing.Point(69, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 119;
            this.label4.Text = "NEW PASSWORD";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.label3.Location = new System.Drawing.Point(69, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 118;
            this.label3.Text = "OLD PASSWORD";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rNewPassTextBox
            // 
            this.rNewPassTextBox.BorderRadius = 10;
            this.rNewPassTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rNewPassTextBox.DefaultText = "";
            this.rNewPassTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.rNewPassTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.rNewPassTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.rNewPassTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.rNewPassTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.rNewPassTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rNewPassTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.rNewPassTextBox.Location = new System.Drawing.Point(69, 157);
            this.rNewPassTextBox.Name = "rNewPassTextBox";
            this.rNewPassTextBox.PasswordChar = '\0';
            this.rNewPassTextBox.PlaceholderText = "";
            this.rNewPassTextBox.SelectedText = "";
            this.rNewPassTextBox.Size = new System.Drawing.Size(193, 26);
            this.rNewPassTextBox.TabIndex = 117;
            // 
            // newPassTextBox
            // 
            this.newPassTextBox.BorderRadius = 10;
            this.newPassTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newPassTextBox.DefaultText = "";
            this.newPassTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.newPassTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.newPassTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newPassTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newPassTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.newPassTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.newPassTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.newPassTextBox.Location = new System.Drawing.Point(69, 102);
            this.newPassTextBox.Name = "newPassTextBox";
            this.newPassTextBox.PasswordChar = '\0';
            this.newPassTextBox.PlaceholderText = "";
            this.newPassTextBox.SelectedText = "";
            this.newPassTextBox.Size = new System.Drawing.Size(193, 26);
            this.newPassTextBox.TabIndex = 116;
            // 
            // oldPassTextBox
            // 
            this.oldPassTextBox.BorderRadius = 10;
            this.oldPassTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.oldPassTextBox.DefaultText = "";
            this.oldPassTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.oldPassTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.oldPassTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.oldPassTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.oldPassTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.oldPassTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.oldPassTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.oldPassTextBox.Location = new System.Drawing.Point(69, 47);
            this.oldPassTextBox.Name = "oldPassTextBox";
            this.oldPassTextBox.PasswordChar = '\0';
            this.oldPassTextBox.PlaceholderText = "";
            this.oldPassTextBox.SelectedText = "";
            this.oldPassTextBox.Size = new System.Drawing.Size(193, 26);
            this.oldPassTextBox.TabIndex = 115;
            // 
            // logOutButton
            // 
            this.logOutButton.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.logOutButton.Location = new System.Drawing.Point(470, 140);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.logOutButton.Size = new System.Drawing.Size(154, 41);
            this.logOutButton.TabIndex = 73;
            this.logOutButton.Text = "LOG OUT";
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.emailLabel.Location = new System.Drawing.Point(308, 81);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(479, 22);
            this.emailLabel.TabIndex = 72;
            this.emailLabel.Text = "email@email.com";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.label1.Location = new System.Drawing.Point(468, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 36);
            this.label1.TabIndex = 71;
            this.label1.Text = "ACCOUNT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // staffProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(1095, 517);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "staffProfile";
            this.Text = "staffProfile";
            this.Load += new System.EventHandler(this.staffProfile_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CheckBox viewPasswordChange;
        private Guna.UI2.WinForms.Guna2Button changeButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public Guna.UI2.WinForms.Guna2TextBox rNewPassTextBox;
        public Guna.UI2.WinForms.Guna2TextBox newPassTextBox;
        public Guna.UI2.WinForms.Guna2TextBox oldPassTextBox;
        private Guna.UI2.WinForms.Guna2Button logOutButton;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label label1;
    }
}