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
        private string uid;
        //private DateTime refundtime= new DateTime(1900, 1, 1, 0, 0, 0, 111);
        string refundtime = "";
        public users(string _Name,string Pwd)
        {
            
            InitializeComponent();
            label2.Text = _Name+"，您好";
            name = _Name;
            pwd = Pwd;
            ticketlist.Columns.Add("类型", 100, HorizontalAlignment.Left);
            ticketlist.Columns.Add("车次/航班号", 100, HorizontalAlignment.Left);
            ticketlist.Columns.Add("购买时间", 150, HorizontalAlignment.Left);
            ticketlist.Columns.Add("价格", 100, HorizontalAlignment.Left);
            ticketlist.Columns.Add("座位", 100, HorizontalAlignment.Left);
            ticketlist.Columns.Add("添加时间", 150, HorizontalAlignment.Left);
            ticketlist.Columns.Add("是否确认", 100, HorizontalAlignment.Left);
            ticketlist.Columns.Add("是否退票", 100, HorizontalAlignment.Left);
            try
            {
                db.Open();
                SqlCommand cmd0 = new SqlCommand();
                cmd0.CommandText = "select userid from _user where nickname='"+name+"'";
                /*
                SqlParameter[] paras =
                {
                    new SqlParameter("@nickmane",name),
                };
                cmd0.Parameters.AddRange(paras);

                */
                cmd0.Connection = db;
                SqlDataReader readeruser;
                //MessageBox.Show(cmd0.CommandText);
                readeruser = cmd0.ExecuteReader();
                readeruser.Read();

                uid = readeruser[0].ToString();
                SqlCommand cmd = new SqlCommand();
                readeruser.Close();
/*
                string str= String.Format("select ticketID,ticketype,flightNumber,butTime,price,seat,insertTime,varifyOrNot,refundOrnot from ticket where userid = {0}  and deleteOrNot=0;", uid);
                
                cmd.CommandText = str;  
                cmd.Connection = db;
                MessageBox.Show(cmd.CommandText);
                SqlDataReader reader = null;
                reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    string result = reader[0].ToString();
                    MessageBox.Show(result);
                }
                reader.Close();
*/
                db.Close();
                updatelist();
            }
            catch (Exception ex)
            {
                MessageBox.Show("未知错误\r\n" + ex.Message);
                Dispose();
            }
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

        public void updatelist()
        {
            ticketlist.Items.Clear();
            db.Open();
            SqlCommand cmd = new SqlCommand();
            string str = String.Format("select ticketID,ticketype,flightNumber,butTime,price,seat,insertTime,varifyOrNot,refundOrnot from ticket where userid = {0}  and deleteOrNot=0;", uid);
            cmd.CommandText = str;
            cmd.Connection = db;
            //MessageBox.Show(cmd.CommandText);
            SqlDataReader reader = null;
            reader = cmd.ExecuteReader();
            ticketlist.BeginUpdate();
            while (reader.Read())
            {
                ListViewItem swap = new ListViewItem();
                swap.Text = reader[1].ToString();
                swap.SubItems.Add(reader[2].ToString());
                swap.SubItems.Add(reader[3].ToString());
                swap.SubItems.Add(reader[4].ToString());
                swap.SubItems.Add(reader[5].ToString());
                swap.SubItems.Add(reader[6].ToString());
                if (reader[7].ToString() == "0")
                    swap.SubItems.Add("No");
                else
                    swap.SubItems.Add("Yes");
                if (reader[8].ToString() == "0")
                    swap.SubItems.Add("No");
                else
                    swap.SubItems.Add("Yes");

                ticketlist.Items.Add(swap);
                //string result = reader[0].ToString();
                //MessageBox.Show(result);
            }
            ticketlist.EndUpdate();
            reader.Close();
            db.Close();
        }

        private void users_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void ticketlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection c = ticketlist.SelectedIndices;
            refundtime = ticketlist.Items[c[0]].Text;
        }

        private void addticket_Click(object sender, EventArgs e)
        {
            user_add uadd = new user_add(uid);
            //ticketlist.Clear();
            //updatelist();
            uadd.Show();
            
        }

        private void update_Click(object sender, EventArgs e)
        {
            updatelist();
        }

        private void delticket_Click(object sender, EventArgs e)
        {
            db.Open();
            DateTime h = new DateTime(1900, 1, 1, 0, 0, 0, 111);
            MessageBox.Show(refundtime);
            //int n = DateTime.Compare(refundtime,h );
            //if (n<10) return;
            SqlCommand cmd = new SqlCommand();
            //MessageBox.Show(ticketlist.SelectedItems[1].SubItems[1].Text);
            string str = String.Format("update ticket set deleteOrNot=1  where userid = {0}  and butTime={1} ;", uid, refundtime);
            cmd.CommandText = str;
            cmd.Connection = db;
            MessageBox.Show(str);
            cmd.ExecuteReader();
            db.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user_publicinfo n = new user_publicinfo();
            n.Show();
        }
    }
    
    
}
