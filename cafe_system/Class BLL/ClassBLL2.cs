using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe_system.Class_BLL
{
    public class ClassBLL2
    {
        private string connectionString = (@"Server=tcp:cafesystem.database.windows.net,1433;Initial Catalog=cafe-system;Persist Security Info=False;User ID=cafesystem;Password=Mugandmufine$;MultipleActiveResultSets=False;Encrypt=True;");


        public int GetLatestOrderID()
        {
            int latestOrderID = 00;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MAX(OrderID) FROM Oder";

                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value && result != null)
                    {
                        latestOrderID = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error getting latest OrderID: {ex.Message}");
                }
            }

            return latestOrderID;
        }

        public int IncrementOrderID(int currentOrderID)
        {
           
                return currentOrderID + 1;
            
        }






        public void SaveOrder(DateTime orderDateTime, string productName , int quantity, decimal amount, int orderID )
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Oder(OrderID,OrderDate,Name,Quantity,Amount) " +
                               "VALUES (@OrderID,@OrderDate,@Name,@Quantity,@Amount)";

                SqlCommand command = new SqlCommand(query, connection);
                

                command.Parameters.AddWithValue("@OrderID", orderID);
                command.Parameters.AddWithValue("@OrderDate", orderDateTime);
                command.Parameters.AddWithValue("@Name", productName);
                command.Parameters.AddWithValue("@Quantity", quantity);
                command.Parameters.AddWithValue("@Amount", amount);

              

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                   Console.WriteLine($"Error saving order: {ex.Message}");
                }
            }
        }
    }
}
