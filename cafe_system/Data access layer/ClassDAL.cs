using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe_system.Data_access_layer
{
    internal class ClassDAL
    {


        public DataTable ReadItemsFromTable(string ResCity)
        {
            connection con1 = new connection();
            con1.conn.Open();

            string query = "SELECT * FROM inventory ";

            SqlCommand cmd = new SqlCommand(query, con1.conn);

            try
            {

                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }



        }





    }
}
