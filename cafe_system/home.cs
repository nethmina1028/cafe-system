using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
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

namespace cafe_system
{
    public partial class home : Form
    {
        private Timer hometimer;
        private string con1 = "Server=tcp:cafesystem.database.windows.net,1433;Initial Catalog=cafe-system;Persist Security Info=False;User ID=cafesystem;Password=Mugandmufine$;MultipleActiveResultSets=False;Encrypt=True;";


        public void SetUsername(string username)
        {
            lbl_username.Text = "" + username;
        }

        public home()
        { 
            InitializeComponent();
            sidepanel.Height = btn_home.Height;
            sidepanel.Top = btn_home.Top;

            dashboard dash = new dashboard();
            dash.TopLevel = false;
            dash.FormBorderStyle = FormBorderStyle.None;
            dash.Dock = DockStyle.Fill;

            panel_home.Controls.Clear(); // Clear existing controls from the panel
            panel_home.Controls.Add(dash); // Add the dashboard form to the panel

            // Show the dashboard form
            dash.Show();

            timer1 = new Timer();
            timer1.Interval = 1000; // Update every second (1000 milliseconds)
            timer1.Tick += Timer_Tick; // Attach event handler
            timer1.Start(); // Start the timer


            // Set initial value for the label
            UpdateLabel();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Update the label on every tick
            UpdateLabel();
        }

        private void UpdateLabel()
        {
            
            lbl_dateTime.Text = DateTime.Now.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            sidepanel.Height = btn_home.Height; // Side Panel of the home button 
            sidepanel.Top = btn_home.Top;

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
            sidepanel.Height = btn_menu.Height; // Side Panel of the menu button 
            sidepanel.Top = btn_menu.Top;

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
            sidepanel.Height = btn_inventory.Height; // Side Panel of the inventory button 
            sidepanel.Top = btn_inventory.Top;

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
            sidepanel.Height = btn_reports.Height; // Side Panel of the reports button 
            sidepanel.Top = btn_reports.Top;

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
            sidepanel.Height = btn_employee.Height; // Side Panel of the employee button 
            sidepanel.Top = btn_employee.Top;

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
            sidepanel.Height = btn_settings.Height; // Side Panel of the settings button 
            sidepanel.Top = btn_settings.Top;

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
            sidepanel.Height = btn_logout.Height; // Side Panel of the logout button 
            sidepanel.Top = btn_logout.Top;
        }


        private void home_Load(object sender, EventArgs e)
        {
            
        }
        

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
