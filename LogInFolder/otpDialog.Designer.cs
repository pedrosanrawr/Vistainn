namespace Vistainn
{
    partial class otpDialog
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
            this.otpTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.otpTextLabel = new System.Windows.Forms.Label();
            this.sendLinkLabel = new System.Windows.Forms.LinkLabel();
            this.submitButton = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // otpTextBox
            // 
            this.otpTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.otpTextBox.BackColor = System.Drawing.Color.Transparent;
            this.otpTextBox.BorderRadius = 15;
            this.otpTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.otpTextBox.DefaultText = "";
            this.otpTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.otpTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.otpTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.otpTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.otpTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.otpTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.otpTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.otpTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.otpTextBox.Location = new System.Drawing.Point(217, 249);
            this.otpTextBox.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.otpTextBox.Name = "otpTextBox";
            this.otpTextBox.PasswordChar = '\0';
            this.otpTextBox.PlaceholderText = "";
            this.otpTextBox.SelectedText = "";
            this.otpTextBox.Size = new System.Drawing.Size(204, 36);
            this.otpTextBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.label1.Location = new System.Drawing.Point(176, 53);
            this.label1.MaximumSize = new System.Drawing.Size(350, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 28);
            this.label1.TabIndex = 24;
            this.label1.Text = "VERIFY YOUR ACCOUNT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // otpTextLabel
            // 
            this.otpTextLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.otpTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.otpTextLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otpTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.otpTextLabel.Location = new System.Drawing.Point(61, 107);
            this.otpTextLabel.Name = "otpTextLabel";
            this.otpTextLabel.Size = new System.Drawing.Size(516, 24);
            this.otpTextLabel.TabIndex = 25;
            this.otpTextLabel.Text = "SEND CODE TO [EMAIL]";
            this.otpTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sendLinkLabel
            // 
            this.sendLinkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(144)))), ((int)(((byte)(36)))));
            this.sendLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sendLinkLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.sendLinkLabel.Location = new System.Drawing.Point(238, 161);
            this.sendLinkLabel.Name = "sendLinkLabel";
            this.sendLinkLabel.Size = new System.Drawing.Size(162, 18);
            this.sendLinkLabel.TabIndex = 26;
            this.sendLinkLabel.TabStop = true;
            this.sendLinkLabel.Text = "SEND CODE";
            this.sendLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sendLinkLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(144)))), ((int)(((byte)(36)))));
            this.sendLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sendLinkLabel_LinkClicked);
            // 
            // submitButton
            // 
            this.submitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.submitButton.BackColor = System.Drawing.Color.Transparent;
            this.submitButton.BorderColor = System.Drawing.Color.Transparent;
            this.submitButton.BorderRadius = 20;
            this.submitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.submitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.submitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.submitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.submitButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(144)))), ((int)(((byte)(36)))));
            this.submitButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.submitButton.Location = new System.Drawing.Point(229, 349);
            this.submitButton.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.submitButton.Name = "submitButton";
            this.submitButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.submitButton.Size = new System.Drawing.Size(180, 45);
            this.submitButton.TabIndex = 27;
            this.submitButton.Text = "SUBMIT";
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.label3.Location = new System.Drawing.Point(217, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "ENTER CODE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // otpDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(639, 476);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.sendLinkLabel);
            this.Controls.Add(this.otpTextLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.otpTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "otpDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "otpDialog";
            this.Load += new System.EventHandler(this.otpDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox otpTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label otpTextLabel;
        private System.Windows.Forms.LinkLabel sendLinkLabel;
        private Guna.UI2.WinForms.Guna2Button submitButton;
        private System.Windows.Forms.Label label3;
    }
}