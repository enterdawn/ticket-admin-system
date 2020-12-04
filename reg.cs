using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 票务管理系统
{
    public partial class reg : Form
    {
        private static SqlConnection db = new SqlConnection();
        public reg(SqlConnection DB)
        {
            InitializeComponent();
            db = DB;
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            //密码与确认密码
            if (password.Text.ToString() != cofirmpassword.Text.ToString())
            {
                MessageBox.Show("两次输入的密码不一致");
                return;
            }
            //必填项...
            if (username.Text == "")
            {
                MessageBox.Show("请输入用户名");
                return;
            }
            if (password.Text == "")
            {
                MessageBox.Show("请输入密码");
                return;
            }
            if (cofirmpassword.Text == "")
            {
                MessageBox.Show("请再次输入密码");
                return;
            }
            if (mobile.Text == "")
            {
                MessageBox.Show("请输入手机号");
                return;
            }
            if (IDnumber.Text == "")
            {
                MessageBox.Show("请输入身份证号");
                return;
            }
            SqlCommand command = new SqlCommand("insert into ",db);
        }
    }
}
