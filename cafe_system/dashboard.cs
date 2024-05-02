using Guna.UI2.WinForms;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace cafe_system
{
    public partial class dashboard : UserControl
    {
        string connectionString = "Server=tcp:cafesystem.database.windows.net,1433;Initial Catalog=cafe-system;Persist Security Info=False;User ID=cafesystem;Password=Mugandmufine$;MultipleActiveResultSets=False;Encrypt=True;";
        internal FormBorderStyle FormBorderStyle;
        public dashboard()
        {
            InitializeComponent();
            DailyTotalIncome();
            TotalOrders();
            TotalItems();
            TotalIncome();
            DisplayTopSellingProducts();
            PopulateChart();
        }

        //Display the daily income 
        private void DailyTotalIncome()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT SUM(Amount) AS TotalIncome FROM Oder WHERE OrderDate = @TodayDate";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TodayDate", DateTime.Today);
            connection.Open();
            object result = command.ExecuteScalar();
            connection.Close();

            decimal totalIncome = result == DBNull.Value ? 0 : Convert.ToDecimal(result);
            lblDTotalIncome.Text = "" + totalIncome;
        }

        //Display Total orders
        private void TotalOrders()
        {
           

            // Query to retrieve distinct orders for the current day
            string query = "SELECT COUNT(DISTINCT OrderId) FROM Oder WHERE OrderDate >= @StartDate AND OrderDate < @EndDate";

            // Current date
            DateTime currentDate = DateTime.Today;
            DateTime startDate = currentDate.Date;
            DateTime endDate = startDate.AddDays(1);

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@StartDate", startDate);
                        command.Parameters.AddWithValue("@EndDate", endDate);

                        // Execute the command and get the total orders
                        int totalOrders = (int)command.ExecuteScalar();

                        // Update the label text with the total orders
                        guna2HtmlLabel1.Text = "" + totalOrders.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        //Display Total Items
        private void TotalItems()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                string query = "SELECT SUM(Quantity) AS TotalItems FROM Oder WHERE OrderDate = @TodayDate";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TodayDate", DateTime.Today);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    int TotalItems = (int)reader["TotalItems"];
                    lblTotalItems.Text = $"{TotalItems}";
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }

         //Display Total Income
        private void TotalIncome()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT SUM(Amount) AS total_sum FROM Oder WHERE OrderDate >= @CafeStartDate";
            SqlCommand command = new SqlCommand(query, connection);
            DateTime cafeStartDate = new DateTime(2024, 4, 30);
            command.Parameters.AddWithValue("@CafeStartDate", cafeStartDate);
            connection.Open();
            object result = command.ExecuteScalar();
            connection.Close();

            decimal totalIncome = result == DBNull.Value ? 0 : Convert.ToDecimal(result);
            lblTotalIncome.Text = $"{totalIncome}";
        }

        //Display Daily Total Income by a chart

        private void PopulateChart()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                
                string query = "SELECT OrderDate, SUM(Amount) AS DailyIncome " +
                               "FROM [Oder] " +
                               "GROUP BY OrderDate " +
                               "ORDER BY OrderDate";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                
                chart1.Series.Clear();

                
                Series series = new Series();
                series.ChartType = SeriesChartType.Spline; 
                series.Name = "Series1";
                chart1.Series.Add(series);

                
                while (reader.Read())
                {
                    DateTime orderDate = Convert.ToDateTime(reader["OrderDate"]);
                    double dailyIncome = Convert.ToDouble(reader["DailyIncome"]);

                    
                    series.Points.AddXY(orderDate, dailyIncome);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }

        }


        private void DisplayTopSellingProducts()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                string query = "SELECT TOP 5 o.Name, SUM(o.Quantity) AS TotalQuantity, i.Stock " +
                               "FROM [Oder] o " +
                               "INNER JOIN inventory i ON o.Name = i.Name " +
                               "WHERE o.OrderDate = @TodayDate " +
                               "GROUP BY o.Name, i.Stock " +
                               "ORDER BY TotalQuantity DESC";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TodayDate", DateTime.Today);
                SqlDataReader reader = command.ExecuteReader();

                int rank = 1;

                while (reader.Read() && rank <= 5)
                {
                    string productName = reader["Name"].ToString();
                    int totalQuantity = Convert.ToInt32(reader["TotalQuantity"]);
                    int maxStock = Convert.ToInt32(reader["Stock"]);

                    switch (rank)
                    {
                        case 1:
                            guna2ProgressBar1.Maximum = maxStock;
                            guna2ProgressBar1.Value = totalQuantity;
                            guna2TextBox1.Text = productName;
                            guna2TextBox2.Text = $"{totalQuantity}";
                            break;
                        case 2:
                            guna2ProgressBar2.Maximum = maxStock;
                            guna2ProgressBar2.Value = totalQuantity;
                            guna2TextBox8.Text = productName;
                            guna2TextBox3.Text = $"{totalQuantity}";
                            break;
                        case 3:
                            guna2ProgressBar3.Maximum = maxStock;
                            guna2ProgressBar3.Value = totalQuantity;
                            guna2TextBox9.Text = productName;
                            guna2TextBox4.Text = $"{totalQuantity}";
                            break;
                        case 4:
                            guna2ProgressBar4.Maximum = maxStock;
                            guna2ProgressBar4.Value = totalQuantity;
                            guna2TextBox10.Text = productName;
                            guna2TextBox6.Text = $"{totalQuantity}";
                            break;
                        case 5:
                            guna2ProgressBar5.Maximum = maxStock;
                            guna2ProgressBar5.Value = totalQuantity;
                            guna2TextBox11.Text = productName;
                            guna2TextBox7.Text = $"{totalQuantity}";
                            break;
                    }

                    rank++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }

        public bool TopLevel { get; internal set; }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }
        private void guna2Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDTotalOrders_Click(object sender, EventArgs e)
        {

        }

        private void ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ProgressBar2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
