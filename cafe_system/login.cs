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

            // change place holder text size in here
            txt_user.Font = new Font(txt_user.Font.FontFamily, 12, FontStyle.Regular);

            txt_password.Font = new Font(txt_password.Font.FontFamily, 12,FontStyle.Regular);
        }




        private void close_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
    }
}
