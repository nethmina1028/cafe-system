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
   
    public partial class inventory : UserControl
    {

        internal FormBorderStyle FormBorderStyle;

        public inventory()
        {
            InitializeComponent();
        }
        public bool TopLevel { get; internal set; }
    }

}
