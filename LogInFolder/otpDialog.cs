using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Vistainn
{
    public partial class otpDialog : Form
    {
        private string generatedOtp;
        private string userEmail;
        private bool isManager;

        public otpDialog(string email, bool isManager)
        {
            InitializeComponent();
            userEmail = email;
            this.isManager = isManager;
        }

        private void otpDialog_Load(object sender, EventArgs e)
        {
            otpTextLabel.Text = $"SEND A CODE TO {userEmail}";
            sendLinkLabel.Text = "SEND OTP";
        }

        private void sendLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Generate and send OTP if it's not already generated or resend it if it has been
            generatedOtp = GenerateOtp();
            SendOtpToEmail(userEmail, generatedOtp);

            MessageBox.Show(generatedOtp == null ? "OTP has been sent to your email." : "OTP has been resent to your email.");
            sendLinkLabel.Text = "RESEND OTP";
        }

        private string GenerateOtp()
        {
            Random rand = new Random();
            return rand.Next(100000, 999999).ToString();
        }

        private void SendOtpToEmail(string email, string otp)
        {
            try
            {
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("vistainnmanager0@gmail.com", "fvbgsccnrznaesxf"),
                    EnableSsl = true,
                };

                smtpClient.Send("vistainnmanager0@gmail.com", email, "Your OTP Code", $"Your OTP code is {otp}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send OTP: {ex.Message}");
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string otp = otpTextBox.Text;

            if (string.IsNullOrWhiteSpace(otp))
            {
                MessageBox.Show("Please enter the OTP.");
                return;
            }

            if (VerifyOtp(otp))
            {
                var changePasswordDialog = new changePasswordDialog(userEmail, isManager);
                changePasswordDialog.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid OTP. Please try again.");
            }
        }

        private bool VerifyOtp(string enteredOtp)
        {
            return enteredOtp == generatedOtp;
        }
    }
}