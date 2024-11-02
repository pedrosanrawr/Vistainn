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
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportsButton = new System.Windows.Forms.Button();
            this.paymentButton = new System.Windows.Forms.Button();
            this.bookButton = new System.Windows.Forms.Button();
            this.customerButton = new System.Windows.Forms.Button();
            this.roomButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.reportsButton);
            this.panel1.Controls.Add(this.paymentButton);
            this.panel1.Controls.Add(this.bookButton);
            this.panel1.Controls.Add(this.customerButton);
            this.panel1.Controls.Add(this.roomButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1097, 134);
            this.panel1.TabIndex = 0;
            // 
            // reportsButton
            // 
            this.reportsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsButton.Location = new System.Drawing.Point(0, 86);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.Size = new System.Drawing.Size(146, 44);
            this.reportsButton.TabIndex = 7;
            this.reportsButton.Text = "REPORTS";
            this.reportsButton.UseVisualStyleBackColor = true;
            this.reportsButton.Click += new System.EventHandler(this.reportsButton_Click);
            // 
            // paymentButton
            // 
            this.paymentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentButton.Location = new System.Drawing.Point(608, 86);
            this.paymentButton.Name = "paymentButton";
            this.paymentButton.Size = new System.Drawing.Size(146, 44);
            this.paymentButton.TabIndex = 6;
            this.paymentButton.Text = "PAYMENT";
            this.paymentButton.UseVisualStyleBackColor = true;
            this.paymentButton.Click += new System.EventHandler(this.paymentButton_Click);
            // 
            // bookButton
            // 
            this.bookButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookButton.Location = new System.Drawing.Point(456, 86);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(146, 44);
            this.bookButton.TabIndex = 5;
            this.bookButton.Text = "BOOK";
            this.bookButton.UseVisualStyleBackColor = true;
            this.bookButton.Click += new System.EventHandler(this.bookButton_Click);
            // 
            // customerButton
            // 
            this.customerButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerButton.Location = new System.Drawing.Point(304, 86);
            this.customerButton.Name = "customerButton";
            this.customerButton.Size = new System.Drawing.Size(146, 44);
            this.customerButton.TabIndex = 4;
            this.customerButton.Text = "CUSTOMER";
            this.customerButton.UseVisualStyleBackColor = true;
            this.customerButton.Click += new System.EventHandler(this.customerButton_Click);
            // 
            // roomButton
            // 
            this.roomButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomButton.Location = new System.Drawing.Point(152, 86);
            this.roomButton.Name = "roomButton";
            this.roomButton.Size = new System.Drawing.Size(146, 44);
            this.roomButton.TabIndex = 3;
            this.roomButton.Text = "ROOM";
            this.roomButton.UseVisualStyleBackColor = true;
            this.roomButton.Click += new System.EventHandler(this.roomButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "DASHBOARD";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(0, 134);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1095, 517);
            this.mainPanel.TabIndex = 8;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 648);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VISTAINN";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button reportsButton;
        private System.Windows.Forms.Button paymentButton;
        private System.Windows.Forms.Button bookButton;
        private System.Windows.Forms.Button customerButton;
        private System.Windows.Forms.Button roomButton;
        private System.Windows.Forms.Panel mainPanel;
    }
}