using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 票务管理系统
{
    public partial class admin_user : Form
    {
        public admin_user()
        {
            InitializeComponent();
        }

        private void check_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            info INFO = new info();
            INFO.Show();
        }
    }
}
