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
        private Dictionary<string, string> dic = new Dictionary<string, string>();
        public modifyUserInfo(string name,string pwd)
        {
            InitializeComponent();
            Name = name;
            Pwd = pwd;
            init();
        }

        private void getFormData(List<List<string>> data)
        {
            data.Clear();
            for (int i = 0; i < this.dataGridView1.Rows.Count-1; i++)
            {
                if (this.dataGridView1.Rows[i] == null)
                {
                    continue;
                }
                List<string> temp = new List<string>();
                for(int j = 0; j < itemName.Count; j++)
                {
                    try
                    {
                        temp.Add(this.dataGridView1.Rows[i].Cells[itemName[j]].Value.ToString());
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        this.Close();
                    }
                }
                data.Add(temp);
            }
        }
        private void init()
        {
            try
            {
                db.Open();
                SqlCommand cmd = new SqlCommand("select nickname as '用户名',IDCardNumber as '身份证号码',_admin as '管理员权限',_status as '账户状态',regTime as '注册时间',active as '活跃度',sex as '性别',phoneNum as '手机号码',email as '电子邮箱' from _user where _admin = '0';", db);
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
            itemName.Add("用户名");
            itemName.Add("身份证号码");
            itemName.Add("管理员权限");
            itemName.Add("账户状态");
            itemName.Add("注册时间");
            itemName.Add("活跃度");
            itemName.Add("性别");
            itemName.Add("手机号码");
            itemName.Add("电子邮箱");
            getFormData(oldData);
            dic.Add("用户名", "nickname");
            dic.Add("身份证号码", "IDCardNumber");
            dic.Add("管理员权限", "_admin");
            dic.Add("账户状态", "_status");
            dic.Add("注册时间", "regTime");
            dic.Add("活跃度", "active");
            dic.Add("性别", "sex");
            dic.Add("手机号码", "phoneNum");
            dic.Add("电子邮箱", "email");
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
                MessageBox.Show("更新失败\r\n"+ ex.Message);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            getFormData(newData);
            
            int rowCnt = newData.Count;
            if (rowCnt == 0)
            {
                this.Close();
                return;
            }
            int colCnt = newData[0].Count;
            for (int i = 0; i < rowCnt-1; i++)
            {
                for(int j = 0; j < colCnt; j++)
                {
                    if (oldData[i][j] != newData[i][j])
                    {
                        update(dic[itemName[j]], newData[i][j],newData[i][0]);
                    }
                }
            }
        }
    }
}
