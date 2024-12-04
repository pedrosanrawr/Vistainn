using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using LiveCharts;
using LiveCharts.Wpf;
using System.Collections.Generic;
using System.Text;

namespace Vistainn
{
    public partial class reportsForm : Form
    {
        // database instance
        Database database = new Database();

        public reportsForm()
        {
            InitializeComponent();
        }
        
        // form - load
        private void reportsForm_Load(object sender, EventArgs e)
        {
            reportTypeComboBox.Items.Add("Occupancy Report");
            reportTypeComboBox.Items.Add("Revenue Report");
            reportTypeComboBox.SelectedIndex = 0;
        }

        // generate report button - clivk
        private void generateReportButton_Click(object sender, EventArgs e)
        {
 
            if (reportTypeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a report type.");
                return;
            }

            string reportType = reportTypeComboBox.SelectedItem.ToString();
            DateTime startDate = startDatePicker.Value;
            DateTime endDate = endDatePicker.Value;

            if (reportType == "Occupancy Report")
                GenerateOccupancyReport(startDate, endDate);
            else
                GenerateRevenueReport(startDate, endDate);
        }

        // generate occupancy report
        public void GenerateOccupancyReport(DateTime startDate, DateTime endDate)
        {
            string query = "SELECT RoomNo, COUNT(*) AS Bookings FROM booking WHERE CheckIn BETWEEN @StartDate AND @EndDate GROUP BY RoomNo";
            var dt = GetData(query, startDate, endDate);
            PopulateChart("Bookings", dt);
            reportDetailsTextBox.Text = $"Occupancy Report from {startDate.ToShortDateString()} to {endDate.ToShortDateString()} generated.";
        }

        // generate revebue report
        public void GenerateRevenueReport(DateTime startDate, DateTime endDate)
        {
            string query = "SELECT RoomNo, SUM(Amount) AS TotalRevenue " +
                "FROM payment p JOIN booking b ON p.BookingId = b.BookingId " +
                "WHERE b.CheckIn BETWEEN @StartDate AND @EndDate GROUP BY RoomNo";
            var dt = GetData(query, startDate, endDate);
            PopulateChart("Revenue", dt);
            reportDetailsTextBox.Text = $"Revenue Report from {startDate.ToShortDateString()} to {endDate.ToShortDateString()} generated.";
        }

        // get data - method
        private DataTable GetData(string query, DateTime startDate, DateTime endDate)
        {
            MySqlConnection con = new MySqlConnection(database.connectionString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@StartDate", startDate);
            cmd.Parameters.AddWithValue("@EndDate", endDate);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            return dt;
        }

        // populate chart - method
        public void PopulateChart(string seriesTitle, DataTable data)
        {
            chart.Series.Clear();
            chart.AxisX.Clear();
            chart.AxisY.Clear();

            var series = new ColumnSeries
            {
                Title = seriesTitle,
                Values = new ChartValues<double>(),
                Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(198, 144, 36)) // Color
            };

            var labels = new List<string>();
            foreach (DataRow row in data.Rows)
            {
                labels.Add(row["RoomNo"].ToString());
                series.Values.Add(Convert.ToDouble(row[seriesTitle == "Bookings" ? "Bookings" : "TotalRevenue"]));
            }

            chart.Series.Add(series);
            chart.AxisX.Add(new Axis { Labels = labels });
            chart.AxisY.Add(new Axis { Title = seriesTitle });
        }

        // refresh button - click
        private void refreshButton_Click(object sender, EventArgs e)
        {
            chart.Series.Clear();
            reportDetailsTextBox.Text = "Report cleared. Select a report type and date range to regenerate.";
        }

    }
}