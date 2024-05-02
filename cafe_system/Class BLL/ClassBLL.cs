using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cafe_system.Data_access_layer;

namespace cafe_system.Class_BLL
{
    internal class ClassBLL
    {
        public DataTable GetItems(string ResCity)
        {
            try
            {
                ClassDAL objDAL = new ClassDAL();
                return objDAL.ReadItemsFromTable(ResCity);

            }
            catch (Exception)
            {

                throw;
            }
        }

      

      
    }
}
