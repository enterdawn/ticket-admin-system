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
    public partial class info : Form
    {
        private static string connString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =\"" + Environment.CurrentDirectory + "\\database.mdf\"; Integrated Security = False; Connect Timeout = 30";
        private SqlConnection db = new SqlConnection(connString);
        private Dictionary<string, string> dic = new Dictionary<string, string>();
        private string Name;
        private string Pwd;
        private void init()
        {
            dic.Add("nickName", "");
            dic.Add("realName", "");
            dic.Add("sex", "");
            dic.Add("email", "");
            dic.Add("phoneNum", "");
            dic.Add("IDCarsNumber", "");
        }
        public info(string name,string pwd)
        {
            InitializeComponent();
            //init();
            Name = name;
            Pwd = pwd;
            SqlCommand cmd = new SqlCommand("select * from _user where nickname = '"+name+"';",db);
            db.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
                nickName.Text = ds.Tables[0].Rows[0]["nickname"].ToString();
                realName.Text = ds.Tables[0].Rows[0]["realName"].ToString();
                sex.Text = ds.Tables[0].Rows[0]["sex"].ToString();
                phoneNum.Text = ds.Tables[0].Rows[0]["phoneNum"].ToString();
                email.Text = ds.Tables[0].Rows[0]["email"].ToString();
                IDCardNumber.Text = ds.Tables[0].Rows[0]["IDCardNumber"].ToString();
                dic["nickName"] = nickName.Text;
                dic["realName"] = realName.Text;
                dic["sex"] = sex.Text;
                dic["phoneNum"] = phoneNum.Text;
                dic["email"] = email.Text;
                dic["IDCardNumber"] = IDCardNumber.Text;
                db.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("意外错误\r\n" + ex.Message);
                Dispose();
            }
        }

        private void modify(string itemName,string itemVal)
        {
            try
            {
                db.Open();
                SqlCommand cmd = new SqlCommand("update _user set "+itemName+" = '"+itemVal+"' where nickname = '"+Name+"';",db);
                cmd.ExecuteNonQuery();
                db.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("修改错误\r\n" + ex.Message);
                db.Close();
                Dispose();
            }
        }

        private void info_Load(object sender, EventArgs e)
        {

        }

        private void change_Click(object sender, EventArgs e)
        {
            if (dic["nickName"] != nickName.Text.ToString())
            {
                modify("nickname", nickName.Text);
            }
            if (dic["realName"] != realName.Text.ToString())
            {
                modify("realName", realName.Text);
            }
            if (dic["sex"] != sex.Text.ToString())
            {
                modify("sex", sex.Text);
            }
            if (dic["phoneNum"] != phoneNum.Text.ToString())
            {
                modify("phoneNum", phoneNum.Text);
            }
            if (dic["email"] != email.Text.ToString())
            {
                modify("email", email.Text);
            }
            if (dic["IDCardNumber"] != IDCardNumber.Text.ToString())
            {
                modify("IDCardNumber", IDCardNumber.Text);
            }
            MessageBox.Show("修改成功\n");
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            modifyPwd ModifyPwd = new modifyPwd(Name, Pwd);
            ModifyPwd.Show();
        }
    }
}
