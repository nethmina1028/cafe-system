using Guna.UI2.WinForms;
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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            dashboard fm = new dashboard();
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;

            panel_home.Controls.Clear(); // Clear existing controls from the panel
            panel_home.Controls.Add(fm); // Add the dashboard form to the panel

            // Show the dashboard form
            fm.Show();
        }
    }
}
