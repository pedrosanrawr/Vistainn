using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistainn.Staff
{
    public partial class StaffDashboard : Form
    {
        public StaffDashboard()
        {
            InitializeComponent();
            loadForm(new roomForm());
        }

        //loadForm
        public void loadForm(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.Clear();
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }

        //buttons
        private void roomButton_Click(object sender, EventArgs e)
        {
            loadForm(new roomForm());
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            loadForm(new bookFormm());
        }

        private void paymentButton_Click(object sender, EventArgs e)
        {
            loadForm(new paymentForm());
        }

        private void aoProfileButton_Click(object sender, EventArgs e)
        {
            loadForm(new AddOnsForm());
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            loadForm(new staffProfile());
        }
    }
}
