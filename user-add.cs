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
    public partial class user_add : Form
    {
        private string uid;

        public user_add(string uid)
        {
            this.uid = uid;
            InitializeComponent();
            this.ttime.CustomFormat = "yyyy/MM/dd hh:mm:ss";
            
        }

        private void update_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
