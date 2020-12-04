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
        private static string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\database.mdf;Integrated Security=True";
        public static SqlConnection db = new SqlConnection(connString);
        public Form1()
        {
            try
            {
                db.Open();
                MessageBox.Show("数据库连接成功");
                SqlCommand command = new SqlCommand("select * from users", db);
                //MessageBox.Show(command.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库连接失败！" + ex.Message);
                System.Environment.Exit(0);
            }

            InitializeComponent();
        }
        private void login_Click(object sender, EventArgs e)
        {
            string user = username.Text;
            string pass = md532.getpass(password.Text);//使用md5对密码进行加密


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

        private void reg_Click(object sender, EventArgs e)
        {
            reg Reg = new reg(db);
            Reg.Show();
        }
    }
}
