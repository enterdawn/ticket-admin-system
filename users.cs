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
    public partial class users : Form
    {
        public static string connString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =\"" + Environment.CurrentDirectory + "\\database.mdf\"; Integrated Security = False; Connect Timeout = 30";
        public SqlConnection db = new SqlConnection(connString);
        private string name;
        private string pwd;
        public users(string _Name,string Pwd)
        {
            
            InitializeComponent();
            label2.Text = _Name+"您好";
            name = _Name;
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

 

        private void users_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                db.Open();
               // SqlCommand cmd = new SqlCommand("select nickname,IDCardNumber,_admin,_status,regTime,active,sex,phoneNum,email from _user where _admin = '0';", db);
              //  SqlDataAdapter da = new SqlDataAdapter();
              //  da.SelectCommand = cmd;
              //  DataSet ds = new DataSet();
              //  da.Fill(ds);
              //  //MessageBox.Show(ds.Tables[0].Rows)
              //  db.Close();
            }
            catch (Exception ex)
            {
              //  MessageBox.Show("未知错误\r\n" + ex.Message);
              //  Dispose();
            }
        }
    }
}
