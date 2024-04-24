using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe_system
{
    public partial class dashboard : UserControl
    {
        string connectionString = "Server=tcp:cafesystem.database.windows.net,1433;Initial Catalog=cafe-system;Persist Security Info=False;User ID=cafesystem;Password=Mugandmufine$;MultipleActiveResultSets=False;Encrypt=True;";
        internal FormBorderStyle FormBorderStyle;
        public dashboard()
        {
            InitializeComponent();
        }

        public bool TopLevel { get; internal set; }

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
