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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void close_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
    }
}
