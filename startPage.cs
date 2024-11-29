using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Vistainn
{
    public partial class startPage : Form
    {
        public startPage()
        {
            InitializeComponent();

        }

        //book now button - click
        private void booknowButton_Click(object sender, EventArgs e)
        {
            //if (hotelEmailTextBox.Text == "vistainn@email.com" && hotelPasswordTextBox.Text == "12345678")
           // {
                managerDashboard dashboard = new managerDashboard();
                dashboard.Show();
                this.Hide();
          //  }
          //  else
          //  {
           //     MessageBox.Show("Incorrect Email or Password");
           // }
        }

        private void managerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            managerPanel.Show();
            staffPanel.Hide();
        }

        private void staffLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            staffPanel.Show();
            managerPanel.Hide();
        }

        private void manageLogInButton_Click(object sender, EventArgs e)
        {
            managerDashboard managerDashboard = new managerDashboard();
            managerDashboard.Show();
            this.Hide();
        }
    }
}


