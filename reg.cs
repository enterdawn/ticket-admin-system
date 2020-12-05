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
        private static string connString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =\"" + Environment.CurrentDirectory + "\\database.mdf\"; Integrated Security = False; Connect Timeout = 30";
        public static SqlConnection db = new SqlConnection(connString);
        private Form1 mainForm=new Form1();
        public reg(Form1 m)
        {
            InitializeComponent();
            mainForm = m;
        }


        private void reg_btn_Click(object sender, EventArgs e)
        {
            //密码与确认密码
            if (pwd.Text.ToString() != cofirmpwd.Text.ToString())
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
            if (pwd.Text == "")
            {
                MessageBox.Show("请输入密码");
                return;
            }
            if (cofirmpwd.Text == "")
            {
                MessageBox.Show("请再次输入密码");
                return;
            }
            if (mobile.Text == "")
            {
                MessageBox.Show("请输入手机号");
                return;
            }
            if (IDCardNumber.Text == "")
            {
                MessageBox.Show("请输入身份证号");
                return;
            }
            string op = "insert into _user(nickname,pwd,realName,sex,phoneNum,email,IDCardNumber,_status,_admin,regTime,active)"+
                "values('" + username.Text.ToString()+"','"+mainForm.getMdPwd(pwd.Text.ToString())+"','"+realname.Text.ToString()+"','"+
                sex.Text.ToString()+"','"+mobile.Text.ToString()+"','"+email.Text.ToString()+"','"+
                IDCardNumber.Text.ToString()+"','"+"1',1,'"+DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") +"',0);";
            SqlCommand command = new SqlCommand();
            try
            {
                db.Open();
                command.CommandText = op;
                command.Connection = db;
                command.ExecuteNonQuery();
                MessageBox.Show("注册成功");
                /*
                command.CommandText = "select * from _user;";
                MessageBox.Show(command.ExecuteScalar().ToString());
                */
                db.Close();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("注册失败\r\n" + ex.Message);
                db.Close();
                this.Close();
            }

        }

        private void reg_Load(object sender, EventArgs e)
        {

        }
    }
}
