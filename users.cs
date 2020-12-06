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
    public partial class users : Form
    {
        private string name;
        private string pwd;
        public users(string Name,string Pwd)
        {
            InitializeComponent();
            name = Name;
            pwd = Pwd;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void changeticket_Click(object sender, EventArgs e)
        {

        }

        private void changeuserinfo_Click(object sender, EventArgs e)
        {
            info INFO = new info(name,pwd);
            INFO.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
