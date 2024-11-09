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

        private void booknowButton_Click(object sender, EventArgs e)
        {
            if (hotelEmailTextBox.Text == "0" && hotelPasswordTextBox.Text == "0")
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Email or Password");
            }
        }
    }
}

