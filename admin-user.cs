﻿using System;
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
        private string name;
        private string pwd;
        public admin_user(string Name,string Pwd)
        {
            InitializeComponent();
            name = Name;
            pwd = Pwd;
        }

        private void check_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            info INFO = new info(name,pwd);
            INFO.Show();
        }

        private void admin_user_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            modifyUserInfo v = new modifyUserInfo(name, pwd);
            v.Show();
        }

        private void admin_user_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            admin_password wd = new admin_password();
            wd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            modifyTicket _modifyTicket = new modifyTicket(name,pwd);
            _modifyTicket.Show();
        }
    }
}
