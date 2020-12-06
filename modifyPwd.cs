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
    public partial class modifyPwd : Form
    {
        private static string connString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =\"" + Environment.CurrentDirectory + "\\database.mdf\"; Integrated Security = False; Connect Timeout = 30";
        private SqlConnection db = new SqlConnection(connString);
        private string Name;
        private string Pwd;
        public modifyPwd(string name,string pwd)
        {
            InitializeComponent();
            Name = name;
            Pwd = pwd;
        }

        private void modifyPwd_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 v = new Form1();
            string oldPwd = v.getMdPwd(textBox1.Text.ToString());
            if (oldPwd != Pwd)
            {
                MessageBox.Show("旧密码错误");
                return;
            }
            string newPwd = textBox2.Text.ToString();
            string comPwd = textBox3.Text.ToString();
            if (newPwd != comPwd)
            {
                MessageBox.Show("两次输入的密码不一致");
                return;
            }
            try
            {
                db.Open();
                SqlCommand cmd = new SqlCommand("update _user set pwd = '"+v.getMdPwd(newPwd)+"' where nickname = '"+Name+"';", db);
                cmd.ExecuteNonQuery();
                db.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("修改失败\r\n" + ex.Message);
                db.Close();
                this.Dispose();
            }
            MessageBox.Show("密码修改成功!");
            this.Close();
        }
    }
}
