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
            string str = "INSERT INTO ticket ( ticketID,ticketype,flightNumber,butTime,price,seat,insertTime,varifyOrNot,refundOrnot ) VALUES ({0},{1},{2},{3},{4},{5},{6},{7},{8}); ";
            comm.CommandText = str;
            this.Close();
        }
    }
}
