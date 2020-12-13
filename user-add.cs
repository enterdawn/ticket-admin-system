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
    public partial class user_add : Form
    {
        private string uid;
        
        public user_add(string uid)
        {
            this.uid = uid;
            InitializeComponent();
            this.ttime.CustomFormat = "yyyy/MM/dd hh:mm:ss";
            
        }

        private void update_Click(object sender, EventArgs e)
        {
            SqlConnection db = new SqlConnection(Form1.connString);
            db.Open();
            SqlCommand comm = new SqlCommand();
            SqlCommand comm1 = new SqlCommand();
            string str1 = "select ticketID,_type,fnum,restNumber,company,placeOfDeparture,distination,startTime ,diachronic,_status,price from classTicket where ticketID={0}";
            str1=String.Format(str1, ticketid.Text);
            comm1.Connection = db;
            comm1.CommandText = str1;
            //MessageBox.Show(str1);
            SqlDataReader readert;
            readert = comm1.ExecuteReader();
            if (readert.Read()) {
                
            }
            else
            {
                MessageBox.Show("票号输入错误");
                return;
            }
            string str = "INSERT INTO ticket ( ticketID,userid,ticketype,flightNumber,butTime,price,seat,insertTime,varifyOrNot,refundOrnot ) VALUES ({0},{1},'{2}','{3}','{4}',{5},'{6}','{7}',{8},{9}); ";
            str=String.Format(str, ticketid.Text, uid, readert[1], readert[2], ttime.Value.ToString("yyyy/MM/dd HH:mm:ss"), tprice.Text, Tseat.Text,DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"),0,0);
            comm.CommandText = str;
            readert.Close();
            comm.Connection = db;
            //MessageBox.Show(str);
            comm.ExecuteReader();
            this.Close();
            MessageBox.Show("添加成功，刷新后查看");
        }
    }
}
