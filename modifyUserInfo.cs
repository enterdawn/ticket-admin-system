﻿using System;
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
    public partial class modifyUserInfo : Form
    {
        private string Name;
        private string Pwd;
        private static string connString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =\"" + Environment.CurrentDirectory + "\\database.mdf\"; Integrated Security = False; Connect Timeout = 30";
        private SqlConnection db = new SqlConnection(connString);
        public modifyUserInfo(string name,string pwd)
        {
            InitializeComponent();
            Name = name;
            Pwd = pwd;
            init();
        }
        private void init()
        {
            try
            {
                db.Open();
                SqlCommand cmd = new SqlCommand("select nickname as '用户名',IDCardNumber as '身份证号码',_admin as '管理员权限',_status as '管理员权限',regTime as '注册时间',active as '活跃度',sex as '性别',phoneNum as '手机号码',email as '电子邮箱' from _user where _admin = '0';", db);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                db.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("未知错误\r\n"+ex.Message);
                Dispose();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void modifyUserInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
