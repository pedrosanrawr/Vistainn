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
using Vistainn.Staff;


namespace Vistainn
{
    public partial class startPage : Form
    {
        public startPage()
        {
            InitializeComponent();

        }

        //staff button - click
        private void staffButton_Click(object sender, EventArgs e)
        {
            StaffDashboard staffDashboard = new StaffDashboard();
            staffDashboard.Show();
            this.Hide();
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
            ManagerDashboard managerDashboard = new ManagerDashboard();
            managerDashboard.Show();
            this.Hide();
        }
    }
}


