using System;
using System.Data;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Drawing;
using System.IO;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using LiveCharts.WinForms;
using LiveCharts.Definitions.Charts;



namespace Vistainn
{
    public partial class reportsForm : Form
    {
        Database database = new MySqlDatabase();

        public reportsForm()
        {
            InitializeComponent();
        }

        //load reports form
        private void reportsForm_Load(object sender, EventArgs e)
        {
            startDatePicker.Value = DateTime.Now.AddDays(-60);
            endDatePicker.Value = DateTime.Now.AddDays(60);

            GenerateOccupancyReport(startDatePicker.Value, endDatePicker.Value);
        }

        //generate report button - click
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

        //generate occupancy report - click
        public void GenerateOccupancyReport(DateTime startDate, DateTime endDate)
        {
            string query = "SELECT RoomNo, COUNT(*) AS Bookings FROM booking WHERE CheckIn BETWEEN @StartDate AND @EndDate GROUP BY RoomNo";
            var dt = GetData(query, startDate, endDate);
            PopulateChart("Bookings", dt);
            reportDetailsTextBox.Text = $"Occupancy Report from {startDate.ToShortDateString()} to {endDate.ToShortDateString()} generated.";
        }

        //generate revenue report - method
        public void GenerateRevenueReport(DateTime startDate, DateTime endDate)
        {
            string query = "SELECT RoomNo, SUM(Amount) AS TotalRevenue " +
                "FROM payment p JOIN booking b ON p.BookingId = b.BookingId " +
                "WHERE b.CheckIn BETWEEN @StartDate AND @EndDate GROUP BY RoomNo";
            var dt = GetData(query, startDate, endDate);
            PopulateChart("Revenue", dt);
            reportDetailsTextBox.Text = $"Revenue Report from {startDate.ToShortDateString()} to {endDate.ToShortDateString()} generated.";
        }

        //get data - method
        private DataTable GetData(string query, DateTime startDate, DateTime endDate)
        {
            var parameters = new Dictionary<string, object>
            {
                { "@StartDate", startDate },
                { "@EndDate", endDate }
            };

            using (var reader = database.ExecuteReader(query, parameters))
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                return dt;
            }
        }

        //populate chart - method
        public void PopulateChart(string seriesTitle, DataTable data)
        {
            chart.Series.Clear();
            chart.AxisX.Clear();
            chart.AxisY.Clear();

            var series = new ColumnSeries
            {
                Title = seriesTitle,
                Values = new ChartValues<double>(),
                Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(198, 144, 36))
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

        //refresh button - click
        private void refreshButton_Click(object sender, EventArgs e)
        {
            chart.Series.Clear();
            reportDetailsTextBox.Text = "Report cleared. Select a report type and date range to regenerate.";
        }

        //link label - click
        private void pdfLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (chart.Series.Count > 0)
            {
                string reportType = reportTypeComboBox.SelectedItem?.ToString();
                string reportSummary = "";

                if (reportType == "Occupancy Report")
                {
                    reportSummary = "This chart shows occupancy trends over the selected period.";
                }
                else if (reportType == "Revenue Report")
                {
                    reportSummary = "This chart shows revenue trends over the selected period.";
                }
                else
                {
                    MessageBox.Show("Invalid report type selected.");
                    return;
                }

                ExportChartToPdf(
                    chart,
                    "chart_output",
                    reportType,
                    reportSummary,
                    startDatePicker.Value,
                    endDatePicker.Value
                );
            }
            else
            {
                MessageBox.Show("No data available to export.");
            }
        }

        //export to pdf - method
        public void ExportChartToPdf(LiveCharts.WinForms.CartesianChart cartesianChart, string fileName, string reportType, string reportSummary, DateTime startDate, DateTime endDate)
        {
            double highestValue = 0;
            double lowestValue = double.MaxValue;
            double totalValue = 0;
            string highestRoom = "";
            string lowestRoom = "";

            if (cartesianChart.Series.Count > 0)
            {
                var series = cartesianChart.Series[0] as ColumnSeries;
                if (series != null && series.Values.Count > 0)
                {
                    for (int i = 0; i < series.Values.Count; i++)
                    {
                        double value = Convert.ToDouble(series.Values[i]);
                        totalValue += value;

                        if (value > highestValue)
                        {
                            highestValue = value;
                            highestRoom = cartesianChart.AxisX[0].Labels[i];
                        }

                        if (value < lowestValue)
                        {
                            lowestValue = value;
                            lowestRoom = cartesianChart.AxisX[0].Labels[i];
                        }
                    }
                }
            }

            string downloadsFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads\";
            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string pdfFilePath = Path.Combine(downloadsFolderPath, $"{fileName}_{timestamp}.pdf");

            using (FileStream fs = new FileStream(pdfFilePath, FileMode.Create))
            {
                Document document = new Document(PageSize.A4, 36, 36, 72, 72);
                PdfWriter.GetInstance(document, fs);

                document.Open();

                Paragraph reportDetails = new Paragraph(
                    $"Report Type: {reportType}\n" +
                    $"Report Date: {DateTime.Now:yyyy-MM-dd}\n" +
                    $"Date Range: {startDate.ToShortDateString()} - {endDate.ToShortDateString()}\n\n",
                    FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14));
                document.Add(reportDetails);

                Bitmap bitmap = new Bitmap(cartesianChart.Width, cartesianChart.Height);
                cartesianChart.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, cartesianChart.Width, cartesianChart.Height));
                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(bitmap, ImageFormat.Png);

                img.ScaleToFit(document.PageSize.Width - 72, document.PageSize.Height - 72);
                img.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
                document.Add(img);

                Paragraph summary = new Paragraph(
                    $"{reportSummary}\n\n" +
                    $"Total {reportType}: {totalValue:F2}\n" +
                    $"Highest {reportType}: {highestValue:F2} (Room: {highestRoom})\n" +
                    $"Lowest {reportType}: {lowestValue:F2} (Room: {lowestRoom})",
                    FontFactory.GetFont(FontFactory.HELVETICA, 12));
                summary.SpacingBefore = 20;
                document.Add(summary);

                document.Close();
            }

            MessageBox.Show($"Chart exported to PDF successfully at {pdfFilePath}");
        }
    }
}