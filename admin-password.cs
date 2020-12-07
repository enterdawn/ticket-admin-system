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
    public partial class admin_password : Form
    {
        public admin_password()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =\"" + Environment.CurrentDirectory + "\\database.mdf\"; Integrated Security = False; Connect Timeout = 30";
            SqlConnection db = new SqlConnection(connString);
            db.Open();
            try
            {
                string mp = textBox2.Text;
                Form1 v=new Form1();
                string pass = "update _user set pwd='"
                                  + Form1.getMdPwd(mp)
                                  + "' where nickname='"
                                  + textBox1.Text+"';";
                
                SqlCommand cmd = new SqlCommand(pass,db);
                cmd.ExecuteNonQuery();
                MessageBox.Show("修改成功");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("没有这个用户");
            }
            

    }
    }
}
