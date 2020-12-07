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
                SqlCommand cmd0 = new SqlCommand();
                cmd0.CommandText = "select userid from _user where nickname=@nickmane;";
                SqlParameter[] paras =
                {
                    new SqlParameter("@nickmane",name),
                };
                cmd0.Parameters.AddRange(paras);
                SqlDataAdapter nickN = new SqlDataAdapter();//实例化sqldataadpter
                nickN.SelectCommand = cmd0;//设置为已实例化SqlDataAdapter的查询命令
                DataSet nick = new DataSet();//实例化dataset
                nickN.Fill(nick);//把数据填充到dataset
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText="select ticketID,butTime,price,seat,insertTime,varifyOrNot,flightNumber,refundOrnot from _user where nickname = @UID  and deleteOrNot=0;";
                SqlParameter[] paras2 =
                {
                    new SqlParameter("@UID",nick.Tables[0]),
                };
                cmd.Parameters.AddRange(paras2);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                //MessageBox.Show(ds.Tables[0].Rows)
                db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("未知错误\r\n" + ex.Message);
                Dispose();
            }
        }
    }
}
