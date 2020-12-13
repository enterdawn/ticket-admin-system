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
            SqlCommand comm = null;
            SqlCommand comm1 = null;
            string str1 = "select ticketID,_type,restNumber,company,placeOfDeparture,distination,startTime ,diachronic,_status,price from classTicket where ticketID= '{0}';";
            String.Format(str1, ticketid.Text);
            comm1.CommandText = str1;
            comm1.Connection = db;
            SqlDataReader readert;
            readert = comm1.ExecuteReader();
            if (!readert.Read()) {
                MessageBox.Show("票号输入错误");
                return;
            }
            string str = "INSERT INTO ticket ( ticketID,ticketype,flightNumber,butTime,price,seat,insertTime,varifyOrNot,refundOrnot ) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}'); ";
            //String.Format(str, ticketid.Text, readert[1].ToString, readert[1].ToString, ttime.Value.ToString);
            comm.CommandText = str;
            this.Close();
        }
    }
}
