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
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            smallbar.Width += 3;

            if (smallbar.Width >= 599)
            {
                timer1.Stop();
                home dashboard = new home();
                dashboard.Show();
                this.Hide();
            }
        }

        private void close_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
    }
}
