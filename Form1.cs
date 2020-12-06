using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace 票务管理系统
{

    public partial class Form1 : Form
    {
        private static string connString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =\"" + Environment.CurrentDirectory + "\\database.mdf\"; Integrated Security = False; Connect Timeout = 30";
        private SqlConnection db = new SqlConnection(connString);
        public Form1()
        {
            InitializeComponent();
        }
        private void login_Click(object sender, EventArgs e)
        {
            string name = username.Text;
            string pwd = md532.getpass(password.Text.ToString());//使用md5对密码进行加密
            SqlCommand cmd = new SqlCommand("select * from _user where nickname = " + name);
            cmd.Connection = db;
            try
            {
                db.Open();
                cmd.CommandText = "select * from _user where nickname = '" + name + "' and pwd = '" + pwd + "'";
                SqlDataAdapter da = new SqlDataAdapter();//实例化sqldataadpter
                da.SelectCommand = cmd;//设置为已实例化SqlDataAdapter的查询命令
                DataSet ds = new DataSet();//实例化dataset
                da.Fill(ds);//把数据填充到dataset
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("用户名或密码错误");
                    return;
                }
                if (ds.Tables[0].Rows[0]["_admin"].ToString() == "0")
                {
                    users user = new users(name,pwd);
                    user.Show();
                }
                else
                {
                    admin_user adu = new admin_user(name,pwd);
                    adu.Show();
                }
                db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("登陆失败\r\n" + ex.Message);
                Dispose();
                db.Close();
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        public class md532
        {
            public static string getpass(string pass)
            {
                string cl = pass;
                string pwd = "";
                MD5 md5 = MD5.Create(); //实例化一个md5对像
                                        // 加密后是一个字节类型的数组，这里要注意编码UTF8/Unicode等的选择　
                byte[] s = md5.ComputeHash(Encoding.UTF8.GetBytes(cl));
                // 通过使用循环，将字节类型的数组转换为字符串，此字符串是常规字符格式化所得
                for (int i = 0; i < s.Length; i++)
                {
                    // 将得到的字符串使用十六进制类型格式。格式后的字符是小写的字母，如果使用大写（X）则格式后的字符是大写字符 
                    pwd = pwd + s[i].ToString("X");
                }
                return pwd;
            }
        }
        public string getMdPwd(string s)
        {
            return md532.getpass(s);
        }

        private void reg_Click(object sender, EventArgs e)
        {
            reg Reg = new reg(this);
            Reg.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

