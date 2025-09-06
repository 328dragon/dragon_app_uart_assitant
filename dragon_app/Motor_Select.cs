using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dragon_app
{
    public partial class Motor_Select : Form
    {
        public Motor_Select()
        {
            InitializeComponent();
        }

        private void Motor_control_closed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }


    }
}
