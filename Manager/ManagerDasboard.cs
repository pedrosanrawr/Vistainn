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
    public partial class ManagerDashboard : Form
    {
        //database instantiation
        Database database = new Database();

        public ManagerDashboard()
        {
            InitializeComponent();
            loadForm(new MReportsForm());
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
            loadForm(new MReportsForm());

        }

        private void roomButton_Click(object sender, EventArgs e)
        {
            loadForm(new MRoomForm());
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            loadForm(new MBookForm());
        }

        private void paymentButton_Click(object sender, EventArgs e)
        {
            loadForm(new MPaymentForm());
        }
    }

    // database class
    class Database
    {
        public string connectionString = "Server=localhost;Database=vistainn; Uid=root; Pwd=;";
    }
}
