using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Vistainn
{
    public partial class managerDashboard : Form
    {
        //database instantiation
        Database database = new Database();

        public managerDashboard()
        {
            InitializeComponent();
            loadForm(new reportsForm());
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
        private void reportsButton_Click(object sender, EventArgs e)
        {
            loadForm(new reportsForm());

        }

        private void roomButton_Click(object sender, EventArgs e)
        {
            loadForm(new roomForm());
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            loadForm(new bookForm());
        }

        private void paymentButton_Click(object sender, EventArgs e)
        {
            loadForm(new paymentForm());
        }
    }

    // database class
    class Database
    {
        public string connectionString = "Server=192.168.100.13;Port=3306;Database=vistainn;Uid=your_user;Pwd=your_password;";
    }
}
