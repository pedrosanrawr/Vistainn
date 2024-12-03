using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System;

namespace Vistainn
{
    partial class startPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startPage));
            this.staffLogInButton = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.staffEmailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.staffPasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.staffForgotPasswordLabel = new System.Windows.Forms.LinkLabel();
            this.managerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.managerForgotPasswordLinkLabel = new System.Windows.Forms.LinkLabel();
            this.manageLogInButton = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.staffLinkLabel = new System.Windows.Forms.LinkLabel();
            this.managerEmailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.managerPasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.staffPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.managerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.logoPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2CheckBox2 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.staffPanel.SuspendLayout();
            this.managerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // staffLogInButton
            // 
            this.staffLogInButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.staffLogInButton.BackColor = System.Drawing.Color.Transparent;
            this.staffLogInButton.BorderColor = System.Drawing.Color.Transparent;
            this.staffLogInButton.BorderRadius = 20;
            this.staffLogInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.staffLogInButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.staffLogInButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.staffLogInButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.staffLogInButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.staffLogInButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(144)))), ((int)(((byte)(36)))));
            this.staffLogInButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffLogInButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.staffLogInButton.Location = new System.Drawing.Point(76, 254);
            this.staffLogInButton.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.staffLogInButton.Name = "staffLogInButton";
            this.staffLogInButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.staffLogInButton.Size = new System.Drawing.Size(180, 45);
            this.staffLogInButton.TabIndex = 12;
            this.staffLogInButton.Text = "LOG IN";
            this.staffLogInButton.Click += new System.EventHandler(this.staffButton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.label3.Location = new System.Drawing.Point(344, 597);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(407, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "\"Your Gateway to Relaxation and Comfort\"";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // staffEmailTextBox
            // 
            this.staffEmailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.staffEmailTextBox.BackColor = System.Drawing.Color.Transparent;
            this.staffEmailTextBox.BorderRadius = 15;
            this.staffEmailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.staffEmailTextBox.DefaultText = "";
            this.staffEmailTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.staffEmailTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.staffEmailTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.staffEmailTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.staffEmailTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.staffEmailTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.staffEmailTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.staffEmailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.staffEmailTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.staffEmailTextBox.Location = new System.Drawing.Point(63, 91);
            this.staffEmailTextBox.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.staffEmailTextBox.Name = "staffEmailTextBox";
            this.staffEmailTextBox.PasswordChar = '\0';
            this.staffEmailTextBox.PlaceholderText = "";
            this.staffEmailTextBox.SelectedText = "";
            this.staffEmailTextBox.Size = new System.Drawing.Size(204, 36);
            this.staffEmailTextBox.TabIndex = 14;
            // 
            // staffPasswordTextBox
            // 
            this.staffPasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.staffPasswordTextBox.BackColor = System.Drawing.Color.Transparent;
            this.staffPasswordTextBox.BorderRadius = 15;
            this.staffPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.staffPasswordTextBox.DefaultText = "";
            this.staffPasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.staffPasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.staffPasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.staffPasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.staffPasswordTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.staffPasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.staffPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.staffPasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.staffPasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.staffPasswordTextBox.Location = new System.Drawing.Point(63, 179);
            this.staffPasswordTextBox.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.staffPasswordTextBox.Name = "staffPasswordTextBox";
            this.staffPasswordTextBox.PasswordChar = '●';
            this.staffPasswordTextBox.PlaceholderText = "";
            this.staffPasswordTextBox.SelectedText = "";
            this.staffPasswordTextBox.Size = new System.Drawing.Size(204, 36);
            this.staffPasswordTextBox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.label4.Location = new System.Drawing.Point(59, 68);
            this.label4.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "ENTER EMAIL";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.label5.Location = new System.Drawing.Point(66, 156);
            this.label5.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "PASSWORD";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.label6.Location = new System.Drawing.Point(140, 26);
            this.label6.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "STAFF";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // staffForgotPasswordLabel
            // 
            this.staffForgotPasswordLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(144)))), ((int)(((byte)(36)))));
            this.staffForgotPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.staffForgotPasswordLabel.AutoSize = true;
            this.staffForgotPasswordLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffForgotPasswordLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.staffForgotPasswordLabel.Location = new System.Drawing.Point(132, 218);
            this.staffForgotPasswordLabel.Name = "staffForgotPasswordLabel";
            this.staffForgotPasswordLabel.Size = new System.Drawing.Size(135, 17);
            this.staffForgotPasswordLabel.TabIndex = 19;
            this.staffForgotPasswordLabel.TabStop = true;
            this.staffForgotPasswordLabel.Text = "FORGOT PASSWORD";
            this.staffForgotPasswordLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(144)))), ((int)(((byte)(36)))));
            // 
            // managerLinkLabel
            // 
            this.managerLinkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(144)))), ((int)(((byte)(36)))));
            this.managerLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.managerLinkLabel.AutoSize = true;
            this.managerLinkLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.managerLinkLabel.Location = new System.Drawing.Point(93, 327);
            this.managerLinkLabel.Name = "managerLinkLabel";
            this.managerLinkLabel.Size = new System.Drawing.Size(141, 17);
            this.managerLinkLabel.TabIndex = 18;
            this.managerLinkLabel.TabStop = true;
            this.managerLinkLabel.Text = "LOG IN AS MANAGER";
            this.managerLinkLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(144)))), ((int)(((byte)(36)))));
            this.managerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.managerLinkLabel_LinkClicked);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.label7.Location = new System.Drawing.Point(121, 26);
            this.label7.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "MANAGER";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // managerForgotPasswordLinkLabel
            // 
            this.managerForgotPasswordLinkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(144)))), ((int)(((byte)(36)))));
            this.managerForgotPasswordLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.managerForgotPasswordLinkLabel.AutoSize = true;
            this.managerForgotPasswordLinkLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerForgotPasswordLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.managerForgotPasswordLinkLabel.Location = new System.Drawing.Point(132, 218);
            this.managerForgotPasswordLinkLabel.Name = "managerForgotPasswordLinkLabel";
            this.managerForgotPasswordLinkLabel.Size = new System.Drawing.Size(135, 17);
            this.managerForgotPasswordLinkLabel.TabIndex = 19;
            this.managerForgotPasswordLinkLabel.TabStop = true;
            this.managerForgotPasswordLinkLabel.Text = "FORGOT PASSWORD";
            this.managerForgotPasswordLinkLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(144)))), ((int)(((byte)(36)))));
            // 
            // manageLogInButton
            // 
            this.manageLogInButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.manageLogInButton.BackColor = System.Drawing.Color.Transparent;
            this.manageLogInButton.BorderColor = System.Drawing.Color.Transparent;
            this.manageLogInButton.BorderRadius = 20;
            this.manageLogInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageLogInButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.manageLogInButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.manageLogInButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.manageLogInButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.manageLogInButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(144)))), ((int)(((byte)(36)))));
            this.manageLogInButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageLogInButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.manageLogInButton.Location = new System.Drawing.Point(76, 254);
            this.manageLogInButton.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.manageLogInButton.Name = "manageLogInButton";
            this.manageLogInButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.manageLogInButton.Size = new System.Drawing.Size(180, 45);
            this.manageLogInButton.TabIndex = 12;
            this.manageLogInButton.Text = "LOG IN";
            this.manageLogInButton.Click += new System.EventHandler(this.manageLogInButton_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.label8.Location = new System.Drawing.Point(66, 156);
            this.label8.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "PASSWORD";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // staffLinkLabel
            // 
            this.staffLinkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(144)))), ((int)(((byte)(36)))));
            this.staffLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.staffLinkLabel.AutoSize = true;
            this.staffLinkLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.staffLinkLabel.Location = new System.Drawing.Point(109, 327);
            this.staffLinkLabel.Name = "staffLinkLabel";
            this.staffLinkLabel.Size = new System.Drawing.Size(108, 17);
            this.staffLinkLabel.TabIndex = 18;
            this.staffLinkLabel.TabStop = true;
            this.staffLinkLabel.Text = "LOG IN AS STAFF";
            this.staffLinkLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(144)))), ((int)(((byte)(36)))));
            this.staffLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.staffLinkLabel_LinkClicked);
            // 
            // managerEmailTextBox
            // 
            this.managerEmailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.managerEmailTextBox.BackColor = System.Drawing.Color.Transparent;
            this.managerEmailTextBox.BorderRadius = 15;
            this.managerEmailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.managerEmailTextBox.DefaultText = "";
            this.managerEmailTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.managerEmailTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.managerEmailTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.managerEmailTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.managerEmailTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.managerEmailTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.managerEmailTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.managerEmailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.managerEmailTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.managerEmailTextBox.Location = new System.Drawing.Point(63, 91);
            this.managerEmailTextBox.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.managerEmailTextBox.Name = "managerEmailTextBox";
            this.managerEmailTextBox.PasswordChar = '\0';
            this.managerEmailTextBox.PlaceholderText = "";
            this.managerEmailTextBox.SelectedText = "";
            this.managerEmailTextBox.Size = new System.Drawing.Size(204, 36);
            this.managerEmailTextBox.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.label9.Location = new System.Drawing.Point(59, 68);
            this.label9.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "ENTER EMAIL";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // managerPasswordTextBox
            // 
            this.managerPasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.managerPasswordTextBox.BackColor = System.Drawing.Color.Transparent;
            this.managerPasswordTextBox.BorderRadius = 15;
            this.managerPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.managerPasswordTextBox.DefaultText = "";
            this.managerPasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.managerPasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.managerPasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.managerPasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.managerPasswordTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.managerPasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.managerPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.managerPasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.managerPasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.managerPasswordTextBox.Location = new System.Drawing.Point(63, 179);
            this.managerPasswordTextBox.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.managerPasswordTextBox.Name = "managerPasswordTextBox";
            this.managerPasswordTextBox.PasswordChar = '●';
            this.managerPasswordTextBox.PlaceholderText = "";
            this.managerPasswordTextBox.SelectedText = "";
            this.managerPasswordTextBox.Size = new System.Drawing.Size(204, 36);
            this.managerPasswordTextBox.TabIndex = 15;
            // 
            // staffPanel
            // 
            this.staffPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.staffPanel.BackColor = System.Drawing.Color.Transparent;
            this.staffPanel.BorderRadius = 30;
            this.staffPanel.BorderThickness = 3;
            this.staffPanel.Controls.Add(this.guna2CheckBox1);
            this.staffPanel.Controls.Add(this.label10);
            this.staffPanel.Controls.Add(this.staffLogInButton);
            this.staffPanel.Controls.Add(this.label6);
            this.staffPanel.Controls.Add(this.staffPasswordTextBox);
            this.staffPanel.Controls.Add(this.label4);
            this.staffPanel.Controls.Add(this.staffForgotPasswordLabel);
            this.staffPanel.Controls.Add(this.staffEmailTextBox);
            this.staffPanel.Controls.Add(this.managerLinkLabel);
            this.staffPanel.Controls.Add(this.label5);
            this.staffPanel.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.staffPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.staffPanel.Location = new System.Drawing.Point(384, 192);
            this.staffPanel.MaximumSize = new System.Drawing.Size(357, 415);
            this.staffPanel.Name = "staffPanel";
            this.staffPanel.Size = new System.Drawing.Size(327, 374);
            this.staffPanel.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.label10.Location = new System.Drawing.Point(10, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 25);
            this.label10.TabIndex = 9;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // managerPanel
            // 
            this.managerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.managerPanel.BackColor = System.Drawing.Color.Transparent;
            this.managerPanel.BorderRadius = 30;
            this.managerPanel.BorderThickness = 3;
            this.managerPanel.Controls.Add(this.guna2CheckBox2);
            this.managerPanel.Controls.Add(this.label11);
            this.managerPanel.Controls.Add(this.manageLogInButton);
            this.managerPanel.Controls.Add(this.label7);
            this.managerPanel.Controls.Add(this.managerPasswordTextBox);
            this.managerPanel.Controls.Add(this.label9);
            this.managerPanel.Controls.Add(this.managerForgotPasswordLinkLabel);
            this.managerPanel.Controls.Add(this.managerEmailTextBox);
            this.managerPanel.Controls.Add(this.staffLinkLabel);
            this.managerPanel.Controls.Add(this.label8);
            this.managerPanel.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.managerPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.managerPanel.Location = new System.Drawing.Point(384, 192);
            this.managerPanel.MaximumSize = new System.Drawing.Size(357, 415);
            this.managerPanel.Name = "managerPanel";
            this.managerPanel.Size = new System.Drawing.Size(327, 374);
            this.managerPanel.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.label11.Location = new System.Drawing.Point(10, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 25);
            this.label11.TabIndex = 9;
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.ImageRotate = 0F;
            this.logoPictureBox.Location = new System.Drawing.Point(316, 37);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(100, 100);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 26;
            this.logoPictureBox.TabStop = false;
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2Shapes1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Shapes1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.guna2Shapes1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.guna2Shapes1.LineEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.guna2Shapes1.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.guna2Shapes1.LineStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.guna2Shapes1.Location = new System.Drawing.Point(422, 37);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.guna2Shapes1.Size = new System.Drawing.Size(20, 100);
            this.guna2Shapes1.TabIndex = 25;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.Zoom = 80;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.label2.Location = new System.Drawing.Point(652, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 46);
            this.label2.TabIndex = 24;
            this.label2.Text = "KIOSK";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.label1.Location = new System.Drawing.Point(439, 50);
            this.label1.MaximumSize = new System.Drawing.Size(350, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 77);
            this.label1.TabIndex = 23;
            this.label1.Text = "VISTAINN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2CheckBox1
            // 
            this.guna2CheckBox1.AutoSize = true;
            this.guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.guna2CheckBox1.CheckedState.BorderRadius = 2;
            this.guna2CheckBox1.CheckedState.BorderThickness = 0;
            this.guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.guna2CheckBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.guna2CheckBox1.Location = new System.Drawing.Point(214, 156);
            this.guna2CheckBox1.Name = "guna2CheckBox1";
            this.guna2CheckBox1.Size = new System.Drawing.Size(53, 20);
            this.guna2CheckBox1.TabIndex = 21;
            this.guna2CheckBox1.Text = "VIEW";
            this.guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox1.UncheckedState.BorderRadius = 2;
            this.guna2CheckBox1.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // guna2CheckBox2
            // 
            this.guna2CheckBox2.AutoSize = true;
            this.guna2CheckBox2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.guna2CheckBox2.CheckedState.BorderRadius = 2;
            this.guna2CheckBox2.CheckedState.BorderThickness = 0;
            this.guna2CheckBox2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.guna2CheckBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.guna2CheckBox2.Location = new System.Drawing.Point(214, 156);
            this.guna2CheckBox2.Name = "guna2CheckBox2";
            this.guna2CheckBox2.Size = new System.Drawing.Size(53, 20);
            this.guna2CheckBox2.TabIndex = 22;
            this.guna2CheckBox2.Text = "VIEW";
            this.guna2CheckBox2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox2.UncheckedState.BorderRadius = 2;
            this.guna2CheckBox2.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // startPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1094, 648);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.guna2Shapes1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.staffPanel);
            this.Controls.Add(this.managerPanel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "startPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VISTAINN - ADMIN";
            this.Resize += new System.EventHandler(this.startPage_Resize);
            this.staffPanel.ResumeLayout(false);
            this.staffPanel.PerformLayout();
            this.managerPanel.ResumeLayout(false);
            this.managerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void startPage_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                int Width = this.ClientSize.Width / 2;
                int Height = 800;

                staffPanel.Width = Width;
                staffPanel.Height = Height;
                managerPanel.Width = Width;
                managerPanel.Height = Height;

                int staffPanelLeft = (this.ClientSize.Width - staffPanel.Width) / 2;
                int managerPanelLeft = (this.ClientSize.Width - managerPanel.Width) / 2;

                int panelTop = this.ClientSize.Height - Height + 100;

                staffPanel.Location = new System.Drawing.Point(staffPanelLeft, panelTop);
                managerPanel.Location = new System.Drawing.Point(managerPanelLeft, panelTop);
            }
            else
            {
                staffPanel.Width = 327;
                staffPanel.Height = 374;
                managerPanel.Width = 327;
                managerPanel.Height = 374;

                staffPanel.Location = new System.Drawing.Point(384, 192);
                managerPanel.Location = new System.Drawing.Point(384, 192); // Slight offset for the manager panel
            }
        }


        #endregion
        private Guna.UI2.WinForms.Guna2Button staffLogInButton;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox staffEmailTextBox;
        private Guna.UI2.WinForms.Guna2TextBox staffPasswordTextBox;
        private Label label4;
        private Label label5;
        private LinkLabel managerLinkLabel;
        private LinkLabel staffForgotPasswordLabel;
        private Label label6;
        private Label label7;
        private LinkLabel managerForgotPasswordLinkLabel;
        private Guna.UI2.WinForms.Guna2Button manageLogInButton;
        private Label label8;
        private LinkLabel staffLinkLabel;
        private Guna.UI2.WinForms.Guna2TextBox managerEmailTextBox;
        private Label label9;
        private Guna.UI2.WinForms.Guna2TextBox managerPasswordTextBox;
        private Guna.UI2.WinForms.Guna2Panel staffPanel;
        private Label label10;
        private Guna.UI2.WinForms.Guna2Panel managerPanel;
        private Label label11;
        private Guna.UI2.WinForms.Guna2PictureBox logoPictureBox;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox2;
    }
}

