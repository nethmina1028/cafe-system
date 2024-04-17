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


            dashboard dash = new dashboard();
            dash.TopLevel = false;
            dash.FormBorderStyle = FormBorderStyle.None;
            dash.Dock = DockStyle.Fill;

            panel_home.Controls.Clear(); // Clear existing controls from the panel
            panel_home.Controls.Add(dash); // Add the dashboard form to the panel

            // Show the dashboard form
            dash.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            dashboard dash = new dashboard();
            dash.TopLevel = false;
            dash.FormBorderStyle = FormBorderStyle.None;
            dash.Dock = DockStyle.Fill;

            panel_home.Controls.Clear(); // Clear existing controls from the panel
            panel_home.Controls.Add(dash); // Add the dashboard form to the panel

            // Show the dashboard form
            dash.Show();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            menu men = new menu();
            men.TopLevel = false;
            men.FormBorderStyle = FormBorderStyle.None;
            men.Dock = DockStyle.Fill;

            panel_home.Controls.Clear(); 
            panel_home.Controls.Add(men); 

           
            men.Show();
        }

        private void btn_inventory_Click(object sender, EventArgs e)
        {
            inventory invent = new inventory();
            invent.TopLevel = false;
            invent.FormBorderStyle = FormBorderStyle.None;
            invent.Dock = DockStyle.Fill;

            panel_home.Controls.Clear();
            panel_home.Controls.Add(invent);


            invent.Show();
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            reports rep = new reports();
            rep.TopLevel = false;
            rep.FormBorderStyle = FormBorderStyle.None;
            rep.Dock = DockStyle.Fill;

            panel_home.Controls.Clear();
            panel_home.Controls.Add(rep);


            rep.Show();
        }

        private void btn_empoyee_Click(object sender, EventArgs e)
        {
            employee emp = new employee();
            emp.TopLevel = false;
            emp.FormBorderStyle = FormBorderStyle.None;
            emp.Dock = DockStyle.Fill;

            panel_home.Controls.Clear();
            panel_home.Controls.Add(emp);


            emp.Show();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            settings set = new settings();
            set.TopLevel = false;
            set.FormBorderStyle = FormBorderStyle.None;
            set.Dock = DockStyle.Fill;

            panel_home.Controls.Clear();
            panel_home.Controls.Add(set);


            set.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            
        }
    }
}
