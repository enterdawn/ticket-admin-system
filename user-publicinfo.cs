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
    public partial class user_publicinfo : Form
    {
        private SqlConnection db = new SqlConnection(Form1.connString);
        public user_publicinfo()
        {
            InitializeComponent();
            publicview.Columns.Add("票号", 100, HorizontalAlignment.Left);
            publicview.Columns.Add("车次/航班号", 100, HorizontalAlignment.Left);
            publicview.Columns.Add("类型", 100, HorizontalAlignment.Left);
            publicview.Columns.Add("剩余量", 70, HorizontalAlignment.Left);
            publicview.Columns.Add("公司", 100, HorizontalAlignment.Left);
            publicview.Columns.Add("始发", 100, HorizontalAlignment.Left);
            publicview.Columns.Add("终到", 100, HorizontalAlignment.Left);
            publicview.Columns.Add("出发时间", 100, HorizontalAlignment.Left);
            publicview.Columns.Add("时长", 100, HorizontalAlignment.Left);
            publicview.Columns.Add("状态", 100, HorizontalAlignment.Left);
            publicview.Columns.Add("价格", 100, HorizontalAlignment.Left);
            updatelist();
        }
        private void updatelist()
        {
            publicview.Items.Clear();
            db.Open();
            SqlCommand cmd = new SqlCommand();
            string str = "select ticketID,_type,restNumber,company,placeOfDeparture,distination,startTime ,diachronic,price,fnum from classTicket;";
            if (start.Text == ""&&end.Text=="")
            {
                
            }
            else if(start.Text == "")
            {
                str = String.Format("select ticketID,_type,restNumber,company,placeOfDeparture,distination,startTime ,diachronic,_status,price,fnum from classTicket where distination= '{0}';",end.Text);
            }
            else if (end.Text == "")
            {
                str = String.Format("select ticketID,_type,restNumber,company,placeOfDeparture,distination,startTime ,diachronic,_status,price,fnum from classTicket where placeOfDeparture= '{0}';", start.Text);
            }
            else
            {
                str = String.Format("select ticketID,_type,restNumber,company,placeOfDeparture,distination,startTime ,diachronic,_status,price,fnum from classTicket where placeOfDeparture= '{0}' and distination= '{1}';", start.Text, end.Text);
            }
            cmd.CommandText = str;
            cmd.Connection = db;
            //MessageBox.Show(cmd.CommandText);
            SqlDataReader reader = null;
            reader = cmd.ExecuteReader();
            publicview.BeginUpdate();
            while (reader.Read())
            {
                ListViewItem swap = new ListViewItem();
                swap.Text = reader[0].ToString();
                swap.SubItems.Add(reader[10].ToString());
                swap.SubItems.Add(reader[1].ToString());
                swap.SubItems.Add(reader[2].ToString());
                swap.SubItems.Add(reader[3].ToString());
                swap.SubItems.Add(reader[4].ToString());
                swap.SubItems.Add(reader[5].ToString());
                swap.SubItems.Add(reader[6].ToString());
                swap.SubItems.Add(reader[7].ToString());
                if(reader[8].ToString()=="1") swap.SubItems.Add("正常");
                if (reader[8].ToString() == "2") swap.SubItems.Add("延误/晚点");
                if (reader[8].ToString() == "3") swap.SubItems.Add("停运");
                swap.SubItems.Add(reader[9].ToString());


                publicview.Items.Add(swap);
                //string result = reader[0].ToString();
                //MessageBox.Show(result);
            }
            publicview.EndUpdate();
            reader.Close();
            db.Close();
        }

        private void click_Click(object sender, EventArgs e)
        {
            updatelist();
        }
    }
}
