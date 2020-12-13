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
    public partial class modifyTicket : Form
    {
        private string name;
        private string pwd;
        private static string connString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =\"" + Environment.CurrentDirectory + "\\database.mdf\"; Integrated Security = False; Connect Timeout = 30";
        private SqlConnection db = new SqlConnection(connString);
        private List<List<string>> oldData = new List<List<string>>();
        private List<List<string>> newData = new List<List<string>>();
        private List<string> itemName = new List<string>();
        private Dictionary<string, string> dic = new Dictionary<string, string>();
        public modifyTicket(string Name,string Pwd)
        {
            InitializeComponent();
            name = Name;
            pwd = Pwd;
            init();
        }

       

        private void init()
        {
            try
            {
                db.Open();
                SqlCommand cmd = new SqlCommand("select flightNumber as '航班号',userid as '用户编号',butTime as '购买时间',price as '价格',seat as '座位号',insertTime as '添加时间',varifyOrNot as '已验证',deleteOrNot as '是否删除',refundOrNot as '是否退票' from ticket;", db);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("未知错误\r\n" + ex.Message);
                Dispose();
            }
            itemName.Add("航班号");
            itemName.Add("用户编号");
            itemName.Add("购买时间");
            itemName.Add("价格");
            itemName.Add("座位号");
            itemName.Add("添加时间");
            itemName.Add("已验证");
            itemName.Add("是否删除");
            itemName.Add("是否退票");
            getFormData(oldData);
            dic.Add("航班号", "flightNumber");
            dic.Add("用户编号", "userid");
            dic.Add("购买时间", "buyTime");
            dic.Add("价格", "price");
            dic.Add("座位号", "seat");
            dic.Add("添加时间", "insertTime");
            dic.Add("已验证", "verifyOrNot");
            dic.Add("是否删除", "deleteOrNot");
            dic.Add("是否退票", "refundOrNot");
        }

        private void getFormData(List<List<string>> data)
        {
            data.Clear();
            for (int i = 0; i < this.dataGridView1.Rows.Count - 1; i++)
            {
                if (this.dataGridView1.Rows[i] == null)
                {
                    continue;
                }
                List<string> temp = new List<string>();
                for (int j = 0; j < itemName.Count; j++)
                {
                    try
                    {
                        temp.Add(this.dataGridView1.Rows[i].Cells[itemName[j]].Value.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        this.Close();
                    }
                }
                data.Add(temp);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void update(string itemName, string val, string nickname)
        {
            try
            {
                db.Open();
                SqlCommand cmd = new SqlCommand("update ticket set " + itemName + " = '" + val + "' where nickname = '" + nickname + "';", db);
                cmd.ExecuteNonQuery();
                db.Close();
                MessageBox.Show("修改成功");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("更新失败\r\n" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getFormData(newData);

            int rowCnt = newData.Count;
            if (rowCnt == 0)
            {
                this.Close();
                return;
            }
            int colCnt = newData[0].Count;
            for (int i = 0; i < rowCnt - 1; i++)
            {
                for (int j = 0; j < colCnt; j++)
                {
                    if (oldData[i][j] != newData[i][j])
                    {
                        update(dic[itemName[j]], newData[i][j], newData[i][0]);
                    }
                }
            }
        }
    }
}
