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
                MessageBox.Show(command.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库连接失败！" + ex.Message);
            }

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
