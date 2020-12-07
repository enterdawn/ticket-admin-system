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
    public partial class modifyUserInfo : Form
    {
        private string Name;
        private string Pwd;
        private static string connString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =\"" + Environment.CurrentDirectory + "\\database.mdf\"; Integrated Security = False; Connect Timeout = 30";
        private SqlConnection db = new SqlConnection(connString);
        private List<List<string>> oldData = new List<List<string>>();
        private List<List<string>> newData = new List<List<string>>();
        private List<string> itemName = new List<string>();
        public modifyUserInfo(string name,string pwd)
        {
            InitializeComponent();
            Name = name;
            Pwd = pwd;
            init();
        }

        private void getFormData(List<List<string>> data)
        {
            DataGridViewRow row = new DataGridViewRow();
            foreach (var row in dataGridView1.Rows)
            {
                List<string> temp = new List<string>();
                
                foreach(DataGridViewColumn col in dataGridView1.Columns)
                {
                    temp.Add(row.Cells[col.Name].Value.ToString());
                }
                data.Add(temp);
            }
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
                getFormData(oldData);
                for(int i = 0; i < oldData.Count; i++)
                {
                    for(int j = 0; j < oldData[i].Count; j++)
                    {
                        MessageBox.Show(oldData[i][j]);
                    }
                }
                db.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("未知错误\r\n"+ex.Message);
                Dispose();
            }
            itemName.Add("nickname");
            itemName.Add("IDCardNumber");
            itemName.Add("_admin");
            itemName.Add("_status");
            itemName.Add("regTime");
            itemName.Add("active");
            itemName.Add("sex");
            itemName.Add("phoneNum");
            itemName.Add("email");
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




        private void update(string itemName,string val,string nickname)
        {
            try
            {
                db.Open();
                SqlCommand cmd = new SqlCommand("update _user set " + itemName + " = '" + val + "' where nickname = '" + nickname + "';", db);
                cmd.ExecuteNonQuery();
                db.Close();
                MessageBox.Show("修改成功");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("更新失败\r\n", ex.Message);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            getFormData(newData);
            MessageBox.Show(newData.Count.ToString());
            int rowCnt = newData.Count;
            if (rowCnt == 0)
            {
                this.Close();
                return;
            }
            int colCnt = newData[0].Count;
            MessageBox.Show("modify");
            for (int i = 0; i < rowCnt; i++)
            {
                for(int j = 0; j < colCnt; j++)
                {
                    MessageBox.Show(oldData[i][j].ToString(), newData[i][j].ToString());
                    if (oldData[i][j] != newData[i][j])
                    {
                        
                        update(itemName[j], newData[i][j],newData[i][0]);
                        return;
                    }
                }
            }
        }
    }
}
